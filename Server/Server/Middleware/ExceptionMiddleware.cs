using Classes.Exceptions;
using Classes.Exceptions.Game;
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
            case BadRequestException:
                statusCode = HttpStatusCode.BadRequest;
                errorDetails.Code = "Bad Request";
                break;
            case UnauthorizedException:
                statusCode = HttpStatusCode.Unauthorized;
                errorDetails.Code = "Unauthorized";
                break;
            case BannedException or HeroLimitReachedException or HeroLevelTooLowException or HeroEquipmentIsFullException
                 or ItemRequiresAnotherProfessionException or ItemIsNotWornableException or HeroEquipmentSlotIsOccupiedException
                 or ItemIsNotDroppableException or HeroIsTooFarAwayException or ItemIsNotSellableException or HeroHasNotEnoughGoldException
                 or HeroIsDeadException or TileIsOccupiedException or MobIsDeadException or HeroHasThisQuestException:
                statusCode = HttpStatusCode.Forbidden;
                errorDetails.Code = "Forbidden";
                break;
            case NotFoundException or HeroIsNotInTheGameException or HeroEquipmentSlotIsEmptyException:
                statusCode = HttpStatusCode.NotFound;
                errorDetails.Code = "Not Found";
                break;
        }

        context.Response.StatusCode = (int)statusCode;
        return context.Response.WriteAsync(JsonConvert.SerializeObject(errorDetails));
    }
}
