using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// NOMBRE APELLIDOS: CRISTHIAN PROAÑO
// PARALELO: 
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 27/04/2024
// PRÁCTICA No. # 5
namespace APIREST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
