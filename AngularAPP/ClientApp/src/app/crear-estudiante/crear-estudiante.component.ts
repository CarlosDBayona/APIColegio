import { Component, OnInit, Inject } from '@angular/core';
import { NgForm } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-crear-estudiante',
  templateUrl: './crear-estudiante.component.html',
  styleUrls: ['./crear-estudiante.component.css']
})
export class CrearEstudianteComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  ngOnInit() {
  }

  onSumbit(form: NgForm){
    this.http.put(this.baseUrl + "api/estudiantes", form.value).subscribe(
      (response) => {
        alert("Registrado Correctamente")
        form.reset()
      }
    )
  }
}
