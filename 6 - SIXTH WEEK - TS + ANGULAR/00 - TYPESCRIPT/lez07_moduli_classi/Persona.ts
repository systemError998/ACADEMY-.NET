//quando l'oggetto da esportare è solo uno 
export default class Persona{
    private nome: string | undefined;
    private cognome: string | undefined; //specifico undefined perchè all'inizio l'attributo non ha valore

    constructor(nome: string, cognome: string){
        this.nome = nome;
        this.cognome = cognome;
    }

    
}
