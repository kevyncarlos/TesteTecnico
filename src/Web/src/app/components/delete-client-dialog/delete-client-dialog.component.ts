import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Client } from 'src/app/Models/client';
import { ClientService } from 'src/app/Services/ClientService';

@Component({
  selector: 'app-delete-client-dialog',
  templateUrl: './delete-client-dialog.component.html'
})
export class DeleteClientDialogComponent implements OnInit {
  result: boolean = false;

  constructor(
    public dialogRef: MatDialogRef<DeleteClientDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public client: Client,
    public clientService: ClientService) { }

  ngOnInit(): void {
    
  }

  cancel() {
    this.dialogRef.close();
  }

  confirm() {
    this.clientService.delete(this.client.id).subscribe({
      next: (result) => this.result = result,
      error: (e) => console.error(e),
      complete: () => this.dialogRef.close(this.result)
    });
  }
}
