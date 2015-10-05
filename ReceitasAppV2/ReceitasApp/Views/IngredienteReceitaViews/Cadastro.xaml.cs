using ReceitasApp.Models;
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
    public sealed partial class Cadastro : Page
    {
        public Cadastro()
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
            cmbIngrediente.ItemsSource = Database.ListarIngrediente();
            cmbUnidadeMedida.ItemsSource = Database.ListarUnidadeMedida();
            cmbReceita.ItemsSource = Database.ListarReceita();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            IngredienteReceita un = new IngredienteReceita()
            {
                Quantidade = double.Parse(txtNome.Text.ToString()),
                IngredienteID = int.Parse( cmbIngrediente.SelectedValue.ToString()),
                UnidadeMedidaID = int.Parse(cmbUnidadeMedida.SelectedValue.ToString()),
                ReceitaID = int.Parse(cmbReceita.SelectedValue.ToString())
            };

            Database.InserirIngredienteReceita(un);
        }
    }
}
