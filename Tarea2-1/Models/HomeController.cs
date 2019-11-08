using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea2_1.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<html><body>" +
                    "<h1>Universidad Autónoma de Santo Domingo (UASD) </h1>" +
                    "<p>Diplomado Desarollo Web C#, MVC </p>" +
                    "</body></html>";
        }
        public string DiplomadoWeb()
        {
            return "<html><body>" +
                    "<h1>Estudaintes:</h1>" +
                    "<p>Norquis Rafael Suarez Castellanos</p>" +
                    "<p>Enmanuel Paulino</p>" +
                    "<p>Antony Enmanuel</p>" +
                    "<p>Yaniel Nuñez</p>" +
                    "</body></html>";

        }
    }
}