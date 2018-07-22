using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;


namespace Design
{
    public partial class Cancellations : Form
    {
        public Cancellations()
        {
            InitializeComponent();
        }

        private void Cancellations_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpCancellations newHelp = new HelpCancellations();
            newHelp.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=cancellations";

            CancellationsDataSet.ReadXml(filePath);

            dgvcancellations.DataSource = CancellationsDataSet;
            dgvcancellations.DataMember = "user";

            dgvcancellations.Columns[0].HeaderText = "First Name";
            dgvcancellations.Columns[1].HeaderText = "Surname";
            dgvcancellations.Columns[2].HeaderText = "Email Address";
            dgvcancellations.Columns[3].HeaderText = "Course Cancelled";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvcancellations.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvcancellations.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvcancellations.Rows[selectedrowindex];

                string email = Convert.ToString(selectedRow.Cells["email"].Value);

                //MessageBox.Show(email);


                string command = "mailto:" + email + "? subject=Regarding Your Cancellation";
                //string command = "mailto:gmail[at]googlem.com?subject=Regarding Your Cancellation";

                Process.Start(command);

            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvcancellations.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvcancellations.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvcancellations.Rows[selectedrowindex];

                string email = Convert.ToString(selectedRow.Cells["email"].Value);

                //MessageBox.Show(email);


                string command = "mailto:" + email + "? subject=Regarding Your Cancellation";
                //string command = "mailto:gmail[at]googlem.com?subject=Regarding Your Cancellation";

                Process.Start(command);
            }
        }
    }
}