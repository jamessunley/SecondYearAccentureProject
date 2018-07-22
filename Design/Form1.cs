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
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Design
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int rw = dgvAll.Rows.Count;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


        // make a function named zpt 

    //define rw as globly variable in form
        public void zpt()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Arial", 10);
            PaperSize psz = new PaperSize("Custom", 100, 200);
            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psz;
            pdoc.DefaultPageSettings.Landscape = true;
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            DialogResult res = pd.ShowDialog();
            if (res == DialogResult.OK)
            {
                PrintPreviewDialog prv = new PrintPreviewDialog();
                prv.Document = pdoc;
                res = prv.ShowDialog();
                if (res == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }

        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 65;
            int Offset = 40;

            int padding = 10;
            graphics.DrawString("Report", new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            string underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            int a = dgvAll.Rows.Count;
            for (int i = 0; i < a; i++)
            {

                //Coursename
                graphics.DrawString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
                SizeF stringSize = new SizeF();

                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value), new Font("Courier New", 10));
                graphics.DrawString("\t" + Convert.ToString(dgvAll.Rows[i].Cells[1].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width, startY + Offset);


                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value), new Font("Courier New", 10));
                graphics.DrawString("\t £" + Convert.ToString(dgvAll.Rows[i].Cells[2].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width+padding, startY + Offset);

                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value), new Font("Courier New", 10));
                graphics.DrawString("\t " + Convert.ToString(dgvAll.Rows[i].Cells[3].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);

                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[3].Value), new Font("Courier New", 10));
                graphics.DrawString("\t £" + Convert.ToString(dgvAll.Rows[i].Cells[4].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);


                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[3].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[4].Value), new Font("Courier New", 10));
                graphics.DrawString("\t " + Convert.ToString(dgvAll.Rows[i].Cells[5].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);

                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[3].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[4].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[5].Value), new Font("Courier New", 10));
                graphics.DrawString("\t " + Convert.ToString(dgvAll.Rows[i].Cells[6].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);

                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[3].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[4].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[5].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[6].Value), new Font("Courier New", 10));
                graphics.DrawString("\t " + Convert.ToString(dgvAll.Rows[i].Cells[7].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);
                
                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[3].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[4].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[5].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[6].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[7].Value), new Font("Courier New", 10));
                graphics.DrawString("\t " + Convert.ToString(dgvAll.Rows[i].Cells[8].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);

                //
                stringSize = e.Graphics.MeasureString(Convert.ToString(dgvAll.Rows[i].Cells[0].Value) + Convert.ToString(dgvAll.Rows[i].Cells[1].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[2].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[3].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[4].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[5].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[6].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[7].Value) + Convert.ToString(padding) + Convert.ToString(dgvAll.Rows[i].Cells[8].Value), new Font("Courier New", 10));
                graphics.DrawString("\t " + Convert.ToString(dgvAll.Rows[i].Cells[9].Value), new Font("Courier New", 10), new SolidBrush(Color.Black), stringSize.Width + padding, startY + Offset);

                Offset = Offset + 20;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSelect.TabStop = false;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.FlatAppearance.BorderSize = 0;

            btnViewComment.TabStop = false;
            btnViewComment.FlatStyle = FlatStyle.Flat;
            btnViewComment.FlatAppearance.BorderSize = 0;

            btnAddComment.TabStop = false;
            btnAddComment.FlatStyle = FlatStyle.Flat;
            btnAddComment.FlatAppearance.BorderSize = 0;

            btnCancel.TabStop = false;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;

            btnSearch.TabStop = false;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;


            //using (StreamReader sr = new StreamReader("Settings.txt"))
            //{
            //    while (sr.Peek() != -1)
            //    {
            //        this.BackColor = (sr.Read);
            //    }
            //}


            // combo box
            cboReport.Items.Add("Report 1");
            cboReport.Items.Add("Report 2");
            cboReport.Items.Add("Report 3");
            cboReport.Items.Add("Report 4");

            //fill datagrid
            string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=courses&quarter=1";

            ReportDataSet.ReadXml(filePath);

            dgvAll.DataSource = ReportDataSet;
            ReportDataSet.Clear();
            dgvAll.DataMember = "course";

            dgvAll.Columns[0].HeaderText = "Course";
            dgvAll.Columns[1].HeaderText = "Quater";
            dgvAll.Columns[2].HeaderText = "Course Cost";
            dgvAll.Columns[3].HeaderText = "Hours";
            dgvAll.Columns[4].HeaderText = "Cost With Travel";
            dgvAll.Columns[5].HeaderText = "Location";
            dgvAll.Columns[6].HeaderText = "Number of Enrolements";
            dgvAll.Columns[7].HeaderText = "Raw Total Cost";
            dgvAll.Columns[8].HeaderText = "Total Cost With Travel";
            dgvAll.Columns[9].HeaderText = "Total Hours";

            
        }
        private void dataGrid ()
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Do you want to exit?", "Exit", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            Comments newComment = new Comments();
            newComment.Show();
        }

        private void btnViewComment_Click(object sender, EventArgs e)
        {
            View newView = new View();
            newView.Show();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnAddComment.BackColor = colorDialog1.Color;
            btnViewComment.BackColor = colorDialog1.Color;
            btnCancel.BackColor = colorDialog1.Color;
            btnSearch.BackColor = colorDialog1.Color;
            btnSelect.BackColor = colorDialog1.Color;
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lblLocation.Font = fontDialog1.Font;

        }

        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Settings.txt"))
            {
                sw.WriteLine(btnAddComment.BackColor);
                sw.WriteLine(this.BackColor);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccentureTraining newAbout = new AccentureTraining();
            newAbout.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpViewReports newHelp = new HelpViewReports();
            newHelp.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancellations newcancel = new Cancellations();
            newcancel.Show();
        }

        // code to print and print priview

        private void printDocument1_PrintReport(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dgvAll, myPaintArgs);
        }
        public PrintDocument Document { get; set; }

        // Declare the PrintDocument object.
        private System.Drawing.Printing.PrintDocument docToPrint =
            new System.Drawing.Printing.PrintDocument();

        [BrowsableAttribute(false)]
        public PrinterSettings PrinterSettings { get; set; }

        private void printToolStripMenuItem_Click_1(object sender, System.EventArgs e)

        {

            // Allow the user to choose the page range he or she would
            // like to print.
            printDialog1.AllowSomePages = true;

            // Show the help button.
            printDialog1.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            printDialog1.Document = docToPrint;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }

        }

        // The PrintDialog will print the document
        // by handling the document's PrintPage event.
        private void document_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the control is drawn.



            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont = new System.Drawing.Font
                ("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }
        private void printPreviewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // The print document 'myDocument' used below
            // is merely for an example.
            // You will have to specify your own print document.
            //printPreviewDialog1.Document = docToPrint;
            //printPreviewDialog1.ShowDialog();
            zpt();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReportDataSet.Clear();
            string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=search&query=" + txtSearch.Text;

            ReportDataSet.ReadXml(filePath);

            dgvAll.DataSource = ReportDataSet;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cboReport.SelectedItem == "Report 1")
            {
                ReportDataSet.Clear();
                string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=courses&quarter=1";

                ReportDataSet.ReadXml(filePath);
            }
            else if(cboReport.SelectedItem == "Report 2")
            {
                ReportDataSet.Clear();
                string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=courses&quarter=2";

                ReportDataSet.ReadXml(filePath);
            }
            else if (cboReport.SelectedItem == "Report 3")
            {
                ReportDataSet.Clear();
                string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=courses&quarter=3";

                ReportDataSet.ReadXml(filePath);
            }
            else if (cboReport.SelectedItem == "Report 4")
            {
                ReportDataSet.Clear();
                string filePath = "http://nestor.sunderland.ac.uk/~bg69qw/accenture-courses/api.php?key=213958403&type=courses&quarter=4";

                ReportDataSet.ReadXml(filePath);
            }

        }
    }
}
