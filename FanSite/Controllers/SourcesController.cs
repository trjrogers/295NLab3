using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Collections.Generic;

namespace FanSite.Controllers
{
    public class SourcesController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PhysicalMedia()
        {
            return View();
        }

        public ViewResult OnlineMedia()
        {
            if (Repository.online.Count != 2)
            {
                OnlineMediaModel b = new OnlineMediaModel("DC Comics", "Learn more about the Joker from the publisher.", "https://www.dccomics.com/characters/joker");
                OnlineMediaModel a = new OnlineMediaModel("Wikipedia", "Learn more about the Joker from fans.", "https://en.wikipedia.org/wiki/Joker_(character)");

                Repository.online.Add(a);
                Repository.online.Add(b);

                List<OnlineMediaModel> onlines = Repository.online;
                onlines.Sort((x, y) => a.Title.CompareTo(b.Title));

                return View(onlines);
            } else
            {
                List<OnlineMediaModel> onlines = Repository.online;
                onlines.Sort((x, y) => x.Title.CompareTo(y.Title));

                return View(onlines);
            }
        }

        [HttpGet]
        public ViewResult Home()
        {
            return View();
        }
    }
}