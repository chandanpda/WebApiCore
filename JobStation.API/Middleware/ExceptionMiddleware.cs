using JobStation.Core;
using JobStation.Core.Domain;
using JobStation.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace JobStation.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> _logger)
        {
            _next = next;
            this._logger = _logger;
        }
        public async Task InvokeAsync(HttpContext httpContext, IUnitOfWork unitOfWork)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong: {ex}");
                await HandleExceptionAsync(httpContext, ex, unitOfWork);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception exception, IUnitOfWork unitOfWork)
        {
            //Save error log in database
            unitOfWork.ErrorLogHistory.Add(new ErrorLogHistory
            {
                ErrorDate = DateTimeOffset.Now,
                ErrorDetails = exception.ToString(),
                IsFixed = false
            });
            await unitOfWork.SaveChangesAsync();

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error"
            }.ToString());
        }
    }
}
