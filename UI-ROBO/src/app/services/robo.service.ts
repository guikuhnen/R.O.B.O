import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { Robo } from 'src/app/models/robo';

var httpOptions = { headers: new HttpHeaders({ "Content-Type": "application/json" }) };

@Injectable({
  providedIn: 'root'
})
export class RoboService {
  url = environment.baseUrl + 'controlarobo';
  constructor(private http: HttpClient) { }

  getEstadosRobo(): Observable<Robo> {
    return this.http.get<Robo>(this.url);
  }

  setEstadosRobo(robo: Robo): Observable<Robo> {    
    return this.http.post<Robo>(this.url, robo, httpOptions)
    .pipe(
      retry(1),
      catchError(this.handleError)
    );
  }
  
  handleError(error) {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      // client-side error
      errorMessage = error.error.message;
    } else {
      // server-side error
      errorMessage = error.error;
    }

    if (window.confirm(errorMessage)) { 
      window.location.reload(); 
    } else {
      window.location.reload();
    }
    return throwError(errorMessage);
  }
}
