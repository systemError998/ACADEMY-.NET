import { Injectable } from '@angular/core';
import { VideotecaRepo } from '../Repos/videoteca.repository';
import { Videoteca } from '../Models/videoteca';

@Injectable({
  providedIn: 'root'
})
export class VideotecaService {

  //inietto la dipendenza della repo, perchè il mio service dipende dalla repo
  constructor(private repo: VideotecaRepo) { }

  ListaVideoteche(): Videoteca[]{
    return this.repo.GetAll();
  }
}
