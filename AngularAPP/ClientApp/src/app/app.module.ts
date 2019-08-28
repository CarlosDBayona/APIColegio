import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CrearEstudianteComponent } from './crear-estudiante/crear-estudiante.component';
import { ActualizarEstudianteComponent } from './actualizar-estudiante/actualizar-estudiante.component';
import { CrearProfesorComponent } from './crear-profesor/crear-profesor.component';
import { CrearMateriaComponent } from './crear-materia/crear-materia.component';
import { AsignarMateriaComponent } from './asignar-materia/asignar-materia.component';
import { AsignarNotasComponent } from './asignar-notas/asignar-notas.component';
import { EliminarProfesorComponent } from './eliminar-profesor/eliminar-profesor.component';
import { GenerarReporteComponent } from './generar-reporte/generar-reporte.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CrearEstudianteComponent,
    ActualizarEstudianteComponent,
    CrearProfesorComponent,
    CrearMateriaComponent,
    AsignarMateriaComponent,
    AsignarNotasComponent,
    EliminarProfesorComponent,
    GenerarReporteComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, children:[
        { path: 'crear-estudiante', component: CrearEstudianteComponent },
        { path: 'actualizar-estudiante', component: ActualizarEstudianteComponent},
        { path: 'crear-profesor', component: CrearProfesorComponent},
        { path: 'crear-materia', component: CrearMateriaComponent},
        { path: 'asignar-materia', component: AsignarMateriaComponent},
        { path: 'asignar-notas', component: AsignarNotasComponent},
        { path: 'eliminar-profesor', component: EliminarProfesorComponent},
        { path: 'generar-reporte', component: GenerarReporteComponent}
      ] },
      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
