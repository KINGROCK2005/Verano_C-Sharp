namespace WinFormsApp2
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejemploDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasGeometricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemploDeLoginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejemploDeLoginToolStripMenuItem
            // 
            this.ejemploDeLoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasGeometricasToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.ejemploDeLoginToolStripMenuItem.Name = "ejemploDeLoginToolStripMenuItem";
            this.ejemploDeLoginToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.ejemploDeLoginToolStripMenuItem.Text = "Ejemplo de Login";
            // 
            // figurasGeometricasToolStripMenuItem
            // 
            this.figurasGeometricasToolStripMenuItem.Name = "figurasGeometricasToolStripMenuItem";
            this.figurasGeometricasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.figurasGeometricasToolStripMenuItem.Text = "Figuras Geometricas";
            this.figurasGeometricasToolStripMenuItem.Click += new System.EventHandler(this.figurasGeometricasToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ejemploDeLoginToolStripMenuItem;
        private ToolStripMenuItem figurasGeometricasToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}