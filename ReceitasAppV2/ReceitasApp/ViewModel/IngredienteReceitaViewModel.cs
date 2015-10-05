using ReceitasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitasApp.ViewModel
{
    public class IngredienteReceitaViewModel
    {
        public int IngredienteReceitaID { get; set; }

        public double Quantidade { get; set; }
        
        public int IngredienteID { get; set; }
        
        public int UnidadeMedidaID { get; set; }

        public int ReceitaID { get; set; }

        public String Nome { get; set; }

        public String UnMedida { get; set; }

        public String NomeReceita { get; set; }

        public IngredienteReceitaViewModel(IngredienteReceita ing)
        {
            IngredienteReceitaID = ing.IngredienteReceitaID;
            Quantidade = ing.Quantidade;
            IngredienteID = ing.IngredienteID;
            UnidadeMedidaID = ing.UnidadeMedidaID;
            ReceitaID = ing.ReceitaID;

            Ingrediente i = Database.BuscarIngredientePorId(ing.IngredienteID);
            Nome = i.Nome;

            UnidadeMedida un = Database.BuscarUnidadeMedidaPorId(ing.UnidadeMedidaID);
            UnMedida = un.Nome;

            Receita receita = Database.BuscarReceitaPorId(ing.ReceitaID);
            NomeReceita = receita.Titulo;
        }

        


    }
}
