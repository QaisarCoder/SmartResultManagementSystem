using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-H5DN19J\\SQLEXPRESS;Initial Catalog=newmydbs;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from login where ids = '" + textBox1.Text.ToString() + "' and passwords = '" + textBox2.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            { 
                //MessageBox.Show("SUCCESSFULLY LOGIN", "LOGIN" );
                Con.Close();
                main_form mn = new main_form();
                mn.Show();
                
                               
              
            }
            else MessageBox.Show("USERNAME OR PASSWORD IS INCORRECT ", "LOGIN ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Con.Close();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                   }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
