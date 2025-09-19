using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ClienteController : Controller
    {
        Sistema sistema1 = Sistema.Instancia;


        public ActionResult Vuelos()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");
            List<Vuelo> vuelos = sistema1.TodosLosVuelos();
            ViewBag.vuelos = vuelos;
            return View();
        }

        [HttpPost]
        public ActionResult ComprarPasaje(DateTime fecha, string codigoDeVuelo, Pasaje.Equipaje equipaje)
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");

            try
            {
                sistema1.CrearPasaje(new Pasaje(sistema1.BuscarVuelo(codigoDeVuelo), fecha, sistema1.BuscarClientePorMail(HttpContext.Session.GetString("Usuario")), equipaje));
                TempData["Mensaje"] = "El pasaje fue comprado exitosamente";
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }
            List<Vuelo> vuelos = sistema1.TodosLosVuelos();
            ViewBag.vuelos = vuelos;
            return RedirectToAction("Vuelos");
        }

        public ActionResult BuscarVuelo()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");
            ViewBag.aeropuertos = sistema1.TodosLosAeropuertos();
            return View();
        }

        [HttpPost]

        public ActionResult BuscarVuelo(string aeropuerto1, string aeropuerto2)
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");
            ViewBag.aeropuertos = sistema1.TodosLosAeropuertos();
            List<Vuelo> vuelosPorRutas = sistema1.BuscarVueloPorRutas(aeropuerto1, aeropuerto2);
            ViewBag.vuelosPorRutas = vuelosPorRutas;
            return View();
        }

        [HttpPost]
        public ActionResult ComprarPasajePorRuta(DateTime fecha, string codigoDeVuelo, Pasaje.Equipaje equipaje)
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");

            try
            {
                sistema1.CrearPasaje(new Pasaje(sistema1.BuscarVuelo(codigoDeVuelo), fecha, sistema1.BuscarClientePorMail(HttpContext.Session.GetString("Usuario")), equipaje));
                TempData["Mensaje"] = "El pasaje fue comprado exitosamente";
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }
            ViewBag.aeropuertos = sistema1.TodosLosAeropuertos();
            List<Vuelo> vuelos = sistema1.TodosLosVuelos();
            ViewBag.vuelos = vuelos;
            return RedirectToAction("BuscarVuelo");
        }

        public ActionResult VerPasajes()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");
            ViewBag.pasajes = sistema1.TodosLosPasajes();
            return View();
        }

        public ActionResult VerPerfil()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");
            ViewBag.usuarioActual = sistema1.BuscarClientePorMail(HttpContext.Session.GetString("Usuario"));
            return View();
        }

    }
}
