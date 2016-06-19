
angular.module('app').controller('mvServiceCtrl', function ($scope, mvService, mvServiceCUD) {

    $scope.services = mvService.query(function() {

    });

    $scope.edit = function (service) {
        $scope.selectedService = service;
    };

    $scope.add = function (service) {
        var newData = {
            name: service.Name,
            created: new Date()
        };

        mvServiceCUD.addOrUpdate(newData).then(function (response) {

            $scope.services.push(response);
            $scope.selectedService = null;
        }, function (reason) {

        });
    };

    $scope.update = function (service) {
        
        mvServiceCUD.addOrUpdate(service).then(function (response) {

           // $scope.services.push(response);
            $scope.selectedService = null;
        }, function (reason) {

        });
    };

    $scope.clear = function () {
        $scope.selectedService = null;
    };

});