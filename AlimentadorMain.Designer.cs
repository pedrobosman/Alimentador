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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerAtualizarDados = new System.Windows.Forms.Timer(this.components);
            this.timerChecarConexao = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPorcLuminosidade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxLampada = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarAmbiente = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPorcLampada = new System.Windows.Forms.TrackBar();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLampada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPorcLampada)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(103, 17);
            this.toolStripLabelStatus.Text = "Status Dispositivo:";
            // 
            // timerAtualizarDados
            // 
            this.timerAtualizarDados.Interval = 1000;
            this.timerAtualizarDados.Tick += new System.EventHandler(this.timerAtualizarDados_Tick);
            // 
            // timerChecarConexao
            // 
            this.timerChecarConexao.Tick += new System.EventHandler(this.timerChecarConexao_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPorcLuminosidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBoxLampada);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBarAmbiente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBarPorcLampada);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(432, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iluminação";
            // 
            // labelPorcLuminosidade
            // 
            this.labelPorcLuminosidade.AutoSize = true;
            this.labelPorcLuminosidade.Location = new System.Drawing.Point(327, 192);
            this.labelPorcLuminosidade.Name = "labelPorcLuminosidade";
            this.labelPorcLuminosidade.Size = new System.Drawing.Size(26, 15);
            this.labelPorcLuminosidade.TabIndex = 14;
            this.labelPorcLuminosidade.Text = "0 %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Luminosidade:";
            // 
            // pictureBoxLampada
            // 
            this.pictureBoxLampada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLampada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLampada.Image = global::Alimentador.Properties.Resources.aceso;
            this.pictureBoxLampada.Location = new System.Drawing.Point(309, 22);
            this.pictureBoxLampada.Name = "pictureBoxLampada";
            this.pictureBoxLampada.Size = new System.Drawing.Size(109, 109);
            this.pictureBoxLampada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLampada.TabIndex = 11;
            this.pictureBoxLampada.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "100%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Luminosidade (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Noite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quando Iluminar o Ambiente?";
            // 
            // trackBarAmbiente
            // 
            this.trackBarAmbiente.LargeChange = 1;
            this.trackBarAmbiente.Location = new System.Drawing.Point(31, 181);
            this.trackBarAmbiente.Maximum = 5;
            this.trackBarAmbiente.Name = "trackBarAmbiente";
            this.trackBarAmbiente.Size = new System.Drawing.Size(217, 45);
            this.trackBarAmbiente.TabIndex = 3;
            this.trackBarAmbiente.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAmbiente.Scroll += new System.EventHandler(this.trackBarAmbiente_Scroll);
            this.trackBarAmbiente.Enter += new System.EventHandler(this.trackBarAmbiente_Enter);
            this.trackBarAmbiente.MouseCaptureChanged += new System.EventHandler(this.trackBarAmbiente_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ambiente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lâmpada";
            // 
            // trackBarPorcLampada
            // 
            this.trackBarPorcLampada.LargeChange = 20;
            this.trackBarPorcLampada.Location = new System.Drawing.Point(25, 77);
            this.trackBarPorcLampada.Maximum = 100;
            this.trackBarPorcLampada.Name = "trackBarPorcLampada";
            this.trackBarPorcLampada.Size = new System.Drawing.Size(223, 45);
            this.trackBarPorcLampada.SmallChange = 10;
            this.trackBarPorcLampada.TabIndex = 0;
            this.trackBarPorcLampada.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPorcLampada.Scroll += new System.EventHandler(this.trackBarPorcLampada_Scroll);
            this.trackBarPorcLampada.Enter += new System.EventHandler(this.trackBarPorcLampada_Enter);
            this.trackBarPorcLampada.MouseCaptureChanged += new System.EventHandler(this.trackBarPorcLampada_MouseCaptureChanged);
            // 
            // AlimentadorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(868, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlimentadorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlimentadorMain";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLampada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPorcLampada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripLabelStatus;
        private System.Windows.Forms.Timer timerAtualizarDados;
        private System.Windows.Forms.Timer timerChecarConexao;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TrackBar trackBarPorcLampada;
        private TrackBar trackBarAmbiente;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private PictureBox pictureBoxLampada;
        private Label label5;
        private Label label10;
        private Label labelPorcLuminosidade;
    }
}