import { Component, OnInit, Renderer2 } from '@angular/core';
import { Shipper } from 'src/app/models/shipper';
import { ShippersService } from 'src/app/services/shippers.service';

@Component({
  selector: 'app-table-shippers',
  templateUrl: './table-shippers.component.html',
  styleUrls: ['./table-shippers.component.scss']
})
export class TableShippersComponent implements OnInit {

  listShipers:Shipper[]= [];

  constructor(private shipperService:ShippersService) { }

  ngOnInit(): void {
    this.getShippers();
    this.refresh();
  }

  refresh():void{
    this.shipperService.refresh$.subscribe(() => {
      this.getShippers();
    });
  }
  getShippers():any{
    this.shipperService.getShippers().subscribe(response => {
      this.listShipers = response;
    });
  }

  sendDataToServiceUpdate(shipper:Shipper){
    this.shipperService.sendInfoUpdate(shipper);
  }
  sendDataToServiceDelete(shipper:Shipper){
    this.shipperService.sendInfoDelete(shipper);
  }

}
