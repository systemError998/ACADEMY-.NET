var Automobi = /** @class */ (function () {
    function Automobi(varMarca, varModello) {
        this.marca = varMarca;
        this.modello = varModello;
    }
    Automobi.prototype.stampaDettaglio = function () {
        console.log("Automobile " + this.marca + " " + this.modello);
    };
    return Automobi;
}());
var autoUno = new Automobi("ford", "focus");
autoUno.stampaDettaglio();
