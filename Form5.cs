using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
    public partial class Marksheet : Form
    {
        public Marksheet()
        {
            InitializeComponent();
        }
        public static SqlConnection Con = new SqlConnection("Data Source=DESKTOP-H5DN19J\\SQLEXPRESS;Initial Catalog=newmydbs;Integrated Security=True;");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Marksheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.STUDENTS' table. You can move, or remove it, as needed.
            this.sTUDENTSTableAdapter.Fill(this.mydbDataSet.STUDENTS);
            groupBox6.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = " select STUDENT_NAME, FATHER_NAME from STUDENTS where Roll_number = '" + comboBox1.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       textBox3.Text = Convert.ToString(reader.GetValue(0));
                        textBox2.Text = Convert.ToString(reader.GetValue(1));
                    }
                    reader.Close();
                    Con.Close();
                }
             //   else MessageBox.Show("No data in their ", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                Con.Close();
            }
        }

        private void get_subject_Click(object sender, EventArgs e)
        {
            generate.Visible = false;
            if (comboBox2.Text.ToString() == "")  MessageBox.Show("Select Semester","ERORR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                groupBox6.Visible = true;
                try
                {
                    Con.Open();

                    string query = "select * from subjects   where semester = '" + comboBox2.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int a = 1;
                        while (true)
                        {
                            if ((Convert.ToString(reader.GetValue(a))) == "") break;
                            a++;
                        }
                        sb1.Text = Convert.ToString(reader.GetValue(1));
                        sb2.Text = Convert.ToString(reader.GetValue(2));
                        sb3.Text = Convert.ToString(reader.GetValue(3));
                        sb4.Text = Convert.ToString(reader.GetValue(4));
                        sb5.Text = Convert.ToString(reader.GetValue(5));
                        if (a >= 7)
                        {
                            sb6.Text = Convert.ToString(reader.GetValue(6));
                            sb6.Visible = true; textBox32.Visible = true; textBox35.Visible = true; textBox27.Visible = true; textBox24.Visible = true; textBox14.Visible = false; textBox42.Visible = false;
                        }
                        else { sb6.Visible = false; textBox32.Visible = false; textBox35.Visible = false; textBox27.Visible = false; textBox24.Visible = false; textBox14.Visible = false; textBox42.Visible = false; }

                        if (a >= 8)
                        {
                            sb7.Text = Convert.ToString(reader.GetValue(7));
                            sb7.Visible = true; textBox33.Visible = true; textBox34.Visible = true; textBox26.Visible = true; textBox25.Visible = true; textBox19.Visible = false; textBox41.Visible = false;
                        }
                        else { sb7.Visible = false; textBox33.Visible = false; textBox34.Visible = false; textBox26.Visible = false; textBox25.Visible = false; textBox19.Visible = false; textBox41.Visible = false; }

                        reader.Close();
                        Con.Close();
                        clear3();
                    }
                    if (comboBox2.Text.ToString() == "8th")
                    {
                        textBox10.Visible = false; textBox36.Visible = false; textBox28.Visible = false; textBox23.Visible = false;
                    }
                    // else MessageBox.Show("No data in their ", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                    Con.Close();
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            main_form mn = new main_form();
            mn.Show();
            this.Close();
        }

        public void clear3()
        {
            maskedTextBox1.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox47.Text = "";
            maskedTextBox2.Text = "";
            textBox22.Text = "";
            textBox18.Text = "";
            textBox44.Text = "";
            textBox30.Text = "";
            textBox21.Text = "";
            textBox17.Text = "";
            textBox45.Text = "";
            textBox31.Text = "";
            textBox20.Text = "";
            textBox16.Text = "";
            textBox46.Text = "";
            textBox28.Text = "";
            textBox23.Text = "";
            textBox15.Text = "";
            textBox43.Text = "";
            textBox27.Text = "";
            textBox24.Text = "";
            textBox14.Text = "";
            textBox42.Text = "";
            textBox26.Text = "";
            textBox25.Text = "";
            textBox19.Text = "";
            textBox41.Text = "";
            textBox26.Text = "0"; maskedTextBox1.Text = "0"; maskedTextBox2.Text = "0"; textBox30.Text = "0"; textBox31.Text = "0"; textBox28.Text = "0"; textBox27.Text = "0";
            label12.Text = "Percentage ";
            label18.Text = "Total Obtain Marks";
            label1.Text = "Result";

        }
        private void clear1_Click(object sender, EventArgs e)
        {

            clear3();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(maskedTextBox1.Text) >= 90) textBox8.Text = "A";
                else if (Convert.ToInt32(maskedTextBox1.Text) < 90 && Convert.ToInt32(maskedTextBox1.Text) >= 80) textBox8.Text = "B";
                else if (Convert.ToInt32(maskedTextBox1.Text) < 80 && Convert.ToInt32(maskedTextBox1.Text) >= 70) textBox8.Text = "C";
                else if (Convert.ToInt32(maskedTextBox1.Text) < 70 && Convert.ToInt32(maskedTextBox1.Text) >= 60) textBox8.Text = "D";
                else textBox8.Text = "F";
            }
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox29_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(maskedTextBox2.Text) >= 90) textBox22.Text = "A";
            else if (Convert.ToInt32(maskedTextBox2.Text) < 90 && Convert.ToInt32(maskedTextBox2.Text) >= 80) textBox22.Text = "B";
            else if (Convert.ToInt32(maskedTextBox2.Text) < 80 && Convert.ToInt32(maskedTextBox2.Text) >= 70) textBox22.Text = "C";
            else if (Convert.ToInt32(maskedTextBox2.Text) < 70 && Convert.ToInt32(maskedTextBox2.Text) >= 60) textBox22.Text = "D";
            else textBox22.Text = "F";
        }
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
}

        private void textBox30_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox30.Text) >= 90) textBox21.Text = "A";
            else if (Convert.ToInt32(textBox30.Text) < 90 && Convert.ToInt32(textBox30.Text) >= 80) textBox21.Text = "B";
            else if (Convert.ToInt32(textBox30.Text) < 80 && Convert.ToInt32(textBox30.Text) >= 70) textBox21.Text = "C";
            else if (Convert.ToInt32(textBox30.Text) < 70 && Convert.ToInt32(textBox30.Text) >= 60) textBox21.Text = "D";
            else textBox21.Text = "F";
}
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
        }

        private void textBox31_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox31.Text) >= 90) textBox20.Text = "A";
            else if (Convert.ToInt32(textBox31.Text) < 90 && Convert.ToInt32(textBox31.Text) >= 80) textBox20.Text = "B";
            else if (Convert.ToInt32(textBox31.Text) < 80 && Convert.ToInt32(textBox31.Text) >= 70) textBox20.Text = "C";
            else if (Convert.ToInt32(textBox31.Text) < 70 && Convert.ToInt32(textBox31.Text) >= 60) textBox20.Text = "D";
            else textBox20.Text = "F";
}
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
        }

        private void textBox28_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox28.Text) >= 90) textBox23.Text = "A";
            else if (Convert.ToInt32(textBox28.Text) < 90 && Convert.ToInt32(textBox28.Text) >= 80) textBox23.Text = "B";
            else if (Convert.ToInt32(textBox28.Text) < 80 && Convert.ToInt32(textBox28.Text) >= 70) textBox23.Text = "C";
            else if (Convert.ToInt32(textBox28.Text) < 70 && Convert.ToInt32(textBox28.Text) >= 60) textBox23.Text = "D";
            else textBox23.Text = "F";
}
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
        }

        private void textBox27_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox27.Text) >= 90) textBox24.Text = "A";
            else if (Convert.ToInt32(textBox27.Text) < 90 && Convert.ToInt32(textBox27.Text) >= 80) textBox24.Text = "B";
            else if (Convert.ToInt32(textBox27.Text) < 80 && Convert.ToInt32(textBox27.Text) >= 70) textBox24.Text = "C";
            else if (Convert.ToInt32(textBox27.Text) < 70 && Convert.ToInt32(textBox27.Text) >= 60) textBox24.Text = "D";
            else textBox24.Text = "F";
}
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
        }

        private void textBox26_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox26.Text) >= 90) textBox25.Text = "A";
            else if (Convert.ToInt32(textBox26.Text) < 90 && Convert.ToInt32(textBox26.Text) >= 80) textBox25.Text = "B";
            else if (Convert.ToInt32(textBox26.Text) < 80 && Convert.ToInt32(textBox26.Text) >= 70) textBox25.Text = "C";
            else if (Convert.ToInt32(textBox26.Text) < 70 && Convert.ToInt32(textBox26.Text) >= 60) textBox25.Text = "D";
            else textBox25.Text = "F";
}
            catch (Exception ex) { MessageBox.Show("Enter Marks"); }
        }

        private void Result_Click(object sender, EventArgs e) {
            //{8,22,21,20,23,24,25
            generate.Visible = true;

            if (textBox8.Text == "F" || textBox8.Text == "" || textBox22.Text == "F" || textBox22.Text == "" || textBox21.Text == "F" || textBox21.Text == "" || textBox20.Text == "F" || textBox20.Text == "" || textBox23.Text == "F" || textBox24.Text == "F" || textBox25.Text == "F" ) label1.Text = "Result : FAIL";
            else label1.Text = "Result :PASS";
            // 6 29 30  31 28 27 26
            int sum = Convert.ToInt32(maskedTextBox1.Text) + Convert.ToInt32(maskedTextBox2.Text) + Convert.ToInt32(textBox30.Text) + Convert.ToInt32(textBox31.Text) + Convert.ToInt32(textBox28.Text) + Convert.ToInt32(textBox27.Text) + Convert.ToInt32(textBox26.Text);
            
            label18.Text = "Total Obtain Marks :" +  Convert.ToString (sum);
            int total = 0;
            // 9 13 12  11 10 32 33 

            if (comboBox2.Text.ToString() == "1st") { total = 700;       }
            else if (comboBox2.Text.ToString() == "2nd") total = 500;
            if (comboBox2.Text.ToString() == "3rd") total = 500;
            else if (comboBox2.Text.ToString() == "4th") total = 500;
            if (comboBox2.Text.ToString() == "5th") total = 600;
            else if (comboBox2.Text.ToString() == "6th") total = 600;
            if (comboBox2.Text.ToString() == "7th") total = 600;
            else if (comboBox2.Text.ToString() == "8th") total = 400;
         else { }
           
            double sum1 = Convert.ToDouble(sum);
            double total1 = Convert.ToDouble(total);
           // MessageBox.Show("" + sum1 + "" + total1);
           double percent = (sum1/ total1) * 100;

            label12.Text = "Percentage :" + percent.ToString("F2");
           
        }

        public void nothing()
        {
            
        }
        private void generate_Click(object sender, EventArgs e)
        {
            
//
//
//
//
//
//
//
            Print pn = new Print();
            if (comboBox2.Text.ToString() == "8th")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, "", "", "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, "", "", textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, "", "", "", label1.Text, label18.Text, label12.Text, dt1.Text,"","","", "","", "");
            else if (comboBox2.Text.ToString() == "2nd")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, "", "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, "", textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, "", "", label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text,"", "",textBox36.Text, "", "");
            else if (comboBox2.Text.ToString() == "3rd")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, "", "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, "", textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, "", "", label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text, "", "", textBox36.Text, "", "");
            else if (comboBox2.Text.ToString() == "4th")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, "", "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, "", textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, "", "", label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text, "", "", textBox36.Text, "", "");
            else if (comboBox2.Text.ToString() == "5th")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, sb6.Text, "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, textBox27.Text, textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, textBox24.Text, "", label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text, textBox32.Text, "", textBox36.Text, textBox35.Text, "");
            else if (comboBox2.Text.ToString() == "6th")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, sb6.Text, "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, textBox27.Text, textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, textBox24.Text, "", label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text, textBox32.Text, "", textBox36.Text, textBox35.Text, "");
            else if (comboBox2.Text.ToString() == "7th")
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, sb6.Text, "", "", maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, textBox27.Text, textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, textBox24.Text, "", label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text, textBox32.Text, "", textBox36.Text, textBox35.Text, "");
            else
                pn.SetUserName(comboBox1.Text, textBox3.Text, textBox2.Text, comboBox2.Text, sb1.Text, sb2.Text, sb3.Text, sb4.Text, sb5.Text, sb6.Text, sb7.Text, textBox26.Text, maskedTextBox1.Text, maskedTextBox2.Text, textBox30.Text, textBox31.Text, textBox28.Text, textBox27.Text, textBox8.Text, textBox22.Text, textBox21.Text, textBox20.Text, textBox23.Text, textBox24.Text, textBox25.Text, label1.Text, label18.Text, label12.Text, dt1.Text, textBox10.Text, textBox32.Text, textBox33.Text, textBox36.Text, textBox35.Text, textBox34.Text);


            pn.Show();
        

    }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";comboBox1.Text = ""; comboBox2.Text = "";
        }
    }
    }

