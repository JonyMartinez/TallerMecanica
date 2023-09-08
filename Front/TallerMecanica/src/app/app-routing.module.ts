import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ClientesComponent } from 'src/app/Components/clientes/clientes.component';
import { MecanicosComponent } from './Components/mecanicos/mecanicos.component';
import { VehiculosComponent } from './Components/vehiculos/vehiculos.component';

 

const routes: Routes = [
 
  { path: 'Clientes', component: ClientesComponent },
  { path: 'Vehiculos', component: VehiculosComponent },
  { path: 'Mecanicos', component: MecanicosComponent },
  

];

 
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }