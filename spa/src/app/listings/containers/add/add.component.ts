import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

import { AddListingReq } from '../../models/AddListingReq';
import { ListingService } from '../../services/listing.service';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  form!: FormGroup;

  currentYear = new Date().getFullYear();
  years: number[] = [];

  constructor(
    private dialogRef: MatDialogRef<AddComponent>,
    private listingService: ListingService
  ) 
  {
    for (let i = this.currentYear; i >= 1900; i--) {
      this.years.push(i);
    }
  }
  
  ngOnInit() {
    this.form = new FormGroup({
      price: new FormControl('', Validators.required),
      bathrooms: new FormControl('', Validators.required),
      halfBathrooms: new FormControl(''),
      bedrooms: new FormControl('', Validators.required),
      yearBuilt: new FormControl('', Validators.required),
      address: new FormControl('', Validators.required),
      photoUrl: new FormControl('', Validators.required),
      latitude: new FormControl('', Validators.required),
      longitude: new FormControl('', Validators.required)
    });
  }

  onSubmit() {
    if (this.form.invalid) {
      return;
    }

    const addListingReq: AddListingReq = {
      price: this.form.value.price,
      bathrooms: this.form.value.bathrooms,
      halfBathrooms: this.form.value.halfBathrooms,
      bedrooms: this.form.value.bedrooms,
      yearBuilt: this.form.value.yearBuilt,
      address: this.form.value.address,
      photoUrl: this.form.value.photoUrl,
      latitude: this.form.value.latitude,
      longitude: this.form.value.longitude
    };

    this.listingService.addListing(addListingReq).subscribe(() => {
      console.log('Listing added');
      this.listingService.getListings().subscribe(() => {
        console.log('Listings updated');
        this.dialogRef.close(true);
      });
      
    });
  }
}
