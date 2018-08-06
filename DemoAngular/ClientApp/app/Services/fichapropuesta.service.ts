import { Injectable, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class FichaPropuestaService {

    myAppUrl: string = "";

    constructor(private _http: Http, @Inject('BASE_URL') baseUrl: string) {

        this.myAppUrl = baseUrl;

    }

    getFichaPropuesta() {

        return this._http.get(this.myAppUrl + 'api/Pedido/ListadoPropuesta')
            .map((response: Response) => response.json())
            .catch(this.errorHandler);
    }


    getPropuestaDetalle(nroPedido: number, nroPropuesta: number) {

        return this._http.get(this.myAppUrl + "api/Pedido/DetallePropuesta/" + nroPedido + "/" + nroPropuesta)
            .map((response: Response) => response.json())
            .catch(this.errorHandler)  

    }
    
    errorHandler(error: Response) {

        console.log(error);
        return Observable.throw(error);

    }

}
