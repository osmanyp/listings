import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

import { AddComponent } from './listings/containers/add/add.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  
  constructor(
    private dialog: MatDialog
  ) {

  }

  openAddListingDialog(): void {
    var dialogRef = this.dialog.open(AddComponent, {
      width: '500px'
    });

    dialogRef.afterClosed().subscribe(() => {
      console.log('The dialog was closed');
    });
  }

}
