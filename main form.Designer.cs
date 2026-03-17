namespace MARKSHEET_MANAGEMENT_SYSTEM_
{
    partial class main_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Log_Out = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MARKSHEET = new System.Windows.Forms.Button();
            this.ADDTEACHER = new System.Windows.Forms.Button();
            this.ADDSUBJECT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ASSIGNINGSUBJECT = new System.Windows.Forms.Button();
            this.STUDENTDETAILS = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Log_Out);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 119);
            this.panel1.TabIndex = 4;
            // 
            // Log_Out
            // 
            this.Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log_Out.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Out.Location = new System.Drawing.Point(1132, 68);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(108, 30);
            this.Log_Out.TabIndex = 6;
            this.Log_Out.Text = "Log Out";
            this.Log_Out.UseVisualStyleBackColor = true;
            this.Log_Out.Click += new System.EventHandler(this.Log_Out_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(445, 28);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(437, 48);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "SHAHEED BENAZIR BHUTTO UNIVERSITY\r\n                 SHAHEED BENAZIRABAD";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 454);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.MARKSHEET);
            this.groupBox1.Controls.Add(this.ADDTEACHER);
            this.groupBox1.Controls.Add(this.ADDSUBJECT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ASSIGNINGSUBJECT);
            this.groupBox1.Controls.Add(this.STUDENTDETAILS);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 356);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // MARKSHEET
            // 
            this.MARKSHEET.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MARKSHEET.Location = new System.Drawing.Point(6, 268);
            this.MARKSHEET.Name = "MARKSHEET";
            this.MARKSHEET.Size = new System.Drawing.Size(189, 41);
            this.MARKSHEET.TabIndex = 5;
            this.MARKSHEET.Text = "MARKSHEET";
            this.MARKSHEET.UseVisualStyleBackColor = true;
            this.MARKSHEET.Click += new System.EventHandler(this.MARKSHEET_Click);
            // 
            // ADDTEACHER
            // 
            this.ADDTEACHER.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDTEACHER.Location = new System.Drawing.Point(6, 113);
            this.ADDTEACHER.Name = "ADDTEACHER";
            this.ADDTEACHER.Size = new System.Drawing.Size(189, 31);
            this.ADDTEACHER.TabIndex = 2;
            this.ADDTEACHER.Text = "ADD TEACHERS";
            this.ADDTEACHER.UseVisualStyleBackColor = true;
            this.ADDTEACHER.Click += new System.EventHandler(this.ADDTEACHER_Click);
            // 
            // ADDSUBJECT
            // 
            this.ADDSUBJECT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDSUBJECT.Location = new System.Drawing.Point(6, 215);
            this.ADDSUBJECT.Name = "ADDSUBJECT";
            this.ADDSUBJECT.Size = new System.Drawing.Size(189, 34);
            this.ADDSUBJECT.TabIndex = 4;
            this.ADDSUBJECT.Text = "ADD SUBJECT";
            this.ADDSUBJECT.UseVisualStyleBackColor = true;
            this.ADDSUBJECT.Click += new System.EventHandler(this.ADDSUBJECT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "DASH BOARD";
            // 
            // ASSIGNINGSUBJECT
            // 
            this.ASSIGNINGSUBJECT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASSIGNINGSUBJECT.Location = new System.Drawing.Point(6, 163);
            this.ASSIGNINGSUBJECT.Name = "ASSIGNINGSUBJECT";
            this.ASSIGNINGSUBJECT.Size = new System.Drawing.Size(189, 33);
            this.ASSIGNINGSUBJECT.TabIndex = 3;
            this.ASSIGNINGSUBJECT.Text = "ASSIGNING  SUBJECT ";
            this.ASSIGNINGSUBJECT.UseVisualStyleBackColor = true;
            this.ASSIGNINGSUBJECT.Click += new System.EventHandler(this.ASSIGNINGSUBJECT_Click);
            // 
            // STUDENTDETAILS
            // 
            this.STUDENTDETAILS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUDENTDETAILS.Location = new System.Drawing.Point(6, 64);
            this.STUDENTDETAILS.Name = "STUDENTDETAILS";
            this.STUDENTDETAILS.Size = new System.Drawing.Size(189, 34);
            this.STUDENTDETAILS.TabIndex = 1;
            this.STUDENTDETAILS.Text = "STUDENT DETAILS";
            this.STUDENTDETAILS.UseVisualStyleBackColor = true;
            this.STUDENTDETAILS.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MARKSHEET_MANAGEMENT_SYSTEM_.Properties.Resources.Gemini_Generated_Image_i5poimi5poimi5po__1_;
            this.pictureBox2.Location = new System.Drawing.Point(232, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1059, 386);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MARKSHEET_MANAGEMENT_SYSTEM_.Properties.Resources.logo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1261, 455);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_form_FormClosed);
            this.Load += new System.EventHandler(this.main_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button STUDENTDETAILS;
        private System.Windows.Forms.Button MARKSHEET;
        private System.Windows.Forms.Button ADDSUBJECT;
        private System.Windows.Forms.Button ASSIGNINGSUBJECT;
        private System.Windows.Forms.Button ADDTEACHER;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Log_Out;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}