namespace SupportToolkit
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
            this.ccsButton = new System.Windows.Forms.Button();
            this.zerosButton = new System.Windows.Forms.Button();
            this.loadfileButton = new System.Windows.Forms.Button();
            this.ccssplitterUC = new SupportToolkit.CCS_Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leadingzerosUC = new SupportToolkit.Leading_Zeros();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ccsButton
            // 
            this.ccsButton.Location = new System.Drawing.Point(12, 12);
            this.ccsButton.Name = "ccsButton";
            this.ccsButton.Size = new System.Drawing.Size(75, 23);
            this.ccsButton.TabIndex = 1;
            this.ccsButton.Text = "CCS Splitter";
            this.ccsButton.UseVisualStyleBackColor = true;
            this.ccsButton.Click += new System.EventHandler(this.ccsButton_Click);
            // 
            // zerosButton
            // 
            this.zerosButton.Location = new System.Drawing.Point(13, 42);
            this.zerosButton.Name = "zerosButton";
            this.zerosButton.Size = new System.Drawing.Size(75, 35);
            this.zerosButton.TabIndex = 2;
            this.zerosButton.Text = "Leading Zeros";
            this.zerosButton.UseVisualStyleBackColor = true;
            this.zerosButton.Click += new System.EventHandler(this.zerosButton_Click);
            // 
            // loadfileButton
            // 
            this.loadfileButton.Location = new System.Drawing.Point(13, 84);
            this.loadfileButton.Name = "loadfileButton";
            this.loadfileButton.Size = new System.Drawing.Size(75, 38);
            this.loadfileButton.TabIndex = 3;
            this.loadfileButton.Text = "Load File Creator";
            this.loadfileButton.UseVisualStyleBackColor = true;
            this.loadfileButton.Click += new System.EventHandler(this.loadfileButton_Click);
            // 
            // ccssplitterUC
            // 
            this.ccssplitterUC.Location = new System.Drawing.Point(100, 0);
            this.ccssplitterUC.Name = "UC";
            this.ccssplitterUC.Size = new System.Drawing.Size(400, 300);
            this.ccssplitterUC.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 300);
            this.panel1.TabIndex = 4;
            // 
            // leadingzerosUC
            // 
            this.leadingzerosUC.Location = new System.Drawing.Point(100, 0);
            this.leadingzerosUC.Name = "UC";
            this.leadingzerosUC.Size = new System.Drawing.Size(400, 300);
            this.leadingzerosUC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "inData Tech Support Toolkit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Written by: Andrew Ruth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leadingzerosUC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loadfileButton);
            this.Controls.Add(this.zerosButton);
            this.Controls.Add(this.ccsButton);
            this.Controls.Add(this.ccssplitterUC);
            this.Name = "Form1";
            this.Text = "Support Toolkit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        #endregion

        private CCS_Splitter ccssplitterUC;
        private System.Windows.Forms.Button ccsButton;
        private System.Windows.Forms.Button zerosButton;
        private System.Windows.Forms.Button loadfileButton;
        private System.Windows.Forms.Panel panel1;
        private Leading_Zeros leadingzerosUC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

