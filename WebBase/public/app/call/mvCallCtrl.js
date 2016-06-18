angular.module('app').filter('startFrom', function () {
    return function (input, start) {
        if (input) {
            start = +start; //parse to int
            return input.slice(start);
        }
        return [];
    }
});
angular.module('app').filter('status', function ($translate) {

    var statusDict = {
        1: $translate.instant('IN'),
        0: $translate.instant('OUT')
    };
    return function (status) {
        return statusDict[status] || 'Error';
    };
});
angular.module('app').controller('mvCallCtrl', function ($scope, mvCall, mvCallCUD) {

    var start = new Date();
    start.setHours(0, 0, 0, 0);

    var end = new Date();
    end.setHours(23, 59, 59, 999);


    var post = function () {
        var postData = {
            From: start,
            To: end
        };


        mvCallCUD.getRange(postData).then(function (response) {
           
            $scope.calls = response.Calls;
            $scope.totalitems = $scope.calls.length;
        }, function (reason) {

        });
};

   // alert(start + ':' + end);
   /* var calls = function () {
        $scope.calls = mvCall.query(function () {
            $scope.totalitems = $scope.calls.length;
        });
    }
    */
    post();

    var that = $scope;
    $scope.picker1 = {
        date: start,
        timepickerOptions: {
            showSeconds: true,
            showMeridian: false,
            max: null
        },
        datepickerOptions: {
            maxDate: null
        },
        closed: function (args) {
            that.closedArgs = args;
            start = args.closeDate;
            post();
        }
    };
    $scope.picker2 = {
        date: end,
        timepickerOptions: {
            showSeconds: true,
            showMeridian: false,
            min: null
        },
        datepickerOptions: {
            minDate: null
        },
        closed: function (args) {
            that.closedArgs = args;
            end = args.closeDate;
            post();
        }
    };

    // watch min and max dates to calculate difference
    var unwatchMinMaxValues = $scope.$watch(function () {
        return [that.picker1, that.picker2, that.picker10, that.picker11];
    }, function () {
        // min max dates
        that.picker1.datepickerOptions.maxDate = that.picker2.date;
        that.picker2.datepickerOptions.minDate = that.picker1.date;

        if (that.picker1.date && that.picker2.date) {
            var diff = that.picker1.date.getTime() - that.picker2.date.getTime();
            that.dayRange = Math.round(Math.abs(diff / (1000 * 60 * 60 * 24)))
        } else {
            that.dayRange = 'n/a';
        }

        // min max times
        that.picker1.timepickerOptions.max = that.picker2.date;
        that.picker2.timepickerOptions.min = that.picker1.date;
    }, true);

    $scope.$on('$destroy', function () {
        unwatchMinMaxValues();
    });

    $scope.openCalendar = function (e, picker) {
        
        that[picker].open = true;
    };

    $scope.maxSize = 5;
    $scope.bigCurrentPage = 1;
    $scope.itemsPerPage = 10;
    


    
    /*
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
    */

    $scope.sortType = 'Created'; // set the default sort type
    $scope.sortReverse = true;  // set the default sort order
    $scope.searchFish = '';
});