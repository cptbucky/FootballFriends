'use strict';


angular.module('jfg.services', ['ngResource'])
    .factory('squadService', ['$http', function ($http) {
        return {
            get: function (callback) {
                callback([{
                    name: 'player 1',
                    position: 'GK'
                }, {
                    name: 'player 2',
                    position: 'RB'
                }, {
                    name: 'player 3',
                    position: 'LB'
                }, {
                    name: 'player 4',
                    position: 'CB'
                }, {
                    name: 'player 5',
                    position: 'CB'
                }, {
                    name: 'player 6',
                    position: 'RM'
                }, {
                    name: 'player 7',
                    position: 'LM'
                }, {
                    name: 'player 8',
                    position: 'CM'
                }, {
                    name: 'player 9',
                    position: 'CM'
                }, {
                    name: 'player 10',
                    position: 'CF'
                }, {
                    name: 'player 11',
                    position: 'CF'
                }, {
                    name: 'player 12',
                    position: 'GK'
                }, {
                    name: 'player 13',
                    position: 'LB'
                }, {
                    name: 'player 14',
                    position: 'CB'
                }, {
                    name: 'player 15',
                    position: 'RM'
                }, {
                    name: 'player 16',
                    position: 'CF'
                }, {
                    name: 'player 17',
                    position: 'CM'
                }]);
            }
        };
    }])
    .factory('AuthenticationModel', [function () {
        var authenticationModel = {
            source: null,
            authId: null,
            isLoggedIn: false,
            username: '',
            thumbnail: null
            //authenticationToken: {}
        };
        return authenticationModel;
    }])
    //.factory('userService', ['$resource', function ($resource) {
    //    return $resource('/UserService/User/:id',
    //            { id: '@id' },
    //            {
    //                list: { method: 'GET', isArray: true }, //same as query
    //                create: { method: 'POST' }, // same as save
    //                update: { method: 'PUT' }
    //                // DEFAULT IMPLEMENTATION OF $RESOURCE
    //                //   'get':    {method:'GET'},
    //                //   'save':   {method:'POST'},
    //                //   'query':  {method:'GET', isArray:true},
    //                //   'remove': {method:'DELETE'},
    //                //   'delete': {method:'DELETE'}
    //            });
    //}])
    ;
