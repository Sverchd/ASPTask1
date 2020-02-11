using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTask1.Models
{
    public class Article
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string content { get; set; }
        public Article(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            content = ct;
        }
    }
}