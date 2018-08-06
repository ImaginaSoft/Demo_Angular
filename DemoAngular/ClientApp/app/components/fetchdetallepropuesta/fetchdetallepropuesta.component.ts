import { Component, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { FichaPropuestaService } from '../../Services/fichapropuesta.service';

@Component({
    selector: 'propuestadetalle',
    templateUrl: './fetchdetallepropuesta.component.html'
})


export class propuestadetalle implements OnInit {


    public detallepropuestalist: DetPropuestaList[];
    propuestaForm: FormGroup;
    nroPedido: number;
    nroPropuesta: number;
    errorMessage: any;

    constructor(private _avRoute: ActivatedRoute,
        private _propuestaService: FichaPropuestaService, private _router: Router) {

        if (this._avRoute.snapshot.params["nroPedido"] && this._avRoute.snapshot.params["nroPropuesta"]) {

            this.nroPedido = this._avRoute.snapshot.params["nroPedido"];
            this.nroPropuesta = this._avRoute.snapshot.params["nroPropuesta"];

        }

    }

    ngOnInit() {

        if (this.nroPedido > 0 && this.nroPropuesta > 0) {

            this._propuestaService.getPropuestaDetalle(this.nroPedido, this.nroPropuesta)
                .subscribe(
                data => {
                    debugger
                            this.detallepropuestalist = data
                    }
                )


        }
    }
}

interface DetPropuestaList {

    NroPedido: number;
    NroDia: number;
    NroOrden: number;
    NroServicio: number;
    DesServicio: string;
    DesServicioDet: string;

}