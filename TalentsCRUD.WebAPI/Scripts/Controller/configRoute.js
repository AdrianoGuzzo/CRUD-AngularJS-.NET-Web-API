app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "View/home.html"
        }).when("/New", {
            templateUrl: "View/new.html"
        }).when("/Edit/:id", {
            templateUrl: "View/edit.html"
        });

});