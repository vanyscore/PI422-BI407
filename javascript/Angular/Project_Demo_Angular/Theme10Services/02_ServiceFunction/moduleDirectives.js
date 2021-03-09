// создаём Модуль с Директивами
angular.module("moduleDirectives", []).directive("buttonsLogic", 
    function(debugService, errorService) {
    // scope - область видимости, 
    // htmlElement - html тэг к кот привязана директива
    // elAttributes - атрибуты html эл-та
    return {
        // привязка к счётчику (задаётся в атрибуте)
        scope: { counter: "=counter" },
        link: function(scope, htmlElement, elAttributes){
            // на событие клик - выполняем логику

            if (scope.counter % 2 == 0) {
                debugService.log("click " + scope.counter)
            } else {
                errorService.log("click " + scope.counter)
            }

            htmlElement.on("click", function(event){
                debugService.log("click " + scope.counter)
                scope.$apply(function(){
                    scope.counter++;
                })
            })
        }
    }
});