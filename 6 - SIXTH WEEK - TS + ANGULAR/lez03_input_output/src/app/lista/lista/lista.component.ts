import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';

@Component({
  selector: 'app-lista',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista.component.html',
  styleUrl: './lista.component.css'
})
export class ListaComponent {
  elenco_stringhe: string[] = ["Fuat", "Meserati", "Lomborghini", "BMX"]
  elenco_prodotti: Prodotto[] = [
    new Prodotto("biscotti", "molto buoni", 0),
    new Prodotto("banane", "un pò dure", 3),
    new Prodotto("marmellata", "liquefa", 7),
    new Prodotto("pane", "secco", 5),
  ]

}
