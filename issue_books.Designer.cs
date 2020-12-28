namespace MiniProject2._0
{
    partial class issue_books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_enrollment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_studentname = new System.Windows.Forms.TextBox();
            this.txt_studentdept = new System.Windows.Forms.TextBox();
            this.txt_studentsem = new System.Windows.Forms.TextBox();
            this.txt_studentcontact = new System.Windows.Forms.TextBox();
            this.txt_studentemail = new System.Windows.Forms.TextBox();
            this.txt_booksname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_booksname);
            this.panel1.Controls.Add(this.txt_studentemail);
            this.panel1.Controls.Add(this.txt_studentcontact);
            this.panel1.Controls.Add(this.txt_studentsem);
            this.panel1.Controls.Add(this.txt_studentdept);
            this.panel1.Controls.Add(this.txt_studentname);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_enrollment);
            this.panel1.Location = new System.Drawing.Point(48, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 492);
            this.panel1.TabIndex = 0;
            // 
            // txt_enrollment
            // 
            this.txt_enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enrollment.Location = new System.Drawing.Point(41, 52);
            this.txt_enrollment.Name = "txt_enrollment";
            this.txt_enrollment.Size = new System.Drawing.Size(208, 22);
            this.txt_enrollment.TabIndex = 0;
            this.txt_enrollment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_studentname
            // 
            this.txt_studentname.Location = new System.Drawing.Point(541, 36);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.Size = new System.Drawing.Size(208, 20);
            this.txt_studentname.TabIndex = 2;
            // 
            // txt_studentdept
            // 
            this.txt_studentdept.Location = new System.Drawing.Point(541, 83);
            this.txt_studentdept.Name = "txt_studentdept";
            this.txt_studentdept.Size = new System.Drawing.Size(208, 20);
            this.txt_studentdept.TabIndex = 3;
            // 
            // txt_studentsem
            // 
            this.txt_studentsem.Location = new System.Drawing.Point(541, 135);
            this.txt_studentsem.Name = "txt_studentsem";
            this.txt_studentsem.Size = new System.Drawing.Size(208, 20);
            this.txt_studentsem.TabIndex = 4;
            // 
            // txt_studentcontact
            // 
            this.txt_studentcontact.Location = new System.Drawing.Point(541, 188);
            this.txt_studentcontact.Name = "txt_studentcontact";
            this.txt_studentcontact.Size = new System.Drawing.Size(208, 20);
            this.txt_studentcontact.TabIndex = 5;
            // 
            // txt_studentemail
            // 
            this.txt_studentemail.Location = new System.Drawing.Point(541, 239);
            this.txt_studentemail.Name = "txt_studentemail";
            this.txt_studentemail.Size = new System.Drawing.Size(208, 20);
            this.txt_studentemail.TabIndex = 6;
            // 
            // txt_booksname
            // 
            this.txt_booksname.Location = new System.Drawing.Point(541, 339);
            this.txt_booksname.Name = "txt_booksname";
            this.txt_booksname.Size = new System.Drawing.Size(208, 20);
            this.txt_booksname.TabIndex = 7;
            this.txt_booksname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_booksname_KeyDown);
            this.txt_booksname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_booksname_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Department :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student Sem :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Contact :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Book Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter Enrollment Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Issue Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(541, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(201, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Issue Books";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(541, 359);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 95);
            this.listBox1.TabIndex = 18;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 554);
            this.Controls.Add(this.panel1);
            this.Name = "issue_books";
            this.Text = "issue_books";
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_booksname;
        private System.Windows.Forms.TextBox txt_studentemail;
        private System.Windows.Forms.TextBox txt_studentcontact;
        private System.Windows.Forms.TextBox txt_studentsem;
        private System.Windows.Forms.TextBox txt_studentdept;
        private System.Windows.Forms.TextBox txt_studentname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_enrollment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}