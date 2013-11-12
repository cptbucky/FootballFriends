'use strict';

var jfg = angular.module('jfg', ['ngResource', 'directive.g+signin', 'jfg.services', 'jfg.directives']); //'jfg.filters', 

jfg.config(function ($routeProvider) {

    $routeProvider.
        when('/login', { templateUrl: 'app/partials/login.html', controller: 'loginController' }).
        when('/squad', { templateUrl: 'app/partials/squad.html', controller: 'squadController' }).
        when('/match', { templateUrl: 'app/partials/match.html', controller: 'matchController' }).
        when('/fixtures', { templateUrl: 'app/partials/fixtures.html', controller: 'fixturesController' }).
        otherwise({ redirectTo: '/squad' });
        //otherwise({ redirectTo: '/login' });
});