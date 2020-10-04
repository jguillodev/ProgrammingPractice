import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'child',
  templateUrl: './child-component.component.html',
  styleUrls: ['../custom.css']
})
export class ChildComponentComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
