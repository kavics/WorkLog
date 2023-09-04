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
            workLogTextBox = new TextBox();
            saveButton = new Button();
            lastDaySummaryButton = new Button();
            stopTaskButton = new Button();
            restartTaskButton = new Button();
            newTaskButton = new Button();
            totalSummaryButton = new Button();
            workHoursButton = new Button();
            openDirectoryButton = new Button();
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
            workLogTextBox.Size = new Size(1000, 530);
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
            // lastDaySummaryButton
            // 
            lastDaySummaryButton.Location = new Point(372, 5);
            lastDaySummaryButton.Margin = new Padding(4, 2, 4, 2);
            lastDaySummaryButton.Name = "lastDaySummaryButton";
            lastDaySummaryButton.Size = new Size(120, 23);
            lastDaySummaryButton.TabIndex = 2;
            lastDaySummaryButton.Text = "Last day Summary";
            lastDaySummaryButton.UseVisualStyleBackColor = true;
            lastDaySummaryButton.Click += lastDaySummaryButton_Click;
            // 
            // stopTaskButton
            // 
            stopTaskButton.Location = new Point(179, 5);
            stopTaskButton.Name = "stopTaskButton";
            stopTaskButton.Size = new Size(75, 23);
            stopTaskButton.TabIndex = 3;
            stopTaskButton.Text = "Stop Task";
            stopTaskButton.UseVisualStyleBackColor = true;
            stopTaskButton.Click += stopTaskButton_Click;
            // 
            // restartTaskButton
            // 
            restartTaskButton.Location = new Point(256, 5);
            restartTaskButton.Name = "restartTaskButton";
            restartTaskButton.Size = new Size(95, 23);
            restartTaskButton.TabIndex = 4;
            restartTaskButton.Text = "Restart Task";
            restartTaskButton.UseVisualStyleBackColor = true;
            restartTaskButton.Click += restartTaskButton_Click;
            // 
            // newTaskButton
            // 
            newTaskButton.Location = new Point(102, 5);
            newTaskButton.Name = "newTaskButton";
            newTaskButton.Size = new Size(75, 23);
            newTaskButton.TabIndex = 5;
            newTaskButton.Text = "New Task";
            newTaskButton.UseVisualStyleBackColor = true;
            newTaskButton.Click += newTaskButton_Click;
            // 
            // totalSummaryButton
            // 
            totalSummaryButton.Location = new Point(495, 5);
            totalSummaryButton.Name = "totalSummaryButton";
            totalSummaryButton.Size = new Size(120, 23);
            totalSummaryButton.TabIndex = 6;
            totalSummaryButton.Text = "Total Summary";
            totalSummaryButton.UseVisualStyleBackColor = true;
            totalSummaryButton.Click += totalSummaryButton_Click;
            // 
            // workHoursButton
            // 
            workHoursButton.Location = new Point(617, 5);
            workHoursButton.Name = "workHoursButton";
            workHoursButton.Size = new Size(120, 23);
            workHoursButton.TabIndex = 7;
            workHoursButton.Text = "Daily Work Hours";
            workHoursButton.UseVisualStyleBackColor = true;
            workHoursButton.Click += workHoursButton_Click;
            // 
            // openDirectoryButton
            // 
            openDirectoryButton.Location = new Point(760, 5);
            openDirectoryButton.Name = "openDirectoryButton";
            openDirectoryButton.Size = new Size(99, 23);
            openDirectoryButton.TabIndex = 8;
            openDirectoryButton.Text = "Open Directory";
            openDirectoryButton.UseVisualStyleBackColor = true;
            openDirectoryButton.Click += openDirectoryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 561);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox workLogTextBox;
        private Button saveButton;
        private Button lastDaySummaryButton;
        private Button stopTaskButton;
        private Button restartTaskButton;
        private Button newTaskButton;
        private Button totalSummaryButton;
        private Button workHoursButton;
        private Button openDirectoryButton;
    }
}