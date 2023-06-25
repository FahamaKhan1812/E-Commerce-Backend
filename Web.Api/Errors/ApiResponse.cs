namespace Web.Api.Errors;
public class ApiResponse
{
    public ApiResponse(int statusCode, string message = null)
    {
        StatusCode = statusCode;
        Message = message ?? GetDefaultNullMessage(statusCode);
    }
    public int StatusCode { get; set; }
    public string Message { get; set; }

    private string? GetDefaultNullMessage(int statusCode)
    {
        return statusCode switch
        {
            400 => "A bad request you have made.",
            401 => "Unauthorized",
            404 => "Resource is not found",
            500 => "An internal server error has occurred.",
            _ => null
        };
    }

}
