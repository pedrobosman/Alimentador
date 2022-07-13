namespace Alimentador
{
    partial class AlimentadorMain
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
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(44, 66);
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
            this.comboBoxPortas.Location = new System.Drawing.Point(33, 37);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPortas.TabIndex = 1;
            this.comboBoxPortas.DropDown += new System.EventHandler(this.Portas_DropDown);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxStatus.Controls.Add(this.comboBoxPortas);
            this.groupBoxStatus.Controls.Add(this.BtnConectar);
            this.groupBoxStatus.Location = new System.Drawing.Point(13, 38);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(184, 119);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status Alimentador";
            // 
            // AlimentadorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 533);
            this.Controls.Add(this.groupBoxStatus);
            this.Name = "AlimentadorMain";
            this.Text = "AlimentadorMain";
            this.Load += new System.EventHandler(this.AlimentadorMain_Load);
            this.groupBoxStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnConectar;
        private ComboBox comboBoxPortas;
        private GroupBox groupBoxStatus;
    }
}