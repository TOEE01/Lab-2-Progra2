using laboratorio2.Dominio;
using laboratorio2.Models;
using laboratorio2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Registropersona(AlmacenViewModels almacenViewModels)
        {
            AlmacenPersona almacenp = new AlmacenPersona();

            if (ModelState.IsValid)
            {
                almacenp.NombrePersona = almacenViewModels.NombrePersona;
                almacenp.EdadPersona = almacenViewModels.EdadPersona;
                almacenp.DescripcionPersona = almacenViewModels.DescripcionPersona;
                return Redirect("/Home/ListaPersonas");
            }
            else
            {
                return View("Index", almacenViewModels);
            }
        }
    }
}
