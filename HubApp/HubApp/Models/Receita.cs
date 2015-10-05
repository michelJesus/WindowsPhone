using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubApp.Models
{
    class Receita
    {
        public int ReceitaID { get; set; }
        public String Titulo { get; set; }
        public int Porcao { get; set; }
        public int TempoPreparo { get; set; }
        public String Observacao { get; set; }
        public String ModoPreparo { get; set; }

        List<IngredienteReceita> IngredientesReceita { get; set; } 
    }
}
