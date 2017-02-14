namespace NAPSTaskManagerUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl = new System.Windows.Forms.Panel();
            this.cmbFileExtension = new System.Windows.Forms.ComboBox();
            this.lblLogPathExtension = new System.Windows.Forms.Label();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.lblParameters = new System.Windows.Forms.Label();
            this.txtParameters = new System.Windows.Forms.TextBox();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateNewTask = new System.Windows.Forms.Button();
            this.pnlTaskList = new System.Windows.Forms.Panel();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.lblScheduleType = new System.Windows.Forms.Label();
            this.lblScheduleType2 = new System.Windows.Forms.Label();
            this.ttpTaskListHint = new System.Windows.Forms.ToolTip(this.components);
            this.taskManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.cmbFileExtension);
            this.pnl.Controls.Add(this.lblLogPathExtension);
            this.pnl.Controls.Add(this.lblFileExtension);
            this.pnl.Controls.Add(this.lblParameters);
            this.pnl.Controls.Add(this.txtParameters);
            this.pnl.Controls.Add(this.lblLogPath);
            this.pnl.Controls.Add(this.lblFilePath);
            this.pnl.Controls.Add(this.txtLogPath);
            this.pnl.Controls.Add(this.txtFilePath);
            this.pnl.Location = new System.Drawing.Point(12, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(253, 110);
            this.pnl.TabIndex = 0;
            // 
            // cmbFileExtension
            // 
            this.cmbFileExtension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFileExtension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFileExtension.FormattingEnabled = true;
            this.cmbFileExtension.Items.AddRange(new object[] {
            ".bat",
            ".ps1"});
            this.cmbFileExtension.Location = new System.Drawing.Point(72, 29);
            this.cmbFileExtension.Name = "cmbFileExtension";
            this.cmbFileExtension.Size = new System.Drawing.Size(84, 24);
            this.cmbFileExtension.TabIndex = 1;
            // 
            // lblLogPathExtension
            // 
            this.lblLogPathExtension.AutoSize = true;
            this.lblLogPathExtension.Location = new System.Drawing.Point(217, 56);
            this.lblLogPathExtension.Name = "lblLogPathExtension";
            this.lblLogPathExtension.Size = new System.Drawing.Size(31, 17);
            this.lblLogPathExtension.TabIndex = 8;
            this.lblLogPathExtension.Text = ".log";
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Location = new System.Drawing.Point(4, 29);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(56, 17);
            this.lblFileExtension.TabIndex = 6;
            this.lblFileExtension.Text = "File ext.";
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(4, 80);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(56, 17);
            this.lblParameters.TabIndex = 5;
            this.lblParameters.Text = "Params";
            // 
            // txtParameters
            // 
            this.txtParameters.Location = new System.Drawing.Point(72, 80);
            this.txtParameters.Name = "txtParameters";
            this.txtParameters.Size = new System.Drawing.Size(176, 22);
            this.txtParameters.TabIndex = 3;
            this.txtParameters.Text = "1 2 3 4 5";
            // 
            // lblLogPath
            // 
            this.lblLogPath.AutoSize = true;
            this.lblLogPath.Location = new System.Drawing.Point(4, 56);
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.Size = new System.Drawing.Size(65, 17);
            this.lblLogPath.TabIndex = 3;
            this.lblLogPath.Text = "Log Path";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(4, 8);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(62, 17);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File path";
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(72, 53);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(147, 22);
            this.txtLogPath.TabIndex = 2;
            this.txtLogPath.Text = "C:\\tmp\\echotest\\echo";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(72, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(176, 22);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.Text = "C:\\tmp\\echo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateNewTask);
            this.panel2.Location = new System.Drawing.Point(271, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 109);
            this.panel2.TabIndex = 1;
            // 
            // btnCreateNewTask
            // 
            this.btnCreateNewTask.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreateNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.btnCreateNewTask.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnCreateNewTask.Location = new System.Drawing.Point(3, 3);
            this.btnCreateNewTask.Name = "btnCreateNewTask";
            this.btnCreateNewTask.Size = new System.Drawing.Size(319, 103);
            this.btnCreateNewTask.TabIndex = 4;
            this.btnCreateNewTask.Text = "Create";
            this.btnCreateNewTask.UseVisualStyleBackColor = false;
            this.btnCreateNewTask.Click += new System.EventHandler(this.btnCreateNewTask_Click);
            // 
            // pnlTaskList
            // 
            this.pnlTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTaskList.AutoScroll = true;
            this.pnlTaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTaskList.Location = new System.Drawing.Point(12, 170);
            this.pnlTaskList.Name = "pnlTaskList";
            this.pnlTaskList.Size = new System.Drawing.Size(584, 337);
            this.pnlTaskList.TabIndex = 2;
            this.pnlTaskList.Resize += new System.EventHandler(this.pnlTaskList_Resize);
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.Location = new System.Drawing.Point(121, 129);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(125, 35);
            this.btnEditSchedule.TabIndex = 3;
            this.btnEditSchedule.Text = "Edit Schedule";
            this.btnEditSchedule.UseVisualStyleBackColor = true;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Location = new System.Drawing.Point(252, 129);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(175, 35);
            this.btnRemoveSchedule.TabIndex = 4;
            this.btnRemoveSchedule.Text = "Remove Schedule";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveSchedule.Click += new System.EventHandler(this.btnRemoveSchedule_Click);
            // 
            // lblScheduleType
            // 
            this.lblScheduleType.AutoSize = true;
            this.lblScheduleType.Location = new System.Drawing.Point(13, 129);
            this.lblScheduleType.Name = "lblScheduleType";
            this.lblScheduleType.Size = new System.Drawing.Size(102, 17);
            this.lblScheduleType.TabIndex = 5;
            this.lblScheduleType.Text = "Schedule type:";
            // 
            // lblScheduleType2
            // 
            this.lblScheduleType2.AutoSize = true;
            this.lblScheduleType2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblScheduleType2.Location = new System.Drawing.Point(16, 150);
            this.lblScheduleType2.Name = "lblScheduleType2";
            this.lblScheduleType2.Size = new System.Drawing.Size(42, 17);
            this.lblScheduleType2.TabIndex = 6;
            this.lblScheduleType2.Text = "None";
            // 
            // taskManagerBindingSource
            // 
            this.taskManagerBindingSource.DataSource = typeof(NAPSTaskManager.TaskManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 519);
            this.Controls.Add(this.lblScheduleType2);
            this.Controls.Add(this.lblScheduleType);
            this.Controls.Add(this.btnRemoveSchedule);
            this.Controls.Add(this.btnEditSchedule);
            this.Controls.Add(this.pnlTaskList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nicole";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateNewTask;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.TextBox txtParameters;
        private System.Windows.Forms.BindingSource taskManagerBindingSource;
        private System.Windows.Forms.Panel pnlTaskList;
        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Label lblScheduleType;
        private System.Windows.Forms.Label lblScheduleType2;
        private System.Windows.Forms.ToolTip ttpTaskListHint;
        private System.Windows.Forms.Label lblLogPathExtension;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.ComboBox cmbFileExtension;
    }
}

