using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreWeb.ViewModels.Register;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreWeb.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        RegisterManager registerManager = new RegisterManager(new EfCityRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View(GetRegisterViewModel());
        }
        [HttpPost]
        public IActionResult Index(RegisterViewModel registerViewModel)
        {

            Writer writer = new Writer();
            writer.WriterName = registerViewModel.WriterName;
            writer.WriterImage = registerViewModel.WriterImage;
            writer.WriterPassword = registerViewModel.WriterPassword;
            writer.WriterMail = registerViewModel.WriterMail;
            if(!registerViewModel.WriterCity.Equals("-1"))
                writer.WriterCity = Convert.ToInt32(registerViewModel.WriterCity);
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme Test";

            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);
            if (results.IsValid)
            {
                writerManager.AddWriter(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(GetRegisterViewModel());

        }

        public RegisterViewModel GetRegisterViewModel()
        {
            List<SelectListItem> values = new List<SelectListItem>();
            values.Add(new SelectListItem { Text = "--Şehir Seçiniz--", Value = "-1" });
            foreach (var city in registerManager.GetCities())
            {
                values.Add(new SelectListItem { Text = city.CityName, Value = city.CityID.ToString()});
            }
            RegisterViewModel registerViewModel = new RegisterViewModel
            {
                Cities = values,
            };
            return registerViewModel;
        }
    }
}
