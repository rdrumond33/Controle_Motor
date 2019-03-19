namespace Controle_Motor
{
    partial class motorForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_ligar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerLog = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnResetar = new System.Windows.Forms.Button();
            this.lblResultadoSE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ligar
            // 
            this.btn_ligar.Location = new System.Drawing.Point(19, 307);
            this.btn_ligar.Name = "btn_ligar";
            this.btn_ligar.Size = new System.Drawing.Size(75, 23);
            this.btn_ligar.TabIndex = 0;
            this.btn_ligar.Text = "Ligar";
            this.btn_ligar.UseVisualStyleBackColor = true;
            this.btn_ligar.Click += new System.EventHandler(this.btn_ligar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema Eletrico";
            // 
            // Text_Log
            // 
            this.Text_Log.Location = new System.Drawing.Point(15, 336);
            this.Text_Log.Multiline = true;
            this.Text_Log.Name = "Text_Log";
            this.Text_Log.ReadOnly = true;
            this.Text_Log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Text_Log.Size = new System.Drawing.Size(1125, 179);
            this.Text_Log.TabIndex = 2;
            this.Text_Log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerLog
            // 
            this.timerLog.Enabled = true;
            this.timerLog.Interval = 250;
            this.timerLog.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(768, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(372, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // btnResetar
            // 
            this.btnResetar.Enabled = false;
            this.btnResetar.Location = new System.Drawing.Point(100, 307);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(75, 23);
            this.btnResetar.TabIndex = 5;
            this.btnResetar.Text = "Resetar";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // lblResultadoSE
            // 
            this.lblResultadoSE.AutoSize = true;
            this.lblResultadoSE.Location = new System.Drawing.Point(31, 77);
            this.lblResultadoSE.Name = "lblResultadoSE";
            this.lblResultadoSE.Size = new System.Drawing.Size(55, 13);
            this.lblResultadoSE.TabIndex = 6;
            this.lblResultadoSE.Text = "Resultado";
            this.lblResultadoSE.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // motorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultadoSE);
            this.Controls.Add(this.btnResetar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ligar);
            this.Name = "motorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ligar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Label lblResultadoSE;
        private System.Windows.Forms.Label label3;
    }
}

