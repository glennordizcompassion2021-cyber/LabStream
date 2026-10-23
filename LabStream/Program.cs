using System;
using System.Windows.Forms;

namespace LabStream
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            FrmLab1 lab = new FrmLab1();
            lab.StartPosition = FormStartPosition.Manual;
            lab.Location = new System.Drawing.Point(30, 120);

            FrmRegistration registration = new FrmRegistration();

            Application.Run(new MultiFormContext(lab, registration));
        }
    }

    
    class MultiFormContext : ApplicationContext
    {
        private int openForms;

        public MultiFormContext(params Form[] forms)
        {
            foreach (Form form in forms)
            {
                openForms++;
                form.FormClosed += (sender, e) =>
                {
                    if (--openForms == 0)
                        ExitThread();
                };
                form.Show();
            }
        }
    }
}
