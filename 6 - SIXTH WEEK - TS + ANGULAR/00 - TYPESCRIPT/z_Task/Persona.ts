import Transazione from "./Transazione";
import Oggetto from "./Oggetto";

// Creare un sistema di gestione baratto.

// Vogliamo creare un sistema di gestione transazioni sotto forma di baratto. 
// L'oggetto della transazione è un semplice oggetto caratterizzato da: 
// Codice, Nome la descrizione e il proprietario attuale.

// Una transazione di vendita deve essere caratterizzata da un codice ed una data. 

// La transazione viene registrata solo a fronte dell'accettazione di una proposta. 
// Una proposta è quindi caratterizzata da un oggetto proposto, un oggetto richiesto e lo stato della proposta 
// (che può essere in pending, accepted, rejected).

export default class Persona{
    private nome: string | undefined; //specifico undefined perchè all'inizio l'attributo non ha valore
    private cognome: string | undefined;

    constructor(nome: string, cognome: string){
        this.nome = nome;
        this.cognome = cognome;
    }

    scambia(){}
    
}