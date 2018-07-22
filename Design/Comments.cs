using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Design
{
    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtBox.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtBox.Font = fontDialog1.Font;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpAddComments newHelp = new HelpAddComments();
            newHelp.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(txtname.Text + ".txt"))
            {
                sw.WriteLine(txtBox.Text);
            }
            this.Close();
        }
    }
}
