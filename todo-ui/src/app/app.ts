import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [CommonModule,RouterOutlet],
  standalone: true,
  template: `<router-outlet></router-outlet>`,
  styleUrl: './app.css'
})
export class App {
  protected title = 'todo-ui';
}
