var module = angular.module("moduleService", [])

var baseLogService = function() {
    this.log = function(obj) {
        console.log("Type: " + this.msgType + " Log:" + obj)
    }
}

// Потомки
var debugLogService = function() {}
debugLogService.prototype = new baseLogService()
debugLogService.prototype.msgType = "DEBUG"

var errorLogService = function() {}
errorLogService.prototype = new baseLogService()
errorLogService.prototype.msgType = "ERROR"

// Прикрепляем объекты как сервисы
module.service("debugService", debugLogService)
module.service("errorService", errorLogService)