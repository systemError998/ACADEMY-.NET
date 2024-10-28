import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { ProdottoInserimentoComponent } from './components/prodotto-inserimento/prodotto-inserimento.component';
import { ProdottoListaComponent } from './components/prodotto-lista/prodotto-lista.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,RouterLink, ProdottoInserimentoComponent,ProdottoListaComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  providers: []
})
export class AppComponent {
  title = 'lez04_ls_prodotti';
}
