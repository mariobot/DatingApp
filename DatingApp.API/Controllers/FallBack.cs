using System.IO;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;

namespace DatingApp.API.Controllers
{
    public class FallBack : Controller
    {
        private readonly DataContext _context;

        public IActionResult Index () 
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","index.html"), "text/HTML");
        }
    }
}