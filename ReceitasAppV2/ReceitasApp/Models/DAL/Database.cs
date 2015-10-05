using ReceitasApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ReceitasApp.Models
{
    public class Database
    {
        public static SQLiteConnection Conexao()
        {
            var con = new SQLite.SQLiteConnection(
                Path.Combine(ApplicationData.Current.LocalFolder.Path,
                "ReceitasApp.db"), true);

            return con;
        }

        public static void CriarBase()
        {
            using (var conexao = Conexao())
            {
                conexao.CreateTable<UnidadeMedida>();
                conexao.CreateTable<Ingrediente>();
                conexao.CreateTable<IngredienteReceita>();
                conexao.CreateTable<Receita>();
                conexao.Close();
            }
        }

        #region UnidadeMedida

        public static void InserirUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Insert(unidadeMedida);
                conexao.Close();
            }
        }

        public static List<UnidadeMedida> ListarUnidadeMedida()
        {
            using (var conexao = Database.Conexao())
            {
                List<UnidadeMedida> lista =
                    conexao.Query<UnidadeMedida>("SELECT * FROM UnidadeMedida");
                conexao.Close();
                return lista;
            }
        }

        public static void ExcluirUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Delete(unidadeMedida);
                conexao.Close();
            }
        }

        public static UnidadeMedida BuscarUnidadeMedidaPorId(int id)
        {
            using (var conexao = Database.Conexao())
            {
                UnidadeMedida unidadeMedida = conexao.Query<UnidadeMedida>("SELECT * FROM UnidadeMedida WHERE UnidadeMedidaID = " + id.ToString()).FirstOrDefault();
                conexao.Close();
                return unidadeMedida;
            }
        }

        public static UnidadeMedida AtualizarUnidadeMedida(int id, string nome)
        {
            using (var conexao = Database.Conexao())
            {
                UnidadeMedida unidadeMedida = BuscarUnidadeMedidaPorId(id);
                unidadeMedida.Nome = nome;
                conexao.Update(unidadeMedida);
                conexao.Close();
                return unidadeMedida;
            }
        }

        #endregion

        #region Ingrediente
        public static void InserirIngrediente(Ingrediente ingrediente)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Insert(ingrediente);
                conexao.Close();
            }
        }

        public static List<Ingrediente> ListarIngrediente()
        {
            using (var conexao = Database.Conexao())
            {
                List<Ingrediente> lista =
                    conexao.Query<Ingrediente>("SELECT * FROM Ingrediente");
                conexao.Close();
                return lista;
            }
        }

        public static void ExcluirIngrediente(Ingrediente ingrediente)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Delete(ingrediente);
                conexao.Close();
            }
        }

        public static Ingrediente BuscarIngredientePorId(int id)
        {
            using (var conexao = Database.Conexao())
            {
                Ingrediente ingrediente = conexao.Query<Ingrediente>("SELECT * FROM Ingrediente WHERE IngredienteID = " + id.ToString()).FirstOrDefault();
                conexao.Close();
                return ingrediente;
            }
        }

        public static Ingrediente AtualizarIngrediente(int id, string nome)
        {
            using (var conexao = Database.Conexao())
            {
                Ingrediente ingrediente = BuscarIngredientePorId(id);
                ingrediente.Nome = nome;
                conexao.Update(ingrediente);
                conexao.Close();
                return ingrediente;
            }
        }

        #endregion

        #region IngredienteReceita
        public static void InserirIngredienteReceita(IngredienteReceita ingrediente)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Insert(ingrediente);
                conexao.Close();
            }
        }

        public static List<IngredienteReceita> ListarIngredienteReceita()
        {
            using (var conexao = Database.Conexao())
            {
                List<IngredienteReceita> lista =
                    conexao.Query<IngredienteReceita>("SELECT * FROM IngredienteReceita");
                conexao.Close();
                return lista;
            }
        }

        public static void ExcluirIngredienteReceita(IngredienteReceita ingrediente)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Delete(ingrediente);
                conexao.Close();
            }
        }

        public static IngredienteReceita BuscarIngredienteReceitaPorId(int id)
        {
            using (var conexao = Database.Conexao())
            {
                IngredienteReceita ingrediente = conexao.Query<IngredienteReceita>("SELECT * FROM IngredienteReceita WHERE IngredienteReceitaID = " + id.ToString()).FirstOrDefault();
                conexao.Close();
                return ingrediente;
            }
        }

        public static IngredienteReceita AtualizarIngredienteReceita(int id, double quantidade, int ingredienteID, int unidadeMedidaID, int receitaID)
        {
            using (var conexao = Database.Conexao())
            {
                IngredienteReceita ingredienteReceita = BuscarIngredienteReceitaPorId(id);
                ingredienteReceita.IngredienteReceitaID = id;
                ingredienteReceita.Quantidade = quantidade;
                ingredienteReceita.IngredienteID = ingredienteID;
                ingredienteReceita.UnidadeMedidaID = unidadeMedidaID;
                ingredienteReceita.ReceitaID = receitaID;
                conexao.Update(ingredienteReceita);
                conexao.Close();
                return ingredienteReceita;
            }
        }

        #endregion

        #region Receita
        public static void InserirReceita(Receita ingrediente)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Insert(ingrediente);
                conexao.Close();
            }
        }

        public static List<Receita> ListarReceita()
        {
            using (var conexao = Database.Conexao())
            {
                List<Receita> lista =
                    conexao.Query<Receita>("SELECT * FROM Receita");
                conexao.Close();
                return lista;
            }
        }

        public static void ExcluirReceita(Receita ingrediente)
        {
            using (var conexao = Database.Conexao())
            {
                conexao.Delete(ingrediente);
                conexao.Close();
            }
        }

        public static Receita BuscarReceitaPorId(int id)
        {
            using (var conexao = Database.Conexao())
            {
                Receita ingrediente = conexao.Query<Receita>("SELECT * FROM Receita WHERE ReceitaID = " + id.ToString()).FirstOrDefault();
                conexao.Close();
                return ingrediente;
            }
        }

        public static Receita AtualizarReceita(int id, String titulo, int tempoPreparo, String modoPreparo, int porcoes, String observacoes)
        {
            using (var conexao = Database.Conexao())
            {
                Receita receita = BuscarReceitaPorId(id);
                receita.ReceitaID = id;
                receita.Titulo = titulo;
                receita.TempoPreparo = tempoPreparo;
                receita.ModoPreparo = modoPreparo;
                receita.Porcoes = porcoes;
                receita.Observacao = observacoes;
                conexao.Update(receita);
                conexao.Close();
                return receita;
            }
        }

        #endregion
    }
}
