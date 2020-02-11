using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTask1.Models
{
    public class Survey
    {
         public int id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string surname { get; set; }
        public IList<string> andVers = new List<string> { };
        public string emotions { get; set; }
        public Survey(string nm, DateTime dt, string sr, List<string> vers, string ems)
        {
            name = nm;
            date = dt;
            surname = sr;
            andVers = vers;
            emotions = ems;
        }
    }
}