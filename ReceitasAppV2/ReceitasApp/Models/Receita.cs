using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasApp.Models
{
    public class Receita
    {
        [PrimaryKey, AutoIncrement]
        public int ReceitaID { get; set; }
        [NotNull]
        public String Titulo { get; set; }
        [NotNull]
        public int TempoPreparo { get; set; }
        [NotNull]
        public String ModoPreparo { get; set; }
        [NotNull]
        public int Porcoes { get; set; }
        [NotNull]
        public String Observacao { get; set; }

    }
}
