using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WorldClock.Models;
using WorldClock.ViewModels;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace WorldClock.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public Models.Country Timezone { get; set; }

        public MainView()
        {
            InitializeComponent();

            CountryModel cm = new CountryModel();
            List<Object> list = cm.GetCountries();

            listBox.DataContext = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddCountryView));
        }
    }
}
