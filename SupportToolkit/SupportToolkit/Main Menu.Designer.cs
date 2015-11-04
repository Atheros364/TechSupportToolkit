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
            this.ccS_Splitter1 = new SupportToolkit.CCS_Splitter();
            this.SuspendLayout();
            // 
            // ccS_Splitter1
            // 
            this.ccS_Splitter1.Location = new System.Drawing.Point(12, 97);
            this.ccS_Splitter1.Name = "ccS_Splitter1";
            this.ccS_Splitter1.Size = new System.Drawing.Size(330, 241);
            this.ccS_Splitter1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 350);
            this.Controls.Add(this.ccS_Splitter1);
            this.Name = "Form1";
            this.Text = "Support Toolkit";
            this.ResumeLayout(false);

        }

        #endregion

        private CCS_Splitter ccS_Splitter1;
    }
}

