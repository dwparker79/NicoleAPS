namespace NAPSTaskManagerUI
{
    partial class ScheduleCreatorForm
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
            this.tbcSchedule = new System.Windows.Forms.TabControl();
            this.tabDailySchedule = new System.Windows.Forms.TabPage();
            this.listDailySchedule = new System.Windows.Forms.ListView();
            this.listDailyColumnHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDailyColumnMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDailyScheduleRemove = new System.Windows.Forms.Button();
            this.btnDailyScheduleAdd = new System.Windows.Forms.Button();
            this.lblMidnightReminder = new System.Windows.Forms.Label();
            this.numDailyMinute = new System.Windows.Forms.NumericUpDown();
            this.lblDailyMinute = new System.Windows.Forms.Label();
            this.numDailyHour = new System.Windows.Forms.NumericUpDown();
            this.lblDailyHour = new System.Windows.Forms.Label();
            this.tabWeeklySchedule = new System.Windows.Forms.TabPage();
            this.listWeeklySchedule = new System.Windows.Forms.ListView();
            this.listWeeklyColumnDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listWeeklyColumnHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listWeeklyColumnMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnWeeklyScheduleAdd = new System.Windows.Forms.Button();
            this.btnWeeklyScheduleRemove = new System.Windows.Forms.Button();
            this.lblWeeklyScheduleMidnight = new System.Windows.Forms.Label();
            this.lblWeeklyScheduleMinute = new System.Windows.Forms.Label();
            this.numWeeklyScheduleMinute = new System.Windows.Forms.NumericUpDown();
            this.lblWeeklyScheduleHour = new System.Windows.Forms.Label();
            this.numWeeklyScheduleHour = new System.Windows.Forms.NumericUpDown();
            this.cmbWeeklyScheduleDay = new System.Windows.Forms.ComboBox();
            this.lblWeeklyScheduleDay = new System.Windows.Forms.Label();
            this.tabBiweeklySchedule = new System.Windows.Forms.TabPage();
            this.listBiweeklySchedule = new System.Windows.Forms.ListView();
            this.listBiweeklyColumnWeek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBiweeklyColumnDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBiweeklyColumnHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBiweeklyColumnMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBiweeklyAdd = new System.Windows.Forms.Button();
            this.btnBiweeklyRemove = new System.Windows.Forms.Button();
            this.lblBiweeklyMidnight = new System.Windows.Forms.Label();
            this.lblBiweeklyMinute = new System.Windows.Forms.Label();
            this.numBiweeklyMinute = new System.Windows.Forms.NumericUpDown();
            this.lblBiweeklyHour = new System.Windows.Forms.Label();
            this.numBiweeklyHour = new System.Windows.Forms.NumericUpDown();
            this.lblBiweeklyDay = new System.Windows.Forms.Label();
            this.cmbBiweeklyDay = new System.Windows.Forms.ComboBox();
            this.lblBiweeklyWeek = new System.Windows.Forms.Label();
            this.cmbBiweeklyWeek = new System.Windows.Forms.ComboBox();
            this.tabMonthlySchedule = new System.Windows.Forms.TabPage();
            this.listMonthlySchedule = new System.Windows.Forms.ListView();
            this.listMonthlyColumnDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMonthlyColumnHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMonthlyColumnMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMonthlyAdd = new System.Windows.Forms.Button();
            this.btnMonthlyRemove = new System.Windows.Forms.Button();
            this.numMonthlyDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthlyMidnight = new System.Windows.Forms.Label();
            this.lblMonthlyMinute = new System.Windows.Forms.Label();
            this.numMonthlyMinute = new System.Windows.Forms.NumericUpDown();
            this.lblMonthlyHour = new System.Windows.Forms.Label();
            this.numMonthlyHour = new System.Windows.Forms.NumericUpDown();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.btnCancelSchedule = new System.Windows.Forms.Button();
            this.tbcSchedule.SuspendLayout();
            this.tabDailySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyHour)).BeginInit();
            this.tabWeeklySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeeklyScheduleMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeeklyScheduleHour)).BeginInit();
            this.tabBiweeklySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBiweeklyMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBiweeklyHour)).BeginInit();
            this.tabMonthlySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyHour)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSchedule
            // 
            this.tbcSchedule.Controls.Add(this.tabDailySchedule);
            this.tbcSchedule.Controls.Add(this.tabWeeklySchedule);
            this.tbcSchedule.Controls.Add(this.tabBiweeklySchedule);
            this.tbcSchedule.Controls.Add(this.tabMonthlySchedule);
            this.tbcSchedule.ItemSize = new System.Drawing.Size(103, 22);
            this.tbcSchedule.Location = new System.Drawing.Point(12, 12);
            this.tbcSchedule.Name = "tbcSchedule";
            this.tbcSchedule.SelectedIndex = 0;
            this.tbcSchedule.Size = new System.Drawing.Size(479, 293);
            this.tbcSchedule.TabIndex = 0;
            // 
            // tabDailySchedule
            // 
            this.tabDailySchedule.Controls.Add(this.listDailySchedule);
            this.tabDailySchedule.Controls.Add(this.btnDailyScheduleRemove);
            this.tabDailySchedule.Controls.Add(this.btnDailyScheduleAdd);
            this.tabDailySchedule.Controls.Add(this.lblMidnightReminder);
            this.tabDailySchedule.Controls.Add(this.numDailyMinute);
            this.tabDailySchedule.Controls.Add(this.lblDailyMinute);
            this.tabDailySchedule.Controls.Add(this.numDailyHour);
            this.tabDailySchedule.Controls.Add(this.lblDailyHour);
            this.tabDailySchedule.Location = new System.Drawing.Point(4, 26);
            this.tabDailySchedule.Name = "tabDailySchedule";
            this.tabDailySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabDailySchedule.Size = new System.Drawing.Size(471, 263);
            this.tabDailySchedule.TabIndex = 0;
            this.tabDailySchedule.Text = "Daily Schedule";
            this.tabDailySchedule.UseVisualStyleBackColor = true;
            // 
            // listDailySchedule
            // 
            this.listDailySchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listDailyColumnHour,
            this.listDailyColumnMinute});
            this.listDailySchedule.Location = new System.Drawing.Point(7, 100);
            this.listDailySchedule.Name = "listDailySchedule";
            this.listDailySchedule.Size = new System.Drawing.Size(457, 157);
            this.listDailySchedule.TabIndex = 8;
            this.listDailySchedule.UseCompatibleStateImageBehavior = false;
            this.listDailySchedule.View = System.Windows.Forms.View.Details;
            // 
            // listDailyColumnHour
            // 
            this.listDailyColumnHour.Text = "Hour";
            // 
            // listDailyColumnMinute
            // 
            this.listDailyColumnMinute.Text = "Minute";
            // 
            // btnDailyScheduleRemove
            // 
            this.btnDailyScheduleRemove.Location = new System.Drawing.Point(333, 70);
            this.btnDailyScheduleRemove.Name = "btnDailyScheduleRemove";
            this.btnDailyScheduleRemove.Size = new System.Drawing.Size(131, 23);
            this.btnDailyScheduleRemove.TabIndex = 7;
            this.btnDailyScheduleRemove.Text = "Remove Selected";
            this.btnDailyScheduleRemove.UseVisualStyleBackColor = false;
            this.btnDailyScheduleRemove.Click += new System.EventHandler(this.btnDailyScheduleRemove_Click);
            // 
            // btnDailyScheduleAdd
            // 
            this.btnDailyScheduleAdd.Location = new System.Drawing.Point(7, 70);
            this.btnDailyScheduleAdd.Name = "btnDailyScheduleAdd";
            this.btnDailyScheduleAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDailyScheduleAdd.TabIndex = 6;
            this.btnDailyScheduleAdd.Text = "Add New";
            this.btnDailyScheduleAdd.UseVisualStyleBackColor = true;
            this.btnDailyScheduleAdd.Click += new System.EventHandler(this.btnDailyScheduleAdd_Click);
            // 
            // lblMidnightReminder
            // 
            this.lblMidnightReminder.AutoSize = true;
            this.lblMidnightReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblMidnightReminder.Location = new System.Drawing.Point(4, 54);
            this.lblMidnightReminder.Name = "lblMidnightReminder";
            this.lblMidnightReminder.Size = new System.Drawing.Size(125, 13);
            this.lblMidnightReminder.TabIndex = 5;
            this.lblMidnightReminder.Text = "0:00 represents midnight.";
            // 
            // numDailyMinute
            // 
            this.numDailyMinute.Location = new System.Drawing.Point(67, 30);
            this.numDailyMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numDailyMinute.Name = "numDailyMinute";
            this.numDailyMinute.Size = new System.Drawing.Size(120, 22);
            this.numDailyMinute.TabIndex = 4;
            // 
            // lblDailyMinute
            // 
            this.lblDailyMinute.AutoSize = true;
            this.lblDailyMinute.Location = new System.Drawing.Point(7, 32);
            this.lblDailyMinute.Name = "lblDailyMinute";
            this.lblDailyMinute.Size = new System.Drawing.Size(54, 17);
            this.lblDailyMinute.TabIndex = 3;
            this.lblDailyMinute.Text = "Minute:";
            // 
            // numDailyHour
            // 
            this.numDailyHour.Location = new System.Drawing.Point(67, 7);
            this.numDailyHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numDailyHour.Name = "numDailyHour";
            this.numDailyHour.Size = new System.Drawing.Size(120, 22);
            this.numDailyHour.TabIndex = 2;
            // 
            // lblDailyHour
            // 
            this.lblDailyHour.AutoSize = true;
            this.lblDailyHour.Location = new System.Drawing.Point(7, 7);
            this.lblDailyHour.Name = "lblDailyHour";
            this.lblDailyHour.Size = new System.Drawing.Size(43, 17);
            this.lblDailyHour.TabIndex = 1;
            this.lblDailyHour.Text = "Hour:";
            // 
            // tabWeeklySchedule
            // 
            this.tabWeeklySchedule.Controls.Add(this.listWeeklySchedule);
            this.tabWeeklySchedule.Controls.Add(this.btnWeeklyScheduleAdd);
            this.tabWeeklySchedule.Controls.Add(this.btnWeeklyScheduleRemove);
            this.tabWeeklySchedule.Controls.Add(this.lblWeeklyScheduleMidnight);
            this.tabWeeklySchedule.Controls.Add(this.lblWeeklyScheduleMinute);
            this.tabWeeklySchedule.Controls.Add(this.numWeeklyScheduleMinute);
            this.tabWeeklySchedule.Controls.Add(this.lblWeeklyScheduleHour);
            this.tabWeeklySchedule.Controls.Add(this.numWeeklyScheduleHour);
            this.tabWeeklySchedule.Controls.Add(this.cmbWeeklyScheduleDay);
            this.tabWeeklySchedule.Controls.Add(this.lblWeeklyScheduleDay);
            this.tabWeeklySchedule.Location = new System.Drawing.Point(4, 26);
            this.tabWeeklySchedule.Name = "tabWeeklySchedule";
            this.tabWeeklySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeeklySchedule.Size = new System.Drawing.Size(471, 263);
            this.tabWeeklySchedule.TabIndex = 1;
            this.tabWeeklySchedule.Text = "Weekly Schedule";
            this.tabWeeklySchedule.UseVisualStyleBackColor = true;
            // 
            // listWeeklySchedule
            // 
            this.listWeeklySchedule.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listWeeklySchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listWeeklyColumnDay,
            this.listWeeklyColumnHour,
            this.listWeeklyColumnMinute});
            this.listWeeklySchedule.Location = new System.Drawing.Point(10, 104);
            this.listWeeklySchedule.Name = "listWeeklySchedule";
            this.listWeeklySchedule.Size = new System.Drawing.Size(454, 153);
            this.listWeeklySchedule.TabIndex = 10;
            this.listWeeklySchedule.UseCompatibleStateImageBehavior = false;
            this.listWeeklySchedule.View = System.Windows.Forms.View.Details;
            // 
            // listWeeklyColumnDay
            // 
            this.listWeeklyColumnDay.Text = "Day";
            // 
            // listWeeklyColumnHour
            // 
            this.listWeeklyColumnHour.Text = "Hour";
            // 
            // listWeeklyColumnMinute
            // 
            this.listWeeklyColumnMinute.Text = "Minute";
            // 
            // btnWeeklyScheduleAdd
            // 
            this.btnWeeklyScheduleAdd.Location = new System.Drawing.Point(10, 74);
            this.btnWeeklyScheduleAdd.Name = "btnWeeklyScheduleAdd";
            this.btnWeeklyScheduleAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWeeklyScheduleAdd.TabIndex = 9;
            this.btnWeeklyScheduleAdd.Text = "Add New";
            this.btnWeeklyScheduleAdd.UseVisualStyleBackColor = true;
            this.btnWeeklyScheduleAdd.Click += new System.EventHandler(this.btnWeeklyScheduleAdd_Click);
            // 
            // btnWeeklyScheduleRemove
            // 
            this.btnWeeklyScheduleRemove.Location = new System.Drawing.Point(337, 74);
            this.btnWeeklyScheduleRemove.Name = "btnWeeklyScheduleRemove";
            this.btnWeeklyScheduleRemove.Size = new System.Drawing.Size(128, 23);
            this.btnWeeklyScheduleRemove.TabIndex = 8;
            this.btnWeeklyScheduleRemove.Text = "Remove Selected";
            this.btnWeeklyScheduleRemove.UseVisualStyleBackColor = true;
            this.btnWeeklyScheduleRemove.Click += new System.EventHandler(this.btnWeeklyScheduleRemove_Click);
            // 
            // lblWeeklyScheduleMidnight
            // 
            this.lblWeeklyScheduleMidnight.AutoSize = true;
            this.lblWeeklyScheduleMidnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblWeeklyScheduleMidnight.Location = new System.Drawing.Point(339, 58);
            this.lblWeeklyScheduleMidnight.Name = "lblWeeklyScheduleMidnight";
            this.lblWeeklyScheduleMidnight.Size = new System.Drawing.Size(125, 13);
            this.lblWeeklyScheduleMidnight.TabIndex = 6;
            this.lblWeeklyScheduleMidnight.Text = "0:00 represents midnight.";
            // 
            // lblWeeklyScheduleMinute
            // 
            this.lblWeeklyScheduleMinute.AutoSize = true;
            this.lblWeeklyScheduleMinute.Location = new System.Drawing.Point(285, 35);
            this.lblWeeklyScheduleMinute.Name = "lblWeeklyScheduleMinute";
            this.lblWeeklyScheduleMinute.Size = new System.Drawing.Size(54, 17);
            this.lblWeeklyScheduleMinute.TabIndex = 5;
            this.lblWeeklyScheduleMinute.Text = "Minute:";
            // 
            // numWeeklyScheduleMinute
            // 
            this.numWeeklyScheduleMinute.Location = new System.Drawing.Point(345, 33);
            this.numWeeklyScheduleMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numWeeklyScheduleMinute.Name = "numWeeklyScheduleMinute";
            this.numWeeklyScheduleMinute.Size = new System.Drawing.Size(120, 22);
            this.numWeeklyScheduleMinute.TabIndex = 4;
            // 
            // lblWeeklyScheduleHour
            // 
            this.lblWeeklyScheduleHour.AutoSize = true;
            this.lblWeeklyScheduleHour.Location = new System.Drawing.Point(296, 9);
            this.lblWeeklyScheduleHour.Name = "lblWeeklyScheduleHour";
            this.lblWeeklyScheduleHour.Size = new System.Drawing.Size(43, 17);
            this.lblWeeklyScheduleHour.TabIndex = 3;
            this.lblWeeklyScheduleHour.Text = "Hour:";
            // 
            // numWeeklyScheduleHour
            // 
            this.numWeeklyScheduleHour.Location = new System.Drawing.Point(345, 7);
            this.numWeeklyScheduleHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numWeeklyScheduleHour.Name = "numWeeklyScheduleHour";
            this.numWeeklyScheduleHour.Size = new System.Drawing.Size(120, 22);
            this.numWeeklyScheduleHour.TabIndex = 2;
            // 
            // cmbWeeklyScheduleDay
            // 
            this.cmbWeeklyScheduleDay.FormattingEnabled = true;
            this.cmbWeeklyScheduleDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbWeeklyScheduleDay.Location = new System.Drawing.Point(103, 7);
            this.cmbWeeklyScheduleDay.MaxDropDownItems = 7;
            this.cmbWeeklyScheduleDay.Name = "cmbWeeklyScheduleDay";
            this.cmbWeeklyScheduleDay.Size = new System.Drawing.Size(121, 24);
            this.cmbWeeklyScheduleDay.TabIndex = 1;
            // 
            // lblWeeklyScheduleDay
            // 
            this.lblWeeklyScheduleDay.AutoSize = true;
            this.lblWeeklyScheduleDay.Location = new System.Drawing.Point(7, 7);
            this.lblWeeklyScheduleDay.Name = "lblWeeklyScheduleDay";
            this.lblWeeklyScheduleDay.Size = new System.Drawing.Size(89, 17);
            this.lblWeeklyScheduleDay.TabIndex = 0;
            this.lblWeeklyScheduleDay.Text = "Day of week:";
            // 
            // tabBiweeklySchedule
            // 
            this.tabBiweeklySchedule.Controls.Add(this.listBiweeklySchedule);
            this.tabBiweeklySchedule.Controls.Add(this.btnBiweeklyAdd);
            this.tabBiweeklySchedule.Controls.Add(this.btnBiweeklyRemove);
            this.tabBiweeklySchedule.Controls.Add(this.lblBiweeklyMidnight);
            this.tabBiweeklySchedule.Controls.Add(this.lblBiweeklyMinute);
            this.tabBiweeklySchedule.Controls.Add(this.numBiweeklyMinute);
            this.tabBiweeklySchedule.Controls.Add(this.lblBiweeklyHour);
            this.tabBiweeklySchedule.Controls.Add(this.numBiweeklyHour);
            this.tabBiweeklySchedule.Controls.Add(this.lblBiweeklyDay);
            this.tabBiweeklySchedule.Controls.Add(this.cmbBiweeklyDay);
            this.tabBiweeklySchedule.Controls.Add(this.lblBiweeklyWeek);
            this.tabBiweeklySchedule.Controls.Add(this.cmbBiweeklyWeek);
            this.tabBiweeklySchedule.Location = new System.Drawing.Point(4, 26);
            this.tabBiweeklySchedule.Name = "tabBiweeklySchedule";
            this.tabBiweeklySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabBiweeklySchedule.Size = new System.Drawing.Size(471, 263);
            this.tabBiweeklySchedule.TabIndex = 2;
            this.tabBiweeklySchedule.Text = "Biweekly Schedule";
            this.tabBiweeklySchedule.UseVisualStyleBackColor = true;
            // 
            // listBiweeklySchedule
            // 
            this.listBiweeklySchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listBiweeklyColumnWeek,
            this.listBiweeklyColumnDay,
            this.listBiweeklyColumnHour,
            this.listBiweeklyColumnMinute});
            this.listBiweeklySchedule.Location = new System.Drawing.Point(7, 103);
            this.listBiweeklySchedule.MultiSelect = false;
            this.listBiweeklySchedule.Name = "listBiweeklySchedule";
            this.listBiweeklySchedule.Size = new System.Drawing.Size(457, 154);
            this.listBiweeklySchedule.TabIndex = 16;
            this.listBiweeklySchedule.UseCompatibleStateImageBehavior = false;
            this.listBiweeklySchedule.View = System.Windows.Forms.View.Details;
            // 
            // listBiweeklyColumnWeek
            // 
            this.listBiweeklyColumnWeek.Text = "Week";
            // 
            // listBiweeklyColumnDay
            // 
            this.listBiweeklyColumnDay.Text = "Day";
            // 
            // listBiweeklyColumnHour
            // 
            this.listBiweeklyColumnHour.Text = "Hour";
            // 
            // listBiweeklyColumnMinute
            // 
            this.listBiweeklyColumnMinute.Text = "Minute";
            // 
            // btnBiweeklyAdd
            // 
            this.btnBiweeklyAdd.Location = new System.Drawing.Point(9, 73);
            this.btnBiweeklyAdd.Name = "btnBiweeklyAdd";
            this.btnBiweeklyAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBiweeklyAdd.TabIndex = 15;
            this.btnBiweeklyAdd.Text = "Add New";
            this.btnBiweeklyAdd.UseVisualStyleBackColor = true;
            this.btnBiweeklyAdd.Click += new System.EventHandler(this.btnBiweeklyAdd_Click);
            // 
            // btnBiweeklyRemove
            // 
            this.btnBiweeklyRemove.Location = new System.Drawing.Point(337, 74);
            this.btnBiweeklyRemove.Name = "btnBiweeklyRemove";
            this.btnBiweeklyRemove.Size = new System.Drawing.Size(128, 23);
            this.btnBiweeklyRemove.TabIndex = 14;
            this.btnBiweeklyRemove.Text = "Remove Selected";
            this.btnBiweeklyRemove.UseVisualStyleBackColor = true;
            this.btnBiweeklyRemove.Click += new System.EventHandler(this.btnBiweeklyRemove_Click);
            // 
            // lblBiweeklyMidnight
            // 
            this.lblBiweeklyMidnight.AutoSize = true;
            this.lblBiweeklyMidnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblBiweeklyMidnight.Location = new System.Drawing.Point(339, 58);
            this.lblBiweeklyMidnight.Name = "lblBiweeklyMidnight";
            this.lblBiweeklyMidnight.Size = new System.Drawing.Size(125, 13);
            this.lblBiweeklyMidnight.TabIndex = 13;
            this.lblBiweeklyMidnight.Text = "0:00 represents midnight.";
            // 
            // lblBiweeklyMinute
            // 
            this.lblBiweeklyMinute.AutoSize = true;
            this.lblBiweeklyMinute.Location = new System.Drawing.Point(285, 35);
            this.lblBiweeklyMinute.Name = "lblBiweeklyMinute";
            this.lblBiweeklyMinute.Size = new System.Drawing.Size(54, 17);
            this.lblBiweeklyMinute.TabIndex = 12;
            this.lblBiweeklyMinute.Text = "Minute:";
            // 
            // numBiweeklyMinute
            // 
            this.numBiweeklyMinute.Location = new System.Drawing.Point(345, 33);
            this.numBiweeklyMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numBiweeklyMinute.Name = "numBiweeklyMinute";
            this.numBiweeklyMinute.Size = new System.Drawing.Size(120, 22);
            this.numBiweeklyMinute.TabIndex = 11;
            // 
            // lblBiweeklyHour
            // 
            this.lblBiweeklyHour.AutoSize = true;
            this.lblBiweeklyHour.Location = new System.Drawing.Point(296, 9);
            this.lblBiweeklyHour.Name = "lblBiweeklyHour";
            this.lblBiweeklyHour.Size = new System.Drawing.Size(43, 17);
            this.lblBiweeklyHour.TabIndex = 10;
            this.lblBiweeklyHour.Text = "Hour:";
            // 
            // numBiweeklyHour
            // 
            this.numBiweeklyHour.Location = new System.Drawing.Point(345, 7);
            this.numBiweeklyHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numBiweeklyHour.Name = "numBiweeklyHour";
            this.numBiweeklyHour.Size = new System.Drawing.Size(120, 22);
            this.numBiweeklyHour.TabIndex = 9;
            // 
            // lblBiweeklyDay
            // 
            this.lblBiweeklyDay.AutoSize = true;
            this.lblBiweeklyDay.Location = new System.Drawing.Point(6, 37);
            this.lblBiweeklyDay.Name = "lblBiweeklyDay";
            this.lblBiweeklyDay.Size = new System.Drawing.Size(37, 17);
            this.lblBiweeklyDay.TabIndex = 3;
            this.lblBiweeklyDay.Text = "Day:";
            // 
            // cmbBiweeklyDay
            // 
            this.cmbBiweeklyDay.DisplayMember = "0,1,2,3,4,5,6";
            this.cmbBiweeklyDay.FormattingEnabled = true;
            this.cmbBiweeklyDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbBiweeklyDay.Location = new System.Drawing.Point(60, 37);
            this.cmbBiweeklyDay.Name = "cmbBiweeklyDay";
            this.cmbBiweeklyDay.Size = new System.Drawing.Size(121, 24);
            this.cmbBiweeklyDay.TabIndex = 2;
            this.cmbBiweeklyDay.ValueMember = "0,1,2,3,4,5,6";
            // 
            // lblBiweeklyWeek
            // 
            this.lblBiweeklyWeek.AutoSize = true;
            this.lblBiweeklyWeek.Location = new System.Drawing.Point(6, 9);
            this.lblBiweeklyWeek.Name = "lblBiweeklyWeek";
            this.lblBiweeklyWeek.Size = new System.Drawing.Size(48, 17);
            this.lblBiweeklyWeek.TabIndex = 1;
            this.lblBiweeklyWeek.Text = "Week:";
            // 
            // cmbBiweeklyWeek
            // 
            this.cmbBiweeklyWeek.DisplayMember = "0, 7";
            this.cmbBiweeklyWeek.FormattingEnabled = true;
            this.cmbBiweeklyWeek.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbBiweeklyWeek.Location = new System.Drawing.Point(60, 6);
            this.cmbBiweeklyWeek.Name = "cmbBiweeklyWeek";
            this.cmbBiweeklyWeek.Size = new System.Drawing.Size(121, 24);
            this.cmbBiweeklyWeek.TabIndex = 0;
            this.cmbBiweeklyWeek.ValueMember = "0,7";
            // 
            // tabMonthlySchedule
            // 
            this.tabMonthlySchedule.Controls.Add(this.listMonthlySchedule);
            this.tabMonthlySchedule.Controls.Add(this.btnMonthlyAdd);
            this.tabMonthlySchedule.Controls.Add(this.btnMonthlyRemove);
            this.tabMonthlySchedule.Controls.Add(this.numMonthlyDay);
            this.tabMonthlySchedule.Controls.Add(this.label3);
            this.tabMonthlySchedule.Controls.Add(this.lblMonthlyMidnight);
            this.tabMonthlySchedule.Controls.Add(this.lblMonthlyMinute);
            this.tabMonthlySchedule.Controls.Add(this.numMonthlyMinute);
            this.tabMonthlySchedule.Controls.Add(this.lblMonthlyHour);
            this.tabMonthlySchedule.Controls.Add(this.numMonthlyHour);
            this.tabMonthlySchedule.Location = new System.Drawing.Point(4, 26);
            this.tabMonthlySchedule.Name = "tabMonthlySchedule";
            this.tabMonthlySchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthlySchedule.Size = new System.Drawing.Size(471, 263);
            this.tabMonthlySchedule.TabIndex = 3;
            this.tabMonthlySchedule.Text = "Monthly Schedule";
            this.tabMonthlySchedule.UseVisualStyleBackColor = true;
            // 
            // listMonthlySchedule
            // 
            this.listMonthlySchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listMonthlyColumnDay,
            this.listMonthlyColumnHour,
            this.listMonthlyColumnMinute});
            this.listMonthlySchedule.Location = new System.Drawing.Point(7, 104);
            this.listMonthlySchedule.Name = "listMonthlySchedule";
            this.listMonthlySchedule.Size = new System.Drawing.Size(458, 153);
            this.listMonthlySchedule.TabIndex = 24;
            this.listMonthlySchedule.UseCompatibleStateImageBehavior = false;
            this.listMonthlySchedule.View = System.Windows.Forms.View.Details;
            // 
            // listMonthlyColumnDay
            // 
            this.listMonthlyColumnDay.Text = "Day";
            // 
            // listMonthlyColumnHour
            // 
            this.listMonthlyColumnHour.Text = "Hour";
            // 
            // listMonthlyColumnMinute
            // 
            this.listMonthlyColumnMinute.Text = "Minute";
            // 
            // btnMonthlyAdd
            // 
            this.btnMonthlyAdd.Location = new System.Drawing.Point(7, 74);
            this.btnMonthlyAdd.Name = "btnMonthlyAdd";
            this.btnMonthlyAdd.Size = new System.Drawing.Size(79, 23);
            this.btnMonthlyAdd.TabIndex = 23;
            this.btnMonthlyAdd.Text = "Add New";
            this.btnMonthlyAdd.UseVisualStyleBackColor = true;
            this.btnMonthlyAdd.Click += new System.EventHandler(this.btnMonthlyAdd_Click);
            // 
            // btnMonthlyRemove
            // 
            this.btnMonthlyRemove.Location = new System.Drawing.Point(335, 74);
            this.btnMonthlyRemove.Name = "btnMonthlyRemove";
            this.btnMonthlyRemove.Size = new System.Drawing.Size(128, 23);
            this.btnMonthlyRemove.TabIndex = 22;
            this.btnMonthlyRemove.Text = "Remove Selected";
            this.btnMonthlyRemove.UseVisualStyleBackColor = true;
            this.btnMonthlyRemove.Click += new System.EventHandler(this.btnMonthlyRemove_Click);
            // 
            // numMonthlyDay
            // 
            this.numMonthlyDay.Location = new System.Drawing.Point(46, 6);
            this.numMonthlyDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMonthlyDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthlyDay.Name = "numMonthlyDay";
            this.numMonthlyDay.Size = new System.Drawing.Size(120, 22);
            this.numMonthlyDay.TabIndex = 20;
            this.numMonthlyDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Day:";
            // 
            // lblMonthlyMidnight
            // 
            this.lblMonthlyMidnight.AutoSize = true;
            this.lblMonthlyMidnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.lblMonthlyMidnight.Location = new System.Drawing.Point(339, 57);
            this.lblMonthlyMidnight.Name = "lblMonthlyMidnight";
            this.lblMonthlyMidnight.Size = new System.Drawing.Size(125, 13);
            this.lblMonthlyMidnight.TabIndex = 18;
            this.lblMonthlyMidnight.Text = "0:00 represents midnight.";
            // 
            // lblMonthlyMinute
            // 
            this.lblMonthlyMinute.AutoSize = true;
            this.lblMonthlyMinute.Location = new System.Drawing.Point(285, 34);
            this.lblMonthlyMinute.Name = "lblMonthlyMinute";
            this.lblMonthlyMinute.Size = new System.Drawing.Size(54, 17);
            this.lblMonthlyMinute.TabIndex = 17;
            this.lblMonthlyMinute.Text = "Minute:";
            // 
            // numMonthlyMinute
            // 
            this.numMonthlyMinute.Location = new System.Drawing.Point(345, 32);
            this.numMonthlyMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMonthlyMinute.Name = "numMonthlyMinute";
            this.numMonthlyMinute.Size = new System.Drawing.Size(120, 22);
            this.numMonthlyMinute.TabIndex = 16;
            // 
            // lblMonthlyHour
            // 
            this.lblMonthlyHour.AutoSize = true;
            this.lblMonthlyHour.Location = new System.Drawing.Point(296, 8);
            this.lblMonthlyHour.Name = "lblMonthlyHour";
            this.lblMonthlyHour.Size = new System.Drawing.Size(43, 17);
            this.lblMonthlyHour.TabIndex = 15;
            this.lblMonthlyHour.Text = "Hour:";
            // 
            // numMonthlyHour
            // 
            this.numMonthlyHour.Location = new System.Drawing.Point(345, 6);
            this.numMonthlyHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numMonthlyHour.Name = "numMonthlyHour";
            this.numMonthlyHour.Size = new System.Drawing.Size(120, 22);
            this.numMonthlyHour.TabIndex = 14;
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCreateSchedule.Location = new System.Drawing.Point(13, 307);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(233, 71);
            this.btnCreateSchedule.TabIndex = 1;
            this.btnCreateSchedule.Text = "Create Schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = true;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // btnCancelSchedule
            // 
            this.btnCancelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelSchedule.Location = new System.Drawing.Point(253, 308);
            this.btnCancelSchedule.Name = "btnCancelSchedule";
            this.btnCancelSchedule.Size = new System.Drawing.Size(238, 70);
            this.btnCancelSchedule.TabIndex = 2;
            this.btnCancelSchedule.Text = "Cancel";
            this.btnCancelSchedule.UseVisualStyleBackColor = true;
            this.btnCancelSchedule.Click += new System.EventHandler(this.btnCancelSchedule_Click);
            // 
            // ScheduleCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 390);
            this.Controls.Add(this.btnCancelSchedule);
            this.Controls.Add(this.btnCreateSchedule);
            this.Controls.Add(this.tbcSchedule);
            this.Name = "ScheduleCreatorForm";
            this.Text = "ScheduleCreatorForm";
            this.tbcSchedule.ResumeLayout(false);
            this.tabDailySchedule.ResumeLayout(false);
            this.tabDailySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyHour)).EndInit();
            this.tabWeeklySchedule.ResumeLayout(false);
            this.tabWeeklySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeeklyScheduleMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeeklyScheduleHour)).EndInit();
            this.tabBiweeklySchedule.ResumeLayout(false);
            this.tabBiweeklySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBiweeklyMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBiweeklyHour)).EndInit();
            this.tabMonthlySchedule.ResumeLayout(false);
            this.tabMonthlySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSchedule;
        private System.Windows.Forms.TabPage tabDailySchedule;
        private System.Windows.Forms.TabPage tabWeeklySchedule;
        private System.Windows.Forms.TabPage tabBiweeklySchedule;
        private System.Windows.Forms.TabPage tabMonthlySchedule;
        private System.Windows.Forms.NumericUpDown numDailyMinute;
        private System.Windows.Forms.Label lblDailyMinute;
        private System.Windows.Forms.NumericUpDown numDailyHour;
        private System.Windows.Forms.Label lblDailyHour;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Button btnCancelSchedule;
        private System.Windows.Forms.Button btnDailyScheduleRemove;
        private System.Windows.Forms.Button btnDailyScheduleAdd;
        private System.Windows.Forms.Label lblMidnightReminder;
        private System.Windows.Forms.Button btnWeeklyScheduleAdd;
        private System.Windows.Forms.Button btnWeeklyScheduleRemove;
        private System.Windows.Forms.Label lblWeeklyScheduleMidnight;
        private System.Windows.Forms.Label lblWeeklyScheduleMinute;
        private System.Windows.Forms.NumericUpDown numWeeklyScheduleMinute;
        private System.Windows.Forms.Label lblWeeklyScheduleHour;
        private System.Windows.Forms.NumericUpDown numWeeklyScheduleHour;
        private System.Windows.Forms.ComboBox cmbWeeklyScheduleDay;
        private System.Windows.Forms.Label lblWeeklyScheduleDay;
        private System.Windows.Forms.Button btnBiweeklyAdd;
        private System.Windows.Forms.Button btnBiweeklyRemove;
        private System.Windows.Forms.Label lblBiweeklyMidnight;
        private System.Windows.Forms.Label lblBiweeklyMinute;
        private System.Windows.Forms.NumericUpDown numBiweeklyMinute;
        private System.Windows.Forms.Label lblBiweeklyHour;
        private System.Windows.Forms.NumericUpDown numBiweeklyHour;
        private System.Windows.Forms.Label lblBiweeklyDay;
        private System.Windows.Forms.ComboBox cmbBiweeklyDay;
        private System.Windows.Forms.Label lblBiweeklyWeek;
        private System.Windows.Forms.ComboBox cmbBiweeklyWeek;
        private System.Windows.Forms.NumericUpDown numMonthlyDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonthlyMidnight;
        private System.Windows.Forms.Label lblMonthlyMinute;
        private System.Windows.Forms.NumericUpDown numMonthlyMinute;
        private System.Windows.Forms.Label lblMonthlyHour;
        private System.Windows.Forms.NumericUpDown numMonthlyHour;
        private System.Windows.Forms.Button btnMonthlyAdd;
        private System.Windows.Forms.Button btnMonthlyRemove;
        private System.Windows.Forms.ListView listDailySchedule;
        private System.Windows.Forms.ColumnHeader listDailyColumnHour;
        private System.Windows.Forms.ColumnHeader listDailyColumnMinute;
        private System.Windows.Forms.ListView listWeeklySchedule;
        private System.Windows.Forms.ColumnHeader listWeeklyColumnDay;
        private System.Windows.Forms.ColumnHeader listWeeklyColumnHour;
        private System.Windows.Forms.ColumnHeader listWeeklyColumnMinute;
        private System.Windows.Forms.ListView listBiweeklySchedule;
        private System.Windows.Forms.ColumnHeader listBiweeklyColumnWeek;
        private System.Windows.Forms.ColumnHeader listBiweeklyColumnDay;
        private System.Windows.Forms.ColumnHeader listBiweeklyColumnHour;
        private System.Windows.Forms.ColumnHeader listBiweeklyColumnMinute;
        private System.Windows.Forms.ListView listMonthlySchedule;
        private System.Windows.Forms.ColumnHeader listMonthlyColumnDay;
        private System.Windows.Forms.ColumnHeader listMonthlyColumnHour;
        private System.Windows.Forms.ColumnHeader listMonthlyColumnMinute;
    }
}