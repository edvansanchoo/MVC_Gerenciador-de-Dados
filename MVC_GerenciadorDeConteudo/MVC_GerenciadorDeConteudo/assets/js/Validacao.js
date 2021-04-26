

var ValidaExclusao = function (id, event) {
    if (confirm("Confirma Exclusão?")) {
        return true
    } else {
        event.preventDefault();
        return false;
    }
}