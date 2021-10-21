import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatSidenav } from '@angular/material/sidenav';
import { Grocery } from './grocery';
import { HomeService } from './home.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  
  
  constructor(private homeService: HomeService) { }
  public groceryList : Grocery[] = [];
  public size: number = 0;
  public pageEvent: any | undefined;
  ngOnInit() {
    
    this.getItemList(0);
   
  }

  onPaginateChange(event: any){
    console.log(event);

    this.getItemList(event.pageIndex);

  }

  getItemList(pageIndex: number){

    this.homeService.getAllItems(pageIndex).subscribe(
      response => {
        
        this.groceryList = response;
        console.log(this.groceryList);
      
      },
      error => {
        console.log(error);
      });

  }



}
