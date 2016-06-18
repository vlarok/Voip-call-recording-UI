angular.module('app').factory('mvRegistrationCUD', function ($http, $q, mvRegistration) {
    return {
        createUser: function (newUserData) {
            var newUser = new mvRegistration(newUserData);
            var dfd = $q.defer();
            newUser.$register().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response);
            });
            return dfd.promise;
        },
        changePassword: function (newPwdData) {
            var newPwd = new mvRegistration(newPwdData);
            var dfd = $q.defer();
            newPwd.$changePassword().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response);
            });
            return dfd.promise;
        }
    }
});