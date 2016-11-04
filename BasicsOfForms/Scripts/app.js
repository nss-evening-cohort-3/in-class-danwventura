var app = angular.module("formBasics", []);

app.controller("FormController", function ($scope) {

    $scope.formSubmit = function () {
        alert("FormCtrl loaded");
       
    }
})