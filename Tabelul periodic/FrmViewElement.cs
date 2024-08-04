using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabelul_periodic
{

    public partial class FrmVizElement : Form
    {
        private Bitmap drawArea;
        private Element ElementSelectat = null;
        private Color ribbonColor = Color.Empty;
        private List<int> ePerStrat;

        public FrmVizElement(Element selection, Color _color)
        {
            InitializeComponent();
            ElementSelectat = selection;
            ribbonColor = _color;

            drawArea = new Bitmap(picCfgElectronic.Width, picCfgElectronic.Height);
            ePerStrat = new List<int>() { 2, 8, 8, 18, 32, 32, 18, 8 };

        }

        private void FrmVizElement_Load(object sender, EventArgs e)
        {
            picCfgElectronic.Image = drawArea;

            LoadRibbon();
            LoadAtomice();
            LoadTermodinamice();
            LoadMaterial();
            LoadDrawing();
        }

        private void LoadRibbon()
        {
            pnlRibbon.BackColor = ribbonColor;
            lbRibbonMAtomica.Text = ElementSelectat.mAtomica.ToString();
            lbRibbonNrAtomic.Text = ElementSelectat.ID.ToString();
            lbRibbonNume.Text = ElementSelectat.nume.ToString();
            lbRibbonOxidare.Text = ElementSelectat.stariOxidari.ToString();
            lbRibbonDensitate.Text = ElementSelectat.densitate.ToString();

            if (ribbonColor == Color.Gray)
                lbTipElement.Text = "";
            else
                lbTipElement.Text = Resource.tipElemente[ribbonColor];
        }

        private void LoadAtomice()
        {
            lbMasaAtomica.Text = ElementSelectat.mAtomica.ToString();

            if (ElementSelectat.stariOxidari > 0)
                lbOxidare.Text = "+" + ElementSelectat.stariOxidari.ToString();
            else
                lbOxidare.Text = ElementSelectat.stariOxidari.ToString();

            lbConfElectronica.Text = ElementSelectat.cfgElectronica;
            lbRazaAtomica.Text = ElementSelectat.razaAtomica.ToString();

            if (ElementSelectat.razaCovalenta == int.MinValue)
                lbRazaCovalenta.Text = "N/A";
            else
                lbRazaCovalenta.Text = ElementSelectat.razaCovalenta.ToString();

        }

        private void LoadTermodinamice()
        {
            lbPctFierbere.Text = ElementSelectat.tempFierbere.ToString();
            lbPctTopire.Text = ElementSelectat.tempTopire.ToString();
            lbCalduraSpecifica.Text = ElementSelectat.tempSpecifica.ToString();
        }

        private void LoadMaterial()
        {
            lbDensitate.Text = ElementSelectat.densitate.ToString();
            lbVolumSpecific.Text = ElementSelectat.volumSpecific.ToString();
            lbConductivitateTermica.Text = ElementSelectat.conductTermica.ToString();
        }

        private void LoadDrawing()
        {
            DesenareNucleu();
            DesenareConfigElectronica();
        }

        private void DesenareNucleu()
        {
            var nucleus = new Strat(0, 25, drawArea);
            nucleus.DrawStrat(drawArea, ribbonColor);
        }

        private void DesenareConfigElectronica()
        {
            int nrElectroni = ElementSelectat.ID;
            ///int posUltimStrat = gasesteStratul();
            int raza = 75;
            int i = 0;
          

            while(nrElectroni - ePerStrat[i] >= 0 )
            {
                var strat = new Strat(ePerStrat[i], raza, drawArea);
                strat.DrawAll(drawArea);
                raza += 23;

                nrElectroni -= ePerStrat[i++];

            }
           
            if(nrElectroni > 0)
            {
                var strat = new Strat(nrElectroni, raza, drawArea);
                strat.DrawAll(drawArea);
            }
        }

        private void BtnWiki_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
