app.controller('editCtrl', function ($scope, $http, $location, $routeParams, $rootScope, $window, base, question, rate, initForm, base) {
    $rootScope.loading = true;
    initForm.init($scope, null, question.Questions, $window);
    $scope.steps = [{ isStep: false, id: 'step1' }, { isStep: false, id: 'step2' }, { isStep: false, id: 'step3' }, { isStep: false, id: 'step4' }];
   
    $http.get('/api/editTalent/' + $routeParams.id).then(function (result) {
        $rootScope.loading = false;
        base.returnRequest(result, function (Status, Data) {
            if (Status) {
                $scope.steps[0].isStep = true;
                $scope.talent = Data;
                $scope.rates = rate.Rates($scope)     
            }
        });
    });

    $scope.submitStep4 = function (talent) {
        $http.post('/api/updateTalent', talent).then(function (result) {
            base.returnRequest(result, function (Status, Data) {
                if (Status)
                    $location.path('/');
            });
        });
    };

    angular.element(document).ready(function () {
        Materialize.updateTextFields();
    });
});