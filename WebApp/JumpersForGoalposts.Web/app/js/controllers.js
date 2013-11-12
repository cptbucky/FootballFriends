'use strict';
/* App Controllers */

jfg.controller('loginController', ['$scope', '$location', 'AuthenticationModel', function loginController($scope, $location, authModel) {
    $scope.message = 'login screen';

    $scope.$on("signinCallback", function (event, authResult) {
        $location.path('/fixtures');
        $scope.$apply();
    });
}]);

jfg.controller('squadController', ['$scope', 'squadService', function squadController($scope, squadService) {
    var setData = function (data) {
        $scope.squadMembers = data;
    };

    squadService.get(setData);
}]);

jfg.controller('matchController', ['$scope', function matchController($scope) {
    $scope.team = [[{
        name: 'player 1',
        position: 'GK',
        widthClass: 'col-xs-12'
    }], [{
        name: 'player 2',
        position: 'LB',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 3',
        position: 'CB',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 4',
        position: 'CB',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 5',
        position: 'RB',
        widthClass: 'col-xs-3'
    }], [
    ], [{
        name: 'player 6',
        position: 'LM',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 7',
        position: 'CM',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 8',
        position: 'CM',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 9',
        position: 'RM',
        widthClass: 'col-xs-3'
    }], [
    ], [{
        name: 'player 10',
        position: 'CF',
        widthClass: 'col-xs-offset-3 col-xs-3'
    }, {
        name: 'player 11',
        position: 'CF',
        widthClass: 'col-xs-3'
    }]];
    
    $scope.subs = [{
        name: 'player 12',
        position: 'LB',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 13',
        position: 'CB',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 14',
        position: 'CB',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 15',
        position: 'RB',
        widthClass: 'col-xs-3'
    }];
    
    $scope.standbys = [{
        name: 'player 6',
        position: 'LM',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 7',
        position: 'CM',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 8',
        position: 'CM',
        widthClass: 'col-xs-3'
    }, {
        name: 'player 9',
        position: 'RM',
        widthClass: 'col-xs-3'
    }];
}]);

jfg.controller('fixturesController', ['$scope', function fixturesController($scope) {
    $scope.fixturesByDate = [{
            date: '01/01/2014',
            fixtures: [{
                    homeTeam: 'Arsenal',
                    awayTeam: 'Sunderland',
                    selected: false
                }, {
                    homeTeam: 'Man City',
                    awayTeam: 'Newcastle United',
                    selected: false
                }, {
                    homeTeam: 'Chelsea',
                    awayTeam: 'Tottenham',
                    selected: false
                }, {
                    homeTeam: 'Aston Villa',
                    awayTeam: 'Liverpool',
                    selected: false
                }]
        }, {
            date: '07/01/2014',
            fixtures: [{
                    homeTeam: 'Arsenal',
                    awayTeam: 'Liverpool',
                    selected: false
                }, {
                    homeTeam: 'Man City',
                    awayTeam: 'Aston Villa',
                    selected: false
                }, {
                    homeTeam: 'Sunderland',
                    awayTeam: 'Tottenham',
                    selected: false
                }, {
                    homeTeam: 'Chelsea',
                    awayTeam: 'Sunderland',
                    selected: false
                }]
        }];

    $scope.select = function(item) {
        for (var i = 0; i < $scope.fixturesByDate.length; i++) {
            for (var j = 0; j < $scope.fixturesByDate[i].fixtures.length; j++) {
                $scope.fixturesByDate[i].fixtures[j].selected = ($scope.fixturesByDate[i].fixtures[j].homeTeam === item.homeTeam && $scope.fixturesByDate[i].fixtures[j].awayTeam === item.awayTeam);
            }
        }
    };
}]);

jfg.controller('navController', ['$scope', '$location', function navController($scope, lo) {
    $scope.routeIs = function (routeName) {
        return lo.path() === routeName;
    };
   
    $scope.visible = function () {
        return lo.path() !== 'login';
    };
    
    $scope.dropdown = [
		{ text: 'Another action', href: '#anotherAction' },
		{ text: 'Something else here', click: "$alert('working ngClick!')" },
		{ divider: true },
		{
		    text: 'Separated link', href: '#',
		    submenu: [
				{ text: 'Second level link', href: '#' },
				{ text: 'Second level link 2', href: '#' }
		    ]
		}
    ];

    $scope.alert = function(msg) { alert(msg) };
}]);