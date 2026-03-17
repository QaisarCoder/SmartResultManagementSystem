using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
//using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        private PrintDocument printDocument = new PrintDocument();

        public void SetUserName(string roll_no, string stname, string ftname, string sem, string sbj1, string sbj2, string sbj3, string sbj4, string sbj5, string sbj6, string sbj7, string obt7, string obt1, string obt2, string obt3, string obt4, string obt5, string obt6, string gr1, string gr2, string gr3, string gr4, string gr5, string gr6, string gr7, string result, string obmrk, string perecnt, string dtpick, string grls3, string grls2, string grls1, string min3, string min2, string min1)
        {
            tb1.Text = roll_no;
            label6.Text = stname + " " + ftname;
            label11.Text = sem + "Semester";
            label8.Text = "Regular Examination Session -20" + roll_no[0] + "" + roll_no[1];
            sb1.Text = sbj1; sb2.Text = sbj2; sb3.Text = sbj3; sb4.Text = sbj4; sb5.Text = sbj5; sb6.Text = sbj6; sb7.Text = sbj7;
            label37.Text = obt1; label38.Text = obt2; label39.Text = obt3; label40.Text = obt4; label41.Text = obt5; label42.Text = obt6; label43.Text = obt7;
            label31.Text = gr1; label32.Text = gr2; label33.Text = gr3; label34.Text = gr4; label35.Text = gr5; label36.Text = gr6; label44.Text = gr7;
            label47.Text = result; label45.Text = obmrk; label46.Text = perecnt; label48.Text = "Date of Issue :" + dtpick;
            label20.Text = grls3; label19.Text = grls2; label18.Text = grls1;
            label25.Text = min3; label30.Text = min2; label29.Text = min1;
        }


        private void Print_Load(object sender, EventArgs e)
        {
            //    // Attach print page event
            //    printDocument.PrintPage += new PrintPageEventHandler(PrintDocument);

            //    // Create and show print dialog
            //    PrintDialog printDialog = new PrintDialog();
            //    printDialog.Document = printDocument;

            //    if (printDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        printDocument.Print();
            //    }
            //}
            //    // Attach print page event
            //    printDocument.PrintPage += new PrintPageEventHandler(PrintDocument);

            //    // Create and show preview dialog
            //    PrintPreviewDialog preview = new PrintPreviewDialog();
            //    preview.Document = printDocument;
            //    preview.Width = 900;
            //    preview.Height = 700;

            //    // Show preview — the user can print from preview window
            //    preview.ShowDialog();
        }






        //PrintDialog printDialog = new PrintDialog();
        //System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
        //printDialog.Document = doc;
        //if (printDialog.ShowDialog() == DialogResult.OK)
        //{
        //    doc.Print();






        //PrintDialog printDialog = new PrintDialog();
        //System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
        //printDialog.Document = doc;

        //// Attach the PrintPage event
        //doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Doc_PrintPage);

        //if (printDialog.ShowDialog() == DialogResult.OK)
        //{
        //    doc.Print();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {FormBorderStyle = FormBorderStyle.None;
            button1.Visible= false;
            try
            {
                // Step 1: Capture the form as an image
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, this.Width, this.Height)
);

                // Step 2: Ask user where to save
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save Form as PDF";
                saveFileDialog.FileName = "FormCapture.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfPath = saveFileDialog.FileName;

                    // Step 3: Convert image to PDF
                    using (FileStream stream = new FileStream(pdfPath, FileMode.Create))
                    {
                        // Create a new PDF document sized to the form
                        iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(bmp.Width, bmp.Height);
                        Document pdfDoc = new Document(pageSize, 0, 0, 0, 0);

                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, ImageFormat.Png);
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                            img.SetAbsolutePosition(0, 0);
                            pdfDoc.Add(img);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Form saved successfully to PDF!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Visible = true;
            FormBorderStyle = FormBorderStyle.Sizable;


            //    SaveFileDialog saveDialog = new SaveFileDialog();
            //    saveDialog.Filter = "PDF Files|*.pdf";
            //    saveDialog.Title = "Save Marksheet as PDF";

            //    if (saveDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        GeneratePDF(saveDialog.FileName);
            //        MessageBox.Show("Marksheet exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //private void GeneratePDF(string filePath)
            //{
            //    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            //    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            //    doc.Open();

            //    // Title
            //    Paragraph title = new Paragraph("STUDENT MARKSHEET", new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 16, iTextSharp.text.Font.BOLD));

            //    title.Alignment = Element.ALIGN_CENTER;
            //    doc.Add(title);
            //    doc.Add(new Paragraph(" "));

            //    // Basic Info
            //    doc.Add(new Paragraph($"Roll No: {textBox1.Text}"));
            //    doc.Add(new Paragraph($"Name: {label6.Text}"));
            //    doc.Add(new Paragraph($"Semester: {label11.Text}"));
            //    doc.Add(new Paragraph($"{label8.Text}"));
            //    doc.Add(new Paragraph(" "));

            //    // Marks Table
            //    PdfPTable table = new PdfPTable(4);
            //    table.WidthPercentage = 100;
            //    table.AddCell("Subject");
            //    table.AddCell("Marks Obtained");
            //    table.AddCell("Grade");
            //    table.AddCell("Min Marks");

            //    // Add subject rows (only if not empty)
            //    AddSubjectRow(table, sb1.Text, label37.Text, label31.Text, label29.Text);
            //    AddSubjectRow(table, sb2.Text, label38.Text, label32.Text, label30.Text);
            //    AddSubjectRow(table, sb3.Text, label39.Text, label33.Text, label25.Text);
            //    AddSubjectRow(table, sb4.Text, label40.Text, label34.Text, "");
            //    AddSubjectRow(table, sb5.Text, label41.Text, label35.Text, "");
            //    AddSubjectRow(table, sb6.Text, label42.Text, label36.Text, "");
            //    AddSubjectRow(table, sb7.Text, label43.Text, label44.Text, "");

            //    doc.Add(table);
            //    doc.Add(new Paragraph(" "));

            //    // Summary info
            //    doc.Add(new Paragraph($"{label45.Text}"));
            //    doc.Add(new Paragraph($"{label46.Text}"));
            //    doc.Add(new Paragraph($"{label47.Text}"));
            //    doc.Add(new Paragraph($"{label48.Text}"));

            //    doc.Close();
            //}
            //private void AddSubjectRow(PdfPTable table, string subject, string marks, string grade, string min)
            //{
            //    if (!string.IsNullOrEmpty(subject))
            //    {
            //        table.AddCell(subject);
            //        table.AddCell(string.IsNullOrEmpty(marks) ? "-" : marks);
            //        table.AddCell(string.IsNullOrEmpty(grade) ? "-" : grade);
            //        table.AddCell(string.IsNullOrEmpty(min) ? "-" : min);
            //    }
            //}

        }
    }
}
