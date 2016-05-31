using RssFeadReader.Models;
using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RssFeadReader.Infrastructure.Extensions
{
    public static class EntitiesExtensions
    {
        public static void UpdateFeedRating(this FeedRating feedRating,FeedViewModel feedVM)
        {
            feedRating.ID = feedVM.ID;
            feedRating.FeedTitle = feedVM.FeedTitle;
            feedRating.UserName = feedVM.UserName;
            feedRating.Rating = feedVM.Rating;
        }
    }
}