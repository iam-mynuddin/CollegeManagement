import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, retry } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class GetDataService {
  baseUrl: string = 'https://localhost:7141/api/data/'
  result: any = {};
  constructor(public http: HttpClient) { }

  getAllFaculty() {
    return this.http.get(this.baseUrl + 'getallfaculty');
  }
  getAllUsers() {
    return this.http.get(this.baseUrl + 'getallusers');
  }
  
}
