namespace Tabelul_periodic
{
    partial class MainApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.otherOptionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opDespre = new System.Windows.Forms.ToolStripMenuItem();
            this.explicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBar1 = new Tabelul_periodic.TabBar();
            this.pnlView = new System.Windows.Forms.Panel();
            this.otherOptionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // otherOptionsMenu
            // 
            this.otherOptionsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.otherOptionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opDespre});
            this.otherOptionsMenu.Name = "contextMenuStrip1";
            this.otherOptionsMenu.Size = new System.Drawing.Size(191, 30);
            // 
            // opDespre
            // 
            this.opDespre.Image = global::Tabelul_periodic.Properties.Resources.despre_frm;
            this.opDespre.Name = "opDespre";
            this.opDespre.Size = new System.Drawing.Size(190, 26);
            this.opDespre.Text = "Despre aplicație";
            this.opDespre.Click += new System.EventHandler(this.OpDespre_Click);
            // 
            // explicatieToolStripMenuItem
            // 
            this.explicatieToolStripMenuItem.Name = "explicatieToolStripMenuItem";
            this.explicatieToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.explicatieToolStripMenuItem.Text = "Explicatie";
            // 
            // tabBar1
            // 
            this.tabBar1.BackColor = System.Drawing.Color.Orange;
            this.tabBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabBar1.Location = new System.Drawing.Point(0, 0);
            this.tabBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBar1.Name = "tabBar1";
            this.tabBar1.Size = new System.Drawing.Size(1248, 60);
            this.tabBar1.TabIndex = 2;
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 60);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1248, 680);
            this.pnlView.TabIndex = 3;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1248, 740);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.tabBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1262, 776);
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanadium Private Beta | Milestone 3 ";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.otherOptionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem opDespre;
        private System.Windows.Forms.ToolStripMenuItem explicatieToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip otherOptionsMenu;
        public System.Windows.Forms.Panel pnlView;
        public TabBar tabBar1;
    }
}