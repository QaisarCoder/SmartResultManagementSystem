using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    public partial class Students_Details : Form
    {
        public Students_Details()
        {
            InitializeComponent();
        }

        public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-H5DN19J\\SQLEXPRESS;Initial Catalog=newmydbs;Integrated Security=True;");

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Gridview(String query)
        {
            try
            {
                Con.Open();
                SqlCommand c = new SqlCommand(query, Con);
                SqlDataAdapter da = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                Con.Close();
              
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
                return;
            }
        }
        public void General_query(string Query)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                Con.Close();
                return;
            }
        }

        public void clear1()
        {
            textBox1.Text = "";   textBox2.Text = ""; textBox3.Text = "";  dTPicker1.Text = ""; CB1.Text = ""; 
            textBox4.Text = "COMPUTER SCIENCE";  textBox7.Text = ""; CB2.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                string Query = ("INSERT INTO Students VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dTPicker1.Text.ToString() +"','"+ CB1.Text.ToString()+"','" + textBox4.Text.ToString() + "','"+ textBox7.Text.ToString() +"','"+ CB2.Text.ToString()+ "')");
                General_query(Query);
                MessageBox.Show("Data Saved", " SAVE", MessageBoxButtons.OK);
                Gridview("select * from Students");
                clear1();
              
            }

            else MessageBox.Show("Fill All Fields ", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        private void update_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                string Query = ("Update Students set  Roll_number = '" + textBox1.Text.ToString() + "', STUDENT_NAME = '" + textBox2.Text.ToString() + "',FATHER_NAME = '" + textBox3.Text.ToString() + "',DOB = '" + dTPicker1.Text.ToString() + "', GENDER = '" + CB1.Text.ToString() + "', DEPARTMENT = '" + textBox4.Text.ToString() + "', BATCH  = '" + textBox7.Text.ToString() + "',SEMESTER = '" + CB2.Text.ToString() + "'  where Roll_number = '" + textBox1.Text.ToString() + "'");
                General_query(Query);
                MessageBox.Show("Data Updated ", " UPDATE", MessageBoxButtons.OK);
                Gridview("select * from Students");
                clear1();
            }

            else MessageBox.Show("Enter Roll Number", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                string Query = ("Delete from  Students where Roll_number = '" + textBox1.Text.ToString() + "' ");
                General_query(Query);
                MessageBox.Show("Data Deleted", " DELETE", MessageBoxButtons.OK);
                clear1();
                Gridview("select * from Students");
            }

            else MessageBox.Show("Enter Roll Number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = "";
            clear1();
            textBox5.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            Gridview("select * from students  where Roll_number  like '" + textBox5.Text + "%'; ");
                            
            else MessageBox.Show("Enter Roll Number", "ERORR", MessageBoxButtons.OK , MessageBoxIcon.Error) ;

        }

        private void GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            if (e.RowIndex != -1)
            {
                DataGridViewRow dg = GridView1.Rows[e.RowIndex];
                textBox1.Text = dg.Cells[0].Value.ToString();
                textBox2.Text = dg.Cells[1].Value.ToString(); 
                textBox3.Text = dg.Cells[2].Value.ToString();
                dTPicker1.Text=dg.Cells[3].Value.ToString();
                CB1.Text = dg.Cells[4].Value.ToString();
                textBox4.Text = dg.Cells[5].Value.ToString(); 
                textBox7.Text = dg.Cells[6].Value.ToString(); 
                CB2.Text = dg.Cells[7].Value.ToString();
            }
        }
            catch (Exception ex) { MessageBox.Show("" + ex); }
}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.STUDENTS' table. You can move, or remove it, as needed.
            this.sTUDENTSTableAdapter.Fill(this.newmydbDataSet.STUDENTS);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            main_form mn = new main_form();
            mn.Show();
            this.Close();
        }
    }
}
