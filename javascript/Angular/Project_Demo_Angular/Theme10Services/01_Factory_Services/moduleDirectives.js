// создаём Модуль с Директивами
angular.module("moduleDirectives", []).directive("buttonsLogic", function(logService){
    // scope - область видимости, 
    // htmlElement - html тэг к кот привязана директива
    // elAttributes - атрибуты html эл-та
    return {
        // привязка к счётчику (задаётся в атрибуте)
        scope: { counter: "=counter" },
        link: function(scope, htmlElement, elAttributes){
            // на событие клик - выполняем логику
            htmlElement.on("click", function(event){
                logService.log("click " + scope.counter)
                scope.$apply(function(){
                    scope.counter++;
                })
            })
        }
    }
});