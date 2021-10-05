import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { Grocery } from "./grocery";

@Injectable({
    providedIn: 'root'
})
export class HomeService{

     baseUrl: string = environment.base_url;
    constructor(private http: HttpClient) {

     }

     getAllItems(){

        return this.http.get<Grocery[]>(this.baseUrl + 'items');

     }

}