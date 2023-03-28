using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }
        public override double GetBonificacao()
        {
            return salario *= 1.17;
        }
        public override void AumentarSalario()
        {
            this.salario *= 1.11;
        }
    }
}
