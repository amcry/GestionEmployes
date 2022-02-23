using GestionEmploye.Common;
using GestionEmploye.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.WinForms
{
    static class Program
    {
        private static readonly EmployeContext _context = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void AjoutEmploye(params string[] noms)
        {
            foreach (var nom in noms)
            {
                _context.Employes.Add(new Employe { Nom = nom });
                
            }

            _context.SaveChanges();
        }

        
    }
}
