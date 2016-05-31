using RssFeadReader.Infrastructure.Core;
using RssFeadReader.Models;
using RssReader.Data.Infrastructure;
using RssReader.Data.Repositories;
using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using RssFeadReader.Infrastructure.Extensions;
using AutoMapper;

namespace RssFeadReader.Controllers
{
    [Authorize(Roles = "Admin")]
    [RoutePrefix("api/feedRating")]
    public class FeedController: ApiControllerBase
    {
        private readonly IEntityBaseRepository<FeedRating> _feedRatingRepository;
        public FeedController(IEntityBaseRepository<FeedRating> feedRatingRepository,IUnitOfWork _unitofWork)
            :base(_unitofWork)
        {
            _feedRatingRepository = feedRatingRepository;
        }

        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(HttpRequestMessage request,FeedViewModel feedRatingViewModel)
        {
            return CreateHttpResponse(request, () =>
                {
                    HttpResponseMessage response = null;
                    
                    if(!ModelState.IsValid)
                    {
                        response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                    }
                    else
                    {
                        FeedRating addRating = new FeedRating();
                        addRating.UpdateFeedRating(feedRatingViewModel);
                        _feedRatingRepository.Add(addRating);

                        _unitOfWork.Commit();

                        feedRatingViewModel = Mapper.Map<FeedRating, FeedViewModel>(addRating);
                        response = request.CreateResponse<FeedViewModel>(HttpStatusCode.Created, feedRatingViewModel);
                    }
                    return response;
                });
        }

        [HttpGet]
        [Route("feedRatings/{username}")]
        public HttpResponseMessage Get(HttpRequestMessage request, string username)
        {
            HttpResponseMessage response = null;
            var feedRatings = _feedRatingRepository.GetAll().Where(x => x.UserName == username);
            IEnumerable<FeedViewModel> feedVM = Mapper.Map<IEnumerable<FeedRating>, IEnumerable<FeedViewModel>>(feedRatings);
            response = request.CreateResponse<IEnumerable<FeedViewModel>>(HttpStatusCode.OK, feedVM);
            return response;
        }

    }
}