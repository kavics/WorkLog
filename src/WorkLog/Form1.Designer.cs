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
            calcButton = new Button();
            stopTaskButton = new Button();
            restartTaskButton = new Button();
            newTaskButton = new Button();
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
            saveButton.Location = new Point(4, 5);
            saveButton.Margin = new Padding(4, 2, 4, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(398, 5);
            calcButton.Margin = new Padding(4, 2, 4, 2);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(75, 23);
            calcButton.TabIndex = 2;
            calcButton.Text = "Calculate";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // stopTaskButton
            // 
            stopTaskButton.Location = new Point(192, 5);
            stopTaskButton.Name = "stopTaskButton";
            stopTaskButton.Size = new Size(75, 23);
            stopTaskButton.TabIndex = 3;
            stopTaskButton.Text = "Stop Task";
            stopTaskButton.UseVisualStyleBackColor = true;
            stopTaskButton.Click += stopTaskButton_Click;
            // 
            // restartTaskButton
            // 
            restartTaskButton.Location = new Point(273, 5);
            restartTaskButton.Name = "restartTaskButton";
            restartTaskButton.Size = new Size(95, 23);
            restartTaskButton.TabIndex = 4;
            restartTaskButton.Text = "Restart Task";
            restartTaskButton.UseVisualStyleBackColor = true;
            restartTaskButton.Click += restartTaskButton_Click;
            // 
            // newTaskButton
            // 
            newTaskButton.Location = new Point(111, 5);
            newTaskButton.Name = "newTaskButton";
            newTaskButton.Size = new Size(75, 23);
            newTaskButton.TabIndex = 5;
            newTaskButton.Text = "New Task";
            newTaskButton.UseVisualStyleBackColor = true;
            newTaskButton.Click += newTaskButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 561);
            Controls.Add(newTaskButton);
            Controls.Add(restartTaskButton);
            Controls.Add(stopTaskButton);
            Controls.Add(calcButton);
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
        private Button calcButton;
        private Button stopTaskButton;
        private Button restartTaskButton;
        private Button newTaskButton;
    }
}