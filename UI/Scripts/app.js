var app = angular.module('main', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/',{
        templateUrl: 'PatientAccount.html',
        controller: 'LoginCtrl'
    }).when('/login', {
        templateUrl: 'Login.html',
        controller: 'LoginCtrl'
    }).otherwise({
        redirectTo: '/'
    });
}]);


app.controller('LoginCtrl', function ($scope) {

    $scope.message = 'This is Add new order screen';

});