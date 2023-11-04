
import { Injectable } from '@angular/core';
import { Aluno } from '../shared/model/aluno-model';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class AlunosService {

  constructor(private httpClient: HttpClient) {}

  getAllAlunos(){
    return this.httpClient.get<Aluno[]>('https://localhost:44340/Aluno/GetAllAlunos')
  }

 createAluno(aluno: Aluno){
    return this.httpClient.post<any>('https://localhost:44340//Aluno/CreateAluno', aluno)
  }

}
