import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { FetchPedidoComponent } from './components/fetchpedido/fetchpedido.component'
import { PedidoService } from './Services/pedidoservice.service';
import { FilterPipe } from '../app/components/pipes/filter.pipe';
import { FichaPropuestaService } from './Services/fichapropuesta.service';
import { FetchFichaPropuestaComponent } from './components/fetchfichapropuesta/fetchfichapropuesta.component';
import { propuestadetalle } from './components/fetchdetallepropuesta/fetchdetallepropuesta.component'

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        FetchPedidoComponent,
        FilterPipe,
        FetchFichaPropuestaComponent,
        propuestadetalle
    ],

    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        BrowserModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'fetch-pedido', component: FetchPedidoComponent },  
            { path: 'fetch-ficha', component: FetchFichaPropuestaComponent }, 
            { path: 'pedido/edit/:nroPedido/:nroPropuesta', component: propuestadetalle },
            { path: '**', redirectTo: 'home' }
        ])
    ],

    providers: [PedidoService, FichaPropuestaService],

    exports: [
        FilterPipe
    ]
})
export class AppModuleShared {
}
