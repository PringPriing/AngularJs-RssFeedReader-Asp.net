using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Entities
{
    public class FeedRating: IEntityBase
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FeedTitle { get; set; }
        public int Rating { get; set; }

    }
}
