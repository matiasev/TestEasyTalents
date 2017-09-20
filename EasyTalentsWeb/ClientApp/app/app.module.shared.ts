import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ListaComponent } from './components/lista/lista.component';
import { EditarComponent } from "./components/editar/editar.component";
import { TalentService } from "./talent.service";
import { DetalheComponent } from "./components/detalhe/detalhe.component";


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        ListaComponent,
        HomeComponent,
        EditarComponent,
        DetalheComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'lista', component: ListaComponent },
            { path: 'lista/editar/:id', component: EditarComponent },
            { path: 'lista/detalhe/:id', component: DetalheComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [
        TalentService
    ]
})
export class AppModuleShared {
}
