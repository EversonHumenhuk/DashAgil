import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { AuthGuard } from './guards/auth.guards';
import { ErrorInterceptor } from './interceptors/error.interceptor';

@NgModule({
    imports: [HttpClientModule],
    providers: [
        AuthGuard,
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    ]
})
export class CoreModule {
}
