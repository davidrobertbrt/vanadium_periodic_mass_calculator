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
    public partial class CalculatorGradNesaturare : UserControl
    {
        private int gradNE;
        private string formula;
        bool reset = true;

        Dictionary<char, int> indici;

        public CalculatorGradNesaturare()
        {
            InitializeComponent();
            LoadQuickActions();
        }

        private void CalculatorGradNesaturare_Load(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void BtnCalculare_Click(object sender, EventArgs e)
        {
            StartComputation();
        }

        private void BtnClipboard_Click(object sender, EventArgs e)
        {
            if (!lbGradNesaturare.Text.Equals("N/A"))
                Clipboard.SetText(lbGradNesaturare.ToString());
        }

        private void Indice_Changed(object sender, EventArgs e)
        {
            lbGradNesaturare.Text = "N/A";
        }


        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void StartComputation()
        {
            try
            {
                FormResultData();
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Valoarea introdusă este prea mare!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();

                return;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Literele nu pot fi indici!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInput();

                return;
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Nu ai introdus nicio valoare!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();

                return;
            }

        }

        #region Computation Engine
        private void FormFormula()
        {
            formula = String.Empty;
            indici = new Dictionary<char, int>();
            bool nullabe = true;
            
            for(int i = this.pnlComputation.Controls.Count - 1; i >= 0; i--)
            {
                Control ctrl = this.pnlComputation.Controls[i];

                if(ctrl is TextBox)
                {

                    if (!String.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        formula += (ctrl.Tag.ToString() + ctrl.Text);
                        indici.Add(ctrl.Tag.ToString()[0], int.Parse(ctrl.Text));

                        nullabe = false;
                    }
                    else
                        indici.Add(ctrl.Tag.ToString()[0], 0);
                }
            }

            if (nullabe == true)
                throw new NullReferenceException();
        }

        private void FormResultData()
        {
            if(reset)
            {
                dtGridIstoric.Rows.RemoveAt(0);
                reset = false;
            }

            FormFormula();

            gradNE = (int)Math.Round(.5 * (2 * indici['C'] + 2 + indici['N'] - indici['X'] - indici['H']));
            lbGradNesaturare.Text = gradNE.ToString();
            dtGridIstoric.Rows.Insert(0,formula, gradNE);
        }


        private void ClearInput()
        {
            foreach (Control ctrl in pnlComputation.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }

            Indice_Changed(null, null);
        }

        private bool ValidateInput()
        {
            bool result = false;

            foreach(Control ctrl in pnlComputation.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(!String.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        if (Regex.IsMatch(ctrl.Text, @"[a-zA-Z]"))
                            return false;
                        else
                            result = true;
                    }
                }
            }

            return result;
        }

        #endregion

        #region History Menu
        private void ClearHistory()
        {
            dtGridIstoric.Rows.Clear();
            dtGridIstoric.Rows.Add("Nu ai nimic în istoric pentru moment...", "");
            reset = true;
        }




        #endregion

        public void LoadQuickActions()
        {
            var quickActions = new Dictionary<Image, EventHandler>();

            quickActions.Add(global::Tabelul_periodic.Properties.Resources.sterge_istoric, new EventHandler(this.BtnClearAll_Click));

            this.Tag = quickActions;
        }

        private void ClearAll()
        {
            ClearHistory();
            ClearInput();
        }

    }
}
