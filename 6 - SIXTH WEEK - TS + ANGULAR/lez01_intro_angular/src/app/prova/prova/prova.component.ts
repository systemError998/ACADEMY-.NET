import { Component } from '@angular/core';
import { Persona } from '../../Models/persona';

@Component({
  selector: 'app-prova',
  standalone: true,
  imports: [],
  templateUrl: './prova.component.html',
  styleUrl: './prova.component.css'
})
export class ProvaComponent {

  //constructor, ngoninit vengono caricati alla creazione del componente
  constructor(){
    console.log("ciao sono il costruttore di PROVACOMPONENT");

    let gio = new Persona();
    gio.nome = "Anna";
    gio.cognome = "Cerasoli";
  }

  ngOnInit(): void {
    console.log("ciao sono il onInit di prova-component");
  }

}
