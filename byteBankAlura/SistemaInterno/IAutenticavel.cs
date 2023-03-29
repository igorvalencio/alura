using byteBankAlura.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.SistemaInterno
{
    public interface IAutenticavel
    {
        public string senha { get; set; }
        public abstract bool autenticar(string senha);
   
    }
}
