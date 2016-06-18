angular.module('app').factory('mvComment', function ($resource) {
    var commentResource = $resource('/api/comment/:CommentId', { _id: "@CommentId" },
        {
            get: { method: 'GET', params: { CommentId: "@CommentId" }, isArray: true },
             
        addOrUpdate: { method: 'PUT', isArray: false }
        }
        );
    return commentResource;
});