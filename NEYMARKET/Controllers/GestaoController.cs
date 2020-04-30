using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NEYMARKET.Data;
using NEYMARKET.DTO;

namespace NEYMARKET.Controllers
{
    public class GestaoController : Controller
    {

    private readonly ApplicationDbContext database;

    public GestaoController(ApplicationDbContext database){
            this.database = database;
        }

     public IActionResult Index(){
         return View(); 
     }

     public IActionResult Categorias(){
            var categorias = database.Categorias.Where(cat => cat.Status == true).ToList();
            return View(categorias);
     }

     public IActionResult NovaCategoria(){
         return View();

    }

    public IActionResult EditarCategoria(int id){
        var categoria = database.Categorias.First(cat => cat.Id == id);
        CategoriaDTO categoriaView= new CategoriaDTO();
        categoriaView.Id = categoria.Id;
        categoriaView.Nome = categoria.Nome;

        return View(categoriaView);
    }

    public IActionResult Fornecedores(){
        var Fornecedores = database.Fornecedores.Where(forne => forne.Status == true).ToList();
            return View(Fornecedores);
     }

     public IActionResult NovoFornecedor(){
         return View();

    }

    public IActionResult EditarFornecedor(int id){
        var fornecedor = database.Fornecedores.First(forne => forne.Id == id);
         FornecedorDTO fornecedorView= new FornecedorDTO();
         fornecedorView.Id = fornecedor.Id;
         fornecedorView.Nome = fornecedor.Nome;
         fornecedorView.Email = fornecedor.Email;
         fornecedorView.Telefone = fornecedor.Telefone;
         
         return View(fornecedorView);

         
    }

    public IActionResult Produtos(){
        var Produtos = database.Produtos.Include(p => p.Categoria).Include(p => p.Fornecedor).Where(p => p.Status == true).ToList();
            return View(Produtos);
     }

     public IActionResult NovoProduto(){
         ViewBag.Categorias = database.Categorias.ToList();
         ViewBag.Fornecedores = database.Fornecedores.ToList();
         return View();
     
     }

     public IActionResult EditarProduto(int id){
        var produto = database.Produtos.Include(p => p.Categoria).Include(p => p.Fornecedor).ToList().First(p => p.Id == id);
         ProdutoDTO produtoView = new ProdutoDTO();
         produtoView.Id = produto.Id;
         produtoView.Nome = produto.Nome;
         produtoView.PrecoDeCusto = produto.PrecoDeCusto;
         produtoView.PrecoDeVenda = produto.PrecoDeVenda;
         produtoView.CategoriaID = produto.Categoria.Id;
         produtoView.FornecedorID = produto.Fornecedor.Id;
         produtoView.Medicao = produto.Medicao;
         ViewBag.Categorias = database.Categorias.ToList();
         ViewBag.Fornecedores = database.Fornecedores.ToList();
         
         return View(produtoView);

    }

     public IActionResult Promocoes(){
         var promocoes = database.Promocoes.Include(p => p.Produto).Where(i => i.Status == true).ToList();
         return View(promocoes);
     }

     public IActionResult NovaPromocao(){
         ViewBag.Produtos = database.Produtos.ToList();
        return View();
     }

    }
}