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
    public partial class SearchModule : UserControl
    {
        public SearchModule()
        {
            InitializeComponent();
        }

        private void SearchModule_Load(object sender, EventArgs e)
        {
            LoadSuggestions();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindElement(txtSearch.Text);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindElement(txtSearch.Text);
        }

        private void FindElement(string input)
        {
            if (!String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var elementGasit = Resource.elements.Find(x => x.nume.ToLower() == input.ToLower());

                if (elementGasit != null)
                    elementGasit.LoadPreview(Color.Black);
            }
        }


        private void LoadSuggestions()
        {
            var sursa = new AutoCompleteStringCollection();

            foreach (Element entry in Resource.elements)
                sursa.Add(entry.nume);

            txtSearch.AutoCompleteCustomSource = sursa;
        }


    }
}
