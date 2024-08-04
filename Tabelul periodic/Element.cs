using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Tabelul_periodic
{
    public class Element
    {
        public int ID, stariOxidari;
        public float mAtomica, densitate, tempTopire, tempFierbere, conductTermica, volumSpecific, tempSpecifica,razaAtomica,razaCovalenta;
        public string nume, simbol, valenta, cfgElectronica;

        public Element(int _ID, string _nume, string _simbol,float _mAtomica, float _densitate, float _tempTopire, float _tempFierbere,float _volumSpecific, float _tempSpecifica ,float _conductTermica, string _cfgElectronica, int _stariOxidari, float _razaAtomica, float _razaCovalenta)
        {
            ID = _ID; stariOxidari = _stariOxidari; razaAtomica = _razaAtomica; razaCovalenta = _razaCovalenta;
            mAtomica = _mAtomica; densitate = _densitate; tempTopire = _tempTopire; tempFierbere = _tempFierbere; conductTermica = _conductTermica;
            nume = _nume; simbol = _simbol; valenta = ""; cfgElectronica = _cfgElectronica;
            volumSpecific = _volumSpecific;
            tempSpecifica = _tempSpecifica;

        }

        

        public void LoadPreview(Color btnColor)
        {
            ///neaparat sa scap de chestia asta cu culoarea. pune mana si baga in fisier si ce tip de element e fiecare...
            new FrmVizElement(this, btnColor).Show();
        }
    }
}
