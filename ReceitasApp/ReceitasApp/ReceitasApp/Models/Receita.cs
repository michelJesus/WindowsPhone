using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasApp.Models
{
    public class Receita
    {
        [PrimaryKey, AutoIncrement]
        public int ReceitaID { get; set; }

        public String Titulo { get; set; }

        public int TempoPreparo { get; set; }

        public String ModoPreparo { get; set; }

        public int Porcoes { get; set; }

        public String Observacao { get; set; }
        
        //public List<IngredienteReceita> IngredientesReceita { get; set; }
    }
}
