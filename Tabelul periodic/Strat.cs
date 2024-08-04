using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Tabelul_periodic
{
    class Strat
    {
        Rectangle supraf;
        public PointF origine;
        public float raza;
        public int nrElectroni;

        ///private List<Electron> electroni;

        public Strat(int _nrElectroni, float _raza,Bitmap drawArea)
        {
            supraf = new Rectangle(drawArea.Width / 2 - (int)_raza, drawArea.Height / 2 - (int)_raza, (int)_raza * 2, (int)_raza * 2);
            raza = _raza; nrElectroni = _nrElectroni;
            origine = new PointF(drawArea.Width / 2, drawArea.Height / 2);
            //electroni = new List<Electron>();
        }


        public void DrawStrat(Bitmap Area,Color culoare)
        {
            using (Graphics g = Graphics.FromImage(Area))
            {

                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                g.InterpolationMode = InterpolationMode.High;

                g.DrawEllipse(new Pen(Color.Black, 1.7f), supraf);

                if (culoare != null)
                    g.FillEllipse(new SolidBrush(culoare), supraf);

            }
        }

        public void DrawElectrons(Bitmap Area)
        {
            int ungAdd = 360 / nrElectroni;
            int ungCr = 0;

            for (int c = 0; c < nrElectroni; c++, ungCr += ungAdd)
            {
                
                var electronG = new Electron(this, ungCr);
                electronG.Draw(Area);

            }
        }

        public void DrawAll(Bitmap Area)
        {
            this.DrawStrat(Area,Color.Transparent);
            this.DrawElectrons(Area);
        }

    }
}
