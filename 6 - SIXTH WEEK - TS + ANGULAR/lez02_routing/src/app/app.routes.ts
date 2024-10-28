import { Routes } from '@angular/router';
import { HomeComponent } from './home/home/home.component';
import { ServiziComponent } from './servizi/servizi/servizi.component';
import { ChisiamoComponent } from './chisiamo/chisiamo/chisiamo.component';
import { ContattiComponent } from './contatti/contatti/contatti.component';

export const routes: Routes = [
    {path: "", redirectTo: "home", pathMatch: "full"},
    {path: "home", component: HomeComponent},
    {path: "servizi", component: ServiziComponent},
    {path: "chisiamo", component: ChisiamoComponent},
    {path: "contatti", component: ContattiComponent},
];
