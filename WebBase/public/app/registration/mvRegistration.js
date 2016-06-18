angular.module('app').factory('mvRegistration', function ($resource) {
    var RegisterResource = $resource('/api/Account/:id', { _id: "@id" },
        {
            register: { method: 'POST', params: { id: "Register" } },
            changePassword: { method: 'POST', params: { id: "ChangePassword" } }
        }

        );

    return RegisterResource;
});

