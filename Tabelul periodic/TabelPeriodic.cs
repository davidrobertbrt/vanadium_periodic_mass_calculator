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
    public partial class TabelPeriodic : UserControl
    {
        private List<EventHandler> events = null;

        public TabelPeriodic()
        {
            InitializeComponent();
        }

        private void TabelPeriodic_Load(object sender, EventArgs e)
        {
            LoadPreviewElement(1, Color.Black);
        }

        #region Button Design & Functionality

        public void PaintNrAtomic(Graphics g,string ID) => g.DrawString(ID, new Font("Segoe UI", 7f, FontStyle.Bold), new SolidBrush(Color.White), new PointF(5, 0));

        private void PaintOnBtn(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            PaintNrAtomic(e.Graphics, btn.Tag.ToString());

        }

        private void HoverOnBtn(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            pnlElement.BackColor = btn.BackColor;

            LoadPreviewElement(Convert.ToInt32(btn.Tag), btn.BackColor);
        }

        private void ClickOnBtn(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int ID = Convert.ToInt32(btn.Tag) - 1;

            Resource.elements[ID].LoadPreview(btn.BackColor);
        }


        #endregion

        #region Preview Element
        private void LoadPreviewElement(int ID, Color pnlColor)
        {
            var element = Resource.elements[ID - 1];

            pnlElement.BackColor = pnlColor;
            lbNrAtomic.Text = element.ID.ToString();
            lbSimbol.Text = element.simbol;
            lbNume.Text = element.nume;
            lbMatomica.Text = element.mAtomica.ToString();
        }

        #endregion


    }
}
