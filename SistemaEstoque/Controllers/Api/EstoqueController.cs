using SistemaEstoque.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;


namespace SistemaEstoque.Controllers.Api
{
    public class EstoqueController : ApiController
    {
        [HttpGet]
        public JsonResult<Produto> ObterProdutoSeletor(long id)
        {
            using (var context = new DBContext())
            {
                return Json(context.Produtos.FirstOrDefault(x => x.Id == id));
            }
        }

        [HttpGet]
        public JsonResult<Produto> ObterProdutoCodigo(long codigo)
        {
            using (var context = new DBContext())
            {
                return Json(context.Produtos.FirstOrDefault(x => x.Codigo == codigo));
            }
            
        }
    }
}