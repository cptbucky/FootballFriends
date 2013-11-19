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
    .factory('NavigationService', function () {
        var options = [];
        var backButton = false;
        
        return {
            options: function () { return options; },
            setOptions: function(newOptions) {
                options = newOptions;
            },
            backButton: function () { return backButton; },
            setBackButton: function (newValue) { backButton = newValue; }
        };
    })
    .factory('FixturesService', function () {

        //var fixtureBase = function() {
        //    return {
        //        getOpposition: function () {
        //            return this.homeTeam === 'Arsenal' ? this.awayTeam : this.homeTeam;
        //        },
        //        selected: false
        //    };
        //};
        
        //var fixture

        var selectedFixture = null;
        
        return {
            setSelectedFixture: function (newFixture) { selectedFixture = newFixture; },
            selectedFixture: function () { return selectedFixture; },
            fixtures: [{
                    month: 'January',
                    fixtures: [{
                            date: '04/01/2014',
                            homeTeam: 'Arsenal',
                            awayTeam: 'Sunderland',
                            location: 'The Emirates',
                            selected: false
                        }, {
                            date: '11/01/2014',
                            homeTeam: 'Arsenal',
                            location: 'The Emirates',
                            awayTeam: 'Newcastle United',
                            selected: false
                        }, {
                            date: '18/01/2014',
                            homeTeam: 'Sunderland',
                            location: 'Stadium of Light',
                            awayTeam: 'Arsenal',
                            selected: false
                        }, {
                            date: '25/01/2014',
                            homeTeam: 'Arsenal',
                            location: 'The Emirates',
                            awayTeam: 'Tottenham',
                            selected: false
                        }]
                }, {
                    month: 'February',
                    fixtures: [{
                            date: '01/02/2014',
                            homeTeam: 'Man City',
                            location: 'City of Manchester Stadium',
                            awayTeam: 'Arsenal',
                            selected: false
                        }, {
                            date: '08/02/2014',
                            homeTeam: 'Chelsea',
                            location: 'Stamford Bridge',
                            awayTeam: 'Arsenal',
                            selected: false
                        }, {
                            date: '15/02/2014',
                            homeTeam: 'Arsenal',
                            location: 'The Emirates',
                            awayTeam: 'Liverpool',
                            selected: false
                        }, {
                            date: '22/02/2014',
                            homeTeam: 'Arsenal',
                            location: 'The Emirates',
                            awayTeam: 'Liverpool',
                            selected: false
                        }]
                }, {
                    month: 'March',
                    fixtures: [{
                            date: '01/03/2014',
                            homeTeam: 'Man City',
                            location: 'City of Manchester Stadium',
                            awayTeam: 'Arsenal',
                            selected: false
                        }, {
                            date: '08/03/2014',
                            homeTeam: 'Chelsea',
                            location: 'Stamford Bridge',
                            awayTeam: 'Arsenal',
                            selected: false
                        }, {
                            date: '15/03/2014',
                            homeTeam: 'Arsenal',
                            location: 'The Emirates',
                            awayTeam: 'Liverpool',
                            selected: false
                        }, {
                            date: '22/03/2014',
                            homeTeam: 'Arsenal',
                            location: 'The Emirates',
                            awayTeam: 'Liverpool',
                            selected: false
                        }, {
                            date: '29/03/2014',
                            homeTeam: 'Hull City',
                            location: 'KC Stadium',
                            awayTeam: 'Arsenal',
                            selected: false
                        }]
                }]
        };
    })
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
