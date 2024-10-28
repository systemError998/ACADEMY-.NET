import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InserisciVideotecaComponent } from './inserisci-videoteca.component';

describe('InserisciVideotecaComponent', () => {
  let component: InserisciVideotecaComponent;
  let fixture: ComponentFixture<InserisciVideotecaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InserisciVideotecaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InserisciVideotecaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
