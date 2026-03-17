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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-H5DN19J\\SQLEXPRESS;Initial Catalog=newmydbs;Integrated Security=True;");

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
            cb2.Text = "";  textBox1.Text = ""; textBox2.Text = "";  textBox3.Text = "";  textBox4.Text = ""; textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = "";
            textBox9.Text = ""; textBox10.Text = ""; 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cb3.Text != "")
                Gridview("SELECT * FROM SUBJECTS where SEMESTER  = '" + cb3.Text + "'; ");

            else MessageBox.Show("Enter Semester", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            main_form mn = new main_form();
            mn.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (cb2.Text != "")
            {
                string Query = ("INSERT INTO SUBJECTS VALUES ('" + cb2.Text.ToString() + "','" + textBox1.Text.ToString() + "','"  + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','"  + textBox4.Text.ToString() + "','" + textBox6.Text.ToString() + "','"  + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "','"  + textBox9.Text.ToString() + "','" + textBox10.Text.ToString() + "')");
                General_query(Query);
                MessageBox.Show("Data Saved ", " SAVE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM SUBJECTS");
                clear1();

            }

            else MessageBox.Show("Fill All Fields", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (cb2.Text != "")
            {
                string Query = ("Update Subjects SET  SEMESTER  = '" + cb2.Text.ToString() + "', SUBJECT1 = '" + textBox1.Text.ToString() + "', SUBJECT2 = '" + textBox2.Text.ToString() + "', SUBJECT3 = '" + textBox3.Text.ToString() + "', SUBJECT4 = '" + textBox4.Text.ToString() + "', SUBJECT5 = '" + textBox6.Text.ToString() + "', SUBJECT6 = '" + textBox7.Text.ToString() + "', SUBJECT7 = '" + textBox8.Text.ToString() + "', SUBJECT8 = '" + textBox9.Text.ToString() + "', SUBJECT9 = '" + textBox10.Text.ToString() + "'  WHERE SEMESTER  = '" + cb2.Text.ToString() + "'");
                General_query(Query);
                MessageBox.Show(" Data updated ", " UPDATE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM SUBJECTS");
                textBox1.Text = "";
                clear1();
            }

            else MessageBox.Show("Enter Semester", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (cb2.Text != "")
            {
                string Query = ("Delete from  SUBJECTS where SEMESTER  = '" + cb2.Text.ToString() + "' ");
                General_query(Query);
                MessageBox.Show("Data Deleted ", " DELETE", MessageBoxButtons.OK);
                textBox1.Text = "";
                clear1();
                Gridview("SELECT * FROM SUBJECTS");
            }

            else MessageBox.Show("Enter Semester", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear1();
            cb3.Text = "";
            GV1.DataSource = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet7.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.newmydbsDataSet7.subjects);

        }

        private void GV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dg = GV1.Rows[e.RowIndex];
                    cb2.Text = dg.Cells[0].Value.ToString();
                    textBox1.Text = dg.Cells[1].Value.ToString();
                    textBox2.Text = dg.Cells[2].Value.ToString();               
                    textBox3.Text = dg.Cells[3].Value.ToString();
                    textBox4.Text = dg.Cells[4].Value.ToString();
                    textBox6.Text = dg.Cells[5].Value.ToString();
                    textBox7.Text = dg.Cells[6].Value.ToString();
                    textBox8.Text = dg.Cells[7].Value.ToString();
                    textBox9.Text = dg.Cells[8].Value.ToString();
                    textBox10.Text = dg.Cells[9].Value.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
