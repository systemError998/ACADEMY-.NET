class Automobile {
    
    marca;
    modello;
    
    //Posso avere un solo costruttore 
    constructor(marca, modello){
        this.marca = marca,
        this.modello = modello
    }

    stampaDettaglio(){
        console.log("Automobile" + " " + this.marca + " " + this.modello); 
    }
}

let auto1 = new Automobile();
auto1.marca = "ford";
auto1.modello = "focus";

auto1.stampaDettaglio();