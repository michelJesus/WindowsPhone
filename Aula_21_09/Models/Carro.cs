using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21_09.Models
{
    public class Carro
    {
        [PrimaryKey, AutoIncrement]
        public int CarroID { get; set; }

        [MaxLength(20), NotNull]
        public String Modelo { get; set; }

        public int Ano { get; set; }

        public override string ToString()
        {
            return "Id: " + CarroID + ", Modelo: " + Modelo + ", Ano: " + Ano;
        }


        
        public static int AdicionarCarro(Carro car)
        {
            using (var con = DataBase.Conexao())
            {
                int id = con.Insert(car);
                con.Close();
                return id;
            }
        }

        public static List<Carro> ListarCarros()
        {
            using (var con = DataBase.Conexao())
            {
                List<Carro> lista = 
                    con.Query<Carro>("SELECT * FROM Carro WHERE Modelo = '" + "Fusca" + "'");
                con.Close();
                return lista;
            }
        }

        public static void ExcluirCarro(Carro c)
        {
            using (var con = DataBase.Conexao())
            {
                con.Delete(c);
            }
        }
    }
}
