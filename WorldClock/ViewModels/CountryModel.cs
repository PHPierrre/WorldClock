using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using WorldClock.Models;

namespace WorldClock.ViewModels
{
    class CountryModel
    {
        ObservableCollection<Models.Country> listCountry = new ObservableCollection<Models.Country>();

        public List<Object> GetCountries()
        {
            var listCountry = DataAccess.GetData();

            return listCountry;
        }
    }
}
