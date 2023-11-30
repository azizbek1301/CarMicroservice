using CarMicroserviceApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarMicroserviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarDbContext _context;

        public CarController(CarDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async ValueTask<ActionResult> GetAllOrders()
        {
            return Ok(_context.Cars);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateOrder(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();

            return Ok(car);
        }
    }
}
