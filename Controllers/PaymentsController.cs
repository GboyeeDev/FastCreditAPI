using Microsoft.AspNetCore.Mvc;

namespace FastCreditAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentsController : ControllerBase
{
    [HttpGet(Name = "GetPayments")]
    public IActionResult Get()
    {
        return Ok(new { Message = "Fast Credit Payment API is running!" });
    }
}