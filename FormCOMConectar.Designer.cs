namespace Alimentador
{
    partial class FormCOMConectar
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
            this.BtnConectar = new System.Windows.Forms.Button();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(54, 100);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(100, 23);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(43, 71);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPortas.Sorted = true;
            this.comboBoxPortas.TabIndex = 1;
            this.comboBoxPortas.DropDown += new System.EventHandler(this.Portas_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Dispositivo";
            // 
            // FormCOMConectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPortas);
            this.Controls.Add(this.BtnConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCOMConectar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alimentador";
            this.Load += new System.EventHandler(this.AlimentadorMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnConectar;
        private ComboBox comboBoxPortas;
        private Label label1;
    }
}