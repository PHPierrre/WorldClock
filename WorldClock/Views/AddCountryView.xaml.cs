using DataAccessLibrary;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace WorldClock.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class AddCountryView : Page
    {
        public AddCountryView()
        {
            this.InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainView));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem) City.SelectedItem;
            string Timezone = typeItem.Name.ToString();

            string Name = Area.Text;

            DataAccess.AddData(Timezone, Name);
        }

        private void City_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Detecter quand l'user a rempli la timzone et remplir le champs
            ComboBoxItem typeItem = (ComboBoxItem) City.SelectedItem;
            string Item = typeItem.Name;
            throw new NotImplementedException();
            //string Timezone = Item.Replace("E", "a");
        }
    }
}
