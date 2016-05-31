using AutoMapper;
using RssFeadReader.Models;
using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RssFeadReader.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return  "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<FeedRating, FeedViewModel>();
        }
    }
}