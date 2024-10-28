import Persona from "./Persona";

export default class Oggetto{
    private codice: string | undefined;
    private nome: string | undefined; //specifico undefined perchè all'inizio l'attributo non ha valore
    private descrizione: string | undefined;
    private proprietario: Persona | undefined;

    constructor(codice: string, nome: string, descrizione: string, proprietario: Persona){
        this.codice = codice;
        this.nome = nome;
        this.descrizione = descrizione;
        this.proprietario = proprietario
    }

}