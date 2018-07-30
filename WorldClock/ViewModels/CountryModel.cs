using System.Collections.Generic;
using System.Collections.ObjectModel;
using WorldClock.Models;

namespace WorldClock.ViewModels
{
    class CountryModel
    {
        ObservableCollection<Country> listCountry = new ObservableCollection<Country>();

        public ObservableCollection<Country> GetCountries()
        {
            listCountry.Add(new Country("France"));
            listCountry.Add(new Country("Corée du sud"));
            listCountry.Add(new Country("Etats Unis"));

            return listCountry;
        }
    }
}
