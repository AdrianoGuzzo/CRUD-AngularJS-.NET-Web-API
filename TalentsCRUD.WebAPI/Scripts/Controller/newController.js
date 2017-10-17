app.controller('newCtrl', function ($scope, $http, $location, $routeParams, $rootScope, $window, question, rate, initForm, base) {
    $rootScope.loading = false;
    initForm.init($scope, rate.Rates, question.Questions, $window);

    $scope.steps = [{ isStep: true, id: 'step1' }, { isStep: false, id: 'step2' }, { isStep: false, id: 'step3' }, { isStep: false, id: 'step4' }];

    $scope.submitStep4 = function (talent) {
        $http.post('/api/saveTalent', talent).then(function (result) {
            base.returnRequest(result, function (Status, Data) {
                if (Status)
                    $location.path('/');
            });
        });
    };

    angular.element(document).ready(function () {
        setTimeout(function () {
            Materialize.updateTextFields();
        }, 100);
    });
});