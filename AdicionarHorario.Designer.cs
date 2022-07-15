namespace Alimentador
{
    partial class AdicionarHorario
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
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownHora = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinuto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVazao = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVazao)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(137, 12);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(60, 23);
            this.comboBoxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minuto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tempo de Vazão (s)";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::Alimentador.Properties.Resources.add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(161, 161);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 40);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::Alimentador.Properties.Resources.remove;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.Location = new System.Drawing.Point(115, 161);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(40, 40);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownHora
            // 
            this.numericUpDownHora.Location = new System.Drawing.Point(137, 47);
            this.numericUpDownHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHora.Name = "numericUpDownHora";
            this.numericUpDownHora.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownHora.TabIndex = 7;
            this.numericUpDownHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHora.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownMinuto
            // 
            this.numericUpDownMinuto.Location = new System.Drawing.Point(137, 82);
            this.numericUpDownMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinuto.Name = "numericUpDownMinuto";
            this.numericUpDownMinuto.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownMinuto.TabIndex = 8;
            this.numericUpDownMinuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMinuto.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownVazao
            // 
            this.numericUpDownVazao.DecimalPlaces = 2;
            this.numericUpDownVazao.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownVazao.Location = new System.Drawing.Point(137, 116);
            this.numericUpDownVazao.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownVazao.Name = "numericUpDownVazao";
            this.numericUpDownVazao.Size = new System.Drawing.Size(60, 23);
            this.numericUpDownVazao.TabIndex = 9;
            this.numericUpDownVazao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVazao.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // AdicionarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(213, 213);
            this.Controls.Add(this.numericUpDownVazao);
            this.Controls.Add(this.numericUpDownMinuto);
            this.Controls.Add(this.numericUpDownHora);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Horário";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVazao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAdd;
        private Button buttonCancel;
        private NumericUpDown numericUpDownHora;
        private NumericUpDown numericUpDownMinuto;
        private NumericUpDown numericUpDownVazao;
    }
}