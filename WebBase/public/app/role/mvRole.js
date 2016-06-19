angular.module('app').factory('mvRole', function ($resource) {
    var commentResource = $resource('/api/role/:ServiceId', { _id: "@ServiceId" },
        {
            get: { method: 'GET', params: { ServiceId: "@ServiceId" }, isArray: true },
             
        addOrUpdate: { method: 'PUT', isArray: false }
        }
        );
    return commentResource;
});