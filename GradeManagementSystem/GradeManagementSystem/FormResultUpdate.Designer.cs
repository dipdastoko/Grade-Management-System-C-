namespace GradeManagementSystem
{
    partial class FormResultUpdate
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
            this.dgvResultUpdate = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotlal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnglishResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScienceResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBanglaResult = new System.Windows.Forms.TextBox();
            this.btnUpdateResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdResult = new System.Windows.Forms.TextBox();
            this.btnBackToTeacher = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultUpdate)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvResultUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 199);
            this.panel1.TabIndex = 0;
            // 
            // dgvResultUpdate
            // 
            this.dgvResultUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultUpdate.Location = new System.Drawing.Point(0, 0);
            this.dgvResultUpdate.Name = "dgvResultUpdate";
            this.dgvResultUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultUpdate.Size = new System.Drawing.Size(601, 199);
            this.dgvResultUpdate.TabIndex = 0;
            this.dgvResultUpdate.DoubleClick += new System.EventHandler(this.dgvResultUpdate_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 254);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBackToTeacher);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtGrade);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtPercent);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTotlal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtEnglishResult);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtScienceResult);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBanglaResult);
            this.panel3.Controls.Add(this.btnUpdateResult);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtIdResult);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 248);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(88, 165);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Percentage";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(88, 139);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // txtTotlal
            // 
            this.txtTotlal.Location = new System.Drawing.Point(88, 113);
            this.txtTotlal.Name = "txtTotlal";
            this.txtTotlal.ReadOnly = true;
            this.txtTotlal.Size = new System.Drawing.Size(100, 20);
            this.txtTotlal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Science";
            // 
            // txtEnglishResult
            // 
            this.txtEnglishResult.Location = new System.Drawing.Point(88, 87);
            this.txtEnglishResult.Name = "txtEnglishResult";
            this.txtEnglishResult.Size = new System.Drawing.Size(100, 20);
            this.txtEnglishResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "English";
            // 
            // txtScienceResult
            // 
            this.txtScienceResult.Location = new System.Drawing.Point(88, 61);
            this.txtScienceResult.Name = "txtScienceResult";
            this.txtScienceResult.Size = new System.Drawing.Size(100, 20);
            this.txtScienceResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bangla";
            // 
            // txtBanglaResult
            // 
            this.txtBanglaResult.Location = new System.Drawing.Point(88, 35);
            this.txtBanglaResult.Name = "txtBanglaResult";
            this.txtBanglaResult.Size = new System.Drawing.Size(100, 20);
            this.txtBanglaResult.TabIndex = 3;
            // 
            // btnUpdateResult
            // 
            this.btnUpdateResult.Location = new System.Drawing.Point(113, 191);
            this.btnUpdateResult.Name = "btnUpdateResult";
            this.btnUpdateResult.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateResult.TabIndex = 2;
            this.btnUpdateResult.Text = "Save";
            this.btnUpdateResult.UseVisualStyleBackColor = true;
            this.btnUpdateResult.Click += new System.EventHandler(this.btnUpdateResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txtIdResult
            // 
            this.txtIdResult.Location = new System.Drawing.Point(88, 9);
            this.txtIdResult.Name = "txtIdResult";
            this.txtIdResult.ReadOnly = true;
            this.txtIdResult.Size = new System.Drawing.Size(100, 20);
            this.txtIdResult.TabIndex = 0;
            // 
            // btnBackToTeacher
            // 
            this.btnBackToTeacher.Location = new System.Drawing.Point(194, 191);
            this.btnBackToTeacher.Name = "btnBackToTeacher";
            this.btnBackToTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnBackToTeacher.TabIndex = 15;
            this.btnBackToTeacher.Text = "Back";
            this.btnBackToTeacher.UseVisualStyleBackColor = true;
            this.btnBackToTeacher.Click += new System.EventHandler(this.btnBackToTeacher_Click);
            // 
            // FormResultUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormResultUpdate";
            this.Text = "FormResultUpdate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormResultUpdate_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultUpdate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotlal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnglishResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScienceResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBanglaResult;
        private System.Windows.Forms.DataGridView dgvResultUpdate;
        private System.Windows.Forms.Button btnBackToTeacher;
    }
}