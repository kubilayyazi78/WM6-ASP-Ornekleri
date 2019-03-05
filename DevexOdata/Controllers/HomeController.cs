using DevexOdata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevexOdata.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ApplicationDbContext db = new ApplicationDbContext();
            for (int i = 0; i < 5000; i++)
            {
                db.Customers.Add(new Customer()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Adress = FakeData.PlaceData.GetAddress(),
                    Balance = FakeData.NumberData.GetNumber(1250, 99999),
                    Surname = FakeData.NameData.GetSurname(),
                    Phone = "05" + FakeData.PhoneNumberData.GetPhoneNumber().Replace("-", "").Substring(0, 10)
                });
                if (i % 100 == 0)
                    {
                    db.SaveChanges();
                    }

            }
            db.SaveChanges();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}