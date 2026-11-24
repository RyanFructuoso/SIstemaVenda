using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SistemaVenda.controle
{
    internal class Relatorio
    {   
        public Document gerarNota()
        {
            var documento = Document.Create(conteudo => { // criando o documentos

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font => font.FontSize(10));

                // Repete em toda página
                pagina.Header().Column(coluna => {
                    coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                    coluna.Item().LineHorizontal(2);
                    coluna.Item().AlignCenter().Text("Silksong Supermercados").Bold();
                    coluna.Item().AlignCenter().Text("O abismo - 0000 - Sorocaba/SP").FontSize(5);
                    coluna.Item().LineHorizontal(0.5f);
                });


                pagina.Content();


                // Repete em toda página
                pagina.Footer().Column(coluna => {
                    coluna.Item().LineHorizontal(0.5f);
                    coluna.Item().Text("Data: 23/11/2026");
                    coluna.Item().Text("Compre mais");

                    coluna.Item().Text("Todos os produtos são de procedência duvidosa").FontSize(1);

                });

            }); 
        });
            documento.GeneratePdf("C:\\Users\\ryan.cfsilva\\Downloads\\Nota.pdf");

            return documento;
        }

        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog 
            {
                Title = "Salvar documento",
                FileName = "Nota.pdf",
                Filter = "PDF|*.pdf"
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);

            }
        }
    }
}
