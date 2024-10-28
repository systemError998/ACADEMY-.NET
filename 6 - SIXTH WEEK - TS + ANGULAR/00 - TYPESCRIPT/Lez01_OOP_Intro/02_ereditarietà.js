
class Automobile {

    //Posso non scrivere gli attributi, si occuperà il costruttore durante la sua creazione di creare anche gli attributi
    constructor(marca, modello){
        this.marca = marca,
        this.modello = modello
    }

    stampaDettaglio(){
        console.log("Automobile" + " " + this.marca + " " + this.modello); 
    }
}

class Elettrica extends Automobile{
    constructor(varMar, varMod, varAutonomia){
        super(varMar, varMod)
        this.autonomia = varAutonomia
    }

    stampaDettaglio(){
        console.log("Automobile" + " " + this.marca + " " + this.modello + " " + this.autonomia); 
    }
}