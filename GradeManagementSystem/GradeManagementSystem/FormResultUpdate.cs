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
    
    public partial class FormResultUpdate : Form
    {
        private FormTeacher T1 = new FormTeacher();
        private DataAccess Da { get; set; }
        private string id;
        private string tid;
        public FormResultUpdate()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.CheckRole();
            
            
        }
        public FormResultUpdate(string holdId,string holdTid,FormTeacher t1)
        {
            
            InitializeComponent();
            this.Da = new DataAccess();
            this.id = holdId;
            this.tid = holdTid;
            this.PopulateGridView();
            this.CheckRole();
            this.T1 = t1;
        }
        public void PopulateGridView()
        {
            try
            {
                string sql = @"select * from ResultTable where StudentId='"+this.id+"';";

                DataSet ds = this.Da.ExecuteQuery(sql);
                //this.dgvResultUpdate.AutoGenerateColumns = false;
                this.dgvResultUpdate.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {

                MessageBox.Show("Error" + exc.Message);
            }

        }

        private void FormResultUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvResultUpdate_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdResult.Text = dgvResultUpdate.CurrentRow.Cells["StudentId"].Value.ToString();
            this.txtBanglaResult.Text = dgvResultUpdate.CurrentRow.Cells["Bangla"].Value.ToString();
            this.txtEnglishResult.Text = dgvResultUpdate.CurrentRow.Cells["English"].Value.ToString();
            this.txtScienceResult.Text = dgvResultUpdate.CurrentRow.Cells["Science"].Value.ToString();
            this.txtTotlal.Text = dgvResultUpdate.CurrentRow.Cells["Total"].Value.ToString();
            this.txtPercent.Text = dgvResultUpdate.CurrentRow.Cells["Percentage"].Value.ToString();
            this.txtGrade.Text = dgvResultUpdate.CurrentRow.Cells["Grade"].Value.ToString();
        }

        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            this.Grade();
            var sql2 = "update ResultTable set Bangla='"+this.txtBanglaResult.Text+"',Science='"+this.txtScienceResult.Text+
                                                         "', English='" + this.txtEnglishResult.Text + "',Total='" + this.txtTotlal.Text +
                                                         "',Grade='" + this.txtGrade.Text + "',Percentage='" + this.txtPercent.Text +
                                                             "' where StudentId = '" + id + "';";
            int count2 = this.Da.ExecuteDML(sql2);
            if (count2 == 1)
            {
                MessageBox.Show("ResultTable Updated");
            }
            else
                MessageBox.Show("ResultTable Update Failed");
            this.PopulateGridView();
            
        }
        private void CheckRole() 
        {
            var sql = "Select * from TeacherTable where TeacherId='"+this.tid+"'";
            var dt = Da.ExecuteQueryTable(sql);
            if (dt.Rows[0]["Subject"].ToString().Equals("Bangla")) 
            {
                this.txtEnglishResult.ReadOnly = true;
                this.txtScienceResult.ReadOnly = true;
            }
            else if (dt.Rows[0]["Subject"].ToString().Equals("Science")) 
            {
                this.txtBanglaResult.ReadOnly = true;
                this.txtEnglishResult.ReadOnly = true;
            }
            else if (dt.Rows[0]["Subject"].ToString().Equals("English"))
            {
                this.txtBanglaResult.ReadOnly = true;
                this.txtScienceResult.ReadOnly = true;
            }

        }
        private void Grade() 
        {
            if (this.txtBanglaResult.Text.Equals("")) 
            {
                this.txtBanglaResult.Text = "0";
            }
            if (this.txtScienceResult.Text.Equals("")) 
            {
                this.txtScienceResult.Text = "0";
            }
            if (this.txtEnglishResult.Text.Equals("")) 
            {
                this.txtEnglishResult.Text = "0";
            }

            int bangla, science, english, total,percent;
            bangla = Convert.ToInt32(this.txtBanglaResult.Text);
            english = Convert.ToInt32(this.txtEnglishResult.Text);
            science = Convert.ToInt32(this.txtScienceResult.Text);

            total = bangla + english + science;
            
            
            percent = (total * 100)/300;
            this.txtPercent.Text = percent.ToString() + "%";

            this.txtTotlal.Text = total.ToString();

            string grade;
            if (total >= 240) 
            {
                grade = "A+";
                this.txtGrade.Text = grade;
            }
            else if(total<240 && total>=180)
            {
                grade = "B";
                this.txtGrade.Text = grade;
            }
            else if (total < 180 && total >= 120)
            {
                grade = "C";
                this.txtGrade.Text = grade;
            }
            else if (total < 120 && total >= 90)
            {
                grade = "D";
                this.txtGrade.Text = grade;
            }
            else if (total < 90)
            {
                grade = "F";
                this.txtGrade.Text = grade;
            }

            
            
            
            
            

        }

        private void btnBackToTeacher_Click(object sender, EventArgs e)
        {
            T1.Visible = true;
            this.Visible = false;
        }
    }
}
