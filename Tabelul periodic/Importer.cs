using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tabelul_periodic
{
    static class Importer
    {
        /// <summary>
        /// http://pastebin.com/raw/CKwm136x
        /// </summary>


        private static string ElementsPath = Application.StartupPath + "\\elemente.txt";
        private static string FormulasPath = Application.StartupPath + "\\popularFormulas.txt";
        private static string[] entries;

        public static void LoadDB()
        {
            LoadElementsDB();
            LoadPopularFormulas();
        }

        private static float RemoveGarbageText(string input)
        {
            float test;
            var entries = input.TrimStart(' ').Split(' ');

            if (String.IsNullOrWhiteSpace(entries[0]))
                return float.MinValue;
            else
            {
                if (float.TryParse(entries[0], out test))
                    return float.Parse(entries[0]);
                else
                    return float.MinValue;
            }
        }

        private static float GetValueNotNull(string input)
        {
            float test;

            if (String.IsNullOrWhiteSpace(input) && !float.TryParse(input, out test))
                return float.MinValue;
            else
            {
                if (float.TryParse(input, out test))
                    return float.Parse(input);
                else
                    return float.MinValue;
            }   
            
        }

        private static void LoadElementsDB()
        {
            using (StreamReader fin = new StreamReader(ElementsPath))
            {
                string line;

                while((line = fin.ReadLine()) != null)
                {
                    entries = line.Split(',');

                    Resource.elements.Add(new Element(int.Parse(entries[2]), entries[0], entries[1].Trim(), float.Parse(entries[3]), RemoveGarbageText(entries[4]), GetValueNotNull(entries[5]), GetValueNotNull(entries[6]),GetValueNotNull(entries[10]), RemoveGarbageText(entries[11]), GetValueNotNull(entries[14]), entries[18], (int)RemoveGarbageText(entries[17]), GetValueNotNull(entries[7]), GetValueNotNull(entries[8])));

                }
            }

        }


        private static void LoadPopularFormulas()
        {
            using (StreamReader fin = new StreamReader(FormulasPath))
            {
                string line = String.Empty;

                while ((line = fin.ReadLine()) != null)
                    Resource.popularFormulas.Add(line);
            }

        }




    }
}
