using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FanSite.Models
{
    public class Comment
    {
        [Required(ErrorMessage = "Please enter your username")]
        public User User{ get; set; }

        [Required(ErrorMessage = "Please leave your comment")]
        public string CommentText { get; set; }
    }
}
