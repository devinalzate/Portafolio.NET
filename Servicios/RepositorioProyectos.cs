using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ListaProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ListaProyectos()
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
                },

                new Proyecto
                {
                    Nombre = "Proyecto 4",
                    Descripcion = "Descripcion del proyecto 4",
                    ImagenURL = "/imaganes/imagen1.png",
                    Link = ""
                },

                new Proyecto
                {
                    Nombre = "Proyecto 5",
                    Descripcion = "Descripcion del proyecto 5",
                    ImagenURL = "/imaganes/imagen2.png",
                    Link = ""
                }
            };
        }
    }
}
