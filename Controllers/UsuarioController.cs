using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dylan_AccesoPlatanitos.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string contrasena)
        {
            UsuarioDAO datos = new UsuarioDAO();
            var encontrado = datos.Login(email, contrasena);
            ViewBag.Mensaje = encontrado == null
                ? "Correo o contraseña incorrectos"
                : "Login exitoso. Bienvenido " + encontrado.Apellidos + " " + encontrado.Nombres;
            return View();

        }
    }
}