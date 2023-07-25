
import { SimuladorService } from './../../services/simulador.service';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SimuladorComponent } from './simulador.component';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

describe('SimuladorComponent', () => {
  let component: SimuladorComponent;
  let fixture: ComponentFixture<SimuladorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule,FormsModule,CommonModule],
      providers: [SimuladorService]
    }).compileComponents();
    fixture = TestBed.createComponent(SimuladorComponent);
    component = fixture.componentInstance;    
  });

  it('Componente Criado', () => {
    expect(component).toBeTruthy();
  });
});
