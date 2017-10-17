app.directive('ngRate', function () {
    return {
        restrict: 'E',
        scope: {
            obj: "=obj"
        },
        link: function (scope, element, attrs) {


        },

        template: '<div class="row">' +
                 '<div class="col s12 col-xs-12 col-sm-12 col-lg-12">' +
                    '<h5>{{obj.title}} <span style="color:red" ng-show="obj.isRequired" >*<span></h5>' +
                '</div>' +
                '<div class="col s3 col-xs-3 col-sm-3 col-lg-3">' +
                    'Nao conheco / I don\'t know' +
                '</div>' +
                '<div class="col s1 col-xs-1 col-sm-1 col-lg-1">' +
                    '<input class="with-gap" name="{{obj.id}}Group" type="radio" ng-model="obj.model.Rate" id="{{obj.id}}Rate0" value="0" ng-required="obj.isRequired"/>' +
                    '<label for="{{obj.id}}Rate0">0</label>' +
                '</div>' +
                '<div class="col s1 col-xs-1 col-sm-1 col-lg-1">' +
                    '<input class="with-gap" name="{{obj.id}}Group" type="radio" ng-model="obj.model.Rate" id="{{obj.id}}Rate1" value="1" ng-required="obj.isRequired"//>' +
                    '<label for="{{obj.id}}Rate1">1</label>' +
                '</div>' +
                '<div class="col s1 col-xs-1 col-sm-1 col-lg-1">' +
                    '<input class="with-gap" name="{{obj.id}}Group" type="radio" ng-model="obj.model.Rate" id="{{obj.id}}Rate2" value="2" ng-required="obj.isRequired"//>' +
                    '<label for="{{obj.id}}Rate2">2</label>' +
                '</div>' +
                '<div class="col s1 col-xs-1 col-sm-1 col-lg-1">' +
                    '<input class="with-gap" name="{{obj.id}}Group" type="radio" ng-model="obj.model.Rate" id="{{obj.id}}Rate3" value="3" ng-required="obj.isRequired"//>' +
                    '<label for="{{obj.id}}Rate3">3</label>' +
                '</div>' +
                '<div class="col s1 col-xs-1 col-sm-1 col-lg-1">' +
                    '<input class="with-gap" name="{{obj.id}}Group" type="radio" ng-model="obj.model.Rate" id="{{obj.id}}Rate4" value="4" ng-required="obj.isRequired"//>' +
                    '<label for="{{obj.id}}Rate4">4</label>' +
                '</div>' +
                '<div class="col s1 col-xs-1 col-sm-1 col-lg-1">' +
                    '<input class="with-gap" name="{{obj.id}}Group" type="radio" ng-model="obj.model.Rate" id="{{obj.id}}Rate5" value="5" ng-required="obj.isRequired"//>' +
                    '<label for="{{obj.id}}Rate5">5</label>' +
                '</div>' +
                '<div class="col s3 col-xs-3 col-sm-3 col-lg-3">' +
                    'Senior' +
                '</div>' +
            '</div>',
    }
});

