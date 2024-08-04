namespace Tabelul_periodic
{
    partial class TabBar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.newTabStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabelPeriodic = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorMasaMolecularaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorGradNesaturareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoTab = new System.Windows.Forms.ToolTip(this.components);
            this.menuButton = new Tabelul_periodic.MenuButton();
            this.pnlSelector = new System.Windows.Forms.Panel();
            this.searchModule1 = new Tabelul_periodic.SearchModule();
            this.newTabStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTabStrip
            // 
            this.newTabStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.newTabStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabelPeriodic,
            this.calculatorMasaMolecularaToolStripMenuItem,
            this.calculatorGradNesaturareToolStripMenuItem});
            this.newTabStrip.Name = "newTabStrip";
            this.newTabStrip.Size = new System.Drawing.Size(226, 82);
            // 
            // newTabelPeriodic
            // 
            this.newTabelPeriodic.Image = global::Tabelul_periodic.Properties.Resources.masa_moleculara_frm;
            this.newTabelPeriodic.Name = "newTabelPeriodic";
            this.newTabelPeriodic.Size = new System.Drawing.Size(225, 26);
            this.newTabelPeriodic.Text = "Tabel periodic";
            this.newTabelPeriodic.Click += new System.EventHandler(this.NewTabelPeriodic_Click);
            // 
            // calculatorMasaMolecularaToolStripMenuItem
            // 
            this.calculatorMasaMolecularaToolStripMenuItem.Image = global::Tabelul_periodic.Properties.Resources.formule_32px;
            this.calculatorMasaMolecularaToolStripMenuItem.Name = "calculatorMasaMolecularaToolStripMenuItem";
            this.calculatorMasaMolecularaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.calculatorMasaMolecularaToolStripMenuItem.Text = "Calculator masa moleculara";
            this.calculatorMasaMolecularaToolStripMenuItem.Click += new System.EventHandler(this.NewMasaMolec_Click);
            // 
            // calculatorGradNesaturareToolStripMenuItem
            // 
            this.calculatorGradNesaturareToolStripMenuItem.Image = global::Tabelul_periodic.Properties.Resources.grad_de_nesaturare;
            this.calculatorGradNesaturareToolStripMenuItem.Name = "calculatorGradNesaturareToolStripMenuItem";
            this.calculatorGradNesaturareToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.calculatorGradNesaturareToolStripMenuItem.Text = "Calculator grad nesaturare";
            this.calculatorGradNesaturareToolStripMenuItem.Click += new System.EventHandler(this.NewGradNesat_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(623, 0);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Menu = this.newTabStrip;
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(58, 49);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "+";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infoTab.SetToolTip(this.menuButton, "Deschide un nou tab");
            this.menuButton.UseVisualStyleBackColor = false;
            // 
            // pnlSelector
            // 
            this.pnlSelector.AutoScroll = true;
            this.pnlSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSelector.Location = new System.Drawing.Point(0, 0);
            this.pnlSelector.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSelector.Name = "pnlSelector";
            this.pnlSelector.Size = new System.Drawing.Size(623, 49);
            this.pnlSelector.TabIndex = 6;
            // 
            // searchModule1
            // 
            this.searchModule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchModule1.Location = new System.Drawing.Point(690, 13);
            this.searchModule1.Name = "searchModule1";
            this.searchModule1.Size = new System.Drawing.Size(234, 24);
            this.searchModule1.TabIndex = 8;
            // 
            // TabBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.searchModule1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pnlSelector);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabBar";
            this.Size = new System.Drawing.Size(936, 49);
            this.Load += new System.EventHandler(this.TabBar_Load);
            this.newTabStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip newTabStrip;
        private System.Windows.Forms.ToolStripMenuItem newTabelPeriodic;
        private System.Windows.Forms.ToolStripMenuItem calculatorMasaMolecularaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorGradNesaturareToolStripMenuItem;
        private System.Windows.Forms.ToolTip infoTab;
        private System.Windows.Forms.Panel pnlSelector;
        private MenuButton menuButton;
        private SearchModule searchModule1;
    }
}
