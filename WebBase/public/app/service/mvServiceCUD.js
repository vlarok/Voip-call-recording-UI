angular.module('app').factory('mvServiceCUD', function ($http, $q, mvService) {
    return {

        addOrUpdate: function (newData) {
            var data = new mvService(newData);
            var dfd = $q.defer();
            data.$addOrUpdate().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response.data.reason);
            });
            return dfd.promise;
        }

    }
});