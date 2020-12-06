
namespace Capstone_Project
{
    partial class StatPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.projectionButton = new System.Windows.Forms.Button();
            this.HRButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerChart)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.playerChart);
            this.panel1.Controls.Add(this.ButtonPanel);
            this.panel1.Controls.Add(this.playerName);
            this.panel1.Location = new System.Drawing.Point(0, -47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 674);
            this.panel1.TabIndex = 1;
            // 
            // playerChart
            // 
            this.playerChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerChart.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.playerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.playerChart.Legends.Add(legend1);
            this.playerChart.Location = new System.Drawing.Point(60, 131);
            this.playerChart.Name = "playerChart";
            this.playerChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.playerChart.Size = new System.Drawing.Size(775, 361);
            this.playerChart.TabIndex = 8;
            this.playerChart.Text = "Data Graph";
            this.playerChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.ColumnCount = 3;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonPanel.Controls.Add(this.projectionButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.HRButton, 2, 1);
            this.ButtonPanel.Controls.Add(this.button2, 1, 0);
            this.ButtonPanel.Controls.Add(this.KButton, 1, 1);
            this.ButtonPanel.Controls.Add(this.button3, 2, 0);
            this.ButtonPanel.Controls.Add(this.button4, 0, 1);
            this.ButtonPanel.Location = new System.Drawing.Point(57, 511);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 2;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonPanel.Size = new System.Drawing.Size(781, 130);
            this.ButtonPanel.TabIndex = 7;
            // 
            // projectionButton
            // 
            this.projectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.projectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.projectionButton.Location = new System.Drawing.Point(3, 3);
            this.projectionButton.Name = "projectionButton";
            this.projectionButton.Padding = new System.Windows.Forms.Padding(10);
            this.projectionButton.Size = new System.Drawing.Size(254, 59);
            this.projectionButton.TabIndex = 1;
            this.projectionButton.Text = "Toggle Projection";
            this.projectionButton.UseVisualStyleBackColor = false;
            this.projectionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HRButton
            // 
            this.HRButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HRButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HRButton.Location = new System.Drawing.Point(523, 68);
            this.HRButton.Name = "HRButton";
            this.HRButton.Padding = new System.Windows.Forms.Padding(10);
            this.HRButton.Size = new System.Drawing.Size(255, 59);
            this.HRButton.TabIndex = 6;
            this.HRButton.Text = "HR Allowed";
            this.HRButton.UseVisualStyleBackColor = false;
            this.HRButton.Click += new System.EventHandler(this.HRButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(263, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(254, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "ERA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.eraButtonClick);
            // 
            // KButton
            // 
            this.KButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KButton.Location = new System.Drawing.Point(263, 68);
            this.KButton.Name = "KButton";
            this.KButton.Padding = new System.Windows.Forms.Padding(10);
            this.KButton.Size = new System.Drawing.Size(254, 59);
            this.KButton.TabIndex = 5;
            this.KButton.Text = "K";
            this.KButton.UseVisualStyleBackColor = false;
            this.KButton.Click += new System.EventHandler(this.kButtonClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(523, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10);
            this.button3.Size = new System.Drawing.Size(255, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "WHIP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.whipButtonClick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(3, 68);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(254, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "K/9";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.k9ButtonClick);
            // 
            // playerName
            // 
            this.playerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.playerName.Location = new System.Drawing.Point(310, 77);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(196, 40);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "Player Name";
            this.playerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // StatPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 626);
            this.Controls.Add(this.panel1);
            this.Name = "StatPage";
            this.Text = "StatPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerChart)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button projectionButton;
        private System.Windows.Forms.Button HRButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart playerChart;
    }
}