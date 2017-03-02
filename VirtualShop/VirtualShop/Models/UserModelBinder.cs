using System.Web;
using System.Web.Mvc;

namespace VirtualShop.Models
{
    public class UserModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            User user = (User)controllerContext.HttpContext.Session["user"];

            if (user == null)
            {
                user                                            = new User();
                controllerContext.HttpContext.Session["user"]   = user;
            }

            return user;
        }
    }
}