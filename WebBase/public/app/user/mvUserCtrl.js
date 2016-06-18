
angular.module('app').controller('mvUserCtrl', function ($scope, mvUser, mvRegistrationCUD, mvNotifier,$translate) {



    $scope.users = mvUser.query(function () {

    });

    $scope.add = function () {
      
            //parooli kinnuts tegemata
            var newUserData = {
                UserName: $scope.userName,
                Email: $scope.email,
                Password: $scope.password,
                ConfirmPassword: $scope.passwordConfirm
            };

            mvRegistrationCUD.createUser(newUserData).then(function (responsed) {

                mvNotifier.notify($translate.instant('USER_CREATED'));
                $scope.users.push(newUserData);

                $scope.userName="",
                $scope.email = "",
                $scope.password="",
                $scope.passwordConfirm=""
               
            }, function (reason) {
                if (!!reason.data.ModelState["model.ConfirmPassword"]) {

                    mvNotifier.error(reason.data.ModelState["model.ConfirmPassword"][0]);
                    console.log(JSON.stringify(reason.data.ModelState["model.ConfirmPassword"][0]));

                }
                //  console.log(JSON.stringify(reason.data.ModelState[""][0]));
                if (!!reason.data.ModelState[""]) {

                    mvNotifier.error(reason.data.ModelState[""][0]);
                    console.log(JSON.stringify(reason.data.ModelState[""][0]));

                }

                //parool ei vordu console.log(JSON.stringify(reason.data.ModelState["model.ConfirmPassword"][0]));
                //muud console.log(JSON.stringify(reason.data.ModelState[""][0]));

            });
        };
    

});