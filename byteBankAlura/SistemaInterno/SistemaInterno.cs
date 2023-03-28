using byteBankAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.SistemaInterno
{
    public class SistemaInterno
    {
        public  bool Logar(Autenticavel funcionario, string senha)
        {
            bool UsuarioAutenticado = funcionario.autenticar(senha);
            if (UsuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;

            }
        }

     
    }

}
