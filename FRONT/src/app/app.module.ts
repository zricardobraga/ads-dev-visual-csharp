import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from "@angular/common/http";
import { ListarProdutoComponent } from './components/views/produto/listar-produto/listar-produto.component';
import { CadastrarProdutoComponent } from './components/views/produto/cadastrar-produto/cadastrar-produto.component'; 

@NgModule({
  declarations: [
    AppComponent,
    ListarProdutoComponent,
    CadastrarProdutoComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
