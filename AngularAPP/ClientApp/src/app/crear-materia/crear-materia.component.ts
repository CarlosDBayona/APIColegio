import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-crear-materia',
  templateUrl: './crear-materia.component.html',
  styleUrls: ['./crear-materia.component.css']
})
export class CrearMateriaComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL')public baseUrl: string) { }

  ngOnInit() {
  }
  onSumbit(form: NgForm){
    this.http.put(this.baseUrl + "api/materias", form.value).subscribe(
      (response) => {
        alert("Registrado Correctamente")
        form.reset()
      }
    )
  }
}
