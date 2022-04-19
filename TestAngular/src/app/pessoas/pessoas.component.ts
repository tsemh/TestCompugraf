import { PessoaService } from './pessoas.service';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
import { Pessoa } from '../models/Pessoa';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-pessoas',
  templateUrl: './pessoas.component.html',
  styleUrls: ['./pessoas.component.css'],
  exportAs: 'ngModule'
})

export class PessoasComponent implements OnInit {

  public title = 'Pessoas';

  public pessoas: Pessoa[];
  public pessoaForm: FormGroup;
  public pessoaSelecionada: Pessoa;
  public idSelecionado: Number;

  public modalRef?: BsModalRef;

  public cep: string;


  selecionaPessoa(pessoa: Pessoa) {
    this.pessoaSelecionada = pessoa;
    this.pessoaForm.patchValue(pessoa);
  }
  selecionaId(pessoa: Pessoa) {
    this.idSelecionado = pessoa.id;
  }

  carregarPessoas() {
    this.pessoaService.getAll().subscribe(
      (pessoas: Pessoa[]) => {
        this.pessoas = pessoas;
      },
      (erro: any) => {
        console.error(erro)
      }
    );
  }

  criarPessoa(pessoa: Pessoa) {
    this.pessoaService.post(pessoa).subscribe(
      (retorno) => {
        console.log(retorno);
        this.carregarPessoas();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  salvarPessoa(pessoa: Pessoa) {
    this.pessoaService.put(pessoa.id, pessoa).subscribe(
      (retorno) => {
        console.log(retorno);
        this.carregarPessoas();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  deletarPessoa(id: number) {
    this.pessoaService.delete(id).subscribe(
      (model: any) => {
        console.log(model);
        this.carregarPessoas();
      },
      (erro: any) => {
        console.error(erro);
      }
    );
  }

  novaPessoa() {
    this.pessoaSelecionada = new Pessoa();
    this.pessoaForm.patchValue(this.pessoaSelecionada);
  }

  consultaCep(valor: String, form: any) {
    this.pessoaService.getCep(valor).subscribe(
      (dados) => {
        this.criaForm()
      }
    )
  }

  criaForm() {
    this.pessoaForm = this.fb.group(
      {
      id: ['', Validators.required],
      cpf: ['', Validators.required],
      nome: ['', Validators.required],
      sobrenome: ['', Validators.required],
      email: ['', Validators.required],
      telefone: ['', Validators.required],
      nacionalidade: ['', Validators.required],
      cep: ['', Validators.required],
      estado: ['', Validators.required],
      cidade: ['', Validators.required],
      logradouro: ['', Validators.required],
    });
  }

  editarSubmit() {
    this.salvarPessoa(this.pessoaForm.value);
  }
  criarSubmit() {
    this.criarPessoa(this.pessoaForm.value);
  }
  
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  novaPessoaAbreModal(template: TemplateRef<any>) {
    this.novaPessoa();
    this.openModal(template)
  }

  selecionaPessoaAbreModal(pessoa: Pessoa, template: TemplateRef<any>) {
    this.selecionaPessoa(pessoa);
    this.openModal(template);
  }

  constructor(
    private modalService: BsModalService,
    private pessoaService: PessoaService,
    private fb: FormBuilder) {
    this.criaForm()
    }

  ngOnInit() {
    this.carregarPessoas();
  }

}
