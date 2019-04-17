import { NgModule } from '@angular/core';
import { AuthDialogComponent } from './auth-dialog.component';
import { MaterialComponentsModule } from '../common/material-components.module';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@NgModule({
    declarations: [AuthDialogComponent],
    imports: [MaterialComponentsModule, CommonModule, FormsModule],
    entryComponents: [AuthDialogComponent]
})
export class AuthDialogModule {}
