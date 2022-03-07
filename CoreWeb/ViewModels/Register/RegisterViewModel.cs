using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreWeb.ViewModels.Register
{
    public class RegisterViewModel
    {

        public List<SelectListItem> Cities { get; set; } = null;
        public string WriterName { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterCity { get; set; }

    }
}
