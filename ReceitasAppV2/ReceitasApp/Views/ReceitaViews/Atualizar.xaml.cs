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

namespace ReceitasApp.Views.ReceitaViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Atualizar : Page
    {
        Receita receita = new Receita();

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
            lvReceita.ItemsSource = Database.ListarReceita();
        }

        private void lvReceita_Tapped(object sender, TappedRoutedEventArgs e)
        {
            receita = (Receita)lvReceita.SelectedItem;

            txtTitulo.Text = receita.Titulo;
            txtTempoPreparo.Text = receita.TempoPreparo.ToString();
            txtModoPrepar.Text = receita.ModoPreparo;
            txtPorcoes.Text = receita.Porcoes.ToString();
            txtObservacao.Text = receita.Observacao;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            receita.Titulo = txtTitulo.Text;
            receita.TempoPreparo = int.Parse(txtTempoPreparo.Text);
            receita.ModoPreparo = txtModoPrepar.Text;
            receita.Porcoes = int.Parse(txtPorcoes.Text);
            receita.Observacao = txtObservacao.Text;

            Database.AtualizarReceita(receita.ReceitaID, receita.Titulo, receita.TempoPreparo, receita.ModoPreparo, receita.Porcoes, receita.Observacao);
            lvReceita.SelectedItem = Database.ListarReceita();
        }
    }
}
