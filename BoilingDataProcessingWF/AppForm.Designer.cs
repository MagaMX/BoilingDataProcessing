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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openExperimentFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelFull = new System.Windows.Forms.TableLayoutPanel();
            this.ProcessPanel = new System.Windows.Forms.Panel();
            this.customProgressBar = new BoilingDataProcessingWF.CustomProgressBar();
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
            this.label_DataGridBC = new System.Windows.Forms.Label();
            this.dataGridViewBC = new System.Windows.Forms.DataGridView();
            this.checkBox_Logarithm = new System.Windows.Forms.CheckBox();
            this.button_GenerateChartCurve = new System.Windows.Forms.Button();
            this.labelPressureChoice = new System.Windows.Forms.Label();
            this.Box_PressureBC = new System.Windows.Forms.ComboBox();
            this.chartBC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageCHF = new System.Windows.Forms.TabPage();
            this.label_Kandlikar = new System.Windows.Forms.Label();
            this.label_Kutateladze = new System.Windows.Forms.Label();
            this.label_Yagov = new System.Windows.Forms.Label();
            this.labelCHFIncrease = new System.Windows.Forms.Label();
            this.chartCHF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_GenerateChartCHF = new System.Windows.Forms.Button();
            this.labelPressureChoiceCHF = new System.Windows.Forms.Label();
            this.Box_PressureCHF = new System.Windows.Forms.ComboBox();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanelFull.SuspendLayout();
            this.ProcessPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageProcessing.SuspendLayout();
            this.UIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_points)).BeginInit();
            this.tabPageBoilingCurves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBC)).BeginInit();
            this.tabPageCHF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCHF)).BeginInit();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
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
            this.tableLayoutPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanelFull.Size = new System.Drawing.Size(868, 448);
            this.tableLayoutPanelFull.TabIndex = 13;
            // 
            // ProcessPanel
            // 
            this.ProcessPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ProcessPanel.Controls.Add(this.customProgressBar);
            this.ProcessPanel.Controls.Add(this.button_process);
            this.ProcessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProcessPanel.Location = new System.Drawing.Point(3, 296);
            this.ProcessPanel.Name = "ProcessPanel";
            this.ProcessPanel.Size = new System.Drawing.Size(862, 149);
            this.ProcessPanel.TabIndex = 10;
            // 
            // customProgressBar
            // 
            this.customProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.customProgressBar.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.customProgressBar.ChannelHeight = 10;
            this.customProgressBar.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.customProgressBar.ForeColor = System.Drawing.SystemColors.Control;
            this.customProgressBar.Location = new System.Drawing.Point(134, 52);
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
            // button_process
            // 
            this.button_process.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_process.Location = new System.Drawing.Point(400, 20);
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
            this.tabControl.Controls.Add(this.tabPageInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(882, 483);
            this.tabControl.TabIndex = 15;
            // 
            // tabPageProcessing
            // 
            this.tabPageProcessing.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProcessing.Controls.Add(this.UIPanel);
            this.tabPageProcessing.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessing.Name = "tabPageProcessing";
            this.tabPageProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessing.Size = new System.Drawing.Size(874, 454);
            this.tabPageProcessing.TabIndex = 0;
            this.tabPageProcessing.Text = "Обработка";
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
            this.UIPanel.Size = new System.Drawing.Size(868, 448);
            this.UIPanel.TabIndex = 1;
            // 
            // checkBox_OpenFile
            // 
            this.checkBox_OpenFile.AutoSize = true;
            this.checkBox_OpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_OpenFile.Location = new System.Drawing.Point(500, 208);
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
            this.checkBox_CreateFile.Location = new System.Drawing.Point(500, 170);
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
            this.label3.Location = new System.Drawing.Point(131, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Файл записи обработки:";
            // 
            // label_XLSX_in
            // 
            this.label_XLSX_in.BackColor = System.Drawing.Color.White;
            this.label_XLSX_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_XLSX_in.Location = new System.Drawing.Point(134, 49);
            this.label_XLSX_in.Name = "label_XLSX_in";
            this.label_XLSX_in.Size = new System.Drawing.Size(360, 30);
            this.label_XLSX_in.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(131, 85);
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
            this.button_select_XLSX_in.Location = new System.Drawing.Point(75, 47);
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
            this.label1.Location = new System.Drawing.Point(131, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Файл эксперимента:";
            // 
            // number_of_points
            // 
            this.number_of_points.Location = new System.Drawing.Point(134, 227);
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
            this.label_choose_NoP.Location = new System.Drawing.Point(131, 208);
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
            this.button_select_DOCX_in.Location = new System.Drawing.Point(75, 105);
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
            this.label_XLSX_out.Location = new System.Drawing.Point(134, 165);
            this.label_XLSX_out.Name = "label_XLSX_out";
            this.label_XLSX_out.Size = new System.Drawing.Size(360, 30);
            this.label_XLSX_out.TabIndex = 7;
            // 
            // button_select_XLSX_out
            // 
            this.button_select_XLSX_out.BackColor = System.Drawing.SystemColors.Control;
            this.button_select_XLSX_out.BackgroundImage = global::BoilingDataProcessingWF.Properties.Resources.XlsxIcon;
            this.button_select_XLSX_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select_XLSX_out.Location = new System.Drawing.Point(75, 163);
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
            this.label_DOCX_in.Location = new System.Drawing.Point(134, 107);
            this.label_DOCX_in.Name = "label_DOCX_in";
            this.label_DOCX_in.Size = new System.Drawing.Size(360, 30);
            this.label_DOCX_in.TabIndex = 6;
            // 
            // tabPageBoilingCurves
            // 
            this.tabPageBoilingCurves.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBoilingCurves.Controls.Add(this.label_DataGridBC);
            this.tabPageBoilingCurves.Controls.Add(this.dataGridViewBC);
            this.tabPageBoilingCurves.Controls.Add(this.checkBox_Logarithm);
            this.tabPageBoilingCurves.Controls.Add(this.button_GenerateChartCurve);
            this.tabPageBoilingCurves.Controls.Add(this.labelPressureChoice);
            this.tabPageBoilingCurves.Controls.Add(this.Box_PressureBC);
            this.tabPageBoilingCurves.Controls.Add(this.chartBC);
            this.tabPageBoilingCurves.Location = new System.Drawing.Point(4, 25);
            this.tabPageBoilingCurves.Name = "tabPageBoilingCurves";
            this.tabPageBoilingCurves.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBoilingCurves.Size = new System.Drawing.Size(874, 454);
            this.tabPageBoilingCurves.TabIndex = 1;
            this.tabPageBoilingCurves.Text = "Кривые кипения";
            // 
            // label_DataGridBC
            // 
            this.label_DataGridBC.AutoSize = true;
            this.label_DataGridBC.Location = new System.Drawing.Point(497, 115);
            this.label_DataGridBC.Name = "label_DataGridBC";
            this.label_DataGridBC.Size = new System.Drawing.Size(109, 16);
            this.label_DataGridBC.TabIndex = 6;
            this.label_DataGridBC.Text = "Табица данных:";
            // 
            // dataGridViewBC
            // 
            this.dataGridViewBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBC.Location = new System.Drawing.Point(497, 137);
            this.dataGridViewBC.Name = "dataGridViewBC";
            this.dataGridViewBC.RowHeadersWidth = 51;
            this.dataGridViewBC.RowTemplate.Height = 24;
            this.dataGridViewBC.Size = new System.Drawing.Size(333, 233);
            this.dataGridViewBC.TabIndex = 5;
            // 
            // checkBox_Logarithm
            // 
            this.checkBox_Logarithm.AutoSize = true;
            this.checkBox_Logarithm.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Logarithm.Location = new System.Drawing.Point(661, 56);
            this.checkBox_Logarithm.Name = "checkBox_Logarithm";
            this.checkBox_Logarithm.Size = new System.Drawing.Size(191, 37);
            this.checkBox_Logarithm.TabIndex = 4;
            this.checkBox_Logarithm.Text = "Логарифмический масштаб";
            this.checkBox_Logarithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Logarithm.UseVisualStyleBackColor = true;
            // 
            // button_GenerateChartCurve
            // 
            this.button_GenerateChartCurve.Location = new System.Drawing.Point(677, 99);
            this.button_GenerateChartCurve.Name = "button_GenerateChartCurve";
            this.button_GenerateChartCurve.Size = new System.Drawing.Size(153, 32);
            this.button_GenerateChartCurve.TabIndex = 3;
            this.button_GenerateChartCurve.Text = "Построить график";
            this.button_GenerateChartCurve.UseVisualStyleBackColor = true;
            // 
            // labelPressureChoice
            // 
            this.labelPressureChoice.AutoSize = true;
            this.labelPressureChoice.Location = new System.Drawing.Point(677, 7);
            this.labelPressureChoice.Name = "labelPressureChoice";
            this.labelPressureChoice.Size = new System.Drawing.Size(142, 16);
            this.labelPressureChoice.TabIndex = 2;
            this.labelPressureChoice.Text = "Выберите давление:";
            // 
            // Box_PressureBC
            // 
            this.Box_PressureBC.FormattingEnabled = true;
            this.Box_PressureBC.Location = new System.Drawing.Point(677, 26);
            this.Box_PressureBC.Name = "Box_PressureBC";
            this.Box_PressureBC.Size = new System.Drawing.Size(153, 24);
            this.Box_PressureBC.TabIndex = 1;
            this.Box_PressureBC.Tag = "";
            // 
            // chartBC
            // 
            this.chartBC.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.Title = "ΔT, °C";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.Title = "q,  кВт/м2";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            chartArea3.Name = "ChartArea1";
            this.chartBC.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.White;
            this.chartBC.Legends.Add(legend3);
            this.chartBC.Location = new System.Drawing.Point(0, 0);
            this.chartBC.Name = "chartBC";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Black;
            series7.Legend = "Legend1";
            series7.Name = "Кривая Ягова";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.MarkerColor = System.Drawing.Color.Red;
            series8.MarkerSize = 6;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Эксперимент";
            this.chartBC.Series.Add(series7);
            this.chartBC.Series.Add(series8);
            this.chartBC.Size = new System.Drawing.Size(675, 451);
            this.chartBC.TabIndex = 0;
            this.chartBC.Text = "chart1";
            // 
            // tabPageCHF
            // 
            this.tabPageCHF.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCHF.Controls.Add(this.label_Kandlikar);
            this.tabPageCHF.Controls.Add(this.label_Kutateladze);
            this.tabPageCHF.Controls.Add(this.label_Yagov);
            this.tabPageCHF.Controls.Add(this.labelCHFIncrease);
            this.tabPageCHF.Controls.Add(this.chartCHF);
            this.tabPageCHF.Controls.Add(this.button_GenerateChartCHF);
            this.tabPageCHF.Controls.Add(this.labelPressureChoiceCHF);
            this.tabPageCHF.Controls.Add(this.Box_PressureCHF);
            this.tabPageCHF.Location = new System.Drawing.Point(4, 25);
            this.tabPageCHF.Name = "tabPageCHF";
            this.tabPageCHF.Size = new System.Drawing.Size(874, 454);
            this.tabPageCHF.TabIndex = 2;
            this.tabPageCHF.Text = "КТП";
            // 
            // label_Kandlikar
            // 
            this.label_Kandlikar.AutoSize = true;
            this.label_Kandlikar.Location = new System.Drawing.Point(491, 198);
            this.label_Kandlikar.Name = "label_Kandlikar";
            this.label_Kandlikar.Size = new System.Drawing.Size(78, 16);
            this.label_Kandlikar.TabIndex = 9;
            this.label_Kandlikar.Text = "Кандликар";
            // 
            // label_Kutateladze
            // 
            this.label_Kutateladze.AutoSize = true;
            this.label_Kutateladze.Location = new System.Drawing.Point(491, 182);
            this.label_Kutateladze.Name = "label_Kutateladze";
            this.label_Kutateladze.Size = new System.Drawing.Size(93, 16);
            this.label_Kutateladze.TabIndex = 8;
            this.label_Kutateladze.Text = "Кутателадзе";
            // 
            // label_Yagov
            // 
            this.label_Yagov.AutoSize = true;
            this.label_Yagov.Location = new System.Drawing.Point(491, 166);
            this.label_Yagov.Name = "label_Yagov";
            this.label_Yagov.Size = new System.Drawing.Size(39, 16);
            this.label_Yagov.TabIndex = 7;
            this.label_Yagov.Text = "Ягов";
            // 
            // labelCHFIncrease
            // 
            this.labelCHFIncrease.AutoSize = true;
            this.labelCHFIncrease.Location = new System.Drawing.Point(491, 131);
            this.labelCHFIncrease.Name = "labelCHFIncrease";
            this.labelCHFIncrease.Size = new System.Drawing.Size(124, 16);
            this.labelCHFIncrease.TabIndex = 6;
            this.labelCHFIncrease.Text = "Увеличение  КТП:";
            // 
            // chartCHF
            // 
            this.chartCHF.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.AxisX.Title = "p, атм";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisY.Title = "q,  кВт/м2";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartCHF.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCHF.Legends.Add(legend4);
            this.chartCHF.Location = new System.Drawing.Point(0, 0);
            this.chartCHF.Name = "chartCHF";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.MarkerSize = 8;
            series9.Name = "Эксперимент";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.MarkerSize = 8;
            series10.Name = "Ягов";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Legend1";
            series11.MarkerSize = 8;
            series11.Name = "Кутателадзе";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.MarkerColor = System.Drawing.Color.DarkGreen;
            series12.MarkerSize = 8;
            series12.Name = "Кандликар";
            this.chartCHF.Series.Add(series9);
            this.chartCHF.Series.Add(series10);
            this.chartCHF.Series.Add(series11);
            this.chartCHF.Series.Add(series12);
            this.chartCHF.Size = new System.Drawing.Size(675, 451);
            this.chartCHF.TabIndex = 5;
            this.chartCHF.Text = "chart1";
            // 
            // button_GenerateChartCHF
            // 
            this.button_GenerateChartCHF.Location = new System.Drawing.Point(677, 56);
            this.button_GenerateChartCHF.Name = "button_GenerateChartCHF";
            this.button_GenerateChartCHF.Size = new System.Drawing.Size(153, 32);
            this.button_GenerateChartCHF.TabIndex = 4;
            this.button_GenerateChartCHF.Text = "Построить график";
            this.button_GenerateChartCHF.UseVisualStyleBackColor = true;
            // 
            // labelPressureChoiceCHF
            // 
            this.labelPressureChoiceCHF.AutoSize = true;
            this.labelPressureChoiceCHF.Location = new System.Drawing.Point(677, 7);
            this.labelPressureChoiceCHF.Name = "labelPressureChoiceCHF";
            this.labelPressureChoiceCHF.Size = new System.Drawing.Size(142, 16);
            this.labelPressureChoiceCHF.TabIndex = 3;
            this.labelPressureChoiceCHF.Text = "Выберите давление:";
            // 
            // Box_PressureCHF
            // 
            this.Box_PressureCHF.FormattingEnabled = true;
            this.Box_PressureCHF.Location = new System.Drawing.Point(677, 26);
            this.Box_PressureCHF.Name = "Box_PressureCHF";
            this.Box_PressureCHF.Size = new System.Drawing.Size(153, 24);
            this.Box_PressureCHF.TabIndex = 2;
            this.Box_PressureCHF.Tag = "";
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageInfo.Controls.Add(this.labelAuthor);
            this.tabPageInfo.Controls.Add(this.labelVersion);
            this.tabPageInfo.Controls.Add(this.pictureBoxLogo);
            this.tabPageInfo.Controls.Add(this.labelInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(874, 454);
            this.tabPageInfo.TabIndex = 3;
            this.tabPageInfo.Text = "О программе";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(416, 127);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(410, 16);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Copyright © Maksim Filippov, Z Corporation 2024. All rights reserved.";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(416, 92);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(177, 16);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Версия 1.0 | 64 - разрядная";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BoilingDataProcessingWF.Properties.Resources.Z_Corp_Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(8, 38);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(375, 375);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(413, 38);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(332, 32);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Boling Data Processing";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 483);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(900, 530);
            this.MinimumSize = new System.Drawing.Size(900, 530);
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
            this.tabPageBoilingCurves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBC)).EndInit();
            this.tabPageCHF.ResumeLayout(false);
            this.tabPageCHF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCHF)).EndInit();
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
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
        private System.Windows.Forms.ComboBox Box_PressureBC;
        private System.Windows.Forms.Label labelPressureChoice;
        private System.Windows.Forms.Button button_GenerateChartCurve;
        private System.Windows.Forms.CheckBox checkBox_Logarithm;
        private System.Windows.Forms.DataGridView dataGridViewBC;
        private System.Windows.Forms.Label label_DataGridBC;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelPressureChoiceCHF;
        private System.Windows.Forms.ComboBox Box_PressureCHF;
        private System.Windows.Forms.Button button_GenerateChartCHF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCHF;
        private System.Windows.Forms.Label labelCHFIncrease;
        private System.Windows.Forms.Label label_Kandlikar;
        private System.Windows.Forms.Label label_Kutateladze;
        private System.Windows.Forms.Label label_Yagov;
    }
}

