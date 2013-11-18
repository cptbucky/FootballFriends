<!DOCTYPE html>

<html lang="en" ng-app="jfg">
<head>
    <title></title>

    <meta name="viewport" content="user-scalable=no,width=device-width" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <%--<link href="Content/bootstrap-united.css" rel="stylesheet" />--%>
    <link href="app/content/app.css" rel="stylesheet" />
    <link href="app/content/android.css" rel="stylesheet" />
    <link href="app/content/matchDay1.css" rel="stylesheet" />

    <script src="Scripts/angular.min.js"></script>
    <script src="Scripts/angular-resource.min.js"></script>
    <%--<script src="Scripts/hello.js"></script>--%>
    <script src="Scripts/i18n/angular-locale_en-gb.js"></script>
    <script src="Scripts/google-plus-signin.js"></script>
    <script src="//mgcrea.github.com/angular-strap/js/angular-strap.js"></script>

    <script src="app/js/app.js"></script>
    <script src="app/js/controllers.js"></script>
    <script src="app/js/services.js"></script>
    <script src="app/js/directives.js"></script>
    <script src="app/js/filters.js"></script>

    <script type="text/javascript">
        (function () {
            var po = document.createElement('script');
            po.type = 'text/javascript';
            po.async = true;
            po.src = 'https://apis.google.com/js/client:plusone.js';
            var s = document.getElementsByTagName('script')[0];
            s.parentNode.insertBefore(po, s);
        })();

        function signinCallback(authResult) {
            console.log(authResult);

            if (authResult['access_token']) {
                var rscope = angular.element(document).scope();
                rscope.$apply(rscope.$broadcast('signinCallback', authResult));
            }
        }
    </script>
</head>
<body>
    <div class="container">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand">Jumpers for Goalposts</a>
                </div>
                <%--  <div class="collapse navbar-collapse pull-right">
                    <ul class="nav navbar-nav">
                        <li class="glyphicon glyphicon-align-justify"></li>
                    </ul>
                </div>--%>
                <button type="button" class="btn pull-right navButton" bs-dropdown="dropdown">...</button>
            </div>
        </div>
        <ng-view></ng-view>
        <div class="navbar navbar-inverse navbar-fixed-bottom" ng-controller="navController">
            <ul class="nav navbar-nav nav-justified">
                <li ng-class="{active: routeIs('/fixtures')}">
                    <a href="#/fixtures">Fixtures</a>
                </li>
                <li ng-class="{active: routeIs('/squad')}">
                    <a href="#/squad">Squad</a>
                </li>
                <li ng-class="{active: routeIs('/match')}">
                    <a href="#/match">Match</a>
                </li>
            </ul>
        </div>
    </div>
</body>
</html>
