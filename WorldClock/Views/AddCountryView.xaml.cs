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
            InitializeComponent();
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
            Frame.Navigate(typeof(MainView));
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
                case "Pacific Standard Time":
                    Name = "Los Angeles, Etats-Unis";
                    break;
                case "US_Mountain Standard Time":
                    Name = "Denver, Etats-Unis";
                    break;
                case "Central America Standard Time":
                    Name = "Chicago, Etats-Unis";
                    break;
                case "Eastern Standard Time":
                    Name = "New York, Etats-Unis";
                    break;
                case "Central Brazilian Standard Time":
                    Name = "Brasilia, Brésil";
                    break;
                case "GMT Standard Time":
                    Name = "Londres, Royaume-Uni";
                    break;
                case "Central Europe Standard Time":
                    Name = "Paris, France";
                    break;
                case "Russian Standard Time":
                    Name = "Moscou, Russie";
                    break;
                case "China Standard Time":
                    Name = "Pékin, Chine";
                    break;
                case "Taipei Standard Time":
                    Name = "Taipei, Taiwan";
                    break;
                case "Tokyo Standard Time":
                    Name = "Tokyo, Japon";
                    break;
                case "Korea Standard Time":
                    Name = "Séoul, Corée du Sud";
                    break;
                case "AUS Central Standard Time":
                    Name = "Sydney, Australie";
                    break;
                default:
                    Name = "Inconnu";
                    break;
            }

            return Name;
        }

        private string ReplaceDoubleUnderscore(string value)
        {
            return value.Replace("_", @" ");
        }
    }
}
