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
            int id_funcionario = Session.userAuth.id_funcionario;
            product.id_funcionario = id_funcionario;

            // chamar a repository

            repository.createProduct(product);

            return true;
        }

        public List<Product> getAll()
        {
            return repository.getAll();
        }

        public bool atualizar(Product product)
        {
            return repository.atualizar(product);
        }

        public bool excluir(Product product)
        {
            return repository.excluir(product.id_produto);
        }
    }
}
