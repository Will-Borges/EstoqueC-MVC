using SistemaEstoque.Models;
using SistemaEstoque.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaEstoque.Controllers
{
    public class EstoqueController : Controller
    {
        Estoque estoque = new Estoque();
        private DBContext db = new DBContext();
        // GET: Estoque
        public ActionResult Index()
        {
            //return View(db.Estoque.ToList());
            return View(db.ProdutoEstoque.ToList());
        }

        public ActionResult EntradaEstoque()
        {
            DBContext db = new DBContext();
            ViewBag.ProdutosDescricao = new SelectList(db.Produtos, "id","descricao");
            return View();
        }

        [HttpPost]
        public ActionResult EntradaEstoque(ProdutoEstoque produtoEstoque)
        {          

            estoque.Quantidade = produtoEstoque.Quantidade;
            estoque.Valor = produtoEstoque.Valor;
            //estoque.dataEntrada = produtoEstoque.dataEntrada;
            estoque.FK_Produto = produtoEstoque.IdProduto;

            db.Estoque.Add(estoque);
            db.SaveChanges();
            return RedirectToAction("Index", "Estoque");
        }

    }
}