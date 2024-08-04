namespace Tabelul_periodic
{
    partial class Taskbar
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
            this.otherOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opDespre = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOther = new Tabelul_periodic.MenuButton();
            this.centruDeAjutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // otherOptions
            // 
            this.otherOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.otherOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opDespre,
            this.centruDeAjutorToolStripMenuItem});
            this.otherOptions.Name = "contextMenuStrip1";
            this.otherOptions.Size = new System.Drawing.Size(215, 84);
            // 
            // opDespre
            // 
            this.opDespre.Image = global::Tabelul_periodic.Properties.Resources.despre_frm;
            this.opDespre.Name = "opDespre";
            this.opDespre.Size = new System.Drawing.Size(190, 26);
            this.opDespre.Text = "Despre aplicație";
            this.opDespre.Click += new System.EventHandler(this.OpDespre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(184, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vanadium";
            // 
            // btnOther
            // 
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(1212, 0);
            this.btnOther.Margin = new System.Windows.Forms.Padding(4);
            this.btnOther.Menu = this.otherOptions;
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(36, 60);
            this.btnOther.TabIndex = 5;
            this.btnOther.Tag = "otherMenu";
            this.btnOther.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOther.UseVisualStyleBackColor = true;
            // 
            // centruDeAjutorToolStripMenuItem
            // 
            this.centruDeAjutorToolStripMenuItem.Image = global::Tabelul_periodic.Properties.Resources.feedback_frm;
            this.centruDeAjutorToolStripMenuItem.Name = "centruDeAjutorToolStripMenuItem";
            this.centruDeAjutorToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.centruDeAjutorToolStripMenuItem.Text = "Centru de ajutor";
            this.centruDeAjutorToolStripMenuItem.Click += new System.EventHandler(this.CentruDeAjutorToolStripMenuItem_Click);
            // 
            // Taskbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOther);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Taskbar";
            this.Size = new System.Drawing.Size(1248, 60);
            this.Tag = "taskbar";
            this.Load += new System.EventHandler(this.Taskbar_Load);
            this.otherOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuButton btnOther;
        private System.Windows.Forms.ContextMenuStrip otherOptions;
        private System.Windows.Forms.ToolStripMenuItem opDespre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem centruDeAjutorToolStripMenuItem;
    }
}
