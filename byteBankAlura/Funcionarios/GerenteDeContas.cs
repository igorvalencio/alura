using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf, double salario) : base(cpf, salario)
        {

        }
        public override void AumentarSalario()
        {
            this.salario *= 1.05;
        }
        public override double GetBonificacao()
        {
            return this.salario * 0.25;
        }
    }
}
