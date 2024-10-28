import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdottoInserimentoComponent } from './prodotto-inserimento.component';

describe('ProdottoInserimentoComponent', () => {
  let component: ProdottoInserimentoComponent;
  let fixture: ComponentFixture<ProdottoInserimentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProdottoInserimentoComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProdottoInserimentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
