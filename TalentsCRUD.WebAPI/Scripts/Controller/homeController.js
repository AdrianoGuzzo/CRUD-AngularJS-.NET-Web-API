app.controller('homeCtrl', function ($scope, $http, $location, $routeParams, $rootScope, base) {
    $rootScope.loading = true;
    $scope.list = [];
    $http.get('/api/listTalent').then(function (result) {
        base.returnRequest(result, function (Status, Data) {
            $rootScope.loading = false;
            $scope.list = Data;
        });
    });
    $scope.edit = function (Id) {
        $location.path('/Edit/' + Id);

    };
    $scope.delete = function (talent) {
        $http.get('/api/deleteTalent/' + talent.Id).then(function (result) {
            base.returnRequest(result, function (Status, Data) {
                if (Status) {
                    var index = $scope.list.indexOf(talent);
                    $scope.list.splice(index, 1);
                }
            });
        });
    };

});