
namespace GradeManagementSystem
{
    partial class FormAdmin
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
            this.btnStudentRefresh = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtStudentAutoName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.cmbSearchSection = new System.Windows.Forms.ComboBox();
            this.cmbSearchClass = new System.Windows.Forms.ComboBox();
            this.txtSearchRoll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTeacherRegistration = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbStudentSection = new System.Windows.Forms.ComboBox();
            this.cmbStudentClass = new System.Windows.Forms.ComboBox();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.txtScienceTeacher = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnglishTeacher = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBanglaTeacher = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudentRoll = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.btnStudentSave = new System.Windows.Forms.Button();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStudentRegistration = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanglaTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScienceTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnStudentRefresh);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnTeacherRegistration);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 281);
            this.panel1.TabIndex = 0;
            // 
            // btnStudentRefresh
            // 
            this.btnStudentRefresh.Location = new System.Drawing.Point(733, 179);
            this.btnStudentRefresh.Name = "btnStudentRefresh";
            this.btnStudentRefresh.Size = new System.Drawing.Size(129, 96);
            this.btnStudentRefresh.TabIndex = 32;
            this.btnStudentRefresh.Text = "Refresh";
            this.btnStudentRefresh.UseVisualStyleBackColor = true;
            this.btnStudentRefresh.Click += new System.EventHandler(this.btnStudentRefresh_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtStudentAutoName);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(506, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 100);
            this.panel5.TabIndex = 18;
            // 
            // txtStudentAutoName
            // 
            this.txtStudentAutoName.Location = new System.Drawing.Point(28, 43);
            this.txtStudentAutoName.Name = "txtStudentAutoName";
            this.txtStudentAutoName.Size = new System.Drawing.Size(164, 20);
            this.txtStudentAutoName.TabIndex = 3;
            this.txtStudentAutoName.TextChanged += new System.EventHandler(this.txtStudentAutoName_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Maroon;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Yellow;
            this.label17.Location = new System.Drawing.Point(33, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "Search by Name";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSearchStudent);
            this.panel4.Controls.Add(this.cmbSearchSection);
            this.panel4.Controls.Add(this.cmbSearchClass);
            this.panel4.Controls.Add(this.txtSearchRoll);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(506, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 169);
            this.panel4.TabIndex = 17;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(143, 127);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 38;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // cmbSearchSection
            // 
            this.cmbSearchSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchSection.FormattingEnabled = true;
            this.cmbSearchSection.Items.AddRange(new object[] {
            "a",
            "b"});
            this.cmbSearchSection.Location = new System.Drawing.Point(73, 71);
            this.cmbSearchSection.Name = "cmbSearchSection";
            this.cmbSearchSection.Size = new System.Drawing.Size(145, 21);
            this.cmbSearchSection.TabIndex = 37;
            // 
            // cmbSearchClass
            // 
            this.cmbSearchClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchClass.FormattingEnabled = true;
            this.cmbSearchClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbSearchClass.Location = new System.Drawing.Point(73, 41);
            this.cmbSearchClass.Name = "cmbSearchClass";
            this.cmbSearchClass.Size = new System.Drawing.Size(145, 21);
            this.cmbSearchClass.TabIndex = 36;
            // 
            // txtSearchRoll
            // 
            this.txtSearchRoll.Location = new System.Drawing.Point(73, 101);
            this.txtSearchRoll.Name = "txtSearchRoll";
            this.txtSearchRoll.Size = new System.Drawing.Size(145, 20);
            this.txtSearchRoll.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Roll";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Section";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(33, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student Search";
            // 
            // btnTeacherRegistration
            // 
            this.btnTeacherRegistration.Location = new System.Drawing.Point(733, 3);
            this.btnTeacherRegistration.Name = "btnTeacherRegistration";
            this.btnTeacherRegistration.Size = new System.Drawing.Size(129, 171);
            this.btnTeacherRegistration.TabIndex = 16;
            this.btnTeacherRegistration.Text = "Teacher Registration";
            this.btnTeacherRegistration.UseVisualStyleBackColor = true;
            this.btnTeacherRegistration.Click += new System.EventHandler(this.btnTeacherRegistration_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbStudentSection);
            this.panel3.Controls.Add(this.cmbStudentClass);
            this.panel3.Controls.Add(this.btnStudentDelete);
            this.panel3.Controls.Add(this.txtScienceTeacher);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtEnglishTeacher);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtBanglaTeacher);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtStudentRoll);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dtpStudentDOB);
            this.panel3.Controls.Add(this.btnStudentSave);
            this.panel3.Controls.Add(this.txtStudentPassword);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtStudentPhone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtStudentAddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtStudentName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 272);
            this.panel3.TabIndex = 0;
            // 
            // cmbStudentSection
            // 
            this.cmbStudentSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentSection.FormattingEnabled = true;
            this.cmbStudentSection.Items.AddRange(new object[] {
            "a",
            "b"});
            this.cmbStudentSection.Location = new System.Drawing.Point(338, 71);
            this.cmbStudentSection.Name = "cmbStudentSection";
            this.cmbStudentSection.Size = new System.Drawing.Size(145, 21);
            this.cmbStudentSection.TabIndex = 31;
            // 
            // cmbStudentClass
            // 
            this.cmbStudentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentClass.FormattingEnabled = true;
            this.cmbStudentClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbStudentClass.Location = new System.Drawing.Point(338, 41);
            this.cmbStudentClass.Name = "cmbStudentClass";
            this.cmbStudentClass.Size = new System.Drawing.Size(145, 21);
            this.cmbStudentClass.TabIndex = 30;
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(408, 234);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 29;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // txtScienceTeacher
            // 
            this.txtScienceTeacher.Location = new System.Drawing.Point(338, 179);
            this.txtScienceTeacher.Name = "txtScienceTeacher";
            this.txtScienceTeacher.Size = new System.Drawing.Size(145, 20);
            this.txtScienceTeacher.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "ScienceTeacher";
            // 
            // txtEnglishTeacher
            // 
            this.txtEnglishTeacher.Location = new System.Drawing.Point(338, 153);
            this.txtEnglishTeacher.Name = "txtEnglishTeacher";
            this.txtEnglishTeacher.Size = new System.Drawing.Size(145, 20);
            this.txtEnglishTeacher.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "English Teacher";
            // 
            // txtBanglaTeacher
            // 
            this.txtBanglaTeacher.Location = new System.Drawing.Point(338, 127);
            this.txtBanglaTeacher.Name = "txtBanglaTeacher";
            this.txtBanglaTeacher.Size = new System.Drawing.Size(145, 20);
            this.txtBanglaTeacher.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "BanglaTeacher";
            // 
            // txtStudentRoll
            // 
            this.txtStudentRoll.Location = new System.Drawing.Point(338, 101);
            this.txtStudentRoll.Name = "txtStudentRoll";
            this.txtStudentRoll.Size = new System.Drawing.Size(145, 20);
            this.txtStudentRoll.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Roll";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Section";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Class";
            // 
            // dtpStudentDOB
            // 
            this.dtpStudentDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStudentDOB.Location = new System.Drawing.Point(77, 124);
            this.dtpStudentDOB.Name = "dtpStudentDOB";
            this.dtpStudentDOB.Size = new System.Drawing.Size(145, 20);
            this.dtpStudentDOB.TabIndex = 16;
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.Location = new System.Drawing.Point(408, 205);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(75, 23);
            this.btnStudentSave.TabIndex = 15;
            this.btnStudentSave.Text = "Save";
            this.btnStudentSave.UseVisualStyleBackColor = true;
            this.btnStudentSave.Click += new System.EventHandler(this.btnStudentSave_Click);
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.Location = new System.Drawing.Point(77, 150);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(145, 20);
            this.txtStudentPassword.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB";
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(77, 98);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(145, 20);
            this.txtStudentPhone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(77, 72);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(145, 20);
            this.txtStudentAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(77, 46);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(145, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(79, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.dgvStudentRegistration);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 235);
            this.panel2.TabIndex = 1;
            // 
            // dgvStudentRegistration
            // 
            this.dgvStudentRegistration.AllowUserToAddRows = false;
            this.dgvStudentRegistration.AllowUserToDeleteRows = false;
            this.dgvStudentRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.Names,
            this.Class,
            this.Section,
            this.Roll,
            this.BanglaTeacher,
            this.EnglishTeacher,
            this.ScienceTeacher,
            this.Address,
            this.Phone,
            this.DateOfBirth,
            this.Password,
            this.Role});
            this.dgvStudentRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentRegistration.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentRegistration.Name = "dgvStudentRegistration";
            this.dgvStudentRegistration.ReadOnly = true;
            this.dgvStudentRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentRegistration.Size = new System.Drawing.Size(865, 235);
            this.dgvStudentRegistration.TabIndex = 0;
            this.dgvStudentRegistration.DoubleClick += new System.EventHandler(this.dgvStudentRegistration_DoubleClick);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Roll
            // 
            this.Roll.DataPropertyName = "Roll";
            this.Roll.HeaderText = "Roll";
            this.Roll.Name = "Roll";
            this.Roll.ReadOnly = true;
            // 
            // BanglaTeacher
            // 
            this.BanglaTeacher.DataPropertyName = "BanglaTeacher";
            this.BanglaTeacher.HeaderText = "BanglaTeacher_Id";
            this.BanglaTeacher.Name = "BanglaTeacher";
            this.BanglaTeacher.ReadOnly = true;
            // 
            // EnglishTeacher
            // 
            this.EnglishTeacher.DataPropertyName = "EnglishTeacher";
            this.EnglishTeacher.HeaderText = "EnglishTeacher_Id";
            this.EnglishTeacher.Name = "EnglishTeacher";
            this.EnglishTeacher.ReadOnly = true;
            // 
            // ScienceTeacher
            // 
            this.ScienceTeacher.DataPropertyName = "ScienceTeacher";
            this.ScienceTeacher.HeaderText = "ScienceTeacher_Id";
            this.ScienceTeacher.Name = "ScienceTeacher";
            this.ScienceTeacher.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DOB";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentRegistration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStudentRegistration;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStudentSave;
        private System.Windows.Forms.DateTimePicker dtpStudentDOB;
        private System.Windows.Forms.TextBox txtBanglaTeacher;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentRoll;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtScienceTeacher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnglishTeacher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanglaTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScienceTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.ComboBox cmbStudentSection;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.Button btnTeacherRegistration;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.ComboBox cmbSearchSection;
        private System.Windows.Forms.ComboBox cmbSearchClass;
        private System.Windows.Forms.TextBox txtSearchRoll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtStudentAutoName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStudentRefresh;
    }
}