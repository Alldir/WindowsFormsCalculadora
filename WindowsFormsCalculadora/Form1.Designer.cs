namespace WindowsFormsCalculadora
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtRSTmulti = new System.Windows.Forms.TextBox();
            this.txtRSTdivi = new System.Windows.Forms.TextBox();
            this.txtRSTsub = new System.Windows.Forms.TextBox();
            this.txtRSTadi = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite outro valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Multiplicação:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Divisão:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subtração:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adição:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(120, 25);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(120, 51);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // txtRSTmulti
            // 
            this.txtRSTmulti.Enabled = false;
            this.txtRSTmulti.Location = new System.Drawing.Point(120, 129);
            this.txtRSTmulti.Name = "txtRSTmulti";
            this.txtRSTmulti.ReadOnly = true;
            this.txtRSTmulti.Size = new System.Drawing.Size(100, 20);
            this.txtRSTmulti.TabIndex = 1;
            // 
            // txtRSTdivi
            // 
            this.txtRSTdivi.Enabled = false;
            this.txtRSTdivi.Location = new System.Drawing.Point(120, 155);
            this.txtRSTdivi.Name = "txtRSTdivi";
            this.txtRSTdivi.ReadOnly = true;
            this.txtRSTdivi.Size = new System.Drawing.Size(100, 20);
            this.txtRSTdivi.TabIndex = 1;
            // 
            // txtRSTsub
            // 
            this.txtRSTsub.Enabled = false;
            this.txtRSTsub.Location = new System.Drawing.Point(120, 181);
            this.txtRSTsub.Name = "txtRSTsub";
            this.txtRSTsub.ReadOnly = true;
            this.txtRSTsub.Size = new System.Drawing.Size(100, 20);
            this.txtRSTsub.TabIndex = 1;
            // 
            // txtRSTadi
            // 
            this.txtRSTadi.Enabled = false;
            this.txtRSTadi.Location = new System.Drawing.Point(120, 207);
            this.txtRSTadi.Name = "txtRSTadi";
            this.txtRSTadi.ReadOnly = true;
            this.txtRSTadi.Size = new System.Drawing.Size(100, 20);
            this.txtRSTadi.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCalcular.Location = new System.Drawing.Point(120, 78);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(279, 293);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRSTadi);
            this.Controls.Add(this.txtRSTsub);
            this.Controls.Add(this.txtRSTdivi);
            this.Controls.Add(this.txtRSTmulti);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtRSTmulti;
        private System.Windows.Forms.TextBox txtRSTdivi;
        private System.Windows.Forms.TextBox txtRSTsub;
        private System.Windows.Forms.TextBox txtRSTadi;
        private System.Windows.Forms.Button btnCalcular;
    }
}

