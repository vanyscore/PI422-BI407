var module1 = angular.module("moduleService", []);
// на js - синглтон (через фабричную функцию)
module1.factory("logService", function(){
    return {
        log: function(text){
            console.log(text);
        }
    }
});