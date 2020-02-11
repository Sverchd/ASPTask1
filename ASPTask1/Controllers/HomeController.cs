using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPTask1.Models;


namespace ASPTask1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            
            return View(ContentArticle.articelList);
        }
        public ActionResult Form(FormCollection form, List<string> versions, string emotions)
        {
            if (HttpContext.Request.HttpMethod == "GET")
            {
                
                ViewBag.Message = "Your contact page.";
                return View(new List<IList<string>> {ContentArticle.versions,ContentArticle.emotions});
            }
            else if (HttpContext.Request.HttpMethod == "POST")
            {

                var surv = new Survey(form["Name"], DateTime.Now, form["SurName"], versions, emotions);
                ContentArticle.surveyList.Add(surv);
                return View("Result",surv);
            }
            else
            {
                return View();
            }
        }

        [HttpGet] public ActionResult Guest()
        {
            HttpContext.Request.GetType();
            ViewBag.Text = "Text";
            return View(ContentArticle.reviewlList);
        }
     
        [HttpPost] public ActionResult Guest(FormCollection form)
        {
            ViewBag.TextReturn = "Вы ввели: " + form["Text"];
            ViewBag.TextReturn = form["UserName"];
            ContentArticle.AddReview(form["UserName"], form["ReviewText"]);
            return View(ContentArticle.reviewlList);
        }

    }
}