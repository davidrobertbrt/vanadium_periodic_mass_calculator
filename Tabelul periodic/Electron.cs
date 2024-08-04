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
    class Electron
    {
        Rectangle supraf;
        public float raza = 10;
        public float unghi;
        Strat posStrat;


        public Electron(Strat _posStrat,float _unghi)
        {
            supraf = new Rectangle(0, 0, 20, 20);
            unghi = _unghi;
            posStrat = _posStrat;
        }

        public void Draw(Bitmap Area)
        {
            var pointCalc = PointF.Empty;
            var origine = posStrat.origine;
            var razaStr = posStrat.raza;


            pointCalc.X = (float)(origine.X + (razaStr * Math.Cos(unghi * Math.PI / 180)));
            pointCalc.Y = (float)(origine.Y + (razaStr * Math.Sin(unghi * Math.PI / 180)));

            supraf.X = (int)pointCalc.X - (int)raza;
            supraf.Y = (int)pointCalc.Y - (int)raza;


            using (Graphics g = Graphics.FromImage(Area))
            {
                Color culoareExt = Color.FromArgb(128, 149, 170);
                Color culoareInt = Color.FromArgb(194, 206, 224);

                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                g.InterpolationMode = InterpolationMode.High;

                g.DrawEllipse(new Pen(culoareExt, 3f), supraf);
                g.FillEllipse(new SolidBrush(culoareInt), supraf);
                ///g.DrawEllipse(new Pen(Color.Black, 3f), supraf);
            }
        }

    }
}
