using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App21092015.Model
{
    public class Carro
    {
        [PrimaryKey, AutoIncrement]
        public int CarroID { get; set; }

        [MaxLength(20), NotNull]
        public String Modelo { get; set; }

        public int Ano { get; set; }

        public override string toDtring()
        {
            return "Id: " + Carro
        }

        public static int AdicionarCarro (Carro car) {
            using (var con = Database.Conexao())
            {
                int id = con.Insert(car);
                con.Close();
                return id;
            }
        }

        public static List<Carro> ListarCarros()
        {
            using (var con = Database.Conexao())
            {
                List<Carro> lista = con.Query<Carro>("SELECT * FROM Carro");
                con.Close();
                return lista;
            }
        }

        public static void ExcluirCarro (Carro c) 
        {
            using (var con = Database.Conexao())
            {
                con.Delete<Carro>(c.CarroID);
            }
        }

    }
}
