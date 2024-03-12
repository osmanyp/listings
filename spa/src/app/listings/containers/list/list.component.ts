import { Component, ViewChild, viewChild } from '@angular/core';
import { Listing } from '../../models/Listing';
import { ListingService } from '../../services/listing.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.css'
})
export class ListComponent {
  dataSource! : MatTableDataSource<Listing>;
  displayedColumns: string[] = ['id', 'price', 'bedrooms', 'address', 'photoUrl', 'actions'];

  private listingsSubscription: Subscription | undefined;;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private listingService: ListingService
    ) { }
  
  ngOnInit() {
    this.getListings();
  }

  ngOnDestroy() {
    this.listingsSubscription?.unsubscribe();
  } 

  getListings() {
    this.listingsSubscription = this.listingService.listingsUpdated$.subscribe((listings) => {
      this.dataSource = new MatTableDataSource(listings);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });

    this.listingService.getListings().subscribe();
  }

  openDeleteDialog(id: number) {
    this.deleteListing(id);
  }

  deleteListing(id: number) {
    this.listingService.deleteListing(id).subscribe(() => {
      this.getListings();
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    } 
  }
}
