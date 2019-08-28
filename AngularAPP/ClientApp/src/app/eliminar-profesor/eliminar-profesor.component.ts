import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-eliminar-profesor',
  templateUrl: './eliminar-profesor.component.html',
  styleUrls: ['./eliminar-profesor.component.css']
})
export class EliminarProfesorComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL')public baseUrl: string) { }

  ngOnInit() {
  }
  onSumbit(form: NgForm){
    this.http.delete(this.baseUrl + "api/profesores", {params: {'cedula': form.value.Cedula}}).subscribe(
      (response) => {
        alert("Eliminado Correctamente")
        form.reset()
      }
    )
  }
}
