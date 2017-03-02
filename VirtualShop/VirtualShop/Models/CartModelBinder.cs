using System.Web.Mvc;

namespace VirtualShop.Models
{
    public class CartModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Cart chart = (Cart)controllerContext.HttpContext.Session["chart"];

            if (chart == null)
            {
                chart = new Cart();
                controllerContext.HttpContext.Session["chart"] = chart;
            }

            return chart;
        }
    }
}