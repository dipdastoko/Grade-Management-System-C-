using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagementSystem
{
    public partial class FormTeacher : Form
    {
        private DataAccess Da { get; set; }
        internal string tid;
        public FormTeacher()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

        }
        public FormTeacher(string holdId)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.tid = holdId;
        }

        public void PopulateGridView()
        {
            try
            {
                string sql = @"select * from StudentTable where BanglaTeacher='" + tid +
                               "' or EnglishTeacher='" + tid +
                               "'or ScienceTeacher='" + tid + "';";

                DataSet ds = this.Da.ExecuteQuery(sql);
                this.dgvTeacerForm.AutoGenerateColumns = false;
                this.dgvTeacerForm.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {

                MessageBox.Show("Error" + exc.Message);
            }

        }


        private void FormTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvTeacerForm_DoubleClick(object sender, EventArgs e)
        {
            this.txtResultId.Text = this.dgvTeacerForm.CurrentRow.Cells["StudentId"].Value.ToString();
        }

        private void btnResultGo_Click(object sender, EventArgs e)
        {
            var id = this.txtResultId.Text;
            FormResultUpdate fru = new FormResultUpdate(this.txtResultId.Text, tid, this);
            fru.Visible = true;
            this.Visible = false;
        }

        private void txtStudentIdSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "Select * from StudentTable where StudentId like '%" + this.txtStudentIdSearch.Text + "%';";
            
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvTeacerForm.DataSource = ds.Tables[0];

        }

        private void txtSearchStudentName_TextChanged(object sender, EventArgs e)
        {
            var sql = "Select * from StudentTable where Names like '%" + this.txtSearchStudentName.Text + "%';";

            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvTeacerForm.DataSource = ds.Tables[0];
            
        }

    }
}
