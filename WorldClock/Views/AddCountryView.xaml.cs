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
            string Timezone = this.ReplaceDoubleUnderscore(typeItem.Name.ToString());

            string Name = Area.Text;

            DataAccess.AddData(Name, Timezone);
        }

        private void City_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem) City.SelectedItem;
            string Item = typeItem.Name;
            string Timezone = this.ReplaceDoubleUnderscore(Item);

            Area.Text = this.NameOfTimezone(Timezone); 
        }

        private string NameOfTimezone(string timezone)
        {
            string Name;

            switch(timezone)
            {
                case "Europe/Paris":
                    Name = "Paris France";
                    break;
                default:
                    Name = "Inconnu";
                    break;
            }

            return Name;
        }

        private string ReplaceDoubleUnderscore(string value)
        {
            return value.Replace("__", @"/");
        }
    }
}
