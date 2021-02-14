using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using RootObject.Models;

namespace RootObject.Controllers
{

    public class CurrencyController : Controller
    {
        //[HttpPost]
        public IActionResult Index(Models.RootObject x)
        {
            //POST
            int Number = x.Quantity;
            string currencySelected = x.To;
            double currencyChange = 0;
            //URL json
            var webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.Cookie, "cookievalue");
            var json = webClient.DownloadString(@"https://api.exchangeratesapi.io/latest");
            Models.RootObject objJson = JsonConvert.DeserializeObject<Models.RootObject>(json);
            //Currency Selected and Change
           /* if (currencySelected == "USD") { currencyChange = objJson.rates.USD; }
            else if (currencySelected == "GBP") { currencyChange = objJson.rates.GBP; }
            else if (currencySelected == "CAD") { currencyChange = objJson.rates.CAD; }
            else if (currencySelected == "AUD") { currencyChange = objJson.rates.AUD; }*/
            //Return total and selected
            ViewBag.Selected = currencySelected;
            ViewBag.Total = Math.Round(Number * Convert.ToDouble(x.To), 4);
            //ViewBag.Total = Math.Round(Number * x.CurrrencySelectedTotal(currencySelected), objJson.rates);
            return View(objJson);
        }

        /*[HttpPost]
        public ActionResult Edit(Models.RootObject x)
        {
            // update student to the database
            int Number = x.Quantity;
            string currencySelected = x.To;
            double currencyChange = 0;
            return RedirectToAction("Index");
        }*/
    }
    public class CurrencySelected
    {
        /*
        public double CurrrencySelectedTotal(string currencySelected, object s)
        {
            double currencyChange = 0;

            if (currencySelected == "USD") { currencyChange = s.rates.USD; ; }
            else if (currencySelected == "GBP") { currencyChange = rates.GBP; }
            else if (currencySelected == "CAD") { currencyChange = rates.CAD; }
            else if (currencySelected == "AUD") { currencyChange = rates.AUD; }

            return currencyChange;
        }*/
    }
}