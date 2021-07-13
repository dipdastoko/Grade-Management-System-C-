namespace GradeManagementSystem
{
    partial class FormTeacherRegistration
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
            this.btnTeacherRefresh = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTeacherSearchName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTeacherSearchId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpTeacherDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbTeacherSubject = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.txtTeacherPhone = new System.Windows.Forms.TextBox();
            this.btnTeacherSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeacherId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacherAddress = new System.Windows.Forms.TextBox();
            this.txtTeacherPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTeacherRegistration = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackToAdmin);
            this.panel1.Controls.Add(this.btnTeacherRefresh);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 286);
            this.panel1.TabIndex = 0;
            // 
            // btnTeacherRefresh
            // 
            this.btnTeacherRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTeacherRefresh.Location = new System.Drawing.Point(278, 175);
            this.btnTeacherRefresh.Name = "btnTeacherRefresh";
            this.btnTeacherRefresh.Size = new System.Drawing.Size(200, 111);
            this.btnTeacherRefresh.TabIndex = 21;
            this.btnTeacherRefresh.Text = "Refresh";
            this.btnTeacherRefresh.UseVisualStyleBackColor = false;
            this.btnTeacherRefresh.Click += new System.EventHandler(this.btnTeacherRefresh_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtTeacherSearchName);
            this.panel5.Location = new System.Drawing.Point(278, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 78);
            this.panel5.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(24, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Search by Name";
            // 
            // txtTeacherSearchName
            // 
            this.txtTeacherSearchName.Location = new System.Drawing.Point(39, 39);
            this.txtTeacherSearchName.Name = "txtTeacherSearchName";
            this.txtTeacherSearchName.Size = new System.Drawing.Size(120, 20);
            this.txtTeacherSearchName.TabIndex = 0;
            this.txtTeacherSearchName.TextChanged += new System.EventHandler(this.txtTeacherSearchName_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtTeacherSearchId);
            this.panel4.Location = new System.Drawing.Point(278, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 81);
            this.panel4.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Maroon;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(42, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search by ID";
            // 
            // txtTeacherSearchId
            // 
            this.txtTeacherSearchId.Location = new System.Drawing.Point(39, 39);
            this.txtTeacherSearchId.Name = "txtTeacherSearchId";
            this.txtTeacherSearchId.Size = new System.Drawing.Size(120, 20);
            this.txtTeacherSearchId.TabIndex = 0;
            this.txtTeacherSearchId.TextChanged += new System.EventHandler(this.txtTeacherSearchId_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.dtpTeacherDOB);
            this.panel3.Controls.Add(this.cmbTeacherSubject);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnTeacherDelete);
            this.panel3.Controls.Add(this.txtTeacherPhone);
            this.panel3.Controls.Add(this.btnTeacherSave);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTeacherId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTeacherName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTeacherAddress);
            this.panel3.Controls.Add(this.txtTeacherPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 286);
            this.panel3.TabIndex = 18;
            // 
            // dtpTeacherDOB
            // 
            this.dtpTeacherDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpTeacherDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTeacherDOB.Location = new System.Drawing.Point(85, 195);
            this.dtpTeacherDOB.Name = "dtpTeacherDOB";
            this.dtpTeacherDOB.Size = new System.Drawing.Size(145, 20);
            this.dtpTeacherDOB.TabIndex = 19;
            // 
            // cmbTeacherSubject
            // 
            this.cmbTeacherSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherSubject.FormattingEnabled = true;
            this.cmbTeacherSubject.Items.AddRange(new object[] {
            "Bangla",
            "English",
            "Science"});
            this.cmbTeacherSubject.Location = new System.Drawing.Point(85, 143);
            this.cmbTeacherSubject.Name = "cmbTeacherSubject";
            this.cmbTeacherSubject.Size = new System.Drawing.Size(145, 21);
            this.cmbTeacherSubject.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(46, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Teacher Registration";
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.BackColor = System.Drawing.Color.Red;
            this.btnTeacherDelete.Location = new System.Drawing.Point(155, 254);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(75, 29);
            this.btnTeacherDelete.TabIndex = 17;
            this.btnTeacherDelete.Text = "Delete";
            this.btnTeacherDelete.UseVisualStyleBackColor = false;
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // txtTeacherPhone
            // 
            this.txtTeacherPhone.Location = new System.Drawing.Point(85, 117);
            this.txtTeacherPhone.Name = "txtTeacherPhone";
            this.txtTeacherPhone.Size = new System.Drawing.Size(145, 20);
            this.txtTeacherPhone.TabIndex = 7;
            // 
            // btnTeacherSave
            // 
            this.btnTeacherSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTeacherSave.Location = new System.Drawing.Point(155, 221);
            this.btnTeacherSave.Name = "btnTeacherSave";
            this.btnTeacherSave.Size = new System.Drawing.Size(75, 29);
            this.btnTeacherSave.TabIndex = 16;
            this.btnTeacherSave.Text = "Save";
            this.btnTeacherSave.UseVisualStyleBackColor = false;
            this.btnTeacherSave.Click += new System.EventHandler(this.btnTeacherSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TeacherId";
            // 
            // txtTeacherId
            // 
            this.txtTeacherId.Location = new System.Drawing.Point(85, 39);
            this.txtTeacherId.Name = "txtTeacherId";
            this.txtTeacherId.ReadOnly = true;
            this.txtTeacherId.Size = new System.Drawing.Size(145, 20);
            this.txtTeacherId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DOB";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(85, 65);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(145, 20);
            this.txtTeacherName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // txtTeacherAddress
            // 
            this.txtTeacherAddress.Location = new System.Drawing.Point(85, 91);
            this.txtTeacherAddress.Name = "txtTeacherAddress";
            this.txtTeacherAddress.Size = new System.Drawing.Size(145, 20);
            this.txtTeacherAddress.TabIndex = 5;
            // 
            // txtTeacherPassword
            // 
            this.txtTeacherPassword.Location = new System.Drawing.Point(85, 169);
            this.txtTeacherPassword.Name = "txtTeacherPassword";
            this.txtTeacherPassword.Size = new System.Drawing.Size(145, 20);
            this.txtTeacherPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Subject";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTeacherRegistration);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 234);
            this.panel2.TabIndex = 1;
            // 
            // dgvTeacherRegistration
            // 
            this.dgvTeacherRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.Names,
            this.Address,
            this.Phone,
            this.Subject,
            this.Password,
            this.Role,
            this.DateOfBirth});
            this.dgvTeacherRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacherRegistration.Location = new System.Drawing.Point(0, 0);
            this.dgvTeacherRegistration.Name = "dgvTeacherRegistration";
            this.dgvTeacherRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherRegistration.Size = new System.Drawing.Size(602, 234);
            this.dgvTeacherRegistration.TabIndex = 0;
            this.dgvTeacherRegistration.DoubleClick += new System.EventHandler(this.dgvTeacherRegistration_DoubleClick);
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "Id";
            this.TeacherId.Name = "TeacherId";
            // 
            // Names
            // 
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "Name";
            this.Names.Name = "Names";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DOB";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // btnBackToAdmin
            // 
            this.btnBackToAdmin.Location = new System.Drawing.Point(484, 257);
            this.btnBackToAdmin.Name = "btnBackToAdmin";
            this.btnBackToAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAdmin.TabIndex = 22;
            this.btnBackToAdmin.Text = "Back";
            this.btnBackToAdmin.UseVisualStyleBackColor = true;
            this.btnBackToAdmin.Click += new System.EventHandler(this.btnBackToAdmin_Click);
            // 
            // FormTeacherRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTeacherRegistration";
            this.Text = "FormTeacherRegistration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTeacherRegistration_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherRegistration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTeacherRegistration;
        private System.Windows.Forms.TextBox txtTeacherId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTeacherPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTeacherPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeacherAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTeacherSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTeacherSearchId;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTeacherSearchName;
        private System.Windows.Forms.Button btnTeacherRefresh;
        private System.Windows.Forms.ComboBox cmbTeacherSubject;
        private System.Windows.Forms.DateTimePicker dtpTeacherDOB;
        private System.Windows.Forms.Button btnBackToAdmin;
    }
}