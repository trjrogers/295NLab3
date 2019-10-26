using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class OnlineMediaModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public OnlineMediaModel(string title, string description, string link)
        {
            //OnlineMediaModel a = new OnlineMediaModel() { Title = "DC Comics", Description = "Learn more about the Joker from the publisher.", Link = "https://www.dccomics.com/characters/joker" };
            //OnlineMediaModel b = new OnlineMediaModel() { Title = "Wikipedia", Description = "Learn more about the Joker from fans.", Link = "https://en.wikipedia.org/wiki/Joker_(character)" };

            //Repository.online.Add(a);
            //Repository.online.Add(b);

            Title = title;
            Description = description;
            Link = link;


        }
    }
}
