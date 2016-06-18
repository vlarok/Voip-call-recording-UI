
angular.module('app').controller('mvProductViewCtrl', function ($scope, mvProduct, mvProductCUD, $routeParams, $location) {

    


    mvProduct.get({ id: $routeParams.id }, function (product) {
        $scope.id = product[0].ProductId;
        $scope.title = product[0].Title;
      
        $scope.intro= product[0].Intro;
        $scope.body = product[0].Body;
        $scope.comments = product[0].Comments;

    });

     $scope.update = function() {
         var newProductData = {
             productId:$routeParams.id ,
             title: $scope.title,
             intro: $scope.intro,
             body: $scope.body,
             created: new Date()

        };

         mvProductCUD.addOrUpdateProduct(newProductData).then(function (response) {
            $location.path('/');
           
        }, function (reason) {
           
        });
    };
   
});
