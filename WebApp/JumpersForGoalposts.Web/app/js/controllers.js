'use strict';
/* App Controllers */

jfg.controller('loginController', ['$scope', '$location', 'AuthenticationModel', function loginController($scope, $location, authModel) {
    $scope.message = 'login screen';

    $scope.$on("signinCallback", function (event, authResult) {
        $location.path('/fixtures');
        $scope.$apply();
    });
}]);

jfg.controller('squadController', ['$scope', '$location', 'NavigationService', 'squadService', function squadController($scope, $location, navigation, squadService) {
    function addSquadMember() {

    }

    navigation.setBackButton(false);
    navigation.setOptions([{ imgPath: 'Content/images/ic_5-content-new.png', action: addSquadMember }]);

    var setData = function (data) {
        $scope.squadMembers = data;
    };

    squadService.get(setData);
}]);

jfg.controller('matchController', ['$scope', '$location', 'NavigationService', function matchController($scope, $location, navigation) {
    navigation.setBackButton(false);
    navigation.setOptions([]);

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

jfg.controller('fixturesController', ['$scope', '$location', 'NavigationService', 'FixturesService', function fixturesController($scope, $location, navigation, fixtures) {
    function navigateToNewFixturePage() {
        fixtures.setSelectedFixture(null);
        
        $location.path('/newFixture');
    }

    navigation.setBackButton(false);
    navigation.setOptions([{ imgPath: 'Content/images/ic_5-content-new.png', action: navigateToNewFixturePage }]);

    $scope.fixturesByMonth = fixtures.fixtures;

    $scope.navToFixtureScreen = function() {
        $location.path('/newFixture');
    };

    $scope.select = function (item) {
        for (var i = 0; i < $scope.fixturesByMonth.length; i++) {
            for (var j = 0; j < $scope.fixturesByMonth[i].fixtures.length; j++) {
                var selected = ($scope.fixturesByMonth[i].fixtures[j].homeTeam === item.homeTeam && $scope.fixturesByMonth[i].fixtures[j].awayTeam === item.awayTeam);
                
                if (selected) {
                    fixtures.setSelectedFixture($scope.fixturesByMonth[i].fixtures[j]);
                }
                
                $scope.fixturesByMonth[i].fixtures[j].selected = selected;
            }
        }
    };

    $scope.getFixtureString = function(fixture) {
        var isHome = fixture.homeTeam === 'Arsenal'; //? fixture.awayTeam : fixture.homeTeam;

        return (isHome ? 'H: ' : 'A: ') + (isHome ? fixture.awayTeam : fixture.homeTeam); // + ' at ' + fixture.location;
    };
}]);

jfg.controller('newFixtureController', ['$scope', '$location', 'NavigationService', 'FixturesService', function newFixtureController($scope, lo, navigation, fixtures) {
    function addFixture() {
        lo.path('/fixtures');
    }
    
    navigation.setBackButton(true);
    navigation.setOptions([{ imgPath: 'Content/images/ic_1-navigation-accept.png', action: addFixture }]);

    if (fixtures.selectedFixture() === null) {
        $scope.fixture = {
            date: '',
            homeTeam: '',
            awayTeam: '',
            location: '',
            selected: false
        };
    } else {
        $scope.fixture = fixtures.selectedFixture();
    }

    $scope.places = [{
            name: 'Home'
        }, {
            name: 'Away'
        }];

    $scope.place = {
        name: 'Home'
    };
}]);

jfg.controller('navController', ['$scope', '$location', '$window', 'NavigationService', function navController($scope, lo, $window, navigation) {
    $scope.routeRelatesTo = function (routeName) {
        var currentPath = lo.path();
        
        if (routeName === '/fixtures' && (currentPath === '/fixtures' || currentPath === '/newFixture')) {
            return true;
        }
        
        return currentPath === routeName;
    };

    $scope.pageNav = {
        imgPath: 'Content/images/ic_1-navigation-previous-item.png',
        action: function() {
            $window.history.back();
        }
    };

    $scope.visible = function () {
        return lo.path() !== 'login';
    };

    $scope.navigation = navigation;

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

    $scope.alert = function (msg) { alert(msg) };
}]);