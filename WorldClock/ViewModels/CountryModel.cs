using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WorldClock.ViewModels
{
    class CountryModel
    {
        readonly ObservableCollection<Country> listCountry = new ObservableCollection<Country>();

        public List<Object> GetCountries()
        {
            var listCountry = DataAccess.GetData();

            return listCountry;
        }
    }
}
