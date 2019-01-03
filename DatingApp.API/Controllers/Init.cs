using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Init : ControllerBase
    {
        private DataContext _context;

        public Init(DataContext context){
            _context = context;
        }

        [HttpGet]
        public IActionResult Database()
        {
            Data.Seed seed = new Data.Seed(_context);
            seed.SeedUser();
            return Ok("Database Initialized");
        }
    }
}