using System;
using System.Web.Mvc;

namespace KnockoutSamples.Extensions
{
    public static class HtmlHelperExtensions
    {
         public static string ActiveIfMatch(this HtmlHelper helper, string action, string controller)
         {
             var routeValues = helper.ViewContext.RouteData.Values;
             var currentAction = routeValues["action"].ToString().ToLower();
             var currentController = routeValues["controller"].ToString().ToLower();

             return (action.ToLower() == currentAction && controller.ToLower() == currentController)
                        ? "active"
                        : String.Empty;
         }
    }
}