using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaEstoque.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool Logar(string usuario, string senha)
        {
           
                using (var context = new DBContext())
                {
                    foreach (var login in  context.Logins)
                    {
                        if (usuario == login.Usuario & senha == login.Senha)
                        {
                            return true;
                        }
                    }
                }

            return false;
        }
    }
}