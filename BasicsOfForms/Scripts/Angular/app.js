var app = angular.module("demoApp", []);

app.controller("FormController", function($scope) {

    $scope.formSubmit = function (event) {
        

        //var form = $("myForm").serialize();
        console.log("works");
        event.PreventDefault();
    }
});