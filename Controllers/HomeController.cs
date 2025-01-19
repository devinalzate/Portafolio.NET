using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        //Privates attributes that it's used in principal controller
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos rep;

        //Constructor class, that invoke of projects repository
        public HomeController(ILogger<HomeController> logger , IRepositorioProyectos rep)
        {
            _logger = logger;
            this.rep = rep;
        }

        //Call action that execute the view and behaviors of index page
        public IActionResult Index()
        {
            var proyectos = rep.ListaProyectos().Take(3).ToList(); //list of the first three projects that are saved in "IRepositorioProyectos"
            var modelos = new HomeIndexViewModel() { Proyectos = proyectos }; //Model asigned to "Index" that use the "IEnumerable" of projects


            var persona = new Persona()
            {
                Nombre = "Devin Santiago Alzate",
                Edad = "19"
            };//Use example of object construction

            ViewBag.jaja = "Con grandes aptitudes de aprendizaje autonomo, interes por nuevas tecnologias y una capacidad de generacion de soluciones a diferentes tipos de problematicas"; //Esto es un modelo sencillo para
                                                                                                                                                                                            //guardar variables en un solo metodo de 
                                                                                                                                                                                            //accion :D

            return View(modelos); //Model aigned to "Index"


        }

        //Call action that execute the view and behaviors of projects page
        public IActionResult Proyectos()
        {
            var proyectos = rep.ListaProyectos(); //model sended to the view


            return View(proyectos);
        }

        public ILogger Get_logger()
        {
            return _logger;
        }

        //Call action that execute the view and behaviors of contact page (that have a predetermined method of [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        //Action that return a new view when users send contact info
        [HttpPost]
        public IActionResult Contacto(ContactoVM contactoVM)
        {
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
