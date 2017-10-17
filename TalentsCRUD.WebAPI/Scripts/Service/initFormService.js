app.service('initForm', function () {
    this.init = function (scope, rates, question, window) {
        scope.talent = {
            Bank: {}
        };
        scope.talent.Rates = [];
        if (rates)
            scope.rates = rates(scope);

        scope.Questions = question(scope);
        scope.isQuestionRequired = function () {
            var isInvalid = false;
            isInvalid = isQuestionRequired(scope.Questions.QuestionWillingness, scope)
            isInvalid = isQuestionRequired(scope.Questions.QuestionBestTime, scope)
            return isInvalid;
        }
        scope.submitStep1 = function () {
            changeStep(2, scope);
        };
        scope.backStep1 = function () {
            changeStep(1, scope);
        };
        scope.submitStep2 = function () {
            changeStep(3, scope);
        };
        scope.backStep2 = function () {
            changeStep(2, scope);
        };
        scope.submitStep3 = function () {
            changeStep(4, scope);
        };
        scope.backStep3 = function () {
            changeStep(3, scope);
        };
    };
    var changeStep = function (index, scope) {
        for (var i in scope.steps) {
            scope.steps[i].isStep = false;
        }
        scope.steps[index - 1].isStep = true;
        window.scrollTo(0, 0);
    }

    var isQuestionRequired = function (question, scope) {
        if (!scope.talent[question.prop])
            return true;
        else
            if (scope.talent[question.prop].length == 0)
                return true;
        return false;
    }
});