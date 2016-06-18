angular.module('app', ['ngResource', 'toaster', 'ngAnimate', 'ngRoute', 'ui.bootstrap','ui.bootstrap.datetimepicker','pascalprecht.translate']);


angular.module('app').config(function ($routeProvider, $locationProvider,$translateProvider) {
    

 
   
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/', {
            templateUrl: '/public/app/Call/Call.html',
            controller: 'mvCallCtrl'
        })
        .when('/user', {
            templateUrl: '/public/app/user/user.html',
            controller: 'mvUserCtrl'
        })
         .when('/user/:id', {
             templateUrl: '/public/app/user/userEdit.html',
             controller: 'mvUserEditCtrl'
         })
    .when('/view/:id', {
        templateUrl: '/public/app/Call/productView.html',
        controller: 'mvProductViewCtrl'
    }).when('/comment/:id', {
        templateUrl: '/public/app/comment/comment.html',
        controller: 'mvCommentCtrl'
    })
        .when('/Call/:id', {
            templateUrl: '/public/app/Call/productDetail.html',
            controller: 'mvProductDetailCtrl'
        })
        .otherwise({ redirectTo: '/404' });


    $translateProvider.translations('en', {
        TITLE: 'Givela eng',
        USER_CREATED: 'User created!',
        PRODUCT_PAGE_TITLE: 'Offers',
        RODUCT_ADDED: 'Success!',
        LOGIN: 'Login',
        LOGIN_OUT: 'Logged out!',
        LOGIN_SUCC: 'Login successful!',
        LOGIN_FAIL: 'Login failed!',
        lable_new_charity: 'New Charity',
        REGISTER: 'Register',
        REG_PAGE_LOADED: 'Registration page loaded!',
        REG_PAGE: 'Create user',
        CANCEL:'Cancel',
        USERNAME: 'Username',
        EMAIL: 'E-mail',
        PASSWORD: 'Password',
        CONF_PASSWORD: 'Confirm password',
        CREATE_NEW_DONATION: 'Create new donation',
        CHOOSE_PICTURE: 'Choose Picture',
        CHANGE_PICTURE: 'Change Picture',
        LABLE_TITLE: 'Title',
        DESCRIPTION: 'Description',
        ENDED: 'Ended',
        NAME: 'Name',
        ADDRESS: 'Address',
        ADD: 'Add',
        MANAGE_PAGE_TITLE: 'Administration page',
        MANAGE_PAGE_LOADED: 'Administration page loaded!',
        TITLE_CHANGE_PASSWORD: 'Change password',
        LABEL_CURRENT_PASSWORD: 'Current password',
        LABEL_NEW_PASSWORD: 'New password',
        LABEL_CONFIRM_NEW_PASSWORD: 'Confirm new password',
        CONFIRM: 'Confirm',
        USER_PAGE_TITLE: 'This is the user page',
        PRODUCT_ADDED: 'Call added!',
        USER_SETTINGS_PAGE_TITLE: 'User settings page',
        NOTIFY_PASSWORD_UPDATED: 'Password updated!',
        BID: 'Bid',
        BIDDERS: 'Bidders',
        BID_VALUE: 'Bid value',
        BID_ADDED: 'Bid added!',
        LABEL_CHOOSE_DONATION: 'Choose who to donate to',
        LIST: 'List',
        LABEL_YOUR_BID: 'Your bid',
        MINIMUM_DONATION: 'Minimum donation',
        VALID_FOR_BID: 'Valid for bidding',
        UPRODUCTS: 'Add new',
        SETTINGS: 'Settings',
        ADMIN: 'Admin',
        LOGOFF: 'Log off',
        LOGIN: 'Login',
        TITLE_TO_LONG: ' is too long',
        TITLE_TO_SHORT: ' is too short',
        PHONE_NUMBER: 'Phone number',
        EDIT:'Edit'


    });
    $translateProvider.translations('et', {
        TITLE: 'Givela eesti',
        USER_CREATED: 'Kasutaja loodud!',
        PRODUCT_PAGE_TITLE: 'Pakkumised',
        RODUCT_ADDED: 'Lisamine õnnestus!',
        LOGIN: 'Logi sisse',
        LOGIN_OUT: 'Logisite välja!',
        LOGIN_SUCC: 'Sisselogimine õnnestus!',
        LOGIN_FAIL: 'Sisselogimine ebaõnnestus!',
        lable_new_charity: 'Uus Heategevus',
        REGISTER: 'Registreeri',
        REG_PAGE_LOADED: 'Registratsiooni leht laetud!',
        CREATE_USER: 'Loo kasutaja',
        USERNAME: 'Kasutajanimi',
        CANCEL:'Loobu',
        EMAIL: 'E-mail',
        PASSWORD: 'Salasõna',
        CONF_PASSWORD: 'Kinnita salasõna',
        CREATE_NEW_DONATION: 'Loo uus annetus',
        CHOOSE_PICTURE: 'Vali pilt',
        CHANGE_PICTURE: 'Muuda pilt',
        LABLE_TITLE: 'Pealkiri',
        DESCRIPTION: 'Kirjeldus',
        ENDED: 'Lõppenud',
        NAME: 'Nimi',
        ADDRESS: 'Aadress',
        ADD: 'Lisa',
        MANAGE_PAGE_TITLE: 'Administraatori leht',
        MANAGE_PAGE_LOADED: 'Administraatori leht laetud!',
        TITLE_CHANGE_PASSWORD: 'Muuda salasõna',
        LABEL_CURRENT_PASSWORD: 'Praegune salasõna',
        LABEL_NEW_PASSWORD: 'Uus salasõna',
        LABEL_CONFIRM_NEW_PASSWORD: 'Kinnita uus salasõna',
        CONFIRM: 'Kinnita',
        USER_PAGE_TITLE: 'See on kasutaja leht',
        PRODUCT_ADDED: 'Ese lisatud!',
        USER_SETTINGS_PAGE_TITLE: 'Kasutaja sätete leht',
        NOTIFY_PASSWORD_UPDATED: 'Salasõna uuendatud!',
        BID: 'Paku',
        BIDDERS: 'Pakkujad',
        BID_VALUE: 'Pakkumise väärtus',
        BID_ADDED: 'Pakkumine lisatud!',
        LABEL_CHOOSE_DONATION: 'Vali annetus',
        LIST: 'Nimekiri',
        LABEL_YOUR_BID: 'Sinu pakkumine',
        MINIMUM_DONATION: 'Minimaalne annetus',
        VALID_FOR_BID: 'Pakkumine kehtib',
        UPRODUCTS: 'Lisa uus',
        SETTINGS: 'Seaded',
        ADMIN: 'Admin',
        LOGOFF: 'Logi välja',
        LOGIN: 'Logi sisse',
        TITLE_TO_LONG: ' on liiga pikk',
        TITLE_TO_SHORT: ' on liiga lühike',
        PHONE_NUMBER:'Telefoni number'

    });
    $translateProvider.useSanitizeValueStrategy(null);
    $translateProvider.preferredLanguage('en');

});
