import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-cadastro-alunos',
  templateUrl: './cadastro-alunos.component.html',
  styleUrls: ['./cadastro-alunos.component.css']
})
export class CadastroAlunosComponent implements OnInit {
 alunoForm: FormGroup = new FormGroup ({});// Inicialize o FormGroup vazio
dadosDoaluno: any; //Propriedade para armazenar os dados dos alunos
constructor(private fb: FormBuilder){}

  ngOnInit(){
    this.alunoForm = this.fb.group({
      nome:[''],
      idade:[''],
      cpf:[''],
      email:[''],
      observacoes:['']
    })
  }

onSubmit(){
  this.dadosDoaluno = this.alunoForm.value;
}
}
