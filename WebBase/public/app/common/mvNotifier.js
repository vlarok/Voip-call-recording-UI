angular.module('app').factory('mvNotifier', function (toaster) {
    return {
        notify: function (msg) {
            toaster.pop('success', "", msg);
            console.log(msg);
        },
        error: function (msg) {
            toaster.pop('error', "", msg);
            console.log(msg);
        },
        warning: function (msg) {
            toaster.pop('warning', "", msg);
            console.log(msg);
        }
    }
})