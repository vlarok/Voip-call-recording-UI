
angular.module('app').controller('mvRoleCtrl', function ($scope, mvRole,mvGroup, mvRoleCUD) {
    var setPrivileges = [];
    var listOfObjects = [];
   var getGroups= function() {
       $scope.groups = mvGroup.query(function (gr) {
          
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
        setPrivileges = [];
        role.Roles.forEach(function (entry) {
            console.log(JSON.stringify(entry.RoleId));
            setPrivileges.push(entry.RoleId);
        });

        $scope.selectedRole = role;
    };

    $scope.add = function (group) {
       
        console.log(JSON.stringify(group));
        setPrivileges.forEach(function(entry) {
            var singleObj = {}
            singleObj['RoleId'] = entry;
          //  singleObj['GroupId'] = group.GroupId;
            listOfObjects.push(singleObj);
        });

        console.log(JSON.stringify(listOfObjects));
        var newData = {
            name: group.Name,
            created: new Date(),
            RoleGroups: listOfObjects
        };

        mvRoleCUD.addOrUpdate(newData).then(function (response) {

            $scope.groups.push(response);
            $scope.selectedRole = null;
            setPrivileges = [];
        }, function (reason) {

        });
    };

    $scope.update = function (group) {
        

       
        console.log(JSON.stringify(group));
        setPrivileges.forEach(function (entry) {
            var singleObj = {}
            singleObj['RoleId'] = entry;
            singleObj['GroupId'] = group.GroupId;
            listOfObjects.push(singleObj);
        });

        console.log(JSON.stringify(listOfObjects));
        var newData = {
            groupId:group.GroupId,
            name: group.Name,
            created: new Date(),
            RoleGroups: listOfObjects
        };

        mvRoleCUD.addOrUpdate(newData).then(function (response) {

            $scope.selectedRole = null;
            setPrivileges = [];
        }, function (reason) {

        });
    };

    $scope.clear = function () {
        $scope.selectedRole = null;
        setPrivileges = [];
        getGroups();
    };

});