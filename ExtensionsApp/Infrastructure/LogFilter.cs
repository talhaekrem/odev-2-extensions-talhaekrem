using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionsApp.Infrastructure
{
    public class LogFilter : Attribute, IActionFilter
    {
        //aksiyondan çıkarken
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string action = context.RouteData.Values["action"].ToString();
            string controller = context.RouteData.Values["controller"].ToString();
        }
        //aksiyona girmeden önce
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.Result.GetType() == typeof(UnauthorizedResult))
            {
                return;
            }
        }
    }
}
