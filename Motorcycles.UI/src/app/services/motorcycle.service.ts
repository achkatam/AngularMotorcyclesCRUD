import { Injectable } from '@angular/core';
import { Motorcycle } from '../models/motorcycle';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MotorcycleService {
  private url = "Motorcycle";
  
  constructor(private http: HttpClient) { }

 public getAllMotorcycles(): Observable<Motorcycle[]>{
  return this.http.get<Motorcycle[]>
  (`${environment.apiUrl}/Motorcycle`);
 }

 public updateMotorcycle(motorcycle: Motorcycle): Observable<Motorcycle[]>{
  return this.http.put<Motorcycle[]>
  (`${environment.apiUrl}/Motorcycle`, motorcycle);
 }
 public addMotorcycle(motorcycle: Motorcycle): Observable<Motorcycle[]>{
  return this.http.post<Motorcycle[]>
  (`${environment.apiUrl}/Motorcycle`, motorcycle);
 }
 public deleteMotorcycle(motorcycle: Motorcycle): Observable<Motorcycle[]>{
  return this.http.delete<Motorcycle[]>
  (`${environment.apiUrl}/Motorcycle/${motorcycle.id}`);
}
}
