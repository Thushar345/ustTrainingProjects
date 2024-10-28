// ./app.component.ts
import { Component } from '@angular/core';
import { CounterComponent } from './components/counter.component';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CounterComponent],
  template: `
    <main>

    <p>Your color preference is {{ theme }}.</p>
    <button (click)="change()">Mode Change</button> <br>

      <h1>Counter: {{ initialCount }}</h1>
      <app-counter [(count)]="initialCount"></app-counter><br>

      <ul [class]="listClasses"> ... </ul>
    <section [class]="sectionClasses"> ... </section>
    <button [class]="buttonClasses"> ... </button>



    <p>@if (a > b) {
      {{a}} is greater than {{b}}
    } 
    @else if (b > a) {
      {{a}} is less than {{b}}
    } 
    @else {
      {{a}} is equal to {{b}}
    }</p>
    </main>
  `,
})
export class AppComponent {
  initialCount = 1;
  theme="dark";
  change(): void{
    if (this.theme =="dark"){
      this.theme="light";
    }
    else{
      this.theme="dark";
    }
    
  }

  listClasses = 'full-width outlined';
  sectionClasses = ['expandable', 'elevated'];
  buttonClasses = {
    highlighted: true,
    embiggened: false,
  };


  a: number =10;
  b: number =3;
}