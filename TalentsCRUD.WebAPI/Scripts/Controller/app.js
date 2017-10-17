var app = angular.module('myApp', ["ngRoute"]).run(function ($rootScope) {
    $rootScope.loading = true;
});