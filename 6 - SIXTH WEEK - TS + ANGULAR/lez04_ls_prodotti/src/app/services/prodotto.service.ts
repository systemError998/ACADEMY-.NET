import { Injectable } from '@angular/core';
import { Prodotto } from '../models/prodotto';
import { v4 as uuidv4 } from 'uuid';
import { ProdottoRepo } from '../../../repos/prodotto.repository';

@Injectable({
  providedIn: 'root'
})
export class ProdottoService {

  constructor(private repo: ProdottoRepo) { }

  InserisciProd(prod: Prodotto){
    prod.codi = uuidv4();  
    //Todo: chiama la Repo...

    return this.repo.Create(prod);
  }

}
