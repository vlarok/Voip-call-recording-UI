
angular.module('app').controller('mvCommentCtrl', function ($scope,$routeParams, mvProduct,mvCommentCUD) {


    mvProduct.get({ id: $routeParams.id }, function (product) {
        $scope.title = product[0].Title;

        $scope.intro = product[0].Intro;
        $scope.body = product[0].Body;
        $scope.comments = product[0].Comments;

    });

    $scope.add = function () {
        var newCommentData = {
            productId:$routeParams.id,
            title: $scope.titleComment,
            author: $scope.authorComment,
            body: $scope.bodyComment,
            created: new Date()
        };

        mvCommentCUD.addOrUpdateComment(newCommentData).then(function (response) {

            $scope.comments.push(response);
            $scope.titleComment = "";
            $scope.authorComment = "";
            $scope.bodyComment = "";
        }, function (reason) {

        });
    };

});