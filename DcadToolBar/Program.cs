using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcadToolBar
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ToolBarForm());
            }
            catch (Exception e)
            {
                File.AppendAllLines(@"\\serv-kalysse\EDatas\Dev\Datas\ToolBarDcad\toolbar_log.txt", new List<string>
                {
                    "[" + DateTime.Now + "] ",
                    e.Message,
                    e.StackTrace
                });
            }
        }
    }
}
