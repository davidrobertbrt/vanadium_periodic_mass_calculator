using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tabelul_periodic
{
    public partial class MainApp : Form
    {
        private Taskbar mainTaskbar = null;
        public MainApp()
        {
            InitializeComponent();
        }

        public void ReloadTaskbar(Taskbar x)
        { 
            if(mainTaskbar != null)
            {
                this.Controls.Remove(mainTaskbar);
                mainTaskbar = null;
            }

            x.Dock = DockStyle.Bottom;
            mainTaskbar = x;
            this.Controls.Add(mainTaskbar);
            
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void OpDespre_Click(object sender, EventArgs e)
        {
            new FrmDespre().ShowDialog();
        }

    }
}
