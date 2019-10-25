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

        // Creates a new comment using passed parameter
        // Returns CommentForm View and binds Comment c in the model
        [HttpGet]
        public ViewResult CommentForm(string title) 
        {
            Comment c = new Comment() { storyTitle = title };
            return View("CommentForm", c);
        }

        [HttpPost]
        public ViewResult CommentForm(string storyTitle, string username, string email, string commentText)
        {
            if (ModelState.IsValid)
            {
                Story s = Repository.stories.Find(x => x.StoryTitle == storyTitle);
                User u = new User() { Email = email, Username = username };
                Comment c = new Comment() { CommentText = commentText, User = u };
                s.AddComment(c);
                return Stories();
            } else
            {
                return View();
            }
        }


        public ViewResult Sources()
        {
            return View();
        }
    }
}
