namespace WorldClock.Models
{
    public class Country
    {
        #region fields
        public string Timezone { get; set; }

        public string Area { get; set; }

        public string Time { get; set; }

        public string Utc { get; set; }
        #endregion fields

        #region constructor
        public Country(string Area, string Timezone)
        {
            this.Area = Area;
            this.Timezone = Timezone;
            
            /*
             * 1 - Calculer UTC
             * 2 - Calculer time
             */
        }
        #endregion constructor
    }
}
