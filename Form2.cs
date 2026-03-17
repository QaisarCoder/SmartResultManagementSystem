using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    public partial class subject2teacher : Form
    {
        public subject2teacher()
        {
            InitializeComponent();
        }
        public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-H5DN19J\\SQLEXPRESS;Initial Catalog=newmydbs;Integrated Security=True;");
        public void Gridview(string query)
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
            cb2.Text = "";    cb3.Text = "";  comboBox1.Text = "";
           

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            
            if (cb2.Text != "" && cb3.Text !="" && comboBox1.Text !="" )
            {
                string Query = ("INSERT INTO SUBJECT_ASSIGN VALUES ('" + cb2.Text.ToString() + "','" + cb3.Text.ToString() + "','" + comboBox1.Text.ToString() + "')");
                General_query(Query);
                MessageBox.Show("Data Saved ", " SAVE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM  SUBJECT_ASSIGN");
                clear1();
                
                

            }

            else MessageBox.Show("Fill All Fields ", " ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            
            if (cb2.Text != "" )
            {
                string Query = ("Update SUBJECT_ASSIGN set  SEMESTER = '" + cb2.Text.ToString() + "', SUBJECT = '" + cb3.Text.ToString() + "',TEACHER_NAME = '" + comboBox1.Text.ToString() + "'  where SUBJECT = '" + cb3.Text.ToString() + "'");
                General_query(Query);
                MessageBox.Show("Data updated ", " UPDATE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM  SUBJECT_ASSIGN");
                clear1();
            }

            else MessageBox.Show("Fill All Fields", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
          
            if (comboBox1.Text != "")
            {
                string Query = ("Delete from  SUBJECT_ASSIGN where SUBJECT = '" + cb3.Text.ToString() + "' ");
                General_query(Query);
                MessageBox.Show("Data Deleted ", " DELETE", MessageBoxButtons.OK);
                Gridview("SELECT * FROM  SUBJECT_ASSIGN");
                clear1();
            }

            else MessageBox.Show("Entre Teacher Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                Gridview("SELECT * FROM  SUBJECT_ASSIGN WHERE SUBJECT like  '" +textBox5.Text +"%' OR TEACHER_NAME = '"+ textBox5.Text+"';  ");
                
            else MessageBox.Show("Fill All Fields", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            GV1.DataSource = "";
            clear1();
            textBox5.Text = "";
        }

        private void GV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dg = GV1.Rows[e.RowIndex];
                    cb2.Text = dg.Cells[0].Value.ToString();
                    cb3.Text = dg.Cells[1].Value.ToString();
                    comboBox1.Text = dg.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void Teachers_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet6.SUBJECT_ASSIGN' table. You can move, or remove it, as needed.
            this.sUBJECT_ASSIGNTableAdapter1.Fill(this.newmydbsDataSet6.SUBJECT_ASSIGN);
            // TODO: This line of code loads data into the 'mydbDataSet5.TEACHER_DETAILS' table. You can move, or remove it, as needed.
            this.tEACHER_DETAILSTableAdapter1.Fill(this.mydbDataSet5.TEACHER_DETAILS);
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                cb3.Items.Clear();
                string query = "select * from subjects   where semester = '" + cb2.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int a = 1;
                    while (true)
                    {
                        if ((Convert.ToString(reader.GetValue(a))) == "") break;
                        cb3.Items.Add(Convert.ToString(reader.GetValue(a)));
                        a++;
                    }

                    reader.Close();
                    Con.Close();
                }
                else MessageBox.Show("No data in their ", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                Con.Close();
            }
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
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

