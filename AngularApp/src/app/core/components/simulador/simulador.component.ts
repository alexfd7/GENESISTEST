import { SimuladorResponse } from './../../models/simulador-response';
import { SimuladorService } from './../../services/simulador.service';
import { Component, OnDestroy } from '@angular/core';
import { SimuladorRequest } from '../../models/simulador-request';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-simulador',
  templateUrl: './simulador.component.html',
  styleUrls: ['./simulador.component.css']
})
export class SimuladorComponent implements OnDestroy {
  
  model!: SimuladorRequest;
  response!: SimuladorResponse;

  private simuladorSubscription: Subscription = new Subscription;

  constructor(private simuladorService:SimuladorService){
    this.model = {
      valorInicial: 10000.00,
      prazo: 10
    }    
  }

  onFormSubmit(){    
    this.simuladorSubscription = this.simuladorService.realizarSimulacao(this.model)
    .subscribe({
      next: (data) => {        
        this.response = {
          valorInicial: data.valorInicial,
          prazo: data.prazo,
          rendimentoBruto: data.rendimentoBruto,
          rendimentoLiquido: data.rendimentoLiquido,
          mensagem : data.mensagem
        }
      },
      error: (e) =>{
        console.log('ERRO');
      }
    })
  }

  ngOnDestroy(): void {    
      this.simuladorSubscription.unsubscribe();
  }

}
