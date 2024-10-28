import { Routes } from '@angular/router';
import { ProdottoListaComponent } from './components/prodotto-lista/prodotto-lista.component';
import { ProdottoInserimentoComponent } from './components/prodotto-inserimento/prodotto-inserimento.component';

export const routes: Routes = [
    {path: "", redirectTo: "prodotti/lista", pathMatch: "full"},
    {path: "prodotti/lista", component: ProdottoListaComponent},
    {path: "prodotti/inserimento", component: ProdottoInserimentoComponent}
];
