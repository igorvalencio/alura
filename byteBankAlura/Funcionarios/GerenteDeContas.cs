using byteBankAlura.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4500)
        {

        }
        public override void AumentarSalario()
        {
            this.salario *= 1.05;
        }

        public override bool autenticar(string senha)
        {
            return this.senha == senha;
        }

        public override double GetBonificacao()
        {
            return this.salario * 0.25;
        }

     
    }
}
