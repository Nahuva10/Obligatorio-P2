using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication1.Controllers
{
    public class InicioController : Controller
    {
        Sistema sistema1 = Sistema.Instancia;



        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("Rol") != null) return View("NoAutorizado");
            return View();
        }

        [HttpPost]

        public IActionResult Login(string mail, string password)
        {
            Usuario? usu = sistema1.BuscarUsuarioPorPwYMail(mail, password);
            if(usu == null)
            {
                ViewBag.Error = "El mail y/o la contrasenia son incorrectos.";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Usuario", usu.Mail);
                if (usu is Administrador) HttpContext.Session.SetString("Rol", "Administrador");
                else HttpContext.Session.SetString("Rol", "Cliente");
                if (HttpContext.Session.GetString("Rol") == "Administrador")
                {
                    return RedirectToAction("Administrador");
                }
                else
                {
                   return RedirectToAction("Cliente");
                }
            }

        }

        public IActionResult Registro()
        {
            if (HttpContext.Session.GetString("Rol") != null) return View("NoAutorizado");
            return View();
        }

        [HttpPost]

        public IActionResult Registro(ClienteOcasional usu)
        {
            try
            {
                sistema1.CrearUsuario(usu);
                Login(usu.Mail, usu.Password);
                return RedirectToAction("Cliente");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("Rol") == null) return View("NoAutorizado");
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult Cliente()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Administrador") return View("NoAutorizado");
            return View();
        }

        public IActionResult Administrador()
        {
            if (HttpContext.Session.GetString("Rol") == null || HttpContext.Session.GetString("Rol") == "Cliente") return View("NoAutorizado");
            return View();
        }
    }
}
