using byteBankAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura
{
    public class GerenciadorBonificacao 
    {
        public double TotalBonificacoes { get;  private set; }

            public void Registrar (Funcionario funcionario)
            {
                this.TotalBonificacoes += funcionario.GetBonificacao();
            }
          
            public void Registrar(Diretor diretor)
            {
                this.TotalBonificacoes += diretor.GetBonificacao();
            }

            public void Registrar(Auxiliar auxiliar) 
            {
                this.TotalBonificacoes += auxiliar.GetBonificacao();
            }

            public void Registrar(GerenteDeContas gerentedecontas)
            {
                this.TotalBonificacoes += gerentedecontas.GetBonificacao();
            }

            public void Registrar(Designer designer)
            {
                    this.TotalBonificacoes += designer.GetBonificacao();
            }

    }
}

