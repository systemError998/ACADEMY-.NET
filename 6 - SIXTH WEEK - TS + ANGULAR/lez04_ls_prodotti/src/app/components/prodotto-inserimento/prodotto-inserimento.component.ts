import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Prodotto } from '../../models/prodotto';
import { ProdottoService } from '../../services/prodotto.service';

@Component({
  selector: 'app-prodotto-inserimento',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './prodotto-inserimento.component.html',
  styleUrl: './prodotto-inserimento.component.css'
})
export class ProdottoInserimentoComponent {
  nome? : string | undefined;
  descrizione? : string ;
  quantita : number = 1;
  prezzo : number = 0;

  constructor(private service: ProdottoService){

  }

  errore: boolean = false;

  salva(){
    if(!this.nome || this.nome?.trim() === "" || this.quantita < 0 || this.prezzo < 0){
      this.errore = true;
      return
    }

    let nuovoProdotto = new Prodotto();
    nuovoProdotto.nome = this.nome;
    nuovoProdotto.desc = this.descrizione;
    nuovoProdotto.quan = this.quantita;
    nuovoProdotto.prez = this.prezzo;
  }

}
