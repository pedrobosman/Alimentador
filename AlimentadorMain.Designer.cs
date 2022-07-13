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
            this.label1 = new System.Windows.Forms.Label();
            this.timerChecarConexao = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(103, 17);
            this.toolStripLabelStatus.Text = "Status Dispositivo:";
            // 
            // timerAtualizarDados
            // 
            this.timerAtualizarDados.Interval = 1000;
            this.timerAtualizarDados.Tick += new System.EventHandler(this.timerAtualizarDados_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timerChecarConexao
            // 
            this.timerChecarConexao.Tick += new System.EventHandler(this.timerChecarConexao_Tick);
            // 
            // AlimentadorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlimentadorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlimentadorMain";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripLabelStatus;
        private System.Windows.Forms.Timer timerAtualizarDados;
        private Label label1;
        private System.Windows.Forms.Timer timerChecarConexao;
    }
}