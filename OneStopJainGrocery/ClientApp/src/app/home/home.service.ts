import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Grocery } from "./grocery";

@Injectable({
    providedIn: 'root'
})
export class HomeService{

    @Inject('BASE_URL') baseUrl: string =document.getElementsByTagName('base')[0].href;
    constructor(private http: HttpClient) {

     }

     getAllItems(){

        return this.http.get<Grocery[]>(this.baseUrl + 'items');

     }

}