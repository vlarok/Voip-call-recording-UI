angular.module('app').factory('mvCall', function ($resource) {
    var callResource = $resource('/api/Call/:CallId', { _id: "@CallId" },
        {
            get: { method: 'GET', params: { CallId: "@CallId" }, isArray: true },
             delete_product: {
                 method: 'DELETE', params: { CallId: "@CallId" }, isArray: false
        },
             addOrUpdate: { method: 'PUT', isArray: false }
            ,
             getRange: { method: 'POST', isArray: false }
        
        }

        );
    return callResource;
});