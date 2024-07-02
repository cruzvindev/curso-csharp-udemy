
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ4;

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }   
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string? Categoria { get; set; }

    public static List<Produto> GetProdutos()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Laptop", Preco = 2500.00, Estoque = 50, Categoria = "Eletrônicos" },
            new Produto { Id = 2, Nome = "Smartphone", Preco = 1500.00, Estoque = 200, Categoria = "Eletrônicos" },
            new Produto { Id = 3, Nome = "Televisão", Preco = 1800.00, Estoque = 75, Categoria = "Eletrônicos" },
            new Produto { Id = 4, Nome = "Geladeira", Preco = 3200.00, Estoque = 30, Categoria = "Eletrodomésticos" },
            new Produto { Id = 5, Nome = "Micro-ondas", Preco = 400.00, Estoque = 100, Categoria = "Eletrodomésticos" },
            new Produto { Id = 6, Nome = "Cafeteira", Preco = 150.00, Estoque = 200, Categoria = "Eletrodomésticos" },
            new Produto { Id = 7, Nome = "Sofá", Preco = 1200.00, Estoque = 4, Categoria = "Móveis" },
            new Produto { Id = 8, Nome = "Mesa de Jantar", Preco = 900.00, Estoque = 20, Categoria = "Móveis" },
            new Produto { Id = 9, Nome = "Cadeira", Preco = 200.00, Estoque = 2, Categoria = "Móveis" },
            new Produto { Id = 10, Nome = "Furadeira", Preco = 300.00, Estoque = 80, Categoria = "Ferramentas" },
            new Produto { Id = 11, Nome = "Serra Elétrica", Preco = 600.00, Estoque = 40, Categoria = "Ferramentas" },
            new Produto { Id = 12, Nome = "Martelo", Preco = 50.00, Estoque = 5, Categoria = "Ferramentas" },
            new Produto { Id = 13, Nome = "T-shirt", Preco = 40.00, Estoque = 300, Categoria = "Roupas" },
            new Produto { Id = 14, Nome = "Jeans", Preco = 120.00, Estoque = 150, Categoria = "Roupas" },
            new Produto { Id = 15, Nome = "Jaqueta", Preco = 250.00, Estoque = 100, Categoria = "Roupas" },
            new Produto { Id = 16, Nome = "Tênis", Preco = 350.00, Estoque = 4, Categoria = "Calçados" },
            new Produto { Id = 17, Nome = "Bota", Preco = 450.00, Estoque = 90, Categoria = "Calçados" },
            new Produto { Id = 18, Nome = "Sandália", Preco = 100.00, Estoque = 200, Categoria = "Calçados" },
            new Produto { Id = 19, Nome = "Shampoo", Preco = 30.00, Estoque = 300, Categoria = "Higiene" },
            new Produto { Id = 20, Nome = "Sabonete", Preco = 5.00, Estoque = 500, Categoria = "Higiene" },
            new Produto { Id = 14, Nome = "Jeans", Preco = 150.00, Estoque = 10, Categoria = "Roupas" },
        };

        return produtos;
    }
}
