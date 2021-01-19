using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaEstoque.Models
{
    public class Classes
    {
        public DBContext DBContext { get; set; }
        public Produto Produto { get; set; }
        public Login Login { get; set; }
        public Estoque Estoque { get; set; }
    }
}