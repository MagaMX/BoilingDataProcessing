namespace BoilingDataProcessingWF
{
    partial class AppForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openExperimentFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelFull = new System.Windows.Forms.TableLayoutPanel();
            this.ProcessPanel = new System.Windows.Forms.Panel();
            this.button_process = new System.Windows.Forms.Button();
            this.createFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageProcessing = new System.Windows.Forms.TabPage();
            this.UIPanel = new System.Windows.Forms.Panel();
            this.checkBox_OpenFile = new System.Windows.Forms.CheckBox();
            this.checkBox_CreateFile = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_XLSX_in = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_select_XLSX_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number_of_points = new System.Windows.Forms.NumericUpDown();
            this.label_choose_NoP = new System.Windows.Forms.Label();
            this.button_select_DOCX_in = new System.Windows.Forms.Button();
            this.label_XLSX_out = new System.Windows.Forms.Label();
            this.button_select_XLSX_out = new System.Windows.Forms.Button();
            this.label_DOCX_in = new System.Windows.Forms.Label();
            this.tabPageBoilingCurves = new System.Windows.Forms.TabPage();
            this.box_Pressure = new System.Windows.Forms.ComboBox();
            this.chartBC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageCHF = new System.Windows.Forms.TabPage();
            this.customProgressBar = new BoilingDataProcessingWF.CustomProgressBar();
            this.tableLayoutPanelFull.SuspendLayout();
            this.ProcessPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageProcessing.SuspendLayout();
            this.UIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_points)).BeginInit();
            this.tabPageBoilingCurves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBC)).BeginInit();
            this.SuspendLayout();
            // 
            // openExperimentFileDialog
            // 
            this.openExperimentFileDialog.FileName = "openExperimentFileDialog";
            // 
            // tableLayoutPanelFull
            // 
            this.tableLayoutPanelFull.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelFull.ColumnCount = 1;
            this.tableLayoutPanelFull.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.81074F));
            this.tableLayoutPanelFull.Controls.Add(this.ProcessPanel, 0, 1);
            this.tableLayoutPanelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFull.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFull.Name = "tableLayoutPanelFull";
            this.tableLayoutPanelFull.RowCount = 2;
            this.tableLayoutPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanelFull.Size = new System.Drawing.Size(768, 418);
            this.tableLayoutPanelFull.TabIndex = 13;
            // 
            // ProcessPanel
            // 
            this.ProcessPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ProcessPanel.Controls.Add(this.customProgressBar);
            this.ProcessPanel.Controls.Add(this.button_process);
            this.ProcessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProcessPanel.Location = new System.Drawing.Point(3, 298);
            this.ProcessPanel.Name = "ProcessPanel";
            this.ProcessPanel.Size = new System.Drawing.Size(762, 117);
            this.ProcessPanel.TabIndex = 10;
            // 
            // button_process
            // 
            this.button_process.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_process.Location = new System.Drawing.Point(353, 7);
            this.button_process.Name = "button_process";
            this.button_process.Size = new System.Drawing.Size(100, 26);
            this.button_process.TabIndex = 0;
            this.button_process.Text = "Обработать";
            this.button_process.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageProcessing);
            this.tabControl.Controls.Add(this.tabPageBoilingCurves);
            this.tabControl.Controls.Add(this.tabPageCHF);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(782, 453);
            this.tabControl.TabIndex = 15;
            // 
            // tabPageProcessing
            // 
            this.tabPageProcessing.Controls.Add(this.UIPanel);
            this.tabPageProcessing.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessing.Name = "tabPageProcessing";
            this.tabPageProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessing.Size = new System.Drawing.Size(774, 424);
            this.tabPageProcessing.TabIndex = 0;
            this.tabPageProcessing.Text = "Обработка";
            this.tabPageProcessing.UseVisualStyleBackColor = true;
            // 
            // UIPanel
            // 
            this.UIPanel.Controls.Add(this.checkBox_OpenFile);
            this.UIPanel.Controls.Add(this.checkBox_CreateFile);
            this.UIPanel.Controls.Add(this.label3);
            this.UIPanel.Controls.Add(this.label_XLSX_in);
            this.UIPanel.Controls.Add(this.label2);
            this.UIPanel.Controls.Add(this.button_select_XLSX_in);
            this.UIPanel.Controls.Add(this.label1);
            this.UIPanel.Controls.Add(this.number_of_points);
            this.UIPanel.Controls.Add(this.label_choose_NoP);
            this.UIPanel.Controls.Add(this.button_select_DOCX_in);
            this.UIPanel.Controls.Add(this.label_XLSX_out);
            this.UIPanel.Controls.Add(this.button_select_XLSX_out);
            this.UIPanel.Controls.Add(this.label_DOCX_in);
            this.UIPanel.Controls.Add(this.tableLayoutPanelFull);
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIPanel.Location = new System.Drawing.Point(3, 3);
            this.UIPanel.MinimumSize = new System.Drawing.Size(500, 300);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.Size = new System.Drawing.Size(768, 418);
            this.UIPanel.TabIndex = 1;
            // 
            // checkBox_OpenFile
            // 
            this.checkBox_OpenFile.AutoSize = true;
            this.checkBox_OpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_OpenFile.Location = new System.Drawing.Point(486, 208);
            this.checkBox_OpenFile.Name = "checkBox_OpenFile";
            this.checkBox_OpenFile.Size = new System.Drawing.Size(237, 20);
            this.checkBox_OpenFile.TabIndex = 14;
            this.checkBox_OpenFile.Text = "Открыть файл после обработки";
            this.checkBox_OpenFile.UseVisualStyleBackColor = false;
            // 
            // checkBox_CreateFile
            // 
            this.checkBox_CreateFile.AutoSize = true;
            this.checkBox_CreateFile.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_CreateFile.Location = new System.Drawing.Point(486, 170);
            this.checkBox_CreateFile.Name = "checkBox_CreateFile";
            this.checkBox_CreateFile.Size = new System.Drawing.Size(166, 20);
            this.checkBox_CreateFile.TabIndex = 13;
            this.checkBox_CreateFile.Text = "Создать новый файл";
            this.checkBox_CreateFile.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(117, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Файл записи обработки:";
            // 
            // label_XLSX_in
            // 
            this.label_XLSX_in.BackColor = System.Drawing.Color.White;
            this.label_XLSX_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_XLSX_in.Location = new System.Drawing.Point(120, 49);
            this.label_XLSX_in.Name = "label_XLSX_in";
            this.label_XLSX_in.Size = new System.Drawing.Size(360, 30);
            this.label_XLSX_in.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(117, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Файл протокола:";
            // 
            // button_select_XLSX_in
            // 
            this.button_select_XLSX_in.BackColor = System.Drawing.SystemColors.Control;
            this.button_select_XLSX_in.BackgroundImage = global::BoilingDataProcessingWF.Properties.Resources.XlsxIcon;
            this.button_select_XLSX_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select_XLSX_in.Location = new System.Drawing.Point(61, 47);
            this.button_select_XLSX_in.Name = "button_select_XLSX_in";
            this.button_select_XLSX_in.Size = new System.Drawing.Size(35, 35);
            this.button_select_XLSX_in.TabIndex = 1;
            this.button_select_XLSX_in.UseVisualStyleBackColor = false;
            this.button_select_XLSX_in.Click += new System.EventHandler(this.Select_XLSX_in);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(117, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Файл эксперимента:";
            // 
            // number_of_points
            // 
            this.number_of_points.Location = new System.Drawing.Point(120, 227);
            this.number_of_points.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.number_of_points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_of_points.Name = "number_of_points";
            this.number_of_points.Size = new System.Drawing.Size(120, 22);
            this.number_of_points.TabIndex = 3;
            this.number_of_points.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label_choose_NoP
            // 
            this.label_choose_NoP.AutoSize = true;
            this.label_choose_NoP.BackColor = System.Drawing.SystemColors.Control;
            this.label_choose_NoP.Location = new System.Drawing.Point(117, 208);
            this.label_choose_NoP.Name = "label_choose_NoP";
            this.label_choose_NoP.Size = new System.Drawing.Size(233, 16);
            this.label_choose_NoP.TabIndex = 9;
            this.label_choose_NoP.Text = "Количество точек для осреднения";
            // 
            // button_select_DOCX_in
            // 
            this.button_select_DOCX_in.BackColor = System.Drawing.SystemColors.Control;
            this.button_select_DOCX_in.BackgroundImage = global::BoilingDataProcessingWF.Properties.Resources.DocxIcon;
            this.button_select_DOCX_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select_DOCX_in.Location = new System.Drawing.Point(61, 105);
            this.button_select_DOCX_in.Name = "button_select_DOCX_in";
            this.button_select_DOCX_in.Size = new System.Drawing.Size(35, 35);
            this.button_select_DOCX_in.TabIndex = 4;
            this.button_select_DOCX_in.UseVisualStyleBackColor = false;
            this.button_select_DOCX_in.Click += new System.EventHandler(this.Select_DOCX_in);
            // 
            // label_XLSX_out
            // 
            this.label_XLSX_out.BackColor = System.Drawing.Color.White;
            this.label_XLSX_out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_XLSX_out.Location = new System.Drawing.Point(120, 165);
            this.label_XLSX_out.Name = "label_XLSX_out";
            this.label_XLSX_out.Size = new System.Drawing.Size(360, 30);
            this.label_XLSX_out.TabIndex = 7;
            // 
            // button_select_XLSX_out
            // 
            this.button_select_XLSX_out.BackColor = System.Drawing.SystemColors.Control;
            this.button_select_XLSX_out.BackgroundImage = global::BoilingDataProcessingWF.Properties.Resources.XlsxIcon;
            this.button_select_XLSX_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select_XLSX_out.Location = new System.Drawing.Point(61, 163);
            this.button_select_XLSX_out.Name = "button_select_XLSX_out";
            this.button_select_XLSX_out.Size = new System.Drawing.Size(35, 35);
            this.button_select_XLSX_out.TabIndex = 5;
            this.button_select_XLSX_out.UseVisualStyleBackColor = false;
            this.button_select_XLSX_out.Click += new System.EventHandler(this.Select_XLSX_out);
            // 
            // label_DOCX_in
            // 
            this.label_DOCX_in.BackColor = System.Drawing.Color.White;
            this.label_DOCX_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_DOCX_in.Location = new System.Drawing.Point(120, 107);
            this.label_DOCX_in.Name = "label_DOCX_in";
            this.label_DOCX_in.Size = new System.Drawing.Size(360, 30);
            this.label_DOCX_in.TabIndex = 6;
            // 
            // tabPageBoilingCurves
            // 
            this.tabPageBoilingCurves.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBoilingCurves.Controls.Add(this.box_Pressure);
            this.tabPageBoilingCurves.Controls.Add(this.chartBC);
            this.tabPageBoilingCurves.Location = new System.Drawing.Point(4, 25);
            this.tabPageBoilingCurves.Name = "tabPageBoilingCurves";
            this.tabPageBoilingCurves.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBoilingCurves.Size = new System.Drawing.Size(774, 424);
            this.tabPageBoilingCurves.TabIndex = 1;
            this.tabPageBoilingCurves.Text = "Кривые кипения";
            // 
            // box_Pressure
            // 
            this.box_Pressure.FormattingEnabled = true;
            this.box_Pressure.Location = new System.Drawing.Point(558, 32);
            this.box_Pressure.Name = "box_Pressure";
            this.box_Pressure.Size = new System.Drawing.Size(153, 24);
            this.box_Pressure.TabIndex = 1;
            this.box_Pressure.Tag = "";
            // 
            // chartBC
            // 
            this.chartBC.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartBC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBC.Legends.Add(legend1);
            this.chartBC.Location = new System.Drawing.Point(8, 6);
            this.chartBC.Name = "chartBC";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBC.Series.Add(series1);
            this.chartBC.Size = new System.Drawing.Size(380, 365);
            this.chartBC.TabIndex = 0;
            this.chartBC.Text = "chart1";
            // 
            // tabPageCHF
            // 
            this.tabPageCHF.Location = new System.Drawing.Point(4, 25);
            this.tabPageCHF.Name = "tabPageCHF";
            this.tabPageCHF.Size = new System.Drawing.Size(774, 424);
            this.tabPageCHF.TabIndex = 2;
            this.tabPageCHF.Text = "КТП";
            this.tabPageCHF.UseVisualStyleBackColor = true;
            // 
            // customProgressBar
            // 
            this.customProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.customProgressBar.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.customProgressBar.ChannelHeight = 10;
            this.customProgressBar.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.customProgressBar.ForeColor = System.Drawing.SystemColors.Control;
            this.customProgressBar.Location = new System.Drawing.Point(100, 39);
            this.customProgressBar.Name = "customProgressBar";
            this.customProgressBar.ShowMaximun = false;
            this.customProgressBar.ShowValue = BoilingDataProcessingWF.TextPosition.Sliding;
            this.customProgressBar.Size = new System.Drawing.Size(600, 32);
            this.customProgressBar.SliderColor = System.Drawing.Color.MediumPurple;
            this.customProgressBar.SliderHeight = 10;
            this.customProgressBar.SymbolAfter = "";
            this.customProgressBar.SymbolBefore = "";
            this.customProgressBar.TabIndex = 9;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "AppForm";
            this.Text = "Boiling Data Processing";
            this.tableLayoutPanelFull.ResumeLayout(false);
            this.ProcessPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageProcessing.ResumeLayout(false);
            this.UIPanel.ResumeLayout(false);
            this.UIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_points)).EndInit();
            this.tabPageBoilingCurves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openExperimentFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFull;
        private System.Windows.Forms.SaveFileDialog createFileDialog;
        private System.Windows.Forms.Panel ProcessPanel;
        private CustomProgressBar customProgressBar;
        private System.Windows.Forms.Button button_process;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageProcessing;
        private System.Windows.Forms.Panel UIPanel;
        private System.Windows.Forms.CheckBox checkBox_OpenFile;
        private System.Windows.Forms.CheckBox checkBox_CreateFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_XLSX_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_select_XLSX_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown number_of_points;
        private System.Windows.Forms.Label label_choose_NoP;
        private System.Windows.Forms.Button button_select_DOCX_in;
        private System.Windows.Forms.Label label_XLSX_out;
        private System.Windows.Forms.Button button_select_XLSX_out;
        private System.Windows.Forms.Label label_DOCX_in;
        private System.Windows.Forms.TabPage tabPageBoilingCurves;
        private System.Windows.Forms.TabPage tabPageCHF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBC;
        private System.Windows.Forms.ComboBox box_Pressure;
    }
}

