using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanSite.Models
{
    public class Story
    {

        // Add in some code where if User with Username doesn't exist, create them, but if they do,
        // use that User object instead of making a new one

        public List<Comment> comments = new List<Comment>();

        public List<Comment> Comments { get { return comments; } }

        public User User { get; set; }

        [Required(ErrorMessage = "Please enter your story's title")]
        public string StoryTitle { get; set; }

        [Required(ErrorMessage = "Please enter your story")]
        public string StoryText { get; set; }

        public void AddComment(Story s, Comment c)
        {
            s.comments.Add(c);
        }
    }
}
