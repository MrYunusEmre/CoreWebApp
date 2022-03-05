using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RegisterManager : IRegisterService
    {
        ICityDal _cityDal;

        public RegisterManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<City> GetCities()
        {
            return _cityDal.GetAll();
            
        }
    }
}
