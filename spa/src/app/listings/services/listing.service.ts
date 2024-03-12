import { Injectable } from '@angular/core';
import { Observable, of, BehaviorSubject } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { Listing } from '../models/Listing';
import { AddListingReq } from '../models/AddListingReq';

@Injectable({
  providedIn: 'root'
})
export class ListingService {

  private listingUrl = 'https://op-demo-listings.azurewebsites.net/listings';
  private listingsUpdatedSource = new BehaviorSubject<Listing[]>([]);
  listingsUpdated$ = this.listingsUpdatedSource.asObservable();

  constructor(
    private http: HttpClient
  ) { }

  addListing(addListingReq: AddListingReq): Observable<any> {
    return this.http.post(`${this.listingUrl}`, addListingReq)
                      .pipe(
                        tap(() => this.refreshListings())
                      );
  }

  getListings(): Observable<Listing[]> {
    return this.http.get<Listing[]>(`${this.listingUrl}`)
      .pipe(
        tap(listings => this.listingsUpdatedSource.next(listings) ),
        catchError(this.handleError<Listing[]>('getListings', []))
      );
  }

  getListing(id: number): Observable<Listing> {
    return this.http.get<Listing>(`${this.listingUrl}/${id}`);
  }

  deleteListing(id: number): Observable<any> {
    return this.http.delete(`${this.listingUrl}/${id}`);
  }

  private refreshListings() {
    this.getListings().subscribe();
  }

  private log(message: string) {
    console.log(`ListingService: ${message}`);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  
}
