export default class Rivista{
    private codice: string | undefined;
    private titolo: string | undefined;

    //mettendo i valori nullable è come se avessimo diversi costruttori (overload dei metodi)
    constructor(codice?: string, titolo?: string){
        this.codice = codice,
        this.titolo = titolo
    }

    public stampaDettaglio(): void {
        console.log("Rivista: " + this.codice + " " + this.titolo);
    }
}

