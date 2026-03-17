namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.GV1 = new System.Windows.Forms.DataGridView();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newmydbsDataSet7 = new MARKSHEET_MANAGEMENT_SYSTEM_.mydbDataSet7();
            this.search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.subjectsTableAdapter = new MARKSHEET_MANAGEMENT_SYSTEM_.mydbDataSet7TableAdapters.subjectsTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newmydbsDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(413, 26);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(437, 48);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "SHAHEED BENAZIR BHUTTO UNIVERSITY\r\n                 SHAHEED BENAZIRABAD";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(540, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 591);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "COURSE ID";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(267, 497);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 42);
            this.button5.TabIndex = 21;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(725, 386);
            this.dataGridView1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(539, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 42);
            this.button3.TabIndex = 19;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(199, 12);
            this.textBox5.MaxLength = 10;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 26);
            this.textBox5.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MARKSHEET_MANAGEMENT_SYSTEM_.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(1241, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MARKSHEET_MANAGEMENT_SYSTEM_.Properties.Resources.logo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 582);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD SUBJECT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(180, 466);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(276, 26);
            this.textBox10.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 37;
            this.label14.Text = "Subject9";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(180, 376);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(276, 26);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(180, 423);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(276, 26);
            this.textBox9.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 35;
            this.label12.Text = "Subject8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Subject7";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(180, 280);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(276, 26);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(180, 327);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(276, 26);
            this.textBox7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Subject6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Subject5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 235);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 26);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Subject4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Subject3";
            // 
            // cb2
            // 
            this.cb2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.cb2.Location = new System.Drawing.Point(180, 40);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(276, 27);
            this.cb2.TabIndex = 0;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "SEMESTER";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Subject2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Subject1";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete.Location = new System.Drawing.Point(394, 534);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 42);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Update.Location = new System.Drawing.Point(205, 534);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(116, 42);
            this.Update.TabIndex = 11;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add.Location = new System.Drawing.Point(10, 534);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 42);
            this.Add.TabIndex = 10;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cb3
            // 
            this.cb3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.cb3.Location = new System.Drawing.Point(125, 37);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(276, 27);
            this.cb3.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Home);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.clear);
            this.groupBox3.Controls.Add(this.GV1);
            this.groupBox3.Controls.Add(this.search);
            this.groupBox3.Controls.Add(this.cb3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(549, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 599);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Home.Location = new System.Drawing.Point(567, 35);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(120, 29);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Semester";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Location = new System.Drawing.Point(363, 517);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 42);
            this.clear.TabIndex = 16;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // GV1
            // 
            this.GV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV1.AutoGenerateColumns = false;
            this.GV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semesterDataGridViewTextBoxColumn,
            this.subject1DataGridViewTextBoxColumn,
            this.subject2DataGridViewTextBoxColumn,
            this.subject3DataGridViewTextBoxColumn,
            this.subject4DataGridViewTextBoxColumn,
            this.subject5DataGridViewTextBoxColumn,
            this.subject6DataGridViewTextBoxColumn,
            this.subject7DataGridViewTextBoxColumn,
            this.subject8DataGridViewTextBoxColumn,
            this.subject9DataGridViewTextBoxColumn});
            this.GV1.DataSource = this.subjectsBindingSource;
            this.GV1.Location = new System.Drawing.Point(0, 74);
            this.GV1.Name = "GV1";
            this.GV1.RowHeadersWidth = 62;
            this.GV1.RowTemplate.Height = 28;
            this.GV1.Size = new System.Drawing.Size(708, 279);
            this.GV1.TabIndex = 20;
            this.GV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV1_CellClick);
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 95;
            // 
            // subject1DataGridViewTextBoxColumn
            // 
            this.subject1DataGridViewTextBoxColumn.DataPropertyName = "subject1";
            this.subject1DataGridViewTextBoxColumn.HeaderText = "subject1";
            this.subject1DataGridViewTextBoxColumn.Name = "subject1DataGridViewTextBoxColumn";
            this.subject1DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject2DataGridViewTextBoxColumn
            // 
            this.subject2DataGridViewTextBoxColumn.DataPropertyName = "subject2";
            this.subject2DataGridViewTextBoxColumn.HeaderText = "subject2";
            this.subject2DataGridViewTextBoxColumn.Name = "subject2DataGridViewTextBoxColumn";
            this.subject2DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject3DataGridViewTextBoxColumn
            // 
            this.subject3DataGridViewTextBoxColumn.DataPropertyName = "subject3";
            this.subject3DataGridViewTextBoxColumn.HeaderText = "subject3";
            this.subject3DataGridViewTextBoxColumn.Name = "subject3DataGridViewTextBoxColumn";
            this.subject3DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject4DataGridViewTextBoxColumn
            // 
            this.subject4DataGridViewTextBoxColumn.DataPropertyName = "subject4";
            this.subject4DataGridViewTextBoxColumn.HeaderText = "subject4";
            this.subject4DataGridViewTextBoxColumn.Name = "subject4DataGridViewTextBoxColumn";
            this.subject4DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject5DataGridViewTextBoxColumn
            // 
            this.subject5DataGridViewTextBoxColumn.DataPropertyName = "subject5";
            this.subject5DataGridViewTextBoxColumn.HeaderText = "subject5";
            this.subject5DataGridViewTextBoxColumn.Name = "subject5DataGridViewTextBoxColumn";
            this.subject5DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject6DataGridViewTextBoxColumn
            // 
            this.subject6DataGridViewTextBoxColumn.DataPropertyName = "subject6";
            this.subject6DataGridViewTextBoxColumn.HeaderText = "subject6";
            this.subject6DataGridViewTextBoxColumn.Name = "subject6DataGridViewTextBoxColumn";
            this.subject6DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject7DataGridViewTextBoxColumn
            // 
            this.subject7DataGridViewTextBoxColumn.DataPropertyName = "subject7";
            this.subject7DataGridViewTextBoxColumn.HeaderText = "subject7";
            this.subject7DataGridViewTextBoxColumn.Name = "subject7DataGridViewTextBoxColumn";
            this.subject7DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject8DataGridViewTextBoxColumn
            // 
            this.subject8DataGridViewTextBoxColumn.DataPropertyName = "subject8";
            this.subject8DataGridViewTextBoxColumn.HeaderText = "subject8";
            this.subject8DataGridViewTextBoxColumn.Name = "subject8DataGridViewTextBoxColumn";
            this.subject8DataGridViewTextBoxColumn.Width = 89;
            // 
            // subject9DataGridViewTextBoxColumn
            // 
            this.subject9DataGridViewTextBoxColumn.DataPropertyName = "subject9";
            this.subject9DataGridViewTextBoxColumn.HeaderText = "subject9";
            this.subject9DataGridViewTextBoxColumn.Name = "subject9DataGridViewTextBoxColumn";
            this.subject9DataGridViewTextBoxColumn.Width = 89;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.newmydbsDataSet7;
            // 
            // mydbDataSet7
            // 
            this.newmydbsDataSet7.DataSetName = "mydbDataSet7";
            this.newmydbsDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.search.Location = new System.Drawing.Point(434, 36);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 29);
            this.search.TabIndex = 14;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 9;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 695);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASSING SUBJECT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newmydbsDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridView GV1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private mydbDataSet7 newmydbsDataSet7;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private mydbDataSet7TableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject9DataGridViewTextBoxColumn;
    }
}