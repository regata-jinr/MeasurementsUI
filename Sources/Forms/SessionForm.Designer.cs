﻿using Measurements.UI.Desktop.Components;

namespace Measurements.UI.Desktop.Forms
{ 
    partial class SessionForm
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
          
            Measurements.UI.Managers.ProcessManager.CloseMvcg();
            _session?.Dispose();
            Measurements.Core.SessionControllerSingleton.AvailableDetectorsListHasChanged -= InitializeDetectorDropDownItems;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SessionFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveSession = new System.Windows.Forms.ToolStripMenuItem();
            this.SessionFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SessionFormButtonStart = new System.Windows.Forms.Button();
            this.SessionFormButtonPause = new System.Windows.Forms.Button();
            this.MenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.SessionFormButtonStop = new System.Windows.Forms.Button();
            this.SessionFormButtonClear = new System.Windows.Forms.Button();
            this.SessionFormAdvancedDataGridViewSearchToolBar = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.SessionFormControlPanel = new System.Windows.Forms.GroupBox();
            this.SessionFormAdvancedDataGridViewMeasurementsJournal = new Zuby.ADGV.AdvancedDataGridView();
            this.SessionFormGroupBoxFormMeasurementsJournal = new System.Windows.Forms.GroupBox();
            this.SessionFormlButtonAddSelectedToJournal = new System.Windows.Forms.Button();
            this.SessionFormButtonRemoveSelectedFromJournal = new System.Windows.Forms.Button();
            this.SessionFormGroupBoxDuration = new System.Windows.Forms.GroupBox();
            this.SessionFormLabelDays = new System.Windows.Forms.Label();
            this.SessionFormNumericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.SessionFormNumericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.SessionFormLabelMinutes = new System.Windows.Forms.Label();
            this.SessionFormNumericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.SessionFormLabelSeconds = new System.Windows.Forms.Label();
            this.SessionFormLabelHours = new System.Windows.Forms.Label();
            this.SessionFormNumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.SessionFormGroupBoxDetectors = new System.Windows.Forms.GroupBox();
            this.SessionFormGroupBoxHeights = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SessionFormsRadioButtonHeight2_5 = new System.Windows.Forms.RadioButton();
            this.SessionFormGroupBoxIrradiationJournalsData = new System.Windows.Forms.GroupBox();
            this.SessionFormLabelIrradiatedSamplesTitle = new System.Windows.Forms.Label();
            this.SessionFormLableIrradiationsJournalsTitle = new System.Windows.Forms.Label();
            this.SessionFormAdvancedDataGridViewIrradiationsJournals = new Zuby.ADGV.AdvancedDataGridView();
            this.SessionFormAdvancedDataGridViewIrradiatedSamples = new Zuby.ADGV.AdvancedDataGridView();
            this.SessionFormMenuStrip.SuspendLayout();
            this.SessionFormControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormAdvancedDataGridViewMeasurementsJournal)).BeginInit();
            this.SessionFormGroupBoxFormMeasurementsJournal.SuspendLayout();
            this.SessionFormGroupBoxDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownHours)).BeginInit();
            this.SessionFormGroupBoxHeights.SuspendLayout();
            this.SessionFormGroupBoxIrradiationJournalsData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormAdvancedDataGridViewIrradiationsJournals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormAdvancedDataGridViewIrradiatedSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionFormMenuStrip
            // 
            this.SessionFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenu});
            this.SessionFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SessionFormMenuStrip.Name = "SessionFormMenuStrip";
            this.SessionFormMenuStrip.Size = new System.Drawing.Size(1412, 24);
            this.SessionFormMenuStrip.TabIndex = 0;
            this.SessionFormMenuStrip.Text = "menuStrip1";
            // 
            // MenuMenu
            // 
            this.MenuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSaveSession});
            this.MenuMenu.Name = "MenuMenu";
            this.MenuMenu.Size = new System.Drawing.Size(53, 20);
            this.MenuMenu.Text = "Меню";
            // 
            // MenuSaveSession
            // 
            this.MenuSaveSession.Name = "MenuSaveSession";
            this.MenuSaveSession.Size = new System.Drawing.Size(177, 22);
            this.MenuSaveSession.Text = "Сохранить сессию";
            this.MenuSaveSession.Click += new System.EventHandler(this.MenuSaveSession_Click);
            // 
            // SessionFormStatusStrip
            // 
            this.SessionFormStatusStrip.Location = new System.Drawing.Point(0, 755);
            this.SessionFormStatusStrip.Name = "SessionFormStatusStrip";
            this.SessionFormStatusStrip.Size = new System.Drawing.Size(1412, 22);
            this.SessionFormStatusStrip.TabIndex = 1;
            this.SessionFormStatusStrip.Text = "statusStrip1";
            // 
            // SessionFormButtonStart
            // 
            this.SessionFormButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionFormButtonStart.BackColor = System.Drawing.Color.Green;
            this.SessionFormButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormButtonStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SessionFormButtonStart.Location = new System.Drawing.Point(248, 26);
            this.SessionFormButtonStart.Name = "SessionFormButtonStart";
            this.SessionFormButtonStart.Size = new System.Drawing.Size(75, 43);
            this.SessionFormButtonStart.TabIndex = 5;
            this.SessionFormButtonStart.Text = "Start";
            this.SessionFormButtonStart.UseVisualStyleBackColor = false;
            this.SessionFormButtonStart.Click += new System.EventHandler(this.SessionFormButtonStart_Click);
            // 
            // SessionFormButtonPause
            // 
            this.SessionFormButtonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionFormButtonPause.BackColor = System.Drawing.Color.DimGray;
            this.SessionFormButtonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormButtonPause.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SessionFormButtonPause.Location = new System.Drawing.Point(167, 26);
            this.SessionFormButtonPause.Name = "SessionFormButtonPause";
            this.SessionFormButtonPause.Size = new System.Drawing.Size(75, 43);
            this.SessionFormButtonPause.TabIndex = 9;
            this.SessionFormButtonPause.Text = "Pause";
            this.SessionFormButtonPause.UseVisualStyleBackColor = false;
            this.SessionFormButtonPause.Click += new System.EventHandler(this.SessionFormButtonPause_Click);
            // 
            // MenuOptions
            // 
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(32, 19);
            this.MenuOptions.Text = "Опции";
            // 
            // SessionFormButtonStop
            // 
            this.SessionFormButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionFormButtonStop.BackColor = System.Drawing.Color.Maroon;
            this.SessionFormButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormButtonStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SessionFormButtonStop.Location = new System.Drawing.Point(5, 26);
            this.SessionFormButtonStop.Name = "SessionFormButtonStop";
            this.SessionFormButtonStop.Size = new System.Drawing.Size(75, 43);
            this.SessionFormButtonStop.TabIndex = 11;
            this.SessionFormButtonStop.Text = "Stop";
            this.SessionFormButtonStop.UseVisualStyleBackColor = false;
            this.SessionFormButtonStop.Click += new System.EventHandler(this.SessionFormButtonStop_Click);
            // 
            // SessionFormButtonClear
            // 
            this.SessionFormButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionFormButtonClear.BackColor = System.Drawing.Color.White;
            this.SessionFormButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormButtonClear.ForeColor = System.Drawing.Color.Black;
            this.SessionFormButtonClear.Location = new System.Drawing.Point(86, 26);
            this.SessionFormButtonClear.Name = "SessionFormButtonClear";
            this.SessionFormButtonClear.Size = new System.Drawing.Size(75, 43);
            this.SessionFormButtonClear.TabIndex = 12;
            this.SessionFormButtonClear.Text = "Clear";
            this.SessionFormButtonClear.UseVisualStyleBackColor = false;
            this.SessionFormButtonClear.Click += new System.EventHandler(this.SessionFormButtonClear_Click);
            // 
            // SessionFormAdvancedDataGridViewSearchToolBar
            // 
            this.SessionFormAdvancedDataGridViewSearchToolBar.AllowMerge = false;
            this.SessionFormAdvancedDataGridViewSearchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SessionFormAdvancedDataGridViewSearchToolBar.Location = new System.Drawing.Point(0, 24);
            this.SessionFormAdvancedDataGridViewSearchToolBar.MaximumSize = new System.Drawing.Size(0, 27);
            this.SessionFormAdvancedDataGridViewSearchToolBar.MinimumSize = new System.Drawing.Size(0, 27);
            this.SessionFormAdvancedDataGridViewSearchToolBar.Name = "SessionFormAdvancedDataGridViewSearchToolBar";
            this.SessionFormAdvancedDataGridViewSearchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SessionFormAdvancedDataGridViewSearchToolBar.Size = new System.Drawing.Size(1412, 27);
            this.SessionFormAdvancedDataGridViewSearchToolBar.TabIndex = 14;
            this.SessionFormAdvancedDataGridViewSearchToolBar.Text = "advancedDataGridViewSearchToolBar1";
            this.SessionFormAdvancedDataGridViewSearchToolBar.Search += new Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventHandler(this.SessionFormAdvancedDataGridViewSearchToolBar_Search);
            // 
            // SessionFormControlPanel
            // 
            this.SessionFormControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionFormControlPanel.Controls.Add(this.SessionFormButtonPause);
            this.SessionFormControlPanel.Controls.Add(this.SessionFormButtonStart);
            this.SessionFormControlPanel.Controls.Add(this.SessionFormButtonStop);
            this.SessionFormControlPanel.Controls.Add(this.SessionFormButtonClear);
            this.SessionFormControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormControlPanel.Location = new System.Drawing.Point(1073, 678);
            this.SessionFormControlPanel.Name = "SessionFormControlPanel";
            this.SessionFormControlPanel.Size = new System.Drawing.Size(331, 75);
            this.SessionFormControlPanel.TabIndex = 16;
            this.SessionFormControlPanel.TabStop = false;
            this.SessionFormControlPanel.Text = "Управление измерениями";
            // 
            // SessionFormAdvancedDataGridViewMeasurementsJournal
            // 
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.AllowUserToAddRows = false;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.AllowUserToDeleteRows = false;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.AllowUserToResizeRows = false;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.FilterAndSortEnabled = true;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.Location = new System.Drawing.Point(12, 54);
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.Name = "SessionFormAdvancedDataGridViewMeasurementsJournal";
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.RowHeadersVisible = false;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.Size = new System.Drawing.Size(1392, 465);
            this.SessionFormAdvancedDataGridViewMeasurementsJournal.TabIndex = 10;
            // 
            // SessionFormGroupBoxFormMeasurementsJournal
            // 
            this.SessionFormGroupBoxFormMeasurementsJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormGroupBoxFormMeasurementsJournal.Controls.Add(this.SessionFormlButtonAddSelectedToJournal);
            this.SessionFormGroupBoxFormMeasurementsJournal.Controls.Add(this.SessionFormButtonRemoveSelectedFromJournal);
            this.SessionFormGroupBoxFormMeasurementsJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormGroupBoxFormMeasurementsJournal.Location = new System.Drawing.Point(647, 524);
            this.SessionFormGroupBoxFormMeasurementsJournal.Name = "SessionFormGroupBoxFormMeasurementsJournal";
            this.SessionFormGroupBoxFormMeasurementsJournal.Size = new System.Drawing.Size(248, 148);
            this.SessionFormGroupBoxFormMeasurementsJournal.TabIndex = 24;
            this.SessionFormGroupBoxFormMeasurementsJournal.TabStop = false;
            this.SessionFormGroupBoxFormMeasurementsJournal.Text = "Формирование журнала";
            // 
            // SessionFormlButtonAddSelectedToJournal
            // 
            this.SessionFormlButtonAddSelectedToJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormlButtonAddSelectedToJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormlButtonAddSelectedToJournal.Location = new System.Drawing.Point(6, 27);
            this.SessionFormlButtonAddSelectedToJournal.Name = "SessionFormlButtonAddSelectedToJournal";
            this.SessionFormlButtonAddSelectedToJournal.Size = new System.Drawing.Size(231, 32);
            this.SessionFormlButtonAddSelectedToJournal.TabIndex = 6;
            this.SessionFormlButtonAddSelectedToJournal.Text = "Добавить";
            this.SessionFormlButtonAddSelectedToJournal.UseVisualStyleBackColor = true;
            this.SessionFormlButtonAddSelectedToJournal.Click += new System.EventHandler(this.SessionFormlButtonAddSelectedToJournal_Click);
            // 
            // SessionFormButtonRemoveSelectedFromJournal
            // 
            this.SessionFormButtonRemoveSelectedFromJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormButtonRemoveSelectedFromJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormButtonRemoveSelectedFromJournal.Location = new System.Drawing.Point(6, 107);
            this.SessionFormButtonRemoveSelectedFromJournal.Name = "SessionFormButtonRemoveSelectedFromJournal";
            this.SessionFormButtonRemoveSelectedFromJournal.Size = new System.Drawing.Size(231, 30);
            this.SessionFormButtonRemoveSelectedFromJournal.TabIndex = 17;
            this.SessionFormButtonRemoveSelectedFromJournal.Text = "Удалить";
            this.SessionFormButtonRemoveSelectedFromJournal.UseVisualStyleBackColor = true;
            // 
            // SessionFormGroupBoxDuration
            // 
            this.SessionFormGroupBoxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormLabelDays);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormNumericUpDownDays);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormNumericUpDownMinutes);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormLabelMinutes);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormNumericUpDownSeconds);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormLabelSeconds);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormLabelHours);
            this.SessionFormGroupBoxDuration.Controls.Add(this.SessionFormNumericUpDownHours);
            this.SessionFormGroupBoxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormGroupBoxDuration.Location = new System.Drawing.Point(901, 524);
            this.SessionFormGroupBoxDuration.Name = "SessionFormGroupBoxDuration";
            this.SessionFormGroupBoxDuration.Size = new System.Drawing.Size(223, 148);
            this.SessionFormGroupBoxDuration.TabIndex = 23;
            this.SessionFormGroupBoxDuration.TabStop = false;
            this.SessionFormGroupBoxDuration.Text = "Продолжительность измерения выбранных образцов";
            // 
            // SessionFormLabelDays
            // 
            this.SessionFormLabelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormLabelDays.Location = new System.Drawing.Point(6, 74);
            this.SessionFormLabelDays.Name = "SessionFormLabelDays";
            this.SessionFormLabelDays.Size = new System.Drawing.Size(48, 21);
            this.SessionFormLabelDays.TabIndex = 16;
            this.SessionFormLabelDays.Text = "Дни";
            this.SessionFormLabelDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionFormNumericUpDownDays
            // 
            this.SessionFormNumericUpDownDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormNumericUpDownDays.Location = new System.Drawing.Point(6, 98);
            this.SessionFormNumericUpDownDays.Name = "SessionFormNumericUpDownDays";
            this.SessionFormNumericUpDownDays.Size = new System.Drawing.Size(48, 22);
            this.SessionFormNumericUpDownDays.TabIndex = 15;
            // 
            // SessionFormNumericUpDownMinutes
            // 
            this.SessionFormNumericUpDownMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormNumericUpDownMinutes.Location = new System.Drawing.Point(114, 98);
            this.SessionFormNumericUpDownMinutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SessionFormNumericUpDownMinutes.Name = "SessionFormNumericUpDownMinutes";
            this.SessionFormNumericUpDownMinutes.Size = new System.Drawing.Size(50, 22);
            this.SessionFormNumericUpDownMinutes.TabIndex = 13;
            // 
            // SessionFormLabelMinutes
            // 
            this.SessionFormLabelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormLabelMinutes.Location = new System.Drawing.Point(114, 74);
            this.SessionFormLabelMinutes.Name = "SessionFormLabelMinutes";
            this.SessionFormLabelMinutes.Size = new System.Drawing.Size(50, 21);
            this.SessionFormLabelMinutes.TabIndex = 14;
            this.SessionFormLabelMinutes.Text = "Мин.";
            this.SessionFormLabelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionFormNumericUpDownSeconds
            // 
            this.SessionFormNumericUpDownSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormNumericUpDownSeconds.Location = new System.Drawing.Point(170, 98);
            this.SessionFormNumericUpDownSeconds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SessionFormNumericUpDownSeconds.Name = "SessionFormNumericUpDownSeconds";
            this.SessionFormNumericUpDownSeconds.Size = new System.Drawing.Size(45, 22);
            this.SessionFormNumericUpDownSeconds.TabIndex = 9;
            // 
            // SessionFormLabelSeconds
            // 
            this.SessionFormLabelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormLabelSeconds.Location = new System.Drawing.Point(170, 74);
            this.SessionFormLabelSeconds.Name = "SessionFormLabelSeconds";
            this.SessionFormLabelSeconds.Size = new System.Drawing.Size(45, 21);
            this.SessionFormLabelSeconds.TabIndex = 10;
            this.SessionFormLabelSeconds.Text = "Сек.";
            this.SessionFormLabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionFormLabelHours
            // 
            this.SessionFormLabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormLabelHours.Location = new System.Drawing.Point(60, 74);
            this.SessionFormLabelHours.Name = "SessionFormLabelHours";
            this.SessionFormLabelHours.Size = new System.Drawing.Size(48, 21);
            this.SessionFormLabelHours.TabIndex = 12;
            this.SessionFormLabelHours.Text = "Часы";
            this.SessionFormLabelHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SessionFormNumericUpDownHours
            // 
            this.SessionFormNumericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormNumericUpDownHours.Location = new System.Drawing.Point(60, 98);
            this.SessionFormNumericUpDownHours.Name = "SessionFormNumericUpDownHours";
            this.SessionFormNumericUpDownHours.Size = new System.Drawing.Size(48, 22);
            this.SessionFormNumericUpDownHours.TabIndex = 11;
            // 
            // SessionFormGroupBoxDetectors
            // 
            this.SessionFormGroupBoxDetectors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormGroupBoxDetectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormGroupBoxDetectors.Location = new System.Drawing.Point(1130, 524);
            this.SessionFormGroupBoxDetectors.Name = "SessionFormGroupBoxDetectors";
            this.SessionFormGroupBoxDetectors.Size = new System.Drawing.Size(274, 68);
            this.SessionFormGroupBoxDetectors.TabIndex = 25;
            this.SessionFormGroupBoxDetectors.TabStop = false;
            this.SessionFormGroupBoxDetectors.Text = "Сменить детектор для выбранного образца";
            // 
            // SessionFormGroupBoxHeights
            // 
            this.SessionFormGroupBoxHeights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormGroupBoxHeights.Controls.Add(this.radioButton3);
            this.SessionFormGroupBoxHeights.Controls.Add(this.radioButton2);
            this.SessionFormGroupBoxHeights.Controls.Add(this.radioButton1);
            this.SessionFormGroupBoxHeights.Controls.Add(this.SessionFormsRadioButtonHeight2_5);
            this.SessionFormGroupBoxHeights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormGroupBoxHeights.Location = new System.Drawing.Point(1130, 598);
            this.SessionFormGroupBoxHeights.Name = "SessionFormGroupBoxHeights";
            this.SessionFormGroupBoxHeights.Size = new System.Drawing.Size(274, 74);
            this.SessionFormGroupBoxHeights.TabIndex = 26;
            this.SessionFormGroupBoxHeights.TabStop = false;
            this.SessionFormGroupBoxHeights.Text = "Установить высоту выбранного образца";
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(207, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "20";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(134, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(72, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // SessionFormsRadioButtonHeight2_5
            // 
            this.SessionFormsRadioButtonHeight2_5.Checked = true;
            this.SessionFormsRadioButtonHeight2_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormsRadioButtonHeight2_5.Location = new System.Drawing.Point(10, 38);
            this.SessionFormsRadioButtonHeight2_5.Name = "SessionFormsRadioButtonHeight2_5";
            this.SessionFormsRadioButtonHeight2_5.Size = new System.Drawing.Size(56, 21);
            this.SessionFormsRadioButtonHeight2_5.TabIndex = 0;
            this.SessionFormsRadioButtonHeight2_5.TabStop = true;
            this.SessionFormsRadioButtonHeight2_5.Text = "2.5";
            this.SessionFormsRadioButtonHeight2_5.UseVisualStyleBackColor = true;
            // 
            // SessionFormGroupBoxIrradiationJournalsData
            // 
            this.SessionFormGroupBoxIrradiationJournalsData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormGroupBoxIrradiationJournalsData.Controls.Add(this.SessionFormLabelIrradiatedSamplesTitle);
            this.SessionFormGroupBoxIrradiationJournalsData.Controls.Add(this.SessionFormLableIrradiationsJournalsTitle);
            this.SessionFormGroupBoxIrradiationJournalsData.Controls.Add(this.SessionFormAdvancedDataGridViewIrradiationsJournals);
            this.SessionFormGroupBoxIrradiationJournalsData.Controls.Add(this.SessionFormAdvancedDataGridViewIrradiatedSamples);
            this.SessionFormGroupBoxIrradiationJournalsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionFormGroupBoxIrradiationJournalsData.Location = new System.Drawing.Point(12, 524);
            this.SessionFormGroupBoxIrradiationJournalsData.Name = "SessionFormGroupBoxIrradiationJournalsData";
            this.SessionFormGroupBoxIrradiationJournalsData.Size = new System.Drawing.Size(629, 228);
            this.SessionFormGroupBoxIrradiationJournalsData.TabIndex = 18;
            this.SessionFormGroupBoxIrradiationJournalsData.TabStop = false;
            this.SessionFormGroupBoxIrradiationJournalsData.Text = "Данные из журналов облучений";
            // 
            // SessionFormLabelIrradiatedSamplesTitle
            // 
            this.SessionFormLabelIrradiatedSamplesTitle.Location = new System.Drawing.Point(202, 16);
            this.SessionFormLabelIrradiatedSamplesTitle.Name = "SessionFormLabelIrradiatedSamplesTitle";
            this.SessionFormLabelIrradiatedSamplesTitle.Size = new System.Drawing.Size(421, 16);
            this.SessionFormLabelIrradiatedSamplesTitle.TabIndex = 20;
            this.SessionFormLabelIrradiatedSamplesTitle.Text = "Список образцов из выбранного журнала";
            // 
            // SessionFormLableIrradiationsJournalsTitle
            // 
            this.SessionFormLableIrradiationsJournalsTitle.Location = new System.Drawing.Point(6, 16);
            this.SessionFormLableIrradiationsJournalsTitle.Name = "SessionFormLableIrradiationsJournalsTitle";
            this.SessionFormLableIrradiationsJournalsTitle.Size = new System.Drawing.Size(193, 16);
            this.SessionFormLableIrradiationsJournalsTitle.TabIndex = 19;
            this.SessionFormLableIrradiationsJournalsTitle.Text = "Список журналов";
            // 
            // SessionFormAdvancedDataGridViewIrradiationsJournals
            // 
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.BackgroundColor = System.Drawing.Color.White;
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.FilterAndSortEnabled = true;
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.Location = new System.Drawing.Point(6, 38);
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.Name = "SessionFormAdvancedDataGridViewIrradiationsJournals";
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.RowHeadersVisible = false;
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.Size = new System.Drawing.Size(193, 184);
            this.SessionFormAdvancedDataGridViewIrradiationsJournals.TabIndex = 18;
            // 
            // SessionFormAdvancedDataGridViewIrradiatedSamples
            // 
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.BackgroundColor = System.Drawing.Color.White;
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.FilterAndSortEnabled = true;
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.Location = new System.Drawing.Point(205, 38);
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.Name = "SessionFormAdvancedDataGridViewIrradiatedSamples";
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.RowHeadersVisible = false;
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.Size = new System.Drawing.Size(418, 184);
            this.SessionFormAdvancedDataGridViewIrradiatedSamples.TabIndex = 17;
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 777);
            this.Controls.Add(this.SessionFormGroupBoxHeights);
            this.Controls.Add(this.SessionFormGroupBoxDetectors);
            this.Controls.Add(this.SessionFormGroupBoxFormMeasurementsJournal);
            this.Controls.Add(this.SessionFormGroupBoxDuration);
            this.Controls.Add(this.SessionFormGroupBoxIrradiationJournalsData);
            this.Controls.Add(this.SessionFormControlPanel);
            this.Controls.Add(this.SessionFormAdvancedDataGridViewSearchToolBar);
            this.Controls.Add(this.SessionFormAdvancedDataGridViewMeasurementsJournal);
            this.Controls.Add(this.SessionFormStatusStrip);
            this.Controls.Add(this.SessionFormMenuStrip);
            this.MainMenuStrip = this.SessionFormMenuStrip;
            this.Name = "SessionForm";
            this.Text = "SessionForm";
            this.SessionFormMenuStrip.ResumeLayout(false);
            this.SessionFormMenuStrip.PerformLayout();
            this.SessionFormControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormAdvancedDataGridViewMeasurementsJournal)).EndInit();
            this.SessionFormGroupBoxFormMeasurementsJournal.ResumeLayout(false);
            this.SessionFormGroupBoxDuration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormNumericUpDownHours)).EndInit();
            this.SessionFormGroupBoxHeights.ResumeLayout(false);
            this.SessionFormGroupBoxIrradiationJournalsData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormAdvancedDataGridViewIrradiationsJournals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionFormAdvancedDataGridViewIrradiatedSamples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SessionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuMenu;
        private System.Windows.Forms.StatusStrip SessionFormStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveSession;
        private System.Windows.Forms.Button SessionFormButtonStart;
        private System.Windows.Forms.Button SessionFormButtonPause;


        // custom components
        private System.Windows.Forms.ToolStripMenuItem DetectorsDropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuOptions;

        private System.Windows.Forms.ToolStripStatusLabel DetectorsLabelStart;
        private System.Windows.Forms.ToolStripStatusLabel DetectorsLabelEnd;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatus;
        private EnumItem CountsOptionsItem;
        private EnumItem SpreadOptionsItem;
        private System.Windows.Forms.ToolStripStatusLabel CountsStatusLabel;
        private System.Windows.Forms.ToolStripDropDownButton HeightDropDownButton;
        private System.Windows.Forms.ToolStripProgressBar MeasurementsProgressBar;
        private Zuby.ADGV.AdvancedDataGridView SessionFormAdvancedDataGridViewMeasurementsJournal;
        private System.Windows.Forms.Button SessionFormButtonStop;
        private System.Windows.Forms.Button SessionFormButtonClear;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar SessionFormAdvancedDataGridViewSearchToolBar;
        private System.Windows.Forms.GroupBox SessionFormControlPanel;
        private System.Windows.Forms.GroupBox SessionFormGroupBoxFormMeasurementsJournal;
        private System.Windows.Forms.Button SessionFormlButtonAddSelectedToJournal;
        private System.Windows.Forms.Button SessionFormButtonRemoveSelectedFromJournal;
        private System.Windows.Forms.GroupBox SessionFormGroupBoxDuration;
        private System.Windows.Forms.Label SessionFormLabelDays;
        private System.Windows.Forms.NumericUpDown SessionFormNumericUpDownDays;
        private System.Windows.Forms.NumericUpDown SessionFormNumericUpDownMinutes;
        private System.Windows.Forms.Label SessionFormLabelMinutes;
        private System.Windows.Forms.NumericUpDown SessionFormNumericUpDownSeconds;
        private System.Windows.Forms.Label SessionFormLabelSeconds;
        private System.Windows.Forms.Label SessionFormLabelHours;
        private System.Windows.Forms.NumericUpDown SessionFormNumericUpDownHours;
        private System.Windows.Forms.GroupBox SessionFormGroupBoxDetectors;
        private System.Windows.Forms.GroupBox SessionFormGroupBoxHeights;
        private System.Windows.Forms.RadioButton SessionFormsRadioButtonHeight2_5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox SessionFormGroupBoxIrradiationJournalsData;
        private System.Windows.Forms.Label SessionFormLabelIrradiatedSamplesTitle;
        private System.Windows.Forms.Label SessionFormLableIrradiationsJournalsTitle;
        private Zuby.ADGV.AdvancedDataGridView SessionFormAdvancedDataGridViewIrradiationsJournals;
        private Zuby.ADGV.AdvancedDataGridView SessionFormAdvancedDataGridViewIrradiatedSamples;
    }
}