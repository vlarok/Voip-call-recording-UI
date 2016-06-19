angular.module('app').factory('mvService', function ($resource) {
    var commentResource = $resource('/api/service/:ServiceId', { _id: "@ServiceId" },
        {
            get: { method: 'GET', params: { ServiceId: "@ServiceId" }, isArray: true },
             
        addOrUpdate: { method: 'PUT', isArray: false }
        }
        );
    return commentResource;
});