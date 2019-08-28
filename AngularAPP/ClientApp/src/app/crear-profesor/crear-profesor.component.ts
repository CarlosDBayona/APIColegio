import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-crear-profesor',
  templateUrl: './crear-profesor.component.html',
  styleUrls: ['./crear-profesor.component.css']
})
export class CrearProfesorComponent implements OnInit {

  constructor(public http: HttpClient, @Inject('BASE_URL')public baseUrl: string) { }

  ngOnInit() {
  }
  
  onSumbit(form: NgForm){
    this.http.put(this.baseUrl + "api/profesores", form.value).subscribe(
      (response) => {
        alert("Registrado Correctamente")
        form.reset()
      }
    )
  }
}
