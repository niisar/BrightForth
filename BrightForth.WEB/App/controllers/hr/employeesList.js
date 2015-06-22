app.controller('hr.employeesList',
    function ($scope, $modal, $animate, ngCrud, $http, ngDialog, myResource, $timeout, authService) {
        var serviceBase = "http://localhost:58519/";
        $scope.templates =
            [{ name: 'Employee', url: '/hr/employeesList' },
             { name: 'Add New Employee', url: '/hr/addEmployee' }];
        $scope.template = $scope.templates[0];

        $scope.myData = {};
        $http.get(serviceBase + 'api/employee').then(function (results) {
            $scope.myData = results.data;
        });

        $scope.logOut = function () {
            authService.logOut();
            location.href = '/common/login';
        }
    }
);

