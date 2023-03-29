using byteBankAlura.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string senha { get; set; }

        public bool autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
