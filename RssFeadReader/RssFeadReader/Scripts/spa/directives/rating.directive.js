(function (app) {
    'use strict';

    app.directive('componentRating', componentRating);
    componentRating.$inject = ['apiService'];
    function componentRating(apiService) {
        return {
            restrict: 'A',
            link: function ($scope, $element, $attrs) {
                $element.raty({
                    score: $attrs.componentRating,
                    halfShow: false,
                    readOnly: $scope.isReadOnly,
                    noRatedMsg: "Not rated yet!",
                    starHalf: "../Content/images/raty/star-half.png",
                    starOff: "../Content/images/raty/star-off.png",
                    starOn: "../Content/images/raty/star-on.png",
                    hints: ["Poor", "Average", "Good", "Very Good", "Excellent"],
                    click: function (score, event) {
                        //Set the model value
                        $scope.feed.Rating = score;
                        
                        $scope.$apply();
                        $scope.FeedRating = {
                            UserName: $scope.username,
                            FeedTitle: $scope.feed.title,
                            Rating: $scope.feed.Rating
                        }

                        apiService.post('/api/feedRating/add', $scope.FeedRating,
                                            null,
                                            null)

                      
                  
                    }
                });
            }
        }
    }

})(angular.module('common.ui'));