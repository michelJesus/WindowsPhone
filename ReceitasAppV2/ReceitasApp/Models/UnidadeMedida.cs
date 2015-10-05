using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasApp.Models
{
    public class UnidadeMedida
    {
        [PrimaryKey, AutoIncrement]
        public int UnidadeMedidaID { get; set; }
        
        [NotNull]
        public String Nome { get; set; }

    }
}