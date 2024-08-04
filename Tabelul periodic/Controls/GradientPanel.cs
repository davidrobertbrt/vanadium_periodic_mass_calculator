using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Tabelul_periodic.Controls
{
    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush bGradient = new LinearGradientBrush(this.ClientRectangle,this.ColorTop,this.ColorBottom,90);

            using (Graphics g = e.Graphics)
                g.FillRectangle(bGradient, this.ClientRectangle);

            base.OnPaint(e);
        }

    }
}
