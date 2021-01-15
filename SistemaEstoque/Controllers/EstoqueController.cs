using SistemaEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEstoque.Controllers
{
    public class EstoqueController : Controller
    {
        // GET: Estoque
        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult EntradaEstoque()
        {
            DBContext db = new DBContext();
            ViewBag.ProdutosDescricao = new SelectList(db.Produtos, "id","descricao");
            return View();
        }

        [HttpPost]
        public ActionResult EntradaEstoque(string value)
        {
            DBContext db = new DBContext();
            ViewBag.ProdutosDescricao = new SelectList(db.Produtos, "id", "descricao");
            return View();
        }

    }
}