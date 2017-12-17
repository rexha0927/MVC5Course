using System.Web.Mvc;

namespace MVC5Course.ActionFilter
{
    public class LocalOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.RequestContext.HttpContext.Request.IsLocal)
            {
                filterContext.Result = new RedirectResult("/");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}