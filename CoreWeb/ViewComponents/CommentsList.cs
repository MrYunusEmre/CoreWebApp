using CoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreWeb.ViewComponents
{
    public class CommentsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    username = "Yunus Emre"
                },
                new UserComment
                {
                    ID=2,
                    username = "Enes"
                },
                new UserComment
                {
                    ID = 3,
                    username = "Berk"
                }
            };

            return View(commentValues);
        }
    }
}
