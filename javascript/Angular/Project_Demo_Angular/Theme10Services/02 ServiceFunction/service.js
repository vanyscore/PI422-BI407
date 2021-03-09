var module1 = angular.module("moduleService", []);
// через функцию сервис

// "базовый класс" для логирования
var baseLogService = function(){
    this.log = function(obj){
        console.log("Type:"+this.msgType+" Log:"+obj);
    }
}
// потомки
var debugLogService = function(){}
debugLogService.prototype = new baseLogService();
debugLogService.prototype.msgType = "DEBUG";

var errorLogService = function(){}
errorLogService.prototype = new baseLogService();
errorLogService.prototype.msgType = "ERROR";

// регистрируем объекты как сервисы
module1
.service("debugService", debugLogService)
.service("errorService", errorLogService)