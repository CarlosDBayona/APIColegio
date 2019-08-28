import { Component, OnInit, Inject } from '@angular/core';
import { NgForm } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-asignar-notas',
  templateUrl: './asignar-notas.component.html',
  styleUrls: ['./asignar-notas.component.css']
})
export class AsignarNotasComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL')public baseUrl: string) { }

  ngOnInit() {
  }
  onSumbit(form: NgForm){
    this.http.post(this.baseUrl + "api/cursos/notas", {...form.value}).subscribe(
      (response) => {
        alert("Registrado Correctamente")
        form.reset()
      }
    )
  }
}
