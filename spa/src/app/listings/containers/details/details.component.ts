import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { ListingService } from '../../services/listing.service';
import { Listing } from '../../models/Listing';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrl: './details.component.css'
})
export class DetailsComponent {
  listing?: Listing;

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private listingService: ListingService
  ) { }

  getListing() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.listingService.getListing(id).subscribe((listing) => {
      this.listing = listing;
    });
  }

  ngOnInit() {
    this.getListing();
  }

  goBack(): void {
    this.location.back();
  }
}
