import { Component, OnInit, Inject } from '@angular/core';
import { NgForm } from '@angular/forms';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-generar-reporte',
  templateUrl: './generar-reporte.component.html',
  styleUrls: ['./generar-reporte.component.css']
})
export class GenerarReporteComponent implements OnInit {
  Estudiante
  constructor(public http: HttpClient, @Inject('BASE_URL')public baseUrl: string) { }

  ngOnInit() {
  }
  onSumbit(form: NgForm){
    this.http.get(this.baseUrl+"api/estudiantes/"+ form.value.id).subscribe(
      (response) => {
        console.log(response)
        this.Estudiante = response;
      }
    )
  }
}
