app.directive('ngQuestion', function () {
    return {
        restrict: 'E',
        scope: {
            question: '=question',
            model: '=model',
            prop: '=prop'
        },
        link: function (scope, element, attrs) {
            scope.addAnswer = function (prop, id, $event) {
                var checkbox = $event.target;
                if (!scope.model[prop])
                    scope.model[prop] = []
                if (checkbox.checked)
                    scope.model[prop].push(id);
                else {
                    for (var i in scope.model[prop]) {
                        if (scope.model[prop][i] == id) {
                            scope.model[prop].splice(i, 1);
                        }
                    }
                }
            }
            scope.onChecked = function (prop, index) {
                if (scope.model[prop])
                    for (var i in scope.model[prop]) {
                        if (scope.model[prop][i] == index)
                            return true;
                    }
                return false;
            }
            scope.isRequired = function (prop) {
                if (!scope.question.required)
                    return false;
                if (!scope.model[prop])
                    return false;
                else
                    if (scope.model[prop].length == 0)
                        return true;
                return false;
            }
        },
        template: '<h4> {{question.Question}} <span style="color:red">*</span></h4>' +
                  ' <ul class="collection">' +
                    '<li ng-repeat="item in question.answers" class="collection-item">' +
                      '<input type="checkbox" class="filled-in" id="{{prop}}CheckBox{{item.id}}" ng-click="addAnswer(prop, item.id, $event)" ng-checked="onChecked(prop, item.id)"/>' +
                      '<label for="{{prop}}CheckBox{{item.id}}">{{item.answer}}</label>' +
                    '</li>' +
                  '</ul>' +
                  '<div ng-show="isRequired(prop)" style="color:red">' +
                       'This is a required question' +
                  '</div>',
    }
});