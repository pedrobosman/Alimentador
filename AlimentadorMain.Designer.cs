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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlimentadorMain));
            this.timerAtualizarDados = new System.Windows.Forms.Timer(this.components);
            this.timerChecarConexao = new System.Windows.Forms.Timer(this.components);
            this.groupBoxIlumincacao = new System.Windows.Forms.GroupBox();
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
            this.statusLedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveHorario = new System.Windows.Forms.Button();
            this.buttonAdicionarHorairo = new System.Windows.Forms.Button();
            this.dataGridViewAlimentacao = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minuto_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoVazao_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JaAlimentou_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRecarregarHorario = new System.Windows.Forms.Button();
            this.groupBoxIlumincacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLampada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPorcLampada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLedBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlimentacao)).BeginInit();
            this.SuspendLayout();
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
            // groupBoxIlumincacao
            // 
            this.groupBoxIlumincacao.Controls.Add(this.labelPorcLuminosidade);
            this.groupBoxIlumincacao.Controls.Add(this.label5);
            this.groupBoxIlumincacao.Controls.Add(this.label10);
            this.groupBoxIlumincacao.Controls.Add(this.pictureBoxLampada);
            this.groupBoxIlumincacao.Controls.Add(this.label9);
            this.groupBoxIlumincacao.Controls.Add(this.label8);
            this.groupBoxIlumincacao.Controls.Add(this.label7);
            this.groupBoxIlumincacao.Controls.Add(this.label6);
            this.groupBoxIlumincacao.Controls.Add(this.label4);
            this.groupBoxIlumincacao.Controls.Add(this.label3);
            this.groupBoxIlumincacao.Controls.Add(this.trackBarAmbiente);
            this.groupBoxIlumincacao.Controls.Add(this.label2);
            this.groupBoxIlumincacao.Controls.Add(this.label1);
            this.groupBoxIlumincacao.Controls.Add(this.trackBarPorcLampada);
            this.groupBoxIlumincacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxIlumincacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxIlumincacao.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIlumincacao.Name = "groupBoxIlumincacao";
            this.groupBoxIlumincacao.Size = new System.Drawing.Size(424, 298);
            this.groupBoxIlumincacao.TabIndex = 1;
            this.groupBoxIlumincacao.TabStop = false;
            this.groupBoxIlumincacao.Text = "Iluminação";
            // 
            // labelPorcLuminosidade
            // 
            this.labelPorcLuminosidade.AutoSize = true;
            this.labelPorcLuminosidade.Location = new System.Drawing.Point(327, 207);
            this.labelPorcLuminosidade.Name = "labelPorcLuminosidade";
            this.labelPorcLuminosidade.Size = new System.Drawing.Size(33, 20);
            this.labelPorcLuminosidade.TabIndex = 14;
            this.labelPorcLuminosidade.Text = "0 %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Luminosidade:";
            // 
            // pictureBoxLampada
            // 
            this.pictureBoxLampada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLampada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLampada.Image = global::Alimentador.Properties.Resources.aceso;
            this.pictureBoxLampada.Location = new System.Drawing.Point(305, 30);
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
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "100%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Luminosidade (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Noite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quando Iluminar o Ambiente?";
            // 
            // trackBarAmbiente
            // 
            this.trackBarAmbiente.LargeChange = 1;
            this.trackBarAmbiente.Location = new System.Drawing.Point(31, 196);
            this.trackBarAmbiente.Maximum = 5;
            this.trackBarAmbiente.Name = "trackBarAmbiente";
            this.trackBarAmbiente.Size = new System.Drawing.Size(217, 45);
            this.trackBarAmbiente.TabIndex = 3;
            this.trackBarAmbiente.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAmbiente.MouseCaptureChanged += new System.EventHandler(this.trackBarAmbiente_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ambiente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lâmpada";
            // 
            // trackBarPorcLampada
            // 
            this.trackBarPorcLampada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.statusLedBindingSource, "Porcentagem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBarPorcLampada.LargeChange = 20;
            this.trackBarPorcLampada.Location = new System.Drawing.Point(25, 84);
            this.trackBarPorcLampada.Maximum = 100;
            this.trackBarPorcLampada.Name = "trackBarPorcLampada";
            this.trackBarPorcLampada.Size = new System.Drawing.Size(223, 45);
            this.trackBarPorcLampada.SmallChange = 10;
            this.trackBarPorcLampada.TabIndex = 0;
            this.trackBarPorcLampada.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPorcLampada.MouseCaptureChanged += new System.EventHandler(this.trackBarPorcLampada_MouseCaptureChanged);
            // 
            // statusLedBindingSource
            // 
            this.statusLedBindingSource.DataSource = typeof(Alimentador.MensagensJson.StatusLed);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveHorario);
            this.groupBox2.Controls.Add(this.buttonAdicionarHorairo);
            this.groupBox2.Controls.Add(this.dataGridViewAlimentacao);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horários de Alimentação";
            // 
            // buttonRemoveHorario
            // 
            this.buttonRemoveHorario.BackgroundImage = global::Alimentador.Properties.Resources.remove;
            this.buttonRemoveHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveHorario.Location = new System.Drawing.Point(469, 238);
            this.buttonRemoveHorario.Name = "buttonRemoveHorario";
            this.buttonRemoveHorario.Size = new System.Drawing.Size(40, 40);
            this.buttonRemoveHorario.TabIndex = 3;
            this.buttonRemoveHorario.UseVisualStyleBackColor = true;
            this.buttonRemoveHorario.Click += new System.EventHandler(this.buttonRemoveHorario_Click);
            // 
            // buttonAdicionarHorairo
            // 
            this.buttonAdicionarHorairo.BackgroundImage = global::Alimentador.Properties.Resources.add;
            this.buttonAdicionarHorairo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdicionarHorairo.Location = new System.Drawing.Point(515, 238);
            this.buttonAdicionarHorairo.Name = "buttonAdicionarHorairo";
            this.buttonAdicionarHorairo.Size = new System.Drawing.Size(40, 40);
            this.buttonAdicionarHorairo.TabIndex = 1;
            this.buttonAdicionarHorairo.UseVisualStyleBackColor = true;
            this.buttonAdicionarHorairo.Click += new System.EventHandler(this.buttonAdicionarHorairo_Click);
            // 
            // dataGridViewAlimentacao
            // 
            this.dataGridViewAlimentacao.AllowUserToAddRows = false;
            this.dataGridViewAlimentacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlimentacao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlimentacao.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewAlimentacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAlimentacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewAlimentacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlimentacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlimentacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Hora_Column,
            this.Minuto_Column,
            this.TempoVazao_Column,
            this.JaAlimentou_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlimentacao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlimentacao.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewAlimentacao.Name = "dataGridViewAlimentacao";
            this.dataGridViewAlimentacao.ReadOnly = true;
            this.dataGridViewAlimentacao.RowTemplate.Height = 25;
            this.dataGridViewAlimentacao.Size = new System.Drawing.Size(558, 210);
            this.dataGridViewAlimentacao.TabIndex = 0;
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            this.ID_Column.ReadOnly = true;
            // 
            // Hora_Column
            // 
            this.Hora_Column.HeaderText = "Hora";
            this.Hora_Column.Name = "Hora_Column";
            this.Hora_Column.ReadOnly = true;
            // 
            // Minuto_Column
            // 
            this.Minuto_Column.HeaderText = "Minuto";
            this.Minuto_Column.Name = "Minuto_Column";
            this.Minuto_Column.ReadOnly = true;
            // 
            // TempoVazao_Column
            // 
            this.TempoVazao_Column.HeaderText = "Tempo de Vazão (s)";
            this.TempoVazao_Column.Name = "TempoVazao_Column";
            this.TempoVazao_Column.ReadOnly = true;
            // 
            // JaAlimentou_Column
            // 
            this.JaAlimentou_Column.HeaderText = "Ja Alimentou?";
            this.JaAlimentou_Column.Name = "JaAlimentou_Column";
            this.JaAlimentou_Column.ReadOnly = true;
            // 
            // buttonRecarregarHorario
            // 
            this.buttonRecarregarHorario.BackgroundImage = global::Alimentador.Properties.Resources.reload;
            this.buttonRecarregarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecarregarHorario.Location = new System.Drawing.Point(957, 345);
            this.buttonRecarregarHorario.Name = "buttonRecarregarHorario";
            this.buttonRecarregarHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRecarregarHorario.Size = new System.Drawing.Size(40, 40);
            this.buttonRecarregarHorario.TabIndex = 2;
            this.buttonRecarregarHorario.UseVisualStyleBackColor = true;
            this.buttonRecarregarHorario.Click += new System.EventHandler(this.buttonRecarregarHorario_Click);
            // 
            // AlimentadorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1009, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRecarregarHorario);
            this.Controls.Add(this.groupBoxIlumincacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlimentadorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Alimentador";
            this.Load += new System.EventHandler(this.AlimentadorMain_Load);
            this.groupBoxIlumincacao.ResumeLayout(false);
            this.groupBoxIlumincacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLampada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPorcLampada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLedBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlimentacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripLabelStatus;
        private System.Windows.Forms.Timer timerAtualizarDados;
        private System.Windows.Forms.Timer timerChecarConexao;
        private GroupBox groupBoxIlumincacao;
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
        private BindingSource statusLedBindingSource;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAlimentacao;
        private Button buttonRecarregarHorario;
        private Button buttonAdicionarHorairo;
        private Button buttonRemoveHorario;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Hora_Column;
        private DataGridViewTextBoxColumn Minuto_Column;
        private DataGridViewTextBoxColumn TempoVazao_Column;
        private DataGridViewTextBoxColumn JaAlimentou_Column;
    }
}