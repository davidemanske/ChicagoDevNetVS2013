angular.module("app", []);

(function () {
    'use strict';

    // Controller name is handy for logging
    var controllerId = 'democontroller';

    // Define the controller on the module.
    // Inject the dependencies. 
    // Point to the controller definition function.
    angular.module('app').controller(controllerId,
        ['$scope', democontroller]);

    function democontroller($scope) {
        // Bindable properties and functions are placed on vm.
        $scope.title = 'democontroller';
        $scope.activate = activate;

        function activate() {
        }

        //#region Internal Methods        

        //#endregion
    }
})();
