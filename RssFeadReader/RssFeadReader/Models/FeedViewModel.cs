using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RssFeadReader.Models
{
    public class FeedViewModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FeedTitle { get; set; }
        public int Rating { get; set; }
    }
}