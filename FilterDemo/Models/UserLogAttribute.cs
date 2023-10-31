using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemo.Models
{
    
    
        public class UserLogAttribute : Attribute, IActionFilter, IResultFilter, IExceptionFilter
        {

            public void LogExecutionTime(string msg)
            {

                File.AppendAllText(Path.Combine(Environment.CurrentDirectory, @"Data\", "Data.txt"), msg);
            }
            public void OnActionExecuted(ActionExecutedContext context)
            {
                string info = "After Action execution->" + context.Controller.ToString() + "->" + context.ActionDescriptor.DisplayName + "->" + DateTime.Now.ToString();
                LogExecutionTime(info);
                LogExecutionTime("\n----------------------------------\n");
            }
            public void OnActionExecuting(ActionExecutingContext context)
            {
                string info = "Before Action execution->" + context.Controller.ToString() + "->" + context.ActionDescriptor.DisplayName + "->" + DateTime.Now.ToString();
                LogExecutionTime(info);
                LogExecutionTime("\n----------------------------------\n");
            }

            public void OnException(ExceptionContext context)
            {
                string info = "On Exception->" + context.Exception + "->" + context.ActionDescriptor.DisplayName + "->" + DateTime.Now.ToString();
                LogExecutionTime(info);
                LogExecutionTime("\n----------------------------------\n");
            }

            public void OnResultExecuted(ResultExecutedContext context)
            {
                string info = "After Result execution->" + context.Controller.ToString() + "->" + context.ActionDescriptor.DisplayName + "->" + DateTime.Now.ToString();
                LogExecutionTime(info);
                LogExecutionTime("\n----------------------------------\n");
            }

            public void OnResultExecuting(ResultExecutingContext context)
            {
                string info = "Before Result execution->" + context.Controller.ToString() + "->" + context.ActionDescriptor.DisplayName + "->" + DateTime.Now.ToString();
                LogExecutionTime(info);
                LogExecutionTime("\n----------------------------------\n");
            }
        }



    }

