// создаем контроллер/ы в гданом модуле
angular.module("mainApp").controller("mainController", function($scope) {
    $scope.message = "Демо разделение js-приложения по МОДУЛЯМ";

    $scope.buttons = {
        titles: ["Button 1", "Button2", "Buttons 3"],
        totalClicks: 0
    };
});