using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKA_Inventario
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            if (isLogged == true)
            {
                Application.Run(new FormPrincipal());
            }
        }

        public static bool isLogged = false;
        public static string user { get; set; }

        public static bool ValidLogin(int cod_usuario, string usuario)
        {
            if (cod_usuario > 0)
            {
                user = usuario;
                isLogged = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
