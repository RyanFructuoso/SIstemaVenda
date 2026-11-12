using SistemaVenda.model;
using SistemaVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Controller
{
    internal class ProductController
    {
        private ProductRepository repository;

        public ProductController()
        {
            repository = new ProductRepository();
        }

        public bool createProduct(Product product)
        {
            int cod_funcionario = Session.userAuth.cod_funcionario;
            product.cod_funcionario = cod_funcionario;

            product.validar();
            // chamar a repository
            // fazer o cadastro
            repository.createProduct(product);

            return true;
        }

        public List<Product> listarProdutos()
        {
            return repository.getAll();
        }

        public List<Product> listarPorPagina(int qtd, int pagina)
        {
            return repository.listarPorPagina(qtd, pagina);
        }

        public int quantidadePaginas(int quantidadeItens)
        {
            int totalProdutos = repository.quantidadeProdutos();
            return (int)Math.Ceiling((decimal)totalProdutos / quantidadeItens);
        }

        public bool atualizar(Product product)
        {
            product.validar();
            return repository.atualizar(product);
        }

        public bool excluir(Product product)
        {
            return repository.excluir(product.cod_produto);
        }
    }
}
