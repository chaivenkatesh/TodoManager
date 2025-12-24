import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { TodoService } from '../../services/todoservice'
import { Todo } from '../../models/todo.model';

@Component({
  selector: 'app-todocomponent',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todocomponent.html',
  styleUrl: './todocomponent.css',
})
export class Todocomponent implements OnInit {
todos: Todo[] = [];
  newTodo = '';

  constructor(private todoService: TodoService) {}

  ngOnInit(): void {
    this.loadTodos();
  }

  loadTodos() {
    this.todoService.getTodos().subscribe((data: Todo[]) => this.todos = data);
  }

  addTodo() {
    if (!this.newTodo.trim()) return;

    this.todoService.addTodo(this.newTodo).subscribe(() => {
      this.newTodo = '';
      this.loadTodos();
    });
  }

  deleteTodo(id: number) {
    this.todoService.deleteTodo(id).subscribe(() => {
      this.loadTodos();
    });
  }
}
