using Microsoft.AspNetCore.Mvc;

namespace GateKeeper.UserApi.Controllers;

[ApiController]
[Route("api/users")]

public class UserController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Get()
    {
        return Ok("UserApi is working");
    }
}