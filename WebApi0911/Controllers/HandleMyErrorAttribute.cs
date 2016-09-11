using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace WebApi0911.Controllers
{
    public class HandleMyErrorAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError,
                new MyError()
                {
                    Error_Message = actionExecutedContext.Exception.Message,
                    SubStatusCode = "500.13"
                });
        }
    }
}