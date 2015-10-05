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
    public sealed partial class Excluir : Page
    {
        List<IngredienteReceitaViewModel> viewModelIngredienteReceita = new List<IngredienteReceitaViewModel>();

        public Excluir()
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
            IngredienteReceitaViewModel ingrediente = (IngredienteReceitaViewModel) lvIngredienteReceita.SelectedItem;
            IngredienteReceita ing = new IngredienteReceita();
            ing.IngredienteReceitaID = ingrediente.IngredienteReceitaID;
            ing.UnidadeMedidaID = ingrediente.UnidadeMedidaID;
            ing.Quantidade = ingrediente.Quantidade;
            ing.IngredienteID = ingrediente.IngredienteID;
            Database.ExcluirIngredienteReceita(ing);
            viewModelIngredienteReceita.Clear();
            atualizaLista();
        }
    }
}
