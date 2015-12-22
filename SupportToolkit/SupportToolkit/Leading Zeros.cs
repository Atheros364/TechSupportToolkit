using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportToolkit
{
    public partial class Leading_Zeros : UserControl
    {
        public Leading_Zeros()
        {
            InitializeComponent();
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            FolderBrowserDialog FolderBrowserSource = new FolderBrowserDialog();

            DialogResult result = FolderBrowserSource.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourceFolderText = FolderBrowserSource.SelectedPath;
            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ZerosOptions optionBox = new ZerosOptions();
            optionBox.ShowDialog();
        }

    }
}
