using daniel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using daniel.Models;

namespace daniel.Controllers
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



        [HttpPost]
        public IActionResult Index(Contacto cliente)
        {
            return View();
        }

        public IActionResult SendNewMessage(Contacto cliente)
        {
            RespuestaGuardar resp = new RespuestaGuardar();
            resp.Exitoso = false;

           
            try
            { /////TODO guardado
                //////////////
                //////
                resp.Exitoso = true;
            }
            catch (Exception)
            {

                resp.Exitoso = false;
            }


            return Ok(resp);
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
    }
}



