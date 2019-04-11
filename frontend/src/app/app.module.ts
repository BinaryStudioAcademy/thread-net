import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { InterceptorsModule } from './interceptors-module/interceptors.module';
import { ComponentsModule } from './components-module/components.module';

@NgModule({
    declarations: [AppComponent],
    imports: [InterceptorsModule, ComponentsModule],
    bootstrap: [AppComponent]
})
export class AppModule {}
