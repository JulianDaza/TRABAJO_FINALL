using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tienda.Models;

namespace Tienda.Controllers
{
    
    public class HomeController : Controller
    {
    public class Usuario
    {
        public string Telefono { get; set; }
        public int ID { get; set; }
    }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult comprar_telefonos(string Telefono, int id)
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario {Telefono = Telefono, ID = id},


            };
            Console.WriteLine(Telefono);
            Console.WriteLine(id);
            ViewBag.Telefono=Telefono;
            ViewBag.ID=id;
            return View();
        }

        public IActionResult comprar_tennis()
        {
            return View();
        }
        //----------------------------------------------------------------
        public IActionResult adicionar(string Telefono, int ID)
        {
            return View();
        }

        public IActionResult mostrar()
        {

            return View();
        }






















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
