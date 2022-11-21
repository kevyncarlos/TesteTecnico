import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DeleteClientDialogComponent } from './components/delete-client-dialog/delete-client-dialog.component';
import { FormClientDialogComponent } from './components/form-client-dialog/form-client-dialog.component';
import { Client } from './Models/client';
import { ClientService } from './Services/ClientService';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  dataSource: Client[] = [];
  displayedColumns: string[] = ['id', 'name', 'birthDate', 'address', 'createdAt', 'updatedAt', 'actions'];

  constructor(public dialog: MatDialog, clientService: ClientService) {
    clientService.getAll().subscribe({
      next: (result) => { 
        this.dataSource = result 
      }
    });
  }

  deleteDialog(client: Client) {
    const dialogRef = this.dialog.open(DeleteClientDialogComponent, {
      data: client
    })

    dialogRef.afterClosed().subscribe({
      next: (result) => {
        if(result){
          window.location.reload();
        }
      }
    })
  }

  addDialog() {
    const dialogRef = this.dialog.open(FormClientDialogComponent)

    dialogRef.afterClosed().subscribe({
      next: (result) => {
        if(result){
          window.location.reload();
        }
      }
    })
  }

  editDialog(client: Client) {
    const dialogRef = this.dialog.open(FormClientDialogComponent, {
      data: client.id
    })

    dialogRef.afterClosed().subscribe({
      next: (result) => {
        if(result){
          window.location.reload();
        }
      }
    })
  }

  title = 'Web';
}