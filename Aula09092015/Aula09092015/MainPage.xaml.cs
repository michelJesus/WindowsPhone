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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Aula09092015
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnIrPagina_Click(object sender, RoutedEventArgs e)
        {
            Carro meuCarro = new Carro()
            {
                CarroID = 1,
                Nome = "Fusca",
                Ano = 1963,
                Placa = "AAA - 0000"
            };


            Carro meuCarro2 = new Carro()
            {
                CarroID = 2,
                Nome = "Fusca",
                Ano = 1963,
                Placa = "BBB - 0001"
            };

            List<Carro> carros = new List<Carro>();
            carros.Add(meuCarro);
            carros.Add(meuCarro2);

            Frame.Navigate(typeof(Page1), carros);

        }
    }
}
