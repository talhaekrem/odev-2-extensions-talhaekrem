using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionsApp.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {
        //aksiyondan çıkarken
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string action = context.RouteData.Values["action"].ToString();
            string controller = context.RouteData.Values["controller"].ToString();

            var result = context.Result;
            return;
        }

        //aksiyona girmeden önce
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (HasIgnoreAttribute(context))
            {
                return;
            }
            
            context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));
            return;
        }

        public bool HasIgnoreAttribute(FilterContext _context)
        {
            return ((ControllerActionDescriptor)_context.ActionDescriptor).MethodInfo.CustomAttributes.Any(f => f.AttributeType == typeof(Ignore));
        }
    }
}