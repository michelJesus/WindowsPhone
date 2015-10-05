using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace App21092015.Model
{
    public class Database
    {
        public static SQLiteConnection Conexao () 
        {

            var con = new SQLiteConnection(Path.Combine(ApplicationData.Current.LocalFolder.Path, "meuBancoTeste.db"), true);
            return con;
            
        }

        public static void CriarBase() 
        {
            using (var con = Conexao())
            {
                con.CreateTable<Carro>();
                con.Close();
            }
        }



    }
}
