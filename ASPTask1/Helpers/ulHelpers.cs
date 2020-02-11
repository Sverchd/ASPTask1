using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPTask1.Helpers
{
    public static class ulHelpers
    {
        // первый параметр - Тип, для которого создается extension method 
        public static MvcHtmlString CreateUl(this HtmlHelper html, List<string> items, string name)
        {
            var ul = new TagBuilder("ul");
            ul.MergeAttribute("name", name);
            foreach (string item in items)
            {
                var option = new TagBuilder("li");
                option.MergeAttribute("value", item);
                option.SetInnerText(item);
                ul.InnerHtml += option.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

        public static MvcHtmlString CreateOl(this HtmlHelper html, List<string> items, string name)
        {
            var ol = new TagBuilder("ol");
            ol.MergeAttribute("name", name);
            foreach (string item in items)
            {
                var option = new TagBuilder("li");
                option.MergeAttribute("value", item);
                option.SetInnerText(item);
                ol.InnerHtml += option.ToString();
            }
            return new MvcHtmlString(ol.ToString());
        }

    }
}