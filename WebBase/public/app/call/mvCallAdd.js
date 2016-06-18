
angular.module('app').controller('mvProductAddCtrl', function ($scope, mvProduct,mvProductCUD) {



    $scope.product = mvProduct.query(function () {

    });

    $scope.add = function() {
        var newProductData = {
            title: $scope.title,
            intro: $scope.intro,
            body:$scope.body,
            created: new Date()
        };

        mvProductCUD.addOrUpdateProduct(newProductData).then(function (response) {
            
            $scope.product.push(response);
            $scope.title = "";
            $scope.intro = "";
            $scope.body = "";
        }, function (reason) {
           
        });
    };

    $scope.hide = function (p) {
        var newProductData = {
            productId: p.ProductId,
            title: p.Title,
            intro: p.Intro,
            body: p.Body,
            hidden: true,
            created: new Date()

        };

        mvProductCUD.addOrUpdateProduct(newProductData).then(function (response) {
            $scope.product.splice($scope.product.indexOf(p), 1);
         

        }, function (reason) {

        });
    };

    $scope.delete = function (p) {
        mvProductCUD.deleteProduct(p).then(function () {

            $scope.product.splice($scope.product.indexOf(p), 1);
        }, function (reason) {

        });
        
        };

});