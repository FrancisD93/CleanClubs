import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClubListComponent } from './club-list/club-list.component';
import { ClubsRoutingModule } from './clubs-routing.module';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
//import { MatDialog } from '@angular/material/dialog';
import { ClubAddComponent } from './dialogs/add/club-add.component';
import { MatIcon, MatIconModule } from '@angular/material/icon';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ClubEditComponent } from './dialogs/edit/club-edit.component';

@NgModule({
    declarations: [ClubListComponent, ClubAddComponent, ClubEditComponent],
    imports: [
        CommonModule,
        MatTableModule,
        MatDialogModule,
        MatPaginatorModule,
        MatIconModule,
        MatButtonModule,
        MatSlideToggleModule,
        MatCheckboxModule,
        ClubsRoutingModule,
        FormsModule,
        MatFormFieldModule,
        ReactiveFormsModule,
    ],
    exports: [ClubListComponent],
    entryComponents: [ClubAddComponent, ClubEditComponent],
})
export class ClubsModule {}