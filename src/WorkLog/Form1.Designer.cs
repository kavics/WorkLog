namespace WorkLog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            workLogTextBox = new TextBox();
            saveButton = new Button();
            stopTaskButton = new Button();
            restartTaskButton = new Button();
            newTaskButton = new Button();
            dayOffButton = new Button();
            lastDaySummaryButton = new Button();
            totalSummaryButton = new Button();
            workHoursButton = new Button();
            openDirectoryButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // workLogTextBox
            // 
            workLogTextBox.AcceptsTab = true;
            workLogTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            workLogTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            workLogTextBox.HideSelection = false;
            workLogTextBox.Location = new Point(0, 30);
            workLogTextBox.Margin = new Padding(4, 2, 4, 2);
            workLogTextBox.Multiline = true;
            workLogTextBox.Name = "workLogTextBox";
            workLogTextBox.ScrollBars = ScrollBars.Both;
            workLogTextBox.Size = new Size(1000, 507);
            workLogTextBox.TabIndex = 0;
            workLogTextBox.WordWrap = false;
            workLogTextBox.TextChanged += workLogTextBox_TextChanged;
            workLogTextBox.DoubleClick += workLogTextBox_DoubleClick;
            workLogTextBox.KeyDown += workLogTextBox_KeyDown;
            workLogTextBox.KeyPress += workLogTextBox_KeyPress;
            workLogTextBox.KeyUp += workLogTextBox_KeyUp;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(9, 5);
            saveButton.Margin = new Padding(4, 2, 4, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // stopTaskButton
            // 
            stopTaskButton.Location = new Point(175, 5);
            stopTaskButton.Name = "stopTaskButton";
            stopTaskButton.Size = new Size(71, 23);
            stopTaskButton.TabIndex = 3;
            stopTaskButton.Text = "Stop Task";
            stopTaskButton.UseVisualStyleBackColor = true;
            stopTaskButton.Click += stopTaskButton_Click;
            // 
            // restartTaskButton
            // 
            restartTaskButton.Location = new Point(248, 5);
            restartTaskButton.Name = "restartTaskButton";
            restartTaskButton.Size = new Size(76, 23);
            restartTaskButton.TabIndex = 4;
            restartTaskButton.Text = "Restart Task";
            restartTaskButton.UseVisualStyleBackColor = true;
            restartTaskButton.Click += restartTaskButton_Click;
            // 
            // newTaskButton
            // 
            newTaskButton.Location = new Point(102, 5);
            newTaskButton.Name = "newTaskButton";
            newTaskButton.Size = new Size(71, 23);
            newTaskButton.TabIndex = 5;
            newTaskButton.Text = "New Task";
            newTaskButton.UseVisualStyleBackColor = true;
            newTaskButton.Click += newTaskButton_Click;
            // 
            // dayOffButton
            // 
            dayOffButton.Location = new Point(326, 5);
            dayOffButton.Name = "dayOffButton";
            dayOffButton.Size = new Size(91, 23);
            dayOffButton.TabIndex = 9;
            dayOffButton.Text = "Take a day off";
            dayOffButton.UseVisualStyleBackColor = true;
            dayOffButton.Click += dayOffButton_Click;
            // 
            // lastDaySummaryButton
            // 
            lastDaySummaryButton.Location = new Point(439, 5);
            lastDaySummaryButton.Margin = new Padding(4, 2, 4, 2);
            lastDaySummaryButton.Name = "lastDaySummaryButton";
            lastDaySummaryButton.Size = new Size(113, 23);
            lastDaySummaryButton.TabIndex = 2;
            lastDaySummaryButton.Text = "Last day Summary";
            lastDaySummaryButton.UseVisualStyleBackColor = true;
            lastDaySummaryButton.Click += lastDaySummaryButton_Click;
            // 
            // totalSummaryButton
            // 
            totalSummaryButton.Location = new Point(555, 5);
            totalSummaryButton.Name = "totalSummaryButton";
            totalSummaryButton.Size = new Size(96, 23);
            totalSummaryButton.TabIndex = 6;
            totalSummaryButton.Text = "Total Summary";
            totalSummaryButton.UseVisualStyleBackColor = true;
            totalSummaryButton.Click += totalSummaryButton_Click;
            // 
            // workHoursButton
            // 
            workHoursButton.Location = new Point(653, 5);
            workHoursButton.Name = "workHoursButton";
            workHoursButton.Size = new Size(120, 23);
            workHoursButton.TabIndex = 7;
            workHoursButton.Text = "Daily Work Hours";
            workHoursButton.UseVisualStyleBackColor = true;
            workHoursButton.Click += workHoursButton_Click;
            // 
            // openDirectoryButton
            // 
            openDirectoryButton.Location = new Point(794, 5);
            openDirectoryButton.Name = "openDirectoryButton";
            openDirectoryButton.Size = new Size(99, 23);
            openDirectoryButton.TabIndex = 8;
            openDirectoryButton.Text = "Open Directory";
            openDirectoryButton.UseVisualStyleBackColor = true;
            openDirectoryButton.Click += openDirectoryButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(102, 17);
            toolStripStatusLabel1.Text = "00:00:00 - 00:00:00";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(102, 17);
            toolStripStatusLabel2.Text = "00:00:00 - 00:00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 561);
            Controls.Add(statusStrip1);
            Controls.Add(dayOffButton);
            Controls.Add(openDirectoryButton);
            Controls.Add(workHoursButton);
            Controls.Add(totalSummaryButton);
            Controls.Add(newTaskButton);
            Controls.Add(restartTaskButton);
            Controls.Add(stopTaskButton);
            Controls.Add(lastDaySummaryButton);
            Controls.Add(saveButton);
            Controls.Add(workLogTextBox);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "WorkLog V1.0";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox workLogTextBox;
        private Button saveButton;
        private Button stopTaskButton;
        private Button restartTaskButton;
        private Button newTaskButton;
        private Button dayOffButton;
        private Button lastDaySummaryButton;
        private Button totalSummaryButton;
        private Button workHoursButton;
        private Button openDirectoryButton;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}