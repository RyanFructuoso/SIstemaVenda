using SistemaVenda.model;
using SistemaVenda.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Controller
{
    internal class ProdutoControle
    {
        private ProdutoRepositorio repositorio;

        public ProdutoControle()
        {
            repositorio = new ProdutoRepositorio();
        }

        public bool criarProduto(Produto produto)
        {
            int cod_funcionario = Sessao.usuarioAutenticado.cod_funcionario;
            produto.cod_funcionario = cod_funcionario;

            produto.validar();
            // chamar a repository
            // fazer o cadastro
            repositorio.criarProduto(produto);

            return true;
        }

        public List<Produto> listarProdutos()
        {
            return repositorio.listarTodos();
        }

        public List<Produto> listarPorPagina(int qtd, int pagina)
        {
            return repositorio.listarPorPagina(qtd, pagina);
        }

        public int quantidadePaginas(int quantidadeItens)
        {
            int totalProdutos = repositorio.quantidadeProdutos();
            return (int)Math.Ceiling((decimal)totalProdutos / quantidadeItens);
        }

        public bool atualizar(Produto produto)
        {
            produto.validar();
            return repositorio.atualizar(produto);
        }

        public bool excluir(Produto produto)
        {
            return repositorio.excluir(produto.cod_produto);
        }
    }
}
