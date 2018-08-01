import { Component, Inject, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { FichaPropuestaService } from '../../Services/fichapropuesta.service';

@Component({
    selector: 'fetchfichapropuesta',
    templateUrl: './fetchfichapropuesta.component.html' 
})  

export class FetchFichaPropuestaComponent {

    public fichaList: FichaPropuestaData[];

    public searchString: string;

    constructor(public http: Http, private _router: Router, private _fichaService: FichaPropuestaService) {

        this.getFichaPropuesta();
    }

    getFichaPropuesta() {

        this._fichaService.getFichaPropuesta().subscribe(
            data => {
                debugger;
                this.fichaList = data
            }
        )

    }
    
}

interface FichaPropuestaData {

    NroPedido: number;
    NroPropuesta: number;
    NroDia: number;
    NroOrden: number;
    NroServicio: number;
    DesServicio: string;
    DesServicioDet: string;

  

}


