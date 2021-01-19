using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaEstoque.ViewModel
{
    public class ProdutoEstoque
    {

        public int idEstoque { get; set; }

        [Display(Name = "Valor:")]
        public float? Valor { get; set; }

        [Display(Name = "Data de Entrada:")]
        public DateTime? dataEntrada { get; set; }

        [Display(Name = "Quantidade:")]
        public int Quantidade { get; set; }

        public int? FK_Produto { get; set; }

        //-----------

        public int IdProduto { get; set; }

        [Display(Name = "Código:")]
        public int? Codigo { get; set; }

        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        [Display(Name = "Referencia:")]
        public string Referencia { get; set; }

        [Display(Name = "Unidade de Medida:")]
        public string UnidadeMedida { get; set; }

        [Display(Name = "NCM:")]
        public int? NCM { get; set; }

    }
}