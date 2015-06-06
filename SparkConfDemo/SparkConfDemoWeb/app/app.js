﻿(function () {
    
    var MainController = function ($scope, $resource, $window) {

        var processSignUp = function (newCustomer) {

            var customerService = $resource('http://localhost:41364/api/customers', {}, {
                query: { method: 'GET', isArray: false },
                save: { method: 'POST', isArray: false }
            });

            customerService.save(newCustomer).$promise.then(function() {
                $window.location.href = 'views/success.html';
            });
        };

        var newCustomer = { firstName: '', lastName: '', email: '', phone: '' };

        $scope.newCustomer = newCustomer;
        $scope.processSignUp = processSignUp;

    };

    var app = angular.module('NewApp', ['ngResource']);
    app.controller('MainController', ['$scope', '$resource', '$window', MainController]);

}());