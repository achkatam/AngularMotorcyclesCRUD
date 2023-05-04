namespace MotorcyclesAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using Models;

[Route("api/[controller]")]
[ApiController]
public class MotorcycleController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Motorcycle>>> GetAllMotorcycles()
    {
        return new List<Motorcycle>
        {
            new Motorcycle
            {
                Id = 1,
                Make = "Ducati",
                Model = "Multistrada 1200S",
                Year = "2016",
                Price = 15000
            }
        };
    }
}