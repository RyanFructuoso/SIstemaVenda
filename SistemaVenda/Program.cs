using SistemaVenda.View;

namespace SistemaVenda;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        
        ApplicationConfiguration.Initialize();
        //Application.Run(new frmCadastroProduto());

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