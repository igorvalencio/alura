using byteBankAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string senha { get; set; }
        public abstract bool autenticar(string senha);
      
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

 
    }
}
