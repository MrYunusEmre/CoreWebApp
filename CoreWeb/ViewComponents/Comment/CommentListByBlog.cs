using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var commentValues = commentManager.GetAllComments(id);
            return View(commentValues);
        }
    }
}
