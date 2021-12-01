import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CarrinhoComponent } from "./components/views/home/carrinho/carrinho.component";
import { IndexComponent } from "./components/views/home/index/index.component";
import { CadastrarProdutoComponent } from "./components/views/produto/cadastrar-produto/cadastrar-produto.component";
import { ListarProdutoComponent } from "./components/views/produto/listar-produto/listar-produto.component";
import { CreateVendaComponent } from "./components/views/venda/create-venda/create-venda.component";
import { ListVendaComponent } from "./components/views/venda/list-venda/list-venda.component";


const routes: Routes = [
    {
        path: "",
        component: IndexComponent,
    },
    {
        path: "home/carrinho",
        component: CarrinhoComponent,
    },
    {
        path: "produto/listar",
        component: ListarProdutoComponent,
    },
    {
        path: "produto/cadastrar",
        component: CadastrarProdutoComponent,
    },
    {
        path: "venda/cadastrar",
        component: CreateVendaComponent
    },
    {
        path: "venda/listar",
        component: ListVendaComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}
