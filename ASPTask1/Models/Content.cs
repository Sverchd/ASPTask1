using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPTask1.Models
{
    public static class ContentArticle
    {
        public static IList<Article> articelList = new List<Article>() {
                    new Article("Individuality", DateTime.Now,"Customization is paramount to productivity. That’s why LineageOS promises to push for user personalization and preference. Everyone is unique and your device should be too."),
            new Article("Security", DateTime.Now,"Your data, your rules. With powerful tools such as Privacy Guard, you are in control of what your apps can do whenever you want."),
            new Article("Longevity", DateTime.Now,"LineageOS extends the functionality and lifespan of mobile devices from more than 20 different manufacturers thanks to our open-source community of contributors from all around the world."),
            new Article("Power to you", DateTime.Now,"Our open-source apps are here to help you get through the day. Want to do more with your device? Power users will enjoy Unix command-line utilities. " +
                "Android developers will turn any device into the perfect device for apps development thanks to enhanced tools and exclusive APIs."),
            new Article("Ready? Get LineageOS now!", DateTime.Now,"LineageOS, an open-source Android distribution, is available for several devices, with more being continuously added thanks to the biggest, yet ever growing, Android open-source community. " +
                "Join us and breathe new life in your device, be it old or new.")
        };
        public static IList<Review> reviewlList = new List<Review>() {
                    new Review("Anton", DateTime.Now,"This rom is so good"),
            new Review("Starfury", DateTime.Now,"It has a lot of bugs!!!"),
            new Review("Sterben", DateTime.Now,"I liked this rom. thanks"),
            new Review("Misha", DateTime.Now,"I don`t like it, stop developing!!" ),
            new Review("Mary", DateTime.Now,"This was the first time I`ve used it but I liked it") 
        };

        public static void AddReview(string nm, string ct)
        {
            reviewlList.Add(new Review(nm, DateTime.Now, ct));
        }
        public static IList<Survey> surveyList = new List<Survey>()
        {
            new Survey("Ivan",DateTime.Now, "Timokhin", new List<string>{"2.3","6.0","8.1","10"},"love")
        };
        public static IList<string> versions = new List<string>{"2.3","4.0","4.2","5.0","6.0","8.1","10"};
        public static IList<string> emotions = new List<string> { "love", "don`t like", "hate"};
        public static void AddSurvey(string name, DateTime date, string surname, List<string> versions, string emotions)
        {
            surveyList.Add(new Survey(name, date, surname,versions,emotions));
        }
        
    }   
}
