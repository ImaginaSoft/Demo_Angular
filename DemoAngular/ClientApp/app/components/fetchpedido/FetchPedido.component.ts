import { Component, Inject, OnInit } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { PedidoService } from '../../Services/pedidoservice.service';

@Component({
    selector: 'FetchPedido',
    templateUrl: './FetchPedido.component.html' 
})  

export class FetchPedidoComponent {

    public pedidoList: PedidoData[];

    public searchString: string;

    constructor(public http: Http, private _router: Router, private _pedidoService: PedidoService) {

        this.getPedidos();
    }

    getPedidos() {

        this._pedidoService.getPedidos().subscribe(
            data => {
                debugger;
                this.pedidoList = data
            }
        )

    }
    
}

interface PedidoData {

    NroPedido: number;
    DesPedido: string;
    FchPedido: Date;
    CodVendedor: string;

}


