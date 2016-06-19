angular.module('app').factory('mvRoleCUD', function ($http, $q, mvGroup) {
    return {

        addOrUpdate: function (newData) {
            var data = new mvGroup(newData);
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