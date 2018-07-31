using DataAccessLibrary;
using System.Collections.ObjectModel;
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
        public MainView()
        {
            InitializeComponent();

            /*CountryModel cm = new CountryModel();
            ObservableCollection<Country> list = cm.GetCountries();

            listBox.DataContext = list;*/

            listBox.DataContext = DataAccess.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddCountryView));
        }
    }
}
