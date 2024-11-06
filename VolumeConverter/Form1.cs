using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            litreTextbox.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void literLabel_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            float cl;
            float litre;
            cl = Convert.ToInt32(clTextbox.Text);
            litre = cl / 100;
            litreTextbox.Text = litre.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clTextbox.Text = "";
            litreTextbox.Text = "";
        }
    }
}
