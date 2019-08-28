import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-asignar-materia',
  templateUrl: './asignar-materia.component.html',
  styleUrls: ['./asignar-materia.component.css']
})
export class AsignarMateriaComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL')public baseUrl: string) { }

  ngOnInit() {
  }
  onSumbit(form: NgForm){
    this.http.put(this.baseUrl + "api/cursos", form.value).subscribe(
      (response) => {
        alert("Registrado Correctamente")
        form.reset()
      }
    )
  }
}
