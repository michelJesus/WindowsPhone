using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churrascometro
{
    public class Calculo
    {
        public enum tipoCalculo { Linguica, Carne, Bebida };

        public double calcularQtds(QtdChurrasco qtd, tipoCalculo tipoCalc) 
        {
          
            switch (tipoCalc)
            {
                case tipoCalculo.Linguica: 
                    return qtd.QtdH * 0.45 + qtd.QtdM * 0.25 + qtd.QtdC * 0.2;

                case tipoCalculo.Carne:
                    return qtd.QtdH * 0.5 + qtd.QtdM * 0.3 + qtd.QtdC * 0.2;
                    
                case tipoCalculo.Bebida:
                    return qtd.QtdH * 0.8 + qtd.QtdM * 0.45 + qtd.QtdC * 0.2;
    
            }
            return 0.0;
   
        }     

    }

}
