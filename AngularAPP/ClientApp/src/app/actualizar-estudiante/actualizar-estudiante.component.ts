import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-actualizar-estudiante',
  templateUrl: './actualizar-estudiante.component.html',
  styleUrls: ['./actualizar-estudiante.component.css']
})
export class ActualizarEstudianteComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  ngOnInit() {

  }
  onSumbit(form: NgForm){
    console.log(form.value)
      this.http.post(this.baseUrl + "api/estudiantes", form.value).subscribe(
        (response) => {
          alert("Actualizado Correctamente")
          form.reset()
        }
      )
    }
}
