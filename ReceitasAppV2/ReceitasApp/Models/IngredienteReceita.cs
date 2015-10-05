using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasApp.Models
{
    public class IngredienteReceita
    {
        [PrimaryKey, AutoIncrement]
        public int IngredienteReceitaID { get; set; }
        [NotNull]
        public double Quantidade { get; set; }
        [NotNull]
        public int IngredienteID { get; set; }
        [NotNull]
        public int UnidadeMedidaID { get; set; }
        [NotNull]
        public int ReceitaID { get; set; }
    }
}
