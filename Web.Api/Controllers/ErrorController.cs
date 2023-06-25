using Microsoft.AspNetCore.Mvc;
using Web.Api.Errors;

namespace Web.Api.Controllers;

[Route("errors/{code}")]
public class ErrorController : BaseAPiCotroller
{
    public IActionResult Error(int code)
    {
        return new ObjectResult(new ApiResponse(code));
    }
}
