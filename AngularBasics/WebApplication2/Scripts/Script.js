/// <reference path="c:\users\saurabh.khare\documents\visual studio 2015\Projects\AngularBasics\WebApplication2\angular/angular.js" />

var myMod = angular.module("FilterSample1Module", []).controller("FilterSampleCtrl", function ($scope) {
    var persons = [
        { name: "Ben", dateOfBirth: new Date("November 23 1980"), gender: "Male", salary: "55000.788" },
        { name: "Sara", dateOfBirth: new Date("November 16 1984"), gender: "Female", salary: "65000" },
        { name: "Mark", dateOfBirth: new Date("December 09 1986"), gender: "Male", salary: "75000" },
        { name: "Ranjan", dateOfBirth: new Date("January 11 1985"), gender: "Male", salary: "55000.111" }
    ];
    $scope.persons = persons;

});