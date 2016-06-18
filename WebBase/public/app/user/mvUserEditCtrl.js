
angular.module('app').controller('mvUserEditCtrl', function ($scope, $routeParams, $location, mvUser, mvUserCUD, mvNotifier, $translate) {


    mvUser.get({ id: $routeParams.id }, function (user) {
        $scope.userName = user.UserName;
        $scope.email = user.Email;
        $scope.phoneNumber = user.PhoneNumber;
    });


    $scope.users = mvUser.query(function () {

    });

    $scope.update = function () {
       
            //parooli kinnuts tegemata
        var newUserData = {
            Id: $routeParams.id,
                UserName: $scope.userName,
                Email: $scope.email,
                PhoneNumber: $scope.phoneNumber
            };

            mvUserCUD.addOrUpdateUser(newUserData).then(function (responsed) {

                mvNotifier.notify($translate.instant('USER_UPDATED'));
                $location.path('/user');
               
            }, function (reason) {
               
            });
        };
    

});