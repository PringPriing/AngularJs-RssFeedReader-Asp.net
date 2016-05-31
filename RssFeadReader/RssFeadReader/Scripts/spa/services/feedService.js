(function (app) {
    'use strict';

    app.factory('feedService', feedService);
    feedService.$inject = ['$http'];

    function feedService($http) {
        var service = {
            parsefeed: parsefeed
        }
        function parsefeed(url) {
            return $http.jsonp('//ajax.googleapis.com/ajax/services/feed/load?v=1.0&num=50&callback=JSON_CALLBACK&q=' + encodeURIComponent(url));
        }
        
        return service;
    }
 
})(angular.module('common.core'));