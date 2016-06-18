angular.module('app').factory('mvCommentCUD', function ($http, $q, mvComment) {
    return {

        addOrUpdateComment: function (newCommentData) {
            var newComment = new mvComment(newCommentData);
            var dfd = $q.defer();
            newComment.$addOrUpdate().then(function (response) {
                dfd.resolve(response);
            }, function (response) {
                dfd.reject(response.data.reason);
            });
            return dfd.promise;
        }

    }
});