import { environment } from './../../../environments/environment';
import { Observable } from 'rxjs';
import { SimuladorRequest } from './../models/simulador-request';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SimuladorResponse } from '../models/simulador-response';

@Injectable({
  providedIn: 'root'
})
export class SimuladorService {

  constructor(private http: HttpClient) { }

  realizarSimulacao(model: SimuladorRequest): Observable<SimuladorResponse>{
    return this.http.post<SimuladorResponse>(`${environment.baseURL}/Simulador/`,model);
  }
}
