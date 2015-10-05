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

namespace App2_26082015
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public int NumeroRandomico { get; set; }
        public int NumeroTentativas { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            Random r = new Random();
            NumeroRandomico = r.Next(10);

            NumeroTentativas = 1;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnChutar_Click(object sender, RoutedEventArgs e)
        {
            if (txtPalpite.Text.Equals(NumeroRandomico.ToString()))
            {
                String mensagem = String.Format("Acertou. Número tentativas: {0}", NumeroTentativas);
                txtResposta.Text = mensagem; 

            }
            else 
            {
                txtResposta.Text = "Errou";
                NumeroTentativas++;
            }
        }

        private void btnGerar_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            NumeroRandomico = r.Next(10);

            txtPalpite.Text = "";
            NumeroTentativas = 1;
            txtResposta.Text = "";
        }

        private void txtPalpite_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPalpite.Text = "";
        }
    }
}
