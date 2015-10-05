using ReceitasApp.Models;
using ReceitasApp.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace ReceitasApp.Views.IngredienteReceitaViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Atualizar : Page
    {
        List<IngredienteReceitaViewModel> viewModelIngredienteReceita = new List<IngredienteReceitaViewModel>();
        IngredienteReceita ing = new IngredienteReceita(); 

        public Atualizar()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            atualizaLista();
            cmbIngrediente.ItemsSource = Database.ListarIngrediente();
            cmbUnidadeMedida.ItemsSource = Database.ListarUnidadeMedida();
            cmbReceita.ItemsSource = Database.ListarReceita();
        }

        public void atualizaLista()
        {
            IngredienteReceitaViewModel ingrediente;
            viewModelIngredienteReceita.Clear();
            List<IngredienteReceita> listaIngredienteReceita = Database.ListarIngredienteReceita();

            foreach (IngredienteReceita ingredienteReceita in listaIngredienteReceita)
            {
                ingrediente = new IngredienteReceitaViewModel(ingredienteReceita);
                viewModelIngredienteReceita.Add(ingrediente);
            }

            lvIngredienteReceita.ItemsSource = viewModelIngredienteReceita;
        }

        private void lvIngredienteReceita_Tapped(object sender, TappedRoutedEventArgs e)
        {
            IngredienteReceitaViewModel ingrediente = (IngredienteReceitaViewModel)lvIngredienteReceita.SelectedItem;
            
            ing.IngredienteReceitaID = ingrediente.IngredienteReceitaID;
            ing.UnidadeMedidaID = ingrediente.UnidadeMedidaID;
            ing.Quantidade = ingrediente.Quantidade;
            ing.IngredienteID = ingrediente.IngredienteID;
            ing.ReceitaID = ingrediente.ReceitaID;

            txtNome.Text = ing.Quantidade.ToString();
            cmbIngrediente.SelectedValue = ing.IngredienteID;
            cmbUnidadeMedida.SelectedValue = ing.UnidadeMedidaID;
            cmbReceita.SelectedValue = ing.ReceitaID;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            ing.Quantidade = double.Parse(txtNome.Text.ToString());
            ing.IngredienteID = int.Parse(cmbIngrediente.SelectedValue.ToString());
            ing.UnidadeMedidaID = int.Parse(cmbUnidadeMedida.SelectedValue.ToString());
            ing.ReceitaID = int.Parse(cmbReceita.SelectedValue.ToString());

            Database.AtualizarIngredienteReceita(ing.IngredienteReceitaID, ing.Quantidade, ing.IngredienteID, ing.UnidadeMedidaID, ing.ReceitaID);

            atualizaLista();
        }
    }
}
