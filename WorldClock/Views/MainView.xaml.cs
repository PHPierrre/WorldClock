using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WorldClock.Models;
using WorldClock.ViewModels;
using WorldClock.Views;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace WorldClock.Views
{
    public sealed partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            CountryModel cm = new CountryModel();
            ObservableCollection<Country> list = cm.GetCountries();

            listBox.DataContext = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
            //Frame.Navigate(typeof(AddCountryView));
        }
    }
}
