import { Categoria } from './../../../../models/categoria';
import { CategoriaService } from './../../../../services/categoria.service';
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Produto } from "src/app/models/produto";
import { ProdutoService } from "src/app/services/produto.service";

@Component({
    selector: "app-cadastrar-produto",
    templateUrl: "./cadastrar-produto.component.html",
    styleUrls: ["./cadastrar-produto.component.css"],
})
export class CadastrarProdutoComponent implements OnInit {
    //serve para vincular os inputs do form html
    nome!: string;
    descricao!: string;
    quantidade!: number;
    preco!: number;
    categorias!: Categoria[];
    categoriaId!: number;

    constructor(private produtoService: ProdutoService, private categoriaService: CategoriaService, private router: Router) {}

    ngOnInit(): void {
        this.categoriaService.list().subscribe((categorias) => {
            this.categorias = categorias;
        });
    }

    create(): void {
        //sempre quando for intanciar um objeto dentro de um método tem que usar o let ou o const
        let produto: Produto = {
            nome: this.nome,
            descricao: this.descricao,
            quantidade: this.quantidade,
            preco: this.preco,
            categoriaId: this.categoriaId,
        };
        this.produtoService.create(produto).subscribe((produto) => {
            this.router.navigate(["produto/listar"]); //o navigate pe
        },
        (error) => {});
    }
}