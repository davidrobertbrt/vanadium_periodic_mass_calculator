using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tabelul_periodic
{
    static class Resource
    {
        public static List<Element> elements = new List<Element>();

        public static List<string> popularFormulas = new List<string>();

        public static MainApp mainApp = null;

        public static Dictionary<Color, string> tipElemente = new Dictionary<Color, string>()
        {
            {Color.Goldenrod, "Lantanide" },
            {Color.SkyBlue, "Metale alcaline"},
            {Color.LimeGreen, "Metale de tranzitie"},
            {Color.Black, "Nemetale" },
            {Color.DarkGreen, "Metale post-tranziționale" },
            {Color.Olive, "Actinide"},
            {Color.RoyalBlue, "Metale alcalino-pământoase" },
            {Color.DarkOrange, "Metaloizi"},
            {Color.HotPink, "Halogeni" },
            {Color.Crimson, "Gaze nobile" }
            
        };

        public static float FindMolecularMass(string symbol)
        {
            if (symbol.Length <= 2)
                return elements.Find(x => x.simbol == symbol).mAtomica;
            else
                return -1;
        }

    }
}
