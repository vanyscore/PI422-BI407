angular
.module("moduleService", [])
.factory("logService", function() {
    return {
        log: function(text) {
            console.log(text);
        }
    }
})