using Microsoft.AspNetCore.Mvc;

namespace GateKeeper.OrdersApi.Controllers;

[ApiController]
[Route("api/orders")]

public class OrdersController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Get()
    {
        return Ok("OrdersApi is working");
    }
}