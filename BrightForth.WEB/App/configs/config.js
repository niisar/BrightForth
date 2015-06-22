app.config(function ($modalProvider) {
    angular.extend($modalProvider.defaults, {
        animation: 'am-fade-and-scale',
        keyboard: true
    });
})
app.config(['cfpLoadingBarProvider', function (cfpLoadingBarProvider) {
    cfpLoadingBarProvider.includeBar = true;
    cfpLoadingBarProvider.includeSpinner = false
    cfpLoadingBarProvider.latencyThreshold = 100;
}]);
app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when("/", {
        redirectTo: '/hr/employees'
    });

  
    $routeProvider.when("/common/login", {
        templateUrl: "/common/login",
        controller: "common.login",
        title: 'Login'
    });

    $routeProvider.when("/hr/employees", {
        templateUrl: "/hr/employees",
        controller: "hr.employeesList",
        title: 'Employees'
    });

    $routeProvider.when("/error-404", {
        templateUrl: "/common/Error-404",
        controller: "taskCtrl",
        title: 'Error 404'
    });

 

    $routeProvider.otherwise({
        redirectTo: '/common/Error-404'
    });
}]);


app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});

var serviceBase = "http://localhost:58519/";
app.constant(['ngAuthSettings', function (authService) {
    apiServiceBaseUri: serviceBase
}]);

