import { Component } from '@angular/core';
import { Persona } from '../../Models/persona';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-lista',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista.component.html',
  styleUrl: './lista.component.css'
})
export class ListaComponent {

  elenco : Persona[] = new Array();
  titolo: string = "Lista dinamica di persone";
  contatore: number = 0;

  constructor(){
    // this.elenco.push( new Persona("Marika", "Mariko") )
    // this.elenco.push( new Persona("Valeria", "Verdi") )
  }

  ngOnInit(){
    setTimeout(() => {
      this.elenco.push( new Persona("Marika", "Mariko") )
      this.elenco.push( new Persona("Valeria", "Verdi") )
    }, 3000)

    this.contatore = this.elenco.length;
  }
}
