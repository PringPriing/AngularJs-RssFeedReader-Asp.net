
(function (app) {
    'use strict';

    app.controller('FeedCtrl', FeedCtrl);
    FeedCtrl.$inject = ['$scope', '$location', 'feedService', '$rootScope', 'apiService', 'notificationService','$interval'];

    function FeedCtrl($scope, $location, feedService, $rootScope, apiService, notificationService,$interval) {
        $scope.loadButonText = "Load";
        $scope.feeds = [];
        $scope.RatedfeedsByUser = [];


        function ExecuteLoadFunctionEvery5Mins(){
            $interval(function () {
                Load();
                $scope.$apply();
            }, 300000);
        }


        function Load() {
            $scope.feeds = [];
            $scope.RatedfeedsByUser = [];
            LoadFeedByUser($scope.username);
            feedService.parsefeed('http://www.sunstar.com.ph/rss/cebu ').then(function (res) {
                //$scope.feeds = res.data.responseData.feed.entries;

                var arr = res.data.responseData.feed.entries;
                var currentFeedTitle;
                var savedFeedTitle;
                var Rating;

                angular.forEach(arr, function (value) {
                    currentFeedTitle = value.title
                    Rating = 0;
                    angular.forEach($scope.RatedfeedsByUser, function (value) {
                        savedFeedTitle = value.FeedTitle;
                        if (currentFeedTitle == savedFeedTitle) {
                            //alert('Rating' + value.Rating);
                            Rating = value.Rating;
                        }
                    });

                    var feed = {
                        link: value.link,
                        title: value.title,
                        contentSnippet: value.contentSnippet,
                        Rating: Rating
                        
                    };

                    $scope.feeds.push(feed);
                   
                });
                
            });
        }

        function LoadFeedByUser(userName) {
            apiService.get('/api/feedRating/feedRatings/' + userName,
                                 null,
                                 LoadFeedByUserCompleted,
                                 LoadFeedByUserFailed);
        }

        function LoadFeedByUserCompleted(response) {
            $scope.RatedfeedsByUser = response.data;
            //iterate();
        }

        function LoadFeedByUserFailed(response) {
            notificationService.displayError(response.statusText);
        }


        Load();
        ExecuteLoadFunctionEvery5Mins();
      
    }

})(angular.module('RSS'));

