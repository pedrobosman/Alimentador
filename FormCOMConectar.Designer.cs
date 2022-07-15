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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCOMConectar));
            this.BtnConectar = new System.Windows.Forms.Button();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackgroundImage = global::Alimentador.Properties.Resources.Conectar;
            this.BtnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConectar.Location = new System.Drawing.Point(140, 230);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(60, 60);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(76, 191);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(198, 28);
            this.comboBoxPortas.Sorted = true;
            this.comboBoxPortas.TabIndex = 1;
            this.comboBoxPortas.DropDown += new System.EventHandler(this.Portas_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Alimentador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcone
            // 
            this.pictureBoxIcone.BackgroundImage = global::Alimentador.Properties.Resources.dogBowl;
            this.pictureBoxIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIcone.Location = new System.Drawing.Point(115, 20);
            this.pictureBoxIcone.Name = "pictureBoxIcone";
            this.pictureBoxIcone.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxIcone.TabIndex = 3;
            this.pictureBoxIcone.TabStop = false;
            // 
            // FormCOMConectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 301);
            this.Controls.Add(this.pictureBoxIcone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPortas);
            this.Controls.Add(this.BtnConectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCOMConectar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alimentador";
            this.Load += new System.EventHandler(this.AlimentadorMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnConectar;
        private ComboBox comboBoxPortas;
        private Label label1;
        private PictureBox pictureBoxIcone;
    }
}