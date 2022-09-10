using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNetUdemy.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
   

    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public  Get()
    {
        
    }
}
