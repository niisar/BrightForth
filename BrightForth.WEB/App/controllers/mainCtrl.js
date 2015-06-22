app.controller('mainCtrl',
    function ($scope, $modal, $animate, ngCrud, $http, ngDialog, myResource, $timeout, authService) {
        $scope.OperType = 0;
        $scope.userId = "df9aaf79-d365-4119-8b26-2ae9ceca4e71";
        $('#page-wrapper').removeClass('nav-small');


        $scope.logOut = function () {
            authService.logOut();
            location.href = '/common/login';
        }
    }

);

//app.controller('taskCtrl',
//    function ($scope, $modal, $animate, $q, ngCrud, myResource, ngDialog, $timeout) {
//        $scope.selectedIndex = -1;
//        $scope.userId = "df9aaf79-d365-4119-8b26-2ae9ceca4e71";
        
//        $('#page-wrapper').removeClass('nav-small');

//        $scope.logOut = function () {
//            authService.logOut();
//            location.href = '/common/login';
//        }

//    }
//);
