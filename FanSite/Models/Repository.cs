using System.Collections.Generic;

namespace FanSite.Models
{
    public static class Repository
    {
        public static List<Story> stories = new List<Story>();

        public static IEnumerable<Story> Stories
        {
            get
            {
                return stories;
            }
        }

        public static void AddStory(Story story)
        {
            stories.Add(story);
        }

        public static Story GetStoryByTitle(string storyTitle)
        {
            return Repository.stories.Find(x => x.StoryTitle == storyTitle);
        }
    }
}
