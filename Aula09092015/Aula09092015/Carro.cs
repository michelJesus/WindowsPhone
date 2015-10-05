using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09092015
{
    class Carro
    {
        public int CarroID { get; set; }
        public String Nome { get; set; }
        public int Ano { get; set; }
        public String Placa { get; set; }


        public override string ToString()
        {
            return "Nome: " + Nome + " Placa: " + Placa + " Ano " + Ano;
        }
    }
}
