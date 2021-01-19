using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaEstoque.Models
{
    public class Estoque
    {
        [Key]
        public int idEstoque { get; set; }

        [Display(Name = "Valor:")]
        public float? Valor { get; set; }

        [Display(Name = "Data de Entrada:")]
        public DateTime? dataEntrada { get; set; }

        [Display(Name = "Quantidade:")]
        public int Quantidade { get; set; }

        public int? FK_Produto { get; set; }

    }
}