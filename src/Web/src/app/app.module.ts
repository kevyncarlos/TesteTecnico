import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser'

import { NgxMaskModule } from 'ngx-mask';

import {MatToolbarModule} from '@angular/material/toolbar';
import {MatTableModule} from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import {MatCardModule} from '@angular/material/card';
import {MatDialogModule} from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatDatepickerModule} from '@angular/material/datepicker';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ClientService } from './Services/ClientService';
import { DeleteClientDialogComponent } from './components/delete-client-dialog/delete-client-dialog.component';
import { FormClientDialogComponent } from './components/form-client-dialog/form-client-dialog.component';
import { FormsModule } from '@angular/forms';
import { MatNativeDateModule } from '@angular/material/core';

@NgModule({
  declarations: [
    AppComponent,
    DeleteClientDialogComponent,
    FormClientDialogComponent
  ],
  imports: [
    FormsModule,
    BrowserModule, 
    HttpClientModule, 
    BrowserAnimationsModule, 
    MatToolbarModule, 
    MatTableModule, 
    MatButtonModule, 
    MatIconModule, 
    MatDividerModule, 
    MatCardModule, 
    MatDialogModule,
    NgxMaskModule.forRoot(),
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule
  ],
  providers: [ClientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
