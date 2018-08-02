using System;
using System.Text;

namespace DataAccessLibrary
{
    public class Country
    {
        public int Id { get; set; }

        public string Timezone { get; set; }

        public string Area { get; set; }

        public string Utc { get; set; }

        public Country(int Id, string Area, string Timezone)
        {
            this.Id = Id;
            this.Area = Area;
            this.Timezone = getTime(Timezone).ToString("H:mm");
            this.Utc = UtcFormatting(getUtc(Timezone).Hours, getUtc(Timezone).Minutes);
        }

        public Country(int id)
        {
            Id = id;
        }

        private TimeSpan getUtc(string Timezone)
        {
            var ToTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Timezone);
            var offset = ToTimeZone.GetUtcOffset(DateTime.Now);
            return offset;
        }

        private DateTime getTime(string Timezone)
        {
            var ToTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Timezone);
            DateTime Final = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ToTimeZone);
            return Final;
        }

        private string UtcFormatting(int Hours, int Minutes)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Hours > 0)
            {
                stringBuilder.Append("UTC + ");
                stringBuilder.Append(Hours);
            }
            else
            {
                stringBuilder.Append("UTC - ");
                stringBuilder.Append(Math.Abs(Hours));
            }

            stringBuilder.Append(" : ");
            if (Minutes == 0) stringBuilder.Append("00");

            return stringBuilder.ToString();

        }
    }
}
