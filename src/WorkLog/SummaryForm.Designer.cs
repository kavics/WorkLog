namespace WorkLog
{
    partial class SummaryForm
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
            textBox1 = new TextBox();
            DropButton = new Button();
            KeepButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(799, 409);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // DropButton
            // 
            DropButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DropButton.Location = new Point(306, 415);
            DropButton.Name = "DropButton";
            DropButton.Size = new Size(75, 23);
            DropButton.TabIndex = 1;
            DropButton.Text = "Drop";
            DropButton.UseVisualStyleBackColor = true;
            DropButton.Click += DropButton_Click;
            // 
            // KeepButton
            // 
            KeepButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            KeepButton.Location = new Point(413, 415);
            KeepButton.Name = "KeepButton";
            KeepButton.Size = new Size(75, 23);
            KeepButton.TabIndex = 2;
            KeepButton.Text = "Keep";
            KeepButton.UseVisualStyleBackColor = true;
            KeepButton.Click += KeepButton_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KeepButton);
            Controls.Add(DropButton);
            Controls.Add(textBox1);
            Name = "SummaryForm";
            Text = "SummaryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button DropButton;
        private Button KeepButton;
    }
}