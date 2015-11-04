namespace SupportToolkit
{
    partial class CCS_Splitter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitallButton = new System.Windows.Forms.Button();
            this.splitorderButton = new System.Windows.Forms.Button();
            this.splittimeButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.adjuststartButton = new System.Windows.Forms.Button();
            this.adjustendButton = new System.Windows.Forms.Button();
            this.adjuststartText = new System.Windows.Forms.TextBox();
            this.adjustendText = new System.Windows.Forms.TextBox();
            this.adjuststartBox = new System.Windows.Forms.Button();
            this.adjustendBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(260, 33);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 23);
            this.fileButton.TabIndex = 0;
            this.fileButton.Text = "Choose File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a .ccs file to split";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "CCS File";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitallButton
            // 
            this.splitallButton.Location = new System.Drawing.Point(48, 80);
            this.splitallButton.Name = "splitallButton";
            this.splitallButton.Size = new System.Drawing.Size(172, 23);
            this.splitallButton.TabIndex = 3;
            this.splitallButton.Text = "Split all of the segments";
            this.splitallButton.UseVisualStyleBackColor = true;
            this.splitallButton.Click += new System.EventHandler(this.splitallButton_Click);
            // 
            // splitorderButton
            // 
            this.splitorderButton.Location = new System.Drawing.Point(48, 128);
            this.splitorderButton.Name = "splitorderButton";
            this.splitorderButton.Size = new System.Drawing.Size(172, 23);
            this.splitorderButton.TabIndex = 4;
            this.splitorderButton.Text = "Split out of order segments";
            this.splitorderButton.UseVisualStyleBackColor = true;
            this.splitorderButton.Click += new System.EventHandler(this.splitorderButton_Click);
            // 
            // splittimeButton
            // 
            this.splittimeButton.Location = new System.Drawing.Point(48, 175);
            this.splittimeButton.Name = "splittimeButton";
            this.splittimeButton.Size = new System.Drawing.Size(172, 23);
            this.splittimeButton.TabIndex = 5;
            this.splittimeButton.Text = "Split segments at a certain time";
            this.splittimeButton.UseVisualStyleBackColor = true;
            this.splittimeButton.Click += new System.EventHandler(this.splittimeButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(235, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "H:MM:SS";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Enter += new System.EventHandler(this.textBox_GotFocus);
            this.textBox2.Leave += new System.EventHandler(this.textBox_LostFocus);
            // 
            // adjuststartButton
            // 
            this.adjuststartButton.Location = new System.Drawing.Point(48, 217);
            this.adjuststartButton.Name = "adjuststartButton";
            this.adjuststartButton.Size = new System.Drawing.Size(172, 23);
            this.adjuststartButton.TabIndex = 7;
            this.adjuststartButton.Text = "Adjust start time";
            this.adjuststartButton.UseVisualStyleBackColor = true;
            this.adjuststartButton.Click += new System.EventHandler(this.adjuststartButton_Click);
            // 
            // adjustendButton
            // 
            this.adjustendButton.Location = new System.Drawing.Point(48, 256);
            this.adjustendButton.Name = "adjustendButton";
            this.adjustendButton.Size = new System.Drawing.Size(172, 23);
            this.adjustendButton.TabIndex = 8;
            this.adjustendButton.Text = "Adjust end time";
            this.adjustendButton.UseVisualStyleBackColor = true;
            this.adjustendButton.Click += new System.EventHandler(this.adjustendButton_Click);
            // 
            // adjuststartText
            // 
            this.adjuststartText.ForeColor = System.Drawing.Color.Gray;
            this.adjuststartText.Location = new System.Drawing.Point(235, 217);
            this.adjuststartText.Name = "adjuststartText";
            this.adjuststartText.Size = new System.Drawing.Size(100, 20);
            this.adjuststartText.TabIndex = 9;
            this.adjuststartText.Text = "mS";
            this.adjuststartText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adjuststartText.Enter += new System.EventHandler(this.textBox_GotFocus);
            this.adjuststartText.Leave += new System.EventHandler(this.textBox_LostFocus);
            // 
            // adjustendText
            // 
            this.adjustendText.ForeColor = System.Drawing.Color.Gray;
            this.adjustendText.Location = new System.Drawing.Point(235, 256);
            this.adjustendText.Name = "adjustendText";
            this.adjustendText.Size = new System.Drawing.Size(100, 20);
            this.adjustendText.TabIndex = 10;
            this.adjustendText.Text = "mS";
            this.adjustendText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.adjustendText.Enter += new System.EventHandler(this.textBox_GotFocus);
            this.adjustendText.Leave += new System.EventHandler(this.textBox_LostFocus);
            // 
            // adjuststartBox
            // 
            this.adjuststartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjuststartBox.Location = new System.Drawing.Point(341, 217);
            this.adjuststartBox.Name = "adjuststartBox";
            this.adjuststartBox.Size = new System.Drawing.Size(28, 21);
            this.adjuststartBox.TabIndex = 11;
            this.adjuststartBox.Text = "-";
            this.adjuststartBox.UseVisualStyleBackColor = true;
            this.adjuststartBox.Click += new System.EventHandler(this.adjuststartBox_Click);
            // 
            // adjustendBox
            // 
            this.adjustendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustendBox.Location = new System.Drawing.Point(341, 255);
            this.adjustendBox.Name = "adjustendBox";
            this.adjustendBox.Size = new System.Drawing.Size(28, 21);
            this.adjustendBox.TabIndex = 12;
            this.adjustendBox.Text = "+";
            this.adjustendBox.UseVisualStyleBackColor = true;
            this.adjustendBox.Click += new System.EventHandler(this.adjustendBox_Click);
            // 
            // CCS_Splitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adjustendBox);
            this.Controls.Add(this.adjuststartBox);
            this.Controls.Add(this.adjustendText);
            this.Controls.Add(this.adjuststartText);
            this.Controls.Add(this.adjustendButton);
            this.Controls.Add(this.adjuststartButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.splittimeButton);
            this.Controls.Add(this.splitorderButton);
            this.Controls.Add(this.splitallButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileButton);
            this.Name = "CCS_Splitter";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button splitallButton;
        private System.Windows.Forms.Button splitorderButton;
        private System.Windows.Forms.Button splittimeButton;
        private System.Windows.Forms.TextBox textBox2;

        public bool waterMarkSplit = true;
        public bool waterMarkStart = true;
        public bool waterMarkEnd = true;
        private System.Windows.Forms.Button adjuststartButton;
        private System.Windows.Forms.Button adjustendButton;
        private System.Windows.Forms.TextBox adjuststartText;
        private System.Windows.Forms.TextBox adjustendText;
        private System.Windows.Forms.Button adjuststartBox;
        private System.Windows.Forms.Button adjustendBox;
    }
}
