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

namespace App1
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
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnObterCheck_Click(object sender, RoutedEventArgs e)
        {
            tbkAceito.Text = chxAceito.IsChecked == true ? "Aceito" : "Não aceito";
        }

        private void btnRadio_Click(object sender, RoutedEventArgs e)
        {
            if (rbnRadio1.IsChecked == true)
            {
                tbkRadio.Text = rbnRadio1.Content.ToString();
            }
            else if (rbnRadio2.IsChecked == true)
            {
                tbkRadio.Text = rbnRadio2.Content.ToString();
            }

        }

        private void btnObterData_Click(object sender, RoutedEventArgs e)
        {
            tbkData.Text = dprData.Date.ToString("dd/MM/yyyy");
        }

        private void btnObterValorSlider_Click(object sender, RoutedEventArgs e)
        {
            tbkSlider.Text = slrValor.Value.ToString();
        }

        private void tbnProgBar_Click(object sender, RoutedEventArgs e)
        {
            if (tbnProgBar.IsChecked == true)
            {
                progBar.Value += 10;
                prgRing.IsActive = true;
            }
            else
            {
                prgRing.IsActive = false;
            }
            
            
        }

        private void btnObterNome_Click(object sender, RoutedEventArgs e)
        {
            var index = cbxNomes.SelectedIndex;
            var item = cbxNomes.SelectedItem;
            var valor = ((ComboBoxItem)cbxNomes.SelectedItem).Content.ToString();

            tbkNomes.Text = valor;
        }
    }
}
