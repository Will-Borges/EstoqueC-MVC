using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Código:")]
        public int? Codigo { get; set; }
        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }
        [Display(Name = "Referencia:")]
        public string Referencia { get; set; }
        [Display(Name = "Unidade de Medida:")]
        public string UnidadeMedida { get; set; }
        [Display(Name = "Quantidade:")]
        public int? Quantidade { get; set; }
        [Display(Name = "NCM:")]
        public int? NCM { get; set; }
        [Display(Name = "Valor:")]
        public decimal? Valor { get; set; }
        [Display(Name = "Data da Compra:")]
        public DateTime? DataCompra { get; set; }

    }
}