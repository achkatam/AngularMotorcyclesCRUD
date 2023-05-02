import { Injectable } from '@angular/core';
import { Motorcycle } from '../models/motorcycle';

@Injectable({
  providedIn: 'root'
})
export class MotorcycleService {

  constructor() { }

  public getAllMotorcycles(): Motorcycle[] {
    let motorcycle = new Motorcycle();
    motorcycle.id = 1;
    motorcycle.make = "Ducati";
    motorcycle.model="Multistrada 1200S";
    motorcycle.year = "2016";
    motorcycle.price = 15000;

    return [motorcycle];
  }
}
