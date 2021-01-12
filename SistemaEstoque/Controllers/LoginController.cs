using SistemaEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEstoque.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPessoa()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginPessoa(Login loginn)
        {
            Login login = new Login();

            if (login.Logar(loginn.Usuario, loginn.Senha))
            {
                return RedirectToAction("Index", "Produtos");
            }
            else
            {
                @ModelState.AddModelError("", "Usuário ou Senha inválidos");
                return View();
            }
        }
    }
}