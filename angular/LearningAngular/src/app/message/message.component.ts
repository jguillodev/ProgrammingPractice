import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent implements OnInit {
@Input() public message : string ='';
@Input('alert-pop') public message1 : string = '';

@Output() onSignup = new EventEmitter<any>();
public data:any={};

  constructor() { }

  public showAlert():void
  {
    alert(this.message1);
  }

  public onSubmit() :void
  {
    this.onSignup.emit(this.data);
  }
  ngOnInit() {
  }

  
}
