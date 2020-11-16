using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.IO;


using System;

namespace ProjectManagement.AuthData
{
    public class LogTimeException : Attribute, IActionFilter
    {
        public void OnActionExcuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }


        public void OnActionExecuting(ActionExecutedContext context)
        {
            string message = FilterContext.RouteData.Values["controlller"] +
                " & " + FilterContext.RouteData.Values["action"] +
                @" = OnresultExcuting " + DateTime.Now.ToString("F") + Environment.NewLine;
            Log(message);
        }

        private void Log(string message)
        {
            stirng path = Path.GetFullPath(@"C:/User/Docue")
        }
    }
}
