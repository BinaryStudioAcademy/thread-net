import { NgModule } from '@angular/core';
import { MaterialComponentsModule } from '../common/material-components.module';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';

@NgModule({
    declarations: [HomeComponent],
    imports: [MaterialComponentsModule, CommonModule, FormsModule]
})
export class HomeModule {}
