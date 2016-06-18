angular.module('app').factory('mvCallCUD', function ($http, $q, mvCall) {
    return {

        
        getRange: function (dataRange) {
            var newRange = new mvCall(dataRange);
           
            var dfd = $q.defer();
            newRange.$getRange().then(function (response) {
                
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response);
            });
            return dfd.promise;
        }

    }
});