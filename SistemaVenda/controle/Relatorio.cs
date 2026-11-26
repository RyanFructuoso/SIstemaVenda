using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SistemaVenda.Controller;
using SistemaVenda.model;
using SistemaVenda.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace SistemaVenda.controle
{
    internal class Relatorio
    {
        //private FuncionarioControle controller;
        public Document gerarNota(List<Item> itens)
        {
            //controller = new FuncionarioControle();
            //Funcionario? funcionario = controller.usuarioAutenticado();
            //string nome = (funcionario != null) ? funcionario.nome : "";

            DateTime data = DateTime.Now;

            var documento = Document.Create(conteudo => { // criando o documentos

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font => font.FontSize(10));

                // Repete em toda página
                pagina.Header().Column(coluna => {
                    coluna.Item().AlignCenter().Text("Silksong Supermercados").Bold();
                    coluna.Item().AlignCenter().Text("CNPJ 94.892.371/0615-82").FontSize(4);
                    coluna.Item().PaddingBottom(10).AlignCenter().Text("O abismo - 0000 - Sorocaba/SP").FontSize(5);
                    coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                    coluna.Item().LineHorizontal(2);
                    coluna.Item().LineHorizontal(0.5f);
                });

                // Conteudo principal
                pagina.Content().Column(coluna =>
                {
                    // Cabeçario dos itens
                    coluna.Item().Row(linha =>
                    {
                        linha.RelativeItem().Text("Item").FontSize(8);
                        linha.RelativeItem(3).Text("Descrição").FontSize(8);
                        linha.RelativeItem().Text("QTD").FontSize(8);
                        linha.RelativeItem().Text("Preço").FontSize(8);
                        linha.RelativeItem().Text("Total").FontSize(8).AlignRight();
                    });
                    coluna.Item().LineHorizontal(0.5f);

                    // Os itens descritos
                    for (int i = 0; i < itens.Count; i++)
                    {
                        Item item = itens[i];

                        coluna.Item().Row(linha =>
                        {
                            linha.ConstantItem(20).Text($"{i + 1}").FontSize(8);
                            linha.RelativeItem(3).Text(item.nomeProduto).FontSize(8);
                            linha.ConstantItem(20).Text(item.quantidade).FontSize(8);
                            linha.RelativeItem().Text($"{item.precoReal:C2}").FontSize(8);
                            linha.RelativeItem().AlignRight().Text($"{item.subTotal:C2}").FontSize(8);
                        });
                    }
                    coluna.Item().LineHorizontal(0.5f);

                    coluna.Item().Row(linha =>
                    {
                        decimal total = itens.Sum(item => item.subTotal);
                        linha.RelativeItem().Text("Total").FontSize(8);
                        linha.RelativeItem().AlignRight().Text($"{total:C2}").FontSize(8);
                    });
                });


                // Repete em toda página
                pagina.Footer().Column(coluna => {
                    coluna.Item().LineHorizontal(0.5f);
                    coluna.Item().Text($"Funcionário:");
                    coluna.Item().Text($"Data: {data:dd/MM/yyyy HH:mm:ss} ");
                    coluna.Item().Text("Volte sempre!!!");

                    coluna.Item().Text("Todos os produtos são de procedência duvidosa").FontSize(1);

                });

            }); 
        });
            documento.GeneratePdf("C:\\Users\\ryan.cfsilva\\Downloads\\Nota.pdf");

            return documento;
        }

        public void salvarPdf(Document documento)
        {
            //var dialogo = new SaveFileDialog 
            //{
            //    Title = "Salvar Documento",
            //    FileName = "Nota.pdf",
            //    Filter = "(PDF)|*.pdf"
            //};
            //if (dialogo.ShowDialog() == DialogResult.OK)
            //{

            //}

            string pasta = Path.GetTempPath();

            string nomeArquivo = $"doc_{Guid.NewGuid()}.pdf";

            string caminho = Path.Combine(pasta, nomeArquivo);

            documento.GeneratePdf(caminho);

            // Abre o documento
            Process.Start( new ProcessStartInfo
            {
                FileName = caminho,
                    UseShellExecute = true
            });
        }
    }
}
