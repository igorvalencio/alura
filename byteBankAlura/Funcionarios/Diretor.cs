using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBankAlura.Funcionarios;

namespace byteBankAlura.Funcionarios 
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return salario;
        }
        public Diretor(string cpf) : base(cpf, 5000) 
        {
            
        }
        public override void AumentarSalario()
        {
            this.salario *= 1.15;
        }

        public string senha { get; set; }
        public bool autenticar(string senha)
        {
            return this.senha == senha;
        }


    }
}
