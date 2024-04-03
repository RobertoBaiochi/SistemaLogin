using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario() {Nome = "Fernando", Senha = "123abc"},
            new Usuario() {Nome = "Lucas", Senha = "abc123"},
            new Usuario() {Nome = "Roberto", Senha = "1q2w3e"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado 
        { 
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario user in usuarios)
            {
                if (user.Nome == nome && user.Senha == senha) 
                {
                    UsuarioLogado = user;
                    return true;
                }
            }

            return false;
        }
    }
}
