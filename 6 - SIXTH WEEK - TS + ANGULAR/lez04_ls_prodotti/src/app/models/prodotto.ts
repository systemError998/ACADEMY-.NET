export class Prodotto {
    codi: string | undefined;
    nome: string | undefined;
    desc: string | undefined;
    quan: number | undefined;
    prez: number | undefined;

    constructor(){}

    StampaDettaglio(){
        console.log(this.codi, this.nome, this.desc, this.quan, this.quan);
    }
    

}
