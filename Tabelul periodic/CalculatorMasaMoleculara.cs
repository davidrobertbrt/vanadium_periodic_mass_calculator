using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tabelul_periodic
{
    public partial class CalculatorMasaMoleculara : UserControl
    {
        private float masaMoleculara = 0;
        private static string pattern = @"[A-Z][a-z]?\d*|\((?:[^()]*(?:\(.*\))?[^()]*)+\)\d+";
        private bool reset = true;

        public CalculatorMasaMoleculara()
        {
            InitializeComponent();
            LoadQuickActions();
        }

        private void Click_BtnCalculare(object sender, EventArgs e)
        {
            StartComputation();
        }

        private void TextChange_txtFormula(object sender, EventArgs e)
        {
            lbMasaMoleculara.Text = "N/A";
        }

        private void Click_CopyToClipboard(object sender, EventArgs e)
        {
            if (!lbMasaMoleculara.Text.Equals("N/A"))
                Clipboard.SetText(lbMasaMoleculara.Text.Substring(0, lbMasaMoleculara.Text.IndexOf(" g")));
        }

        private void CalculatorMasaMoleculara_Load(object sender, EventArgs e)
        {
            LoadPopularFormula();
            ClearHistory();
        }

        public void BtnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        void StartComputation()
        {
            try
            {
                FormResultData();
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Formula a fost scrisă incorect!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();

                return;
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Calcul eșuat! Ai incercat cumva să introduci un element fictiv?", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();

                return;
            }
        }

        #region Compute Formula
        bool ValidateFormula(string formula)
        {
            if (String.IsNullOrWhiteSpace(formula))
                return false;

            if (!Regex.IsMatch(formula, pattern))
                return false;

            return true;
        }

        float ComputeFormula(string input)
        {
            float total = 0; //Rezultat final

            ///Sistemul de stiva ptr calcule
            List<Tuple<string, int, float>> st = new List<Tuple<string, int, float>>();
            int depth = -1;
            /////

            string extFormula = String.Empty; ///formula din afara parantezelor.

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[')
                {
                    st.Add(new Tuple<string, int, float>("", 0, 0));
                    depth++;
                }
                else
                {
                    if (input[i] == ')' || input[i] == ']')
                    {
                        int j, coef; //parcurgerea coeficientului dezvoltarii
                        string coefStr = String.Empty;

                        for (j = i + 1; j < input.Length; j++)
                        {
                            if (Char.IsDigit(input[j]))
                                coefStr += input[j];
                            else
                                break;
                        }

                        i = j - 1; // -1 ptr ca for-ul incrementeaza i-ul la fiecare pas.

                        if (depth >= 0) /// daca nu am ajuns pe ultimul nivel al stivei
                        {
                            if (!int.TryParse(coefStr, out coef))
                                coef = 1;

                            st[depth] = new Tuple<string, int, float>(st[depth].Item1, coef, st[depth].Item3);

                        }

                        if (depth >= 1) ///daca mai am dezvoltari necalculate
                            st[depth - 1] = new Tuple<string, int, float>(st[depth - 1].Item1, st[depth - 1].Item2, st[depth - 1].Item3 + CalculateSubFormula(st[depth].Item1, st[depth].Item2) + st[depth].Item3 * st[depth].Item2);
                        else
                            total += ((CalculateSubFormula(st[depth].Item1) + st[depth].Item3) * st[depth].Item2);

                        st.RemoveAt(depth--);
                    }
                    else
                    {
                        if (Char.IsLetterOrDigit(input[i]))
                        {
                            if (depth >= 0)
                                st[depth] = new Tuple<string, int, float>(st[depth].Item1 + input[i], st[depth].Item2, st[depth].Item3);
                            else
                                extFormula += input[i];
                        }
                    }

                }
            }

            total += CalculateSubFormula(extFormula);

            return total;

        }

        float CalculateSubFormula(string input, int dezCoef = 1)
        {
            string symbol, coefStr;
            symbol = coefStr = String.Empty;

            float total = 0;
            int coef;

            foreach (char ch in input)
            {
                if (Char.IsLetter(ch))
                {
                    if (Char.IsLower(ch))
                        symbol += ch;
                    else
                    {
                        if (!String.IsNullOrEmpty(symbol))
                        {
                            if (!int.TryParse(coefStr, out coef))
                                coef = 1;

                            total += (Resource.FindMolecularMass(symbol) * coef);

                            coefStr = String.Empty;
                        }

                        symbol = String.Empty + ch;
                    }
                }
                else
                {
                    if (Char.IsDigit(ch))
                        coefStr += ch;
                }
            }

            if (!String.IsNullOrEmpty(symbol))
            {
                if (!int.TryParse(coefStr, out coef))
                    coef = 1;

                total += (Resource.FindMolecularMass(symbol) * coef);
                coefStr = String.Empty;
            }

            total *= dezCoef;

            return total;
        }

        void FormResultData()
        {
            masaMoleculara = ComputeFormula(txtFormula.Text);

            if(masaMoleculara == -1)
                throw new System.FormatException();

            if (masaMoleculara == 0)
                throw new System.NullReferenceException();

            lbMasaMoleculara.Text = masaMoleculara.ToString() + " g/mol";

            if (reset)
            {
                dtGridIstoric.Rows.RemoveAt(0);
                reset = false;
            }

            if (!ValueExists(txtFormula.Text))
                dtGridIstoric.Rows.Insert(0,txtFormula.Text, lbMasaMoleculara.Text);

        }



        #endregion

        #region History Menu
        private bool ValueExists(string x)
        {
            bool found = false;

            try
            {
                foreach(DataGridViewRow entry in dtGridIstoric.Rows)
                {
                    if(entry.Cells[0].Value.ToString().Equals(x))
                    {
                        found = true;
                        break;
                    }
                }

                return found;
            }
            catch
            {
                return false;
            }
        }

        private void ClearHistory()
        {
            dtGridIstoric.Rows.Clear();
            dtGridIstoric.Rows.Add("Nu ai nimic în istoric pentru moment...", "");

            reset = true;
        }
        #endregion

        #region Popular Formulas
        private void LoadPopularFormula()
        {
            listBoxFormulePopulare.DataSource = Resource.popularFormulas;
        }

        private void DoubleClick_PopularFormula(object sender, EventArgs e)
        {
            txtFormula.Text = listBoxFormulePopulare.Items[listBoxFormulePopulare.SelectedIndex].ToString();
            StartComputation();
        }
        #endregion

        private void ClearInput()
        {
            txtFormula.Text = "";
        }

        private void ClearAll()
        {
            ClearInput();
            ClearHistory();
        }


        private void NotImplemented(object sender,EventArgs e)
        {
            MessageBox.Show("Neimplementat!");
        }

        public void LoadQuickActions()
        {
            var quickActions = new Dictionary<Image, EventHandler>();

            quickActions.Add(global::Tabelul_periodic.Properties.Resources.sterge_istoric,new EventHandler(this.BtnClearAll_Click));

            this.Tag = quickActions;
        }

    }
}
