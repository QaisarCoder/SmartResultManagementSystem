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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    public partial class TEACHER_DETAIL : Form
    {
        public TEACHER_DETAIL()
        {
            InitializeComponent();
        }
        public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-H5DN19J\\SQLEXPRESS;Initial Catalog=newmydbs;Integrated Security=True;");

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
                GV1.DataSource = dt;
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
            textBox2.Text = "";  cb1.Text = ""; textBox4.Text = "COMPUTER SCIENCE";
             mask.Text = "";  textBox1.Text = "";

        }
         


        private void Add_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text != "" && cb1.Text != "" && mask.Text != "")
            {
                string Query = ("INSERT INTO TEACHER_DETAILS(TEACHER_NAME, GENDER, DEPARTMENT, PHONE_NUMBER) VALUES ('" + textBox2.Text.ToString() + "','" + cb1.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + mask.Text.ToString() + "')");
                General_query(Query);
                MessageBox.Show("Data Saved ", " SAVE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM TEACHER_DETAILS");
                clear1();
                
            }

            else MessageBox.Show("Fill All Fields", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string Query = ("Update TEACHER_DETAILS set  TEACHER_NAME = '" + textBox2.Text.ToString() + "', GENDER = '" + cb1.Text.ToString() + "', DEPARTMENT = '" + textBox4.Text.ToString() + "', PHONE_NUMBER  = '" + mask.Text.ToString() + "'  where TEACHER_ID = '" + textBox1.Text.ToString() + "'");
                General_query(Query);
                MessageBox.Show(" Data updated ", " UPDATE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM TEACHER_DETAILS");
                textBox1.Text = "";
                clear1();
            }

            else MessageBox.Show("Enter Teacher Name", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string Query = ("Delete from  TEACHER_DETAILS where TEACHER_ID = '" + textBox1.Text.ToString() + "' ");
                General_query(Query);
                MessageBox.Show("Data Deleted ", " DELETE", MessageBoxButtons.OK);
                textBox1.Text = "";
                clear1();
                Gridview("SELECT * FROM TEACHER_DETAILS");
            }

            else MessageBox.Show("Enter Teacher Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear1();
            textBox6.Text = "";
            GV1.DataSource = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
                Gridview("SELECT * FROM TEACHER_DETAILS where TEACHER_NAME  like '" + textBox6.Text + "%'; ");

            else MessageBox.Show("Enter Teacher Name", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void TEACHER_DETAIL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet3.TEACHER_DETAILS' table. You can move, or remove it, as needed.
            this.tEACHER_DETAILSTableAdapter.Fill(this.mydbDataSet3.TEACHER_DETAILS);

        }

        private void GV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dg = GV1.Rows[e.RowIndex];
                    textBox1.Text = dg.Cells[0].Value.ToString();
                    textBox2.Text = dg.Cells[1].Value.ToString();
                    cb1.Text = dg.Cells[2].Value.ToString();
                    textBox4.Text = dg.Cells[3].Value.ToString();
                    mask.Text = dg.Cells[4].Value.ToString();
                                   }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            main_form mn = new main_form();
            mn.Show();
            this.Close();
        }
    }
}
