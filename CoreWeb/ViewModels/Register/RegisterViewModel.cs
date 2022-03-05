using EntityLayer.Concrete;
using System.Collections.Generic;

namespace CoreWeb.ViewModels.Register
{
    public class RegisterViewModel
    {

        public List<City> Cities { get; set; }
        public string WriterName { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public int WriterCity { get; set; } = -1;

    }
}
