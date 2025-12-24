import { bootstrapApplication } from '@angular/platform-browser';
import { App } from './app/app';
import { provideRouter, Routes } from '@angular/router';
import { Todocomponent } from './app/components/todocomponent/todocomponent';
import { provideHttpClient } from '@angular/common/http';
import 'zone.js';


const routes: Routes = [
    { path: '', redirectTo: 'ToDo', pathMatch: 'full' }, // Default route
   { path: 'ToDo', component: Todocomponent },
  { path: '**', redirectTo: 'User' } // optional fallback
];

 
bootstrapApplication(App,  {
 providers: [
  provideHttpClient(),
  provideRouter(routes)]
})
    .catch((err) => console.error(err))  