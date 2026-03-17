using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students_Details st = new Students_Details();
            st.Show();
            this.Close();
        }

        

        private void main_form_Load(object sender, EventArgs e)
        {
          
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ADDTEACHER_Click(object sender, EventArgs e)
        {
            TEACHER_DETAIL sd = new TEACHER_DETAIL();
            sd.Show();
            this.Close();
        }

        private void ASSIGNINGSUBJECT_Click(object sender, EventArgs e)
        {
            subject2teacher st = new subject2teacher();
            st.Show();
            this.Close();
        }

        private void ADDSUBJECT_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void MARKSHEET_Click(object sender, EventArgs e)
        {
            Marksheet m = new Marksheet();
            m.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                 }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            //LoginForm lg = new LoginForm();

            //lg.Show();
            this.Close();
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

