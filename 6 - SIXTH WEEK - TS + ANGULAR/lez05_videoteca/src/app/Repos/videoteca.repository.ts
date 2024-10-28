import { Injectable } from "@angular/core";
import { Videoteca } from "../Models/videoteca";
import urlAPIVideoteca from "../url";

@Injectable({
    providedIn: 'root'
})

export class VideotecaRepo{

    private elencoVideoteche: Videoteca[] = [];

    constructor(){}

    GetAll(): Videoteca[] {

        fetch(urlAPIVideoteca, {
            headers: {
                'Content-Type' : 'application/json'
            }
        })
        .then( responseJSON => responseJSON.json())
        .then( json => console.log(json) )

        return [];

    }


}


