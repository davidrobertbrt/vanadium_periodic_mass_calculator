using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabelul_periodic
{
    public partial class TabBar : UserControl
    {
        private List<Control> activeTabs = null;
        private int nrTab = 0;
        public Control focusedTab = null;

        private readonly Point tabLocation = new Point(0,49);

        private readonly Image imgTabel = global::Tabelul_periodic.Properties.Resources.masa_moleculara_frm;
        private readonly Image imgMolec = global::Tabelul_periodic.Properties.Resources.formule_32px;
        private readonly Image imgNesaturare = global::Tabelul_periodic.Properties.Resources.grad_de_nesaturare;


        public TabBar()
        {
            InitializeComponent();

            activeTabs = new List<Control>();
        }

        private void TabBar_Load(object sender, EventArgs e)
        { 
            LoadInitialTabs();
        }

        private void LoadInitialTabs()
        {
            NewGradNesat_Click(null, null);
            NewMasaMolec_Click(null, null);
            NewTabelPeriodic_Click(null, null);
        }

        private void LoadTab(Control comp)
        {
            if (focusedTab != null)
                Resource.mainApp.pnlView.Controls.Remove(focusedTab);

            focusedTab = comp;
            focusedTab.Dock = DockStyle.Fill; 
            focusedTab.Location = tabLocation;

            Resource.mainApp.pnlView.Controls.Add(focusedTab);
            Resource.mainApp.ReloadTaskbar(new Taskbar());
        }

        private void SelectTab(object sender, EventArgs e)
        {
            var btn = (RadioButton)sender;

            if (btn.Checked == true)
                LoadTab(activeTabs[pnlSelector.Controls.IndexOf(btn)]);
        
        }

        private void RemoveTab(int index, bool active)
        {

            if (nrTab == 1)
            {
                Application.Exit();
                return;
            }

            if(active == true)
            {
                RadioButton btn;

                if (index - 1 < 0)
                    btn = (RadioButton)this.pnlSelector.Controls[index + 1];
                else
                    btn = (RadioButton)this.pnlSelector.Controls[index - 1];

                btn.PerformClick();
            }

            this.pnlSelector.Controls.RemoveAt(index);
            activeTabs.RemoveAt(index);
            nrTab--;
        }

        private void LoadTabButton(Image img, int corespTab)
        {
            var btn = new RadioButton();

            btn.Appearance = Appearance.Button;
            btn.Dock = DockStyle.Left;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Image = img;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.Margin = new Padding(4);
            btn.Size = new Size(60, 60);
            btn.Tag = corespTab;
            btn.CheckedChanged += new EventHandler(SelectTab);
            btn.MouseUp += TabUserAction;

            this.pnlSelector.Controls.Add(btn);
            btn.PerformClick();
        }

        private void TabUserAction(object sender, MouseEventArgs e)
        {
            var btn = (RadioButton)sender;

            if (e.Button == MouseButtons.Right)
                RemoveTab(pnlSelector.Controls.IndexOf(btn), btn.Checked);
            else
                btn.Checked = true;
        }

        private void NewTabelPeriodic_Click(object sender, EventArgs e)
        {
            activeTabs.Add(new TabelPeriodic());
            LoadTabButton(imgTabel, nrTab++);
        }

        private void NewMasaMolec_Click(object sender, EventArgs e)
        {
            activeTabs.Add(new CalculatorMasaMoleculara());
            LoadTabButton(imgMolec, nrTab++);
        }

        private void NewGradNesat_Click(object sender, EventArgs e)
        {
            activeTabs.Add(new CalculatorGradNesaturare());
            LoadTabButton(imgNesaturare, nrTab++);
        }


    }
}
