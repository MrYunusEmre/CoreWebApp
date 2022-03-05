using BusinessLayer.Concrete;
using CoreWeb.ViewModels.Register;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreWeb.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            RegisterManager registerManager = new RegisterManager(new EfCityRepository());
            RegisterViewModel registerViewModel = new RegisterViewModel
            {
                Cities = registerManager.GetCities(),
            };

            return View(registerViewModel);
        }   
        [HttpPost]
        public IActionResult Index(RegisterViewModel registerViewModel)
        {
            Writer writer = new Writer();
            writer.WriterName = registerViewModel.WriterName;
            writer.WriterImage = registerViewModel.WriterImage;
            writer.WriterPassword = registerViewModel.WriterPassword;
            writer.WriterMail = registerViewModel.WriterMail;
            writer.WriterCity = registerViewModel.WriterCity;
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme Test";
            writerManager.AddWriter(writer);
            return RedirectToAction("Index","Blog");
    }
}
}
