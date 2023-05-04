import { Component } from '@angular/core';
import { Motorcycle } from './models/motorcycle';
import { MotorcycleService } from './services/motorcycle.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Motorcycles.UI';
  motorcycles: Motorcycle[] = [];

  constructor(private motorcycleService: MotorcycleService) { }

  ngOnInit(): void {
    this.motorcycleService
    .getAllMotorcycles()
    .subscribe((result: Motorcycle[]) => (this.motorcycles = result));
  }
}