using SistemaVenda.controle;
using SistemaVenda.View;
using QuestPDF.Infrastructure;
using SistemaVenda.model;

namespace SistemaVenda;

internal static class Program
{
    [STAThread]
    static void Main()
    {

        QuestPDF.Settings.License = LicenseType.Community;

        ApplicationConfiguration.Initialize();
        //Application.Run(new frmCadastroProduto());
        //Relatorio relatorio = new Relatorio();
        //List<Item> itens = new List<Item>();
        //itens.Add(
        //    new Item
        //    {
        //        nomeProduto = "Pera",
        //        preco = 350,
        //        quantidade = 4
        //    }
        //);
        //var documento = relatorio.gerarNota(itens);
        //relatorio.salvarPdf(documento);

        while (true)
        {
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    break;
                }
            }
            using (frmPrincipal principal = new frmPrincipal())
            {
                Application.Run(principal);
                if (principal.DialogResult != DialogResult.Retry)
                {
                    break;
                }
            }
        }
    }
}