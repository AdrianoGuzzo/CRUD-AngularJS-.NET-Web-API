app.controller('homeCtrl', function ($scope, $http, $location, $routeParams, $rootScope, base) {

    $rootScope.loading = true;
    $scope.list = [];
    $scope.talentView = {};
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
    $scope.view = function (talent) {
        $http.get('/api/viewTalent/' + talent.Id).then(function (result) {
            base.returnRequest(result, function (Status, Data) {
                $scope.talentView = Data;
                $('#modalView').modal();
                $('#modalView').modal('open');
            });
        });             
    };
    $scope.countRate = function (Rate) {
        var count =[];
        for (i = 0; i < Rate; i++) {
            count.push(i);
        }
        return count;
    }
    $(document).ready(function () {
        $('.tooltipped').tooltip({ delay: 50, position: 'top' });
    });

});