import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { FirstComponent } from "./first/first.component";
import { SecondComponent } from "./second/second.component";
import { PageNotFoundComponent } from "./page-not-found/page-not-found.component";


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive, FirstComponent, SecondComponent, PageNotFoundComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'RoutingDemo';
}
