using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.Funcionarios
{
    public abstract class Funcionario 
    {
        public string nome { get; set; }
        public string cpf { get; private set; }
        public double salario { get;  protected set; }
        public static int TotalFuncionarios { get; private set; }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();


        public Funcionario(string cpf, double salario)
        {
            this.salario = salario;
            this.cpf = cpf;
            TotalFuncionarios++;
        }

        
       

       
    }
}
