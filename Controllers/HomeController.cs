using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos rep;

        public HomeController(ILogger<HomeController> logger , IRepositorioProyectos rep)
        {
            _logger = logger;
            this.rep = rep;
        }

        public IActionResult Index()
        {
            var proyectos = rep.ListaProyectos().Take(3).ToList();
            var modelos = new HomeIndexViewModel() { Proyectos = proyectos };


            var persona = new Persona()
            {
                Nombre = "Devin Santiago Alzate",
                Edad = "19"
            };

            ViewBag.jaja = "Con grandes aptitudes de aprendizaje autonomo, interes por nuevas tecnologias y una capacidad de generacion de soluciones a diferentes tipos de problematicas"; //Esto es un modelo sencillo para
                                                                                                                                                                                            //guardar variables en un solo metodo de 
                                                                                                                                                                                            //accion :D

            return View(modelos); //El segundo parametro es el 
                                  //valor asignado al atributo "model"


        }

        public IActionResult Proyectos()
        {
            var proyectos = rep.ListaProyectos();


            return View(proyectos);
        }

        public ILogger Get_logger()
        {
            return _logger;
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoVM contactoVM)
        {
            var nombre = contactoVM.nombre;
            var email = contactoVM.email;
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
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
