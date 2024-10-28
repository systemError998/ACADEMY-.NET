import { Injectable } from "@angular/core";
import { Prodotto } from "../src/app/models/prodotto";

@Injectable({
    providedIn: 'root' //In questo modo lo iniettiamo nel main, che in angular è app.component (selector app-root)
  })

export class ProdottoRepo{

    private elenco: Prodotto[] = [];

    //Inserisco tutto nel costruttore perchè è un'operazione che devo ripetere più volte.
    //Ogni volta che richiamo this in automatico richiamo anche il costruttore
    constructor(){
        //se non c'è l'item prodotti
        if(!localStorage.getItem("prodotti"))
            //creo l'item e metto un array vuoto che ospiterà gli oggetti Prodotto
            localStorage.setItem("prodotti", JSON.stringify([]))

        let stringaLS: string | null = localStorage.getItem("prodotti");
        if(stringaLS !== null){
            this.elenco = JSON.parse(stringaLS)
        }
    }

    Create(p: Prodotto): boolean{
        this.elenco.push(p);
        localStorage.setItem("prodotti", JSON.stringify(this.elenco))
        return true;
    }

    GetAll(){
        return this.elenco;
    }

    ListaProdotti() : Prodotto[] {
        return this.repo
    }


}