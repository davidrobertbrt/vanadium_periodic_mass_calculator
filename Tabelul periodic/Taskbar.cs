using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tabelul_periodic
{
    public partial class Taskbar : UserControl
    {

        public Taskbar()
        {
            InitializeComponent();
        }

        public void LoadActions(Control tab)
        {
            if(tab.Tag != null)
                LoadQuickButtons((Dictionary < Image, EventHandler > )tab.Tag);
        }

        private void LoadQuickButtons(Dictionary <Image,EventHandler> actions)
        {
            foreach (var action in actions)
            {
                var btn = new Button();
                btn.Dock = DockStyle.Right;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Image = action.Key;
                btn.Click += action.Value;
                btn.UseVisualStyleBackColor = true;

                this.Controls.Add(btn);
            }

        }



        #region Other Options Menu EVENTS
        private void OpDespre_Click(object sender, EventArgs e)
        {
            new FrmDespre().ShowDialog();
        }

        #endregion

        private void Taskbar_Load(object sender, EventArgs e)
        {
            LoadActions(Resource.mainApp.tabBar1.focusedTab);
        }

        private void CentruDeAjutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://trello.com/b/bbOBTLwn/beta-program");

        }
    }
}
