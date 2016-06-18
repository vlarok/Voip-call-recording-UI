angular.module('app').factory('mvUserCUD', function ($http, $q, mvUser) {
    return {

        addOrUpdateUser: function (newUserData) {
            var newUser = new mvUser(newUserData);
            var dfd = $q.defer();
            newUser.$addOrUpdate().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response.data.reason);
            });
            return dfd.promise;
        }


        

    }
});