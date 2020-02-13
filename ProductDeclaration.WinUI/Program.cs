using ProductDeclaration.Core;
using ProductDeclaration.Core.DataAccess;
using ProductDeclaration.Core.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductDeclaration.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbConnection.InitializeConnections(DatabaseType.SqlServer);
            Application.Run(new ProductDeclarationForm(new DeclarationRepository()));
        }
    }
}
