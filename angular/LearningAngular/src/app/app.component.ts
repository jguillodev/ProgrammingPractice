import { Component, Input } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  //template: '<h1>Component is the main Building Block in Angluar</h1> <h2>Angular 8 Samples</h2>',
  //styles: ['h1{color:red; font-weight:bold;}','h2{color:blue}']
  styleUrls:['custom.css']
  
})
export class AppComponent {
  title = 'LearningAngular';
  public val: string="";
  public newVal: string="This is alert popup message";
  public value1: number = 10;
  public array1: Array<number> = [10,22,14];
  public dt1: Date = new Date();
  public status: boolean = true;
  data: number = 100;
  showColor: boolean = false;

  constructor()
  {
    console.log(`new - data is${this.data}` );
  }
  public changeColor(): void 
  {
    this.showColor = !this.showColor;
  }
  public returnString():string
  {
    return "String return from function";
  }

  public showAlert() : void 
  {
    console.log('You clicked on the button...');
    alert("Click Event Fired...");
  }

  public onSignUp(data:any):void
  {
    let strMessage:string = "Thanks for Signup " + data.name + ".";
    strMessage += "Email id" + data.email + "has been registered successfully.";
    alert(strMessage);
  }
  ngOnChanges()
  {
    console.log(`ngOnChanges - data is ${this.data}`);
  }
  ngOnInit()
  {
    console.log(`ngOnInit - data is ${this.data}`);
  }
}
