﻿using ReceitasApp.Models;
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

namespace ReceitasApp.Views.IngredienteViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lista : Page
    {
        public Lista()
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
            lvIngrediente.ItemsSource = Database.ListarIngrediente();
        }

        private void lvIngrediente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedIngredienteID = 0;
            if (lvIngrediente.SelectedIndex != -1)
            {
                Ingredientexxx listitem = lvIngrediente.SelectedItem as Ingredientexxx;
                Frame.Navigate(typeof(Atualizar), listitem);
            }
        }
    }
}
