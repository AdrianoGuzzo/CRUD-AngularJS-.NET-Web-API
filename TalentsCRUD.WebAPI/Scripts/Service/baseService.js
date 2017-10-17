app.service('base', function () {
    this.returnRequest = function (result, callback) {
        if (result.data.Status)
            callback(true, result.data.Data)
        else {
            alert("Error!!! Olhe o console")
            for (var i in result.data.erros) {
                console.log(result.data.erros[i].message)
                console.log(result.data.erros[i].stackTrace)
            }
            callback(false)
        }
    };
});