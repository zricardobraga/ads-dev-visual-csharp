import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Categoria } from '../models/categoria';

@Injectable({
  providedIn: 'root'
})

export class CategoriaService {
    private baseUrl = "http://localhost:5000/api/categoria";

    constructor(private http: HttpClient) { }

    list(): Observable<Categoria[]> {
        return this.http.get<Categoria[]>(`${this.baseUrl}/list`);
    }
}
