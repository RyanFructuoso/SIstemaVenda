using SistemaVenda.controle;
using SistemaVenda.View;
using QuestPDF.Infrastructure;

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
        //relatorio.salvarPdf();

        while (true)
        {
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    break;
                }
            }
            using (frmPrimary primary = new frmPrimary())
            {
                Application.Run(primary);
                if (primary.DialogResult != DialogResult.Retry)
                {
                    break;
                }
            }
        }
    }
}