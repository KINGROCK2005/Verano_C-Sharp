namespace Ejemplos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Ing = new System.Windows.Forms.Label();
            this.txtIng = new System.Windows.Forms.MaskedTextBox();
            this.ilbl_IL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lnl_IP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_El = new System.Windows.Forms.Label();
            this.cboTI = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(122, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicacion para Calcular Inss Laboral";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Ing
            // 
            this.lbl_Ing.AutoSize = true;
            this.lbl_Ing.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Ing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ing.ForeColor = System.Drawing.Color.Red;
            this.lbl_Ing.Location = new System.Drawing.Point(162, 77);
            this.lbl_Ing.Name = "lbl_Ing";
            this.lbl_Ing.Size = new System.Drawing.Size(67, 18);
            this.lbl_Ing.TabIndex = 1;
            this.lbl_Ing.Text = "Ingresos";
            // 
            // txtIng
            // 
            this.txtIng.ForeColor = System.Drawing.Color.Black;
            this.txtIng.HideSelection = false;
            this.txtIng.Location = new System.Drawing.Point(280, 72);
            this.txtIng.Mask = "99999";
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(100, 23);
            this.txtIng.TabIndex = 2;
            this.txtIng.ValidatingType = typeof(int);
            // 
            // ilbl_IL
            // 
            this.ilbl_IL.AutoSize = true;
            this.ilbl_IL.BackColor = System.Drawing.SystemColors.Control;
            this.ilbl_IL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ilbl_IL.ForeColor = System.Drawing.Color.Red;
            this.ilbl_IL.Location = new System.Drawing.Point(162, 179);
            this.ilbl_IL.Name = "ilbl_IL";
            this.ilbl_IL.Size = new System.Drawing.Size(92, 18);
            this.ilbl_IL.TabIndex = 3;
            this.ilbl_IL.Text = "Inss Laboral";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(162, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(329, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(243, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lnl_IP
            // 
            this.lnl_IP.AutoSize = true;
            this.lnl_IP.BackColor = System.Drawing.SystemColors.Control;
            this.lnl_IP.Location = new System.Drawing.Point(162, 224);
            this.lnl_IP.Name = "lnl_IP";
            this.lnl_IP.Size = new System.Drawing.Size(74, 15);
            this.lnl_IP.TabIndex = 8;
            this.lnl_IP.Text = "Inss Patronal";
            this.lnl_IP.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // lbl_El
            // 
            this.lbl_El.AutoSize = true;
            this.lbl_El.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_El.Location = new System.Drawing.Point(162, 111);
            this.lbl_El.Name = "lbl_El";
            this.lbl_El.Size = new System.Drawing.Size(69, 15);
            this.lbl_El.TabIndex = 10;
            this.lbl_El.Text = "Tipo de Inss";
            // 
            // cboTI
            // 
            this.cboTI.FormattingEnabled = true;
            this.cboTI.Items.AddRange(new object[] {
            "Laboral",
            "Patronal"});
            this.cboTI.Location = new System.Drawing.Point(280, 103);
            this.cboTI.Name = "cboTI";
            this.cboTI.Size = new System.Drawing.Size(121, 23);
            this.cboTI.TabIndex = 11;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(282, 216);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 23);
            this.txtIP.TabIndex = 12;
            this.txtIP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 370);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.cboTI);
            this.Controls.Add(this.lbl_El);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnl_IP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ilbl_IL);
            this.Controls.Add(this.txtIng);
            this.Controls.Add(this.lbl_Ing);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo de Inss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_Ing;
        private MaskedTextBox txtIng;
        private Label ilbl_IL;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lnl_IP;
        private Label label5;
        private Label lbl_El;
        private ComboBox cboTI;
        private TextBox txtIP;
    }
}