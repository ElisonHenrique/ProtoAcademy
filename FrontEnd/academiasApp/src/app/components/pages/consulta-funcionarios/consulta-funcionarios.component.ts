import { Funcionario } from './../../../shared/model/funcionario-model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-consulta-funcionarios',
  templateUrl: './consulta-funcionarios.component.html',
  styleUrls: ['./consulta-funcionarios.component.css'],
})
export class ConsultaFuncionariosComponent implements OnInit {
  /*
Atributos
*/
  funcionarios: Funcionario[] = [];
  quantidadeDeFuncionarios: number = 0;

  constructor() {}

  ngOnInit(): void {
    this.funcionarios = [
      {
        nome: 'Daniel Henrique',
        idade: 20,
        cargo: 'Gerente',
      },

      {
        nome: 'Moises Henrique',
        idade: 28,
        cargo: 'Sub-Gerente',
      },
      {
        nome: 'João Abreu',
        idade: 32,
        cargo: 'Proprietario',
      },
      {
        nome: 'Matheus Bueno',
        idade: 32,
        cargo: 'Socio',
      },
    ];

    this.quantidadeDeFuncionarios = this.funcionarios.length;

  }
}
