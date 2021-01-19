using SistemaEstoque.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SistemaEstoque.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ProdutoEstoque> ProdutoEstoque { get; set; } // puxar funcao quando utilizar

        public void PegaProdutosEstoque()
        {
            ProdutoEstoque prodEstoque = new ProdutoEstoque();

            foreach (var Estoque in Estoque)
            {
                foreach (var produto in Produtos)
                {
                    if (Estoque.FK_Produto == produto.Id)
                    {
                        prodEstoque.Codigo = produto.Codigo;
                        prodEstoque.dataEntrada = Estoque.dataEntrada;
                        prodEstoque.idEstoque = Estoque.idEstoque;
                        prodEstoque.Quantidade = Estoque.Quantidade;
                        prodEstoque.Valor = Estoque.Valor;
                        prodEstoque.Descricao = produto.Descricao;

                        ProdutoEstoque.Add(prodEstoque);
                    }
                }
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}