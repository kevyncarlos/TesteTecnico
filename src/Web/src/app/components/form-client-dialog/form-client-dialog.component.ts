import { Component, Inject, Input, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Client } from 'src/app/Models/client';
import { ClientService } from 'src/app/Services/ClientService';

@Component({
  selector: 'app-form-client-dialog',
  templateUrl: './form-client-dialog.component.html',
  styleUrls: ['./form-client-dialog.component.css']
})
export class FormClientDialogComponent implements OnInit {
  title: string = 'Add Client';
  result: boolean = false;
  @Input() client: Client = {} as Client;

  constructor(
    public dialogRef: MatDialogRef<FormClientDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public clientId: number,
    public clientService: ClientService
  ) { }

  ngOnInit(): void {
    if(this.clientId) {
      this.title = 'Update Client: ' + this.clientId;
      this.clientService.getById(this.clientId).subscribe({
        next: (result) => this.client = result
      })
    }
  }

  save() {
    if(this.clientId) {
      this.clientService.put(this.client).subscribe({
        next: (result) => this.result = result != null,
        error: (e) => console.error(e),
        complete: () => this.dialogRef.close(this.result)
      });
    } else {
      this.clientService.post(this.client).subscribe({
        next: (result) => this.result = result != null,
        error: (e) => console.error(e),
        complete: () => this.dialogRef.close(this.result)
      });
    }
  }

}
