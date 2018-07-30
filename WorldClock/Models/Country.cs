namespace WorldClock.Models
{
    public class Country
    {
        #region fields
        public string Timezone { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public string Utc { get; set; }
        #endregion fields

        #region constructor
        public Country(string name)
        {
            Name = name;

            /*switch (name)
            {
                

            }*/
        }
        #endregion constructor
    }
}
