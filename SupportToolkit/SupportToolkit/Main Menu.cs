using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportToolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ccssplitterUC.Hide();
            leadingzerosUC.Hide();
        }

        // The buttons switch between user controls, everything else is done in the controls themselves
        private void ccsButton_Click(object sender, EventArgs e)
        {
            HideUserControls();
            ccssplitterUC.Show();
        }

        private void zerosButton_Click(object sender, EventArgs e)
        {
            HideUserControls();
            leadingzerosUC.Show();
        }

        private void loadfileButton_Click(object sender, EventArgs e)
        {
            HideUserControls();

        }

        private void HideUserControls()//this will hide the intro text and all of the user controls
        {
            label1.Hide();
            label2.Hide();
            Control[] userControls = Controls.Find("UC", true);//get the controls that contain the name UC for user control and then hide them
            for(int i = 0; i < userControls.Length; i++)
            {
                userControls[i].Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
