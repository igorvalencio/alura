using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankAlura.ParceriaComercial
{
    public class ParceiroComercial
    {
        public string senha {get; set;}
        public  bool autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
