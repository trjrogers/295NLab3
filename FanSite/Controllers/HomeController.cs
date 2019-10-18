using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Web;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        public ViewResult Stories()
        {
            return View(Repository.Stories);
        }

        [HttpGet]
        public ViewResult StoryForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StoryForm(Story story)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStory(story);
                IEnumerable<Story> stories = Repository.Stories;
                return View("Stories", stories);
            } else
            {
                return View();
            }
        }

        public ViewResult CommentForm(string title)
        {
            return View("CommentForm", HttpUtility.HtmlDecode(title));
        }

        [HttpPost]
        public ViewResult CommentForm(Story story, Comment comment)
        {
            if (ModelState.IsValid)
            {
                story.AddComment(story, comment);
                IEnumerable<Story> stories = Repository.Stories;
                return View("Stories", stories);
            }
            else {
                return View();
            }
        }

        public ViewResult Sources()
        {
            return View();
        }
    }
}
