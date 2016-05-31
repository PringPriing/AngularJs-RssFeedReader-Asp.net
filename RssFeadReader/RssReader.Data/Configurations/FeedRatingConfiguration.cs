using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Configurations
{
    class FeedRatingConfiguration : EntityBaseConfiguration<FeedRating>
    {
        public FeedRatingConfiguration()
        {
            Property(x => x.UserName).IsRequired().HasMaxLength(100);
            Property(x => x.FeedTitle).IsRequired().HasMaxLength(200);
            Property(x => x.Rating).IsRequired();
        }
    }
}
