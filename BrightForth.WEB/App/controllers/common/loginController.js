app.controller('common.login',
    function ($scope, $modal, $animate, $location, $http, ngDialog, $timeout, authService) {

        $scope.loginData = {
            userName: "",
            password: ""
        };

 

        $scope.message = "";

        $scope.login = function () {
            authService.login($scope.loginData).then(function (response) {
                location.href = '/common/index';
            },
         function (err) {
             $scope.message = err.error_description;
         });
        };
    }
);