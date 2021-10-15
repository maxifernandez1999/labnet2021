import { AfterViewInit, Component, ElementRef, Input, OnDestroy, OnInit, Renderer2, ViewChild } from '@angular/core';

import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

import { Subscription } from 'rxjs';

import { Shipper } from 'src/app/models/shipper';

import { ShippersService } from 'src/app/services/shippers.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit, AfterViewInit, OnDestroy {

  isUpdate:boolean = true;
  actionAdd = true;
  actionUpdate = false;
  shipper:Shipper;
  formAdd : FormGroup;
  title:string = "Add Shipper";

  subscriptionAdd:Subscription;
  subscriptionUpdate:Subscription;
  getData:Subscription;

  @Input() formInput:string; 

  @ViewChild('companyName') companyName:ElementRef;
  @ViewChild('divButtons') buttons:ElementRef;
  @ViewChild('action') action:ElementRef;

  get companyNameControl():AbstractControl{
    return this.formAdd.get('companyName');
  }

  get regionControl():AbstractControl{
    return this.formAdd.get('region');
  }

  get phoneControl():AbstractControl{
    return this.formAdd.get('phone');
  }

  public get form():any{
    return this.formAdd.controls;
  }

  constructor(private readonly fb: FormBuilder,
              private shipperService:ShippersService,
              private renderer2:Renderer2) { }

  ngOnInit(): void {
    this.initForm();
    
  }
  ngAfterViewInit(){
    this.getDataToService();
  }
  ngOnDestroy(){
    this.subscriptionUpdate.unsubscribe();
    this.subscriptionAdd.unsubscribe();
    this.getData.unsubscribe();
  }

  getDataToService():void{
    this.getData = this.shipperService.communicatorUpdate$.subscribe(shp => {
      this.shipper = shp
      const phoneSplite = this.shipper.Phone.split(')');
      if(phoneSplite[0] != undefined && phoneSplite[1] != undefined){
        this.formAdd.setValue({
          companyName: this.shipper.CompanyName, 
          region: phoneSplite[0].slice(1,4),
          phone: phoneSplite[1].split("-")[0].replace(/ /g, "") + phoneSplite[1].split("-")[1]
        });
        if(this.isUpdate){
          this.generateCancelButton();
          this.actionAdd = false;
          this.actionUpdate = true;
        }
        this.isUpdate = false;
        this.title = "Update Shipper";
      }   
    });
  }
  generateCancelButton():any{
    const element = this.buttons.nativeElement;
    const input = this.renderer2.createElement('input');
    this.renderer2.setAttribute(input,"type","button");
    this.renderer2.setAttribute(input,"value","Cancel");
    this.renderer2.addClass(input,"btn");
    this.renderer2.addClass(input,"btn-danger");
    this.renderer2.addClass(input,"m-1");
    this.renderer2.appendChild(element,input);
    this.renderer2.listen(input,'click',() => {
      window.location.reload();
    })
    return input;
  }

  initForm():void{
    this.formAdd = this.fb.group({
      companyName: ['',[Validators.required,Validators.maxLength(40)]],
      region: ['',[Validators.required,Validators.minLength(3),Validators.maxLength(3),Validators.pattern('^[0-9]*$')]],
      phone: ['',[Validators.required,Validators.maxLength(7),Validators.pattern('^[0-9]*$')]]
    });
  }
  formatPhone(){
    let phonefirstPart = this.formAdd.get('phone').value.substr(0,3);
    let phoneSecondPart = this.formAdd.get('phone').value.substr(3,6);
    let region = this.formAdd.get('region').value;
    return '(' + region + ')' + phonefirstPart + '-' + phoneSecondPart;
  }
  addShipper():void{
    let shipper = new Shipper();
    shipper.CompanyName = this.formAdd.get('companyName').value;
    shipper.Phone = this.formatPhone();
    this.subscriptionAdd = this.shipperService.addShippers(shipper).subscribe(response => {
      this.sendDataToServiceAlertAdd("added");
    },err => {
      this.sendDataToServiceAlertAdd("error");
    });
  }
  updateShipper(){
    let shipper = new Shipper();
    shipper.ShipperID = this.shipper.ShipperID;
    shipper.CompanyName = this.formAdd.get('companyName').value;
    shipper.Phone = this.formatPhone();
    console.log(this.shipper.ShipperID.toString());
    this.subscriptionUpdate = this.shipperService.updateShipper(this.shipper.ShipperID.toString(),shipper).subscribe(response => {
      this.sendDataToServiceAlertUpdate("updated");
    },err => {
      this.sendDataToServiceAlertUpdate("error");
    });
  }

  sendDataToServiceAlertAdd(data){
    this.shipperService.sendInfoAlertAdd(data);
  }

  sendDataToServiceAlertUpdate(data){
    this.shipperService.sendInfoAlertUpdate(data);
  }
  onClickClear():void{
    const arrayControls:any[] = [
      this.companyNameControl,
      this.regionControl,
      this.phoneControl
    ];
    arrayControls.forEach(control => {
      if(control){
        control.setValue('');
      }
    });
  }

}
