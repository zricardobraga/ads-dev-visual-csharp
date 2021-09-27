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

    constructor(private service: ProdutoService, private router: Router) {}

    ngOnInit(): void {}

    create(): void {
        //sempre quando for intanciar um objeto dentro de um método tem que usar o let ou o const
        let produto: Produto = {
            nome: this.nome,
            descricao: this.descricao,
            quantidade: this.quantidade,
            preco: this.preco,
        };
        this.service.create(produto).subscribe((produto) => {
            this.router.navigate(["produto/listar"]); //o navigate pe
        },
        (error) => {});
    }
}