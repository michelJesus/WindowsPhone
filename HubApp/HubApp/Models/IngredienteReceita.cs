using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubApp.Models
{
    class IngredienteReceita
    {
        public int IngredienteReceitaID { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public Double Quantidade { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
    }
}
