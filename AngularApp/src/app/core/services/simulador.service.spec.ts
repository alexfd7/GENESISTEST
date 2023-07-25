import { SimuladorResponse } from './../models/simulador-response';
import { TestBed } from '@angular/core/testing';

import { SimuladorService } from './simulador.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { SimuladorRequest } from '../models/simulador-request';

describe('SimuladorService', () => {
  let service: SimuladorService;
  

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [SimuladorService]
    }).compileComponents();
    service = TestBed.inject(SimuladorService);
  });

  it('Componente Criado', () => {
    expect(service).toBeTruthy();
  });

  it('Teste de Simulador', (done)  => {
    spyOn(console, 'log').and.callThrough();    
    const model: SimuladorRequest = {
        valorInicial: 10000,
        prazo: 10
      }      
    done();
    service.realizarSimulacao(model)
    .subscribe({
      next: (data) => {                  
        data.valorInicial.toPrecision(2);
        done();
      },
      error: (e) =>{
        console.log('ERRO');
      }
    });      
  });

  
});
