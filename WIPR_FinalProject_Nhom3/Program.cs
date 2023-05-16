using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginFrm = new LoginForm();

            if (loginFrm.ShowDialog() == DialogResult.OK)
            {
                MainFormStaff mainFrm = new MainFormStaff();
                Application.Run(mainFrm);
            }

            //AddVehicleForm addVehicle = new AddVehicleForm();
            //Application.Run(addVehicle);
        }
    }
}
