import { Component } from '@angular/core';
import { Videoteca } from '../../Models/videoteca';
import { VideotecaService } from '../../services/videoteca.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-lista-videoteche',
  standalone: true,
  imports: [],
  templateUrl: './lista-videoteche.component.html',
  styleUrl: './lista-videoteche.component.css'
})
export class ListaVideotecheComponent {
   
  elencoVideoteche: Videoteca[] = [];

  constructor(private service: VideotecaService){}

  ngOnInit(){
    this.stampaVideoteche();
  }

  stampaVideoteche(){
    this.elencoVideoteche = this.service.ListaVideoteche();
  }


}
