import { Pessoa } from '../models/Pessoa';
import { environment } from '../../environments/environment';
import { HttpClient } from "@angular/common/http";
import { Injectable,} from "@angular/core";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {

  baseUrl = `${environment.baseUrl}/pessoa`;


  constructor(private http: HttpClient) {  }

  getCep(cep: String){
    return this.http.get(`http://viacep.com.br/ws/${cep}/json/`)
  }

  getAll(): Observable<Pessoa[]> {
    return this.http.get<Pessoa[]>(`${this.baseUrl}`);
  }

  post(pessoa: Pessoa) {
    return this.http.post(`${this.baseUrl}`, pessoa);
  }
  put(id: number, pessoa: Pessoa) {
    return this.http.put(`${this.baseUrl}/${id}`, pessoa);
  }
  delete(id: number) {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }

}