using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
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
            var proyectos = ListaProyectos().Take(3).ToList();
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

        private List<Proyecto> ListaProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Nombre = "Proyecto 1",
                    Descripcion = "Descripcion del proyecto 1",
                    ImagenURL = "/imaganes/imagen1.png",
                    Link = ""
                },

                new Proyecto
                {
                    Nombre = "Proyecto 2",
                    Descripcion = "Descripcion del proyecto 2",
                    ImagenURL = "/imaganes/imagen2.png",
                    Link = ""
                },

                new Proyecto
                {
                    Nombre = "Proyecto 3",
                    Descripcion = "Descripcion del proyecto 3",
                    ImagenURL = "/imaganes/imagen3.png",
                    Link = ""
                }
            };
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
