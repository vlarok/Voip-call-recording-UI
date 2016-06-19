
angular.module('app').controller('mvRoleCtrl', function ($scope, mvRole,mvGroup, mvRoleCUD) {
    var setPrivileges = [];
   var getGroups= function() {
       $scope.roles = mvGroup.query(function () {

       });

   }

   var getPrivileges = function () {
       $scope.privileges = mvRole.query(function () {

       });

   }
    getPrivileges();
    getGroups();

    $scope.addPrivilege = function (data) {
        setPrivileges.push(data);

    }
    $scope.removePrivilege = function (data) {
        setPrivileges.splice(setPrivileges.indexOf(data), 1);

    }
    $scope.active = function (data) {
        //   console.log(str.indexOf(data));
        return setPrivileges.indexOf(data) > -1;
    }


    $scope.edit = function (role) {
        $scope.selectedRole = role;
    };

    $scope.add = function (role) {
        var newData = {
            name: role.Name,
            created: new Date()
        };

        mvRoleCUD.addOrUpdate(newData).then(function (response) {

            $scope.roles.push(response);
            $scope.selectedRole = null;
        }, function (reason) {

        });
    };

    $scope.update = function (role) {
        
        mvRoleCUD.addOrUpdate(role).then(function (response) {

            $scope.selectedRole = null;
        }, function (reason) {

        });
    };

    $scope.clear = function () {
        $scope.selectedRole = null;
        getGroups();
    };

});