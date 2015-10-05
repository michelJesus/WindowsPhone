using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasApp.Models
{
    public class IngredienteReceita
    {
        [PrimaryKey, AutoIncrement]
        public int IngredienteReceitaID { get; set; }

        public double Quantidade { get; set; }

        //public Ingrediente Ingrediente { get; set; }
        //public UnidadeMedida UnidadeMedida { get; set; }

        public int IngredienteID { get; set; }
        public int UnidadeMedidaID { get; set; }

        public int ReceitaID { get; set; }

        public IngredienteReceita(Ingredientexxx ing, UnidadeMedida un)
        {
            IngredienteID = ing.IngredienteID;

        }
    }
}
