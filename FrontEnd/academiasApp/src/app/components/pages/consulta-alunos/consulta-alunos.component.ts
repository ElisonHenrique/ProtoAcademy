import { Component, OnInit } from '@angular/core';
import { Aluno } from 'src/app/shared/model/aluno-model';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css']
})
export class ConsultaAlunosComponent implements OnInit {
  /*
Atributos
*/
  alunos: Aluno[] = [];
  quantidadeDeAlunos: number = 0;

  constructor() {}

  ngOnInit(): void {
    this.alunos = [
      {
        nome: 'Daniel Henrique',
        idade: 20,
        observacoes: 'Acelerado Demais ',
      },

      {
        nome: 'Moises Henrique',
        idade: 28,
        observacoes: 'Paciente e comunicativo',
      },
      {
        nome: 'João Abreu',
        idade: 32,
        observacoes: 'Calmo e Determinado',
      },
      {
        nome: 'Matheus Bueno',
        idade: 32,
        observacoes: 'Tranquilo e da Paz',
      },
    ];

    this.quantidadeDeAlunos = this.alunos.length;

  }
}
