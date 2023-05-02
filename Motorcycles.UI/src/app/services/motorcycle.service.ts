import { Injectable } from '@angular/core';
import { Motorcycle } from '../models/motorcycle';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class MotorcycleService {
  private url = "Motorcycle";
  constructor(private http: HttpClient) { }

  public getAllMotorcycles(): Observable<Motorcycle[]> {
   return this.http.get<Motorcycle[]>('${environment.apiUrl}/${this.url}');
  }
}
