import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListaVideotecheComponent } from './lista-videoteche.component';

describe('ListaVideotecheComponent', () => {
  let component: ListaVideotecheComponent;
  let fixture: ComponentFixture<ListaVideotecheComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListaVideotecheComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListaVideotecheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
