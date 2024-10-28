export class Videoteca {

    cod: string | undefined;
    nom: string | undefined;
    ind: string | undefined;

    StampaDettaglioVideoteca() : void {
        console.log(this.cod, this.nom, this.ind);
    }
}
