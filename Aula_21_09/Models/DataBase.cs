using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Aula_21_09.Models
{
    public class DataBase
    {
       public static SQLiteConnection Conexao()
        {
            var con = new SQLite.SQLiteConnection(
                Path.Combine(ApplicationData.Current.LocalFolder.Path,
                "meuBancoTeste.db"), true);
            
           return con;
        }

        public static void CriarBase()
       {
            using(var con = Conexao())
            {
                con.CreateTable<Carro>();
                con.Close();
            }
       }
    }
}
