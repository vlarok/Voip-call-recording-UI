angular.module('app').factory('mvUser', function ($resource) {
    var productResource = $resource('/api/user/:CallId', { _id: "@CallId" },
        {
            get: { method: 'GET', params: { ProductId: "@CallId" }, isArray: false },
             delete_product: {
                 method: 'DELETE', params: { ProductId: "@CallId" }, isArray: false
        },
        addOrUpdate: { method: 'PUT', isArray: false }
        }
        );
    return productResource;
});