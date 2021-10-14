import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Shipper } from 'src/app/models/shipper';
import { ShippersService } from 'src/app/services/shippers.service';

@Component({
  selector: 'app-modal-delete',
  templateUrl: './modal-delete.component.html',
  styleUrls: ['./modal-delete.component.scss']
})
export class ModalDeleteComponent implements OnInit,OnDestroy {

  shipper:Shipper;
  subscription:Subscription;

  constructor(private shipperService:ShippersService) { }

  ngOnInit(): void {
    this.getDataToService();
  }
  ngOnDestroy(){
    this.subscription.unsubscribe();
  }
  getDataToService():void{
    this.subscription = this.shipperService.communicatorDelete$.subscribe(
      shp => this.shipper = shp
    );
  }
  deleteShipper(id:number):void{
    this.shipperService.deleteShipper(id.toString()).subscribe(res => {
        this.sendDataToServiceAlertDelete("deleted");   
    },err => {
      this.sendDataToServiceAlertDelete("error");
    });
  }

  sendDataToServiceAlertDelete(data){
    this.shipperService.sendInfoAlertDelete(data);
  }

}
