using ReceitasApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace ReceitasApp.Views.IngredienteViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Excluir : Page
    {
        public Excluir()
        {
            this.InitializeComponent();
            comboBox.ItemsSource = Database.ListarIngrediente();
        }
        private async void ExibirDialog()
        {
            // mensagem simples
            MessageDialog d = new MessageDialog("Texto");

            // mensagem com botao e evento
            d.Commands.Add(new UICommand("Sim", new UICommandInvokedHandler(confirmaExclusao)));
            await d.ShowAsync();
        }

        private void confirmaExclusao(IUICommand command)
        {

            Ingredientexxx ing = comboBox.SelectedValue as Ingredientexxx;

            Database.ExcluirIngrediente(ing);

        }


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ExibirDialog();
        }
    }
}
