angular.module('app').factory('mvGroup', function ($resource) {
    var commentResource = $resource('/api/group/:ServiceId', { _id: "@ServiceId" },
        {
            get: { method: 'GET', params: { ServiceId: "@ServiceId" }, isArray: true },
             
        addOrUpdate: { method: 'PUT', isArray: false }
        }
        );
    return commentResource;
});