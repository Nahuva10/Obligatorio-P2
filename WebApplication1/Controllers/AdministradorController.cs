using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AdministradorController : Controller
    {
        Sistema sistema1 = Sistema.Instancia;


        public ActionResult VerPasajes()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Cliente") return View("NoAutorizado");
            List<Pasaje> pasajes = sistema1.TodosLosPasajesAdmin();
            ViewBag.pasajesAdmin = pasajes;
            return View();
        }

        public ActionResult VerClientes()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Cliente") return View("NoAutorizado");
            List<Cliente> clientes = sistema1.TodosLosClientes();
            ViewBag.clientes = clientes;
            return View();
        }

        [HttpPost]

        public ActionResult VerClientes(string cedula, string premio, string puntos)
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Cliente") return View("NoAutorizado");

            try
            {
                sistema1.ModificarCliente(cedula, premio, puntos);
                TempData["Mensaje"] = "Tabla de clientes actualizada con exito";
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }
            return RedirectToAction("VerClientes");
        }
    }
}
