using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class PhysicalMediaModel
    {
        private List<PhysicalMediaModel> physicalList = new List<PhysicalMediaModel>();

        public List<PhysicalMediaModel> PhysicalList
        {
            get
            {
                return physicalList;
            }
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
