import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  //template: '<h1>Component is the main Building Block in Angluar</h1> <h2>Angular 8 Samples</h2>',
  //styles: ['h1{color:red; font-weight:bold;}','h2{color:blue}']
  styleUrls:['custom.css']
  
})
export class AppComponent {
  title = 'LearningAngular';

  data:number =100;
  constructor()
  {
    console.log(`new - data is${this.data}` );
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
