using Classes.Exceptions;
using Classes.Models;
using Newtonsoft.Json;
using System.Net;

namespace Server.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _requestDelegate;
    public ExceptionMiddleware(RequestDelegate _requestDelegate)
    {
        this._requestDelegate = _requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _requestDelegate(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        context.Response.ContentType = "application/json";
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
        var errorDetails = new Error
        {
            Code = "Failure",
            Message = ex.Message
        };

        switch (ex)
        {
            case NotFoundException:
                statusCode = HttpStatusCode.NotFound;
                errorDetails.Code = "Not Found";
                break;
            case UnauthorizedException:
                statusCode = HttpStatusCode.Unauthorized;
                errorDetails.Code = "Unauthorized";
                break;
            case BannedException:
                statusCode = HttpStatusCode.Forbidden;
                errorDetails.Code = "Forbidden";
                break;
            case BadRequestException:
                statusCode = HttpStatusCode.BadRequest;
                errorDetails.Code = "Bad Request";
                break;
        }

        string response = JsonConvert.SerializeObject(errorDetails);
        context.Response.StatusCode = (int)statusCode;
        return context.Response.WriteAsync(response);
    }
}
