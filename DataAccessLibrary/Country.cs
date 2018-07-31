using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Country
    {
        public int Id { get; set; }

        public string Timezone { get; set; }

        public string Area { get; set; }

        public Country(int Id, string Area, string Timezone)
        {
            this.Id = Id;
            this.Area = Area;
            this.Timezone = Timezone;
        }

        public Country()
        {
            Id = 1;
            this.Area = "Paris France";
            this.Timezone = "Europe/Paris";
        }
    }
}
