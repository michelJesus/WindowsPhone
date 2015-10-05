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

namespace ReceitasApp.Views.UnidadeMedidaViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Atualizar : Page
    {
        UnidadeMedida un;

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
            lvUnidadeMedidaAtualizar.ItemsSource = Database.ListarUnidadeMedida();
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            if (un != null)
            {
                un.Nome = txtAtualizarNome.Text;
                Database.AtualizarUnidadeMedida(un.UnidadeMedidaID, un.Nome);
                lvUnidadeMedidaAtualizar.ItemsSource = Database.ListarUnidadeMedida();
            }
        }

        private void lvUnidadeMedidaAtualizar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            un = (UnidadeMedida)lvUnidadeMedidaAtualizar.SelectedItem;
            txtAtualizarNome.Text = un.Nome;
        }
    }
}
