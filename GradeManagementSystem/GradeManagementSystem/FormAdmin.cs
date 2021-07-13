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
    public partial class FormAdmin : Form
    {
        private DataAccess Da { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void PopulateGridView(string sql = "select * from StudentTable;")
        {
            try
            {
                DataSet ds = Da.ExecuteQuery(sql);

                this.dgvStudentRegistration.AutoGenerateColumns = false;
                this.dgvStudentRegistration.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error"+exc.Message);
            }

        }
//Student Insertion
        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ( String.IsNullOrEmpty(this.txtStudentName.Text) ||
                    String.IsNullOrEmpty(this.txtStudentAddress.Text) || String.IsNullOrEmpty(this.txtStudentPhone.Text) ||
                    String.IsNullOrEmpty(this.dtpStudentDOB.Text) || String.IsNullOrEmpty(this.txtStudentPassword.Text)
                     || String.IsNullOrEmpty(this.cmbStudentClass.Text)||String.IsNullOrEmpty(this.cmbStudentSection.Text)||
                     String.IsNullOrEmpty(this.txtStudentRoll.Text)|| String.IsNullOrEmpty(this.txtBanglaTeacher.Text) ||
                     String.IsNullOrEmpty(this.txtEnglishTeacher.Text)|| String.IsNullOrEmpty(this.txtScienceTeacher.Text))
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }
//update
                var id = this.cmbStudentClass.Text+"-"+ this.cmbStudentSection.Text +"-"+ this.txtStudentRoll.Text;

                var qr = "select * from StudentTable where StudentId='"+id+"';";
                DataSet ds = this.Da.ExecuteQuery(qr);

            if (ds.Tables[0].Rows.Count == 1)
            {
                string sql = "update StudentTable set Names='"+this.txtStudentName.Text+"',Address='"+this.txtStudentAddress.Text+
                                                       "',Phone='"+this.txtStudentPhone.Text +"',DateOfBirth='"+this.dtpStudentDOB.Text+
                                                       "',Password='"+this.txtStudentPassword.Text+"',Role='student',Class='"+
                                                          this.cmbStudentClass.Text+"',Section='"+this.cmbStudentSection.Text +
                                                          "',Roll='"+this.txtStudentRoll.Text +"',BanglaTeacher='"+this.txtBanglaTeacher.Text +
                                                          "',EnglishTeacher='"+this.txtEnglishTeacher.Text +"',ScienceTeacher='"+this.txtScienceTeacher.Text +
                                                          "' where StudentId = '"+id+"';";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                    MessageBox.Show("Data Update Failed");
                
         //LoginTable update
                var sql1 = "update LoginTable set UserId='" +id+ "',Password='" + this.txtStudentPassword.Text +
                    "',Role='student' where UserId = '" +id+ "';";
                int count1 = this.Da.ExecuteDML(sql1);
                if (count1 == 1)
                {
                    MessageBox.Show("LoginTable Updated");
                }
                else
                    MessageBox.Show("LoginTable Update Failed");

          //Result Table update
                var sql2 = "update ResultTable set ResultTable.StudentId='" + id + "' where StudentId = '" + id + "';";
                int count2 = this.Da.ExecuteDML(sql2);
                if (count2 == 1)
                {
                    MessageBox.Show("ResultTable Updated");
                }
                else
                    MessageBox.Show("ResultTable Update Failed");
            
            }
//isertion
                else{
                
                var sql = @"insert into StudentTable  values('"+id+"','"+this.txtStudentName.Text+
                                                             "','"+this.txtStudentAddress.Text+"','"+txtStudentPhone.Text+
                                                              "','"+this.dtpStudentDOB.Text+"','"+this.txtStudentPassword.Text+
                                                              "','student','" + this.cmbStudentClass.Text +
                                                              "','" + this.cmbStudentSection.Text + "','" + this.txtStudentRoll.Text +
                                                              "','" + this.txtBanglaTeacher.Text + "','" + this.txtEnglishTeacher.Text +
                                                              "','" + this.txtScienceTeacher.Text + "');";

                
                
                int count = this.Da.ExecuteDML(sql);
                if (count == 1)
                {
                    MessageBox.Show("Insertion Complete");
                }
                else
                {
                    MessageBox.Show("Insertion Incomplete");
                }
      //Login Table insertion
                
                var sql1 = "insert into LoginTable Values('" +id+ "','" + this.txtStudentPassword.Text +
                                                            "','student');";
                int count1 = this.Da.ExecuteDML(sql1);
                if (count == 1)
                {
                    MessageBox.Show(id.ToString());
                    MessageBox.Show("LoginTable Data Inserted");
                }
                else
                    MessageBox.Show("LoginTable Data Insertion Failed");
        //ResultTable  insertion
                var sql2 = "insert into ResultTable (ResultTable.StudentId) values('"+id+"');";
                

                
                int count2 = this.Da.ExecuteDML(sql2);
                if (count2 == 1)
                {
                    MessageBox.Show(id.ToString());
                    MessageBox.Show("ResultTable Updated");
                }
                else
                    MessageBox.Show("ResultTable Update Failed");
                
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.PopulateGridView();
        }

        

        

//Student Delete
        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            var id = this.dgvStudentRegistration.CurrentRow.Cells["StudentId"].Value.ToString();
            var sql = "delete from StudentTable where StudentId =  '" + id + "';";

            var count = this.Da.ExecuteDML(sql);
            if (count == 1)
            {
                MessageBox.Show("Deletion Complete");
            }
            else
            {
                MessageBox.Show("Deletion Incomplete");
            }

//Login Table
            var sql1 = "delete from LoginTable where UserId =  '" + id + "';";

            var count1 = this.Da.ExecuteDML(sql1);
            if (count1 == 1)
            {
                MessageBox.Show("LoginTable Deletion Complete");
            }
            else
            {
                MessageBox.Show("LoginTable Deletion Incomplete");
            }
//Result Table
            var sql2 = "delete from ResultTable where StudentId =  '" + id + "';";

            var count2 = this.Da.ExecuteDML(sql2);
            if (count2 == 1)
            {
                MessageBox.Show("ResultTable Deletion Complete");
            }
            else
            {
                MessageBox.Show("ResultTable Deletion Incomplete");
            }
            this.PopulateGridView();
        }

        

//double click
        private void dgvStudentRegistration_DoubleClick(object sender, EventArgs e)
        {
            this.txtStudentName.Text = this.dgvStudentRegistration.CurrentRow.Cells["Names"].Value.ToString();
            this.txtStudentAddress.Text = this.dgvStudentRegistration.CurrentRow.Cells["Address"].Value.ToString();
            this.txtStudentPhone.Text = this.dgvStudentRegistration.CurrentRow.Cells["Phone"].Value.ToString();
            this.dtpStudentDOB.Text = this.dgvStudentRegistration.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            this.txtStudentPassword.Text = this.dgvStudentRegistration.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbStudentClass.Text = this.dgvStudentRegistration.CurrentRow.Cells["Class"].Value.ToString();
            this.cmbStudentSection.Text = this.dgvStudentRegistration.CurrentRow.Cells["Section"].Value.ToString();
            this.txtStudentRoll.Text = this.dgvStudentRegistration.CurrentRow.Cells["Roll"].Value.ToString();
            this.txtBanglaTeacher.Text = this.dgvStudentRegistration.CurrentRow.Cells["BanglaTeacher"].Value.ToString();
            this.txtEnglishTeacher.Text = this.dgvStudentRegistration.CurrentRow.Cells["EnglishTeacher"].Value.ToString();
            this.txtScienceTeacher.Text = this.dgvStudentRegistration.CurrentRow.Cells["ScienceTeacher"].Value.ToString();

        }

        private void btnTeacherRegistration_Click(object sender, EventArgs e)
        {
            FormTeacherRegistration ftr = new FormTeacherRegistration(this);
            ftr.Visible = true;
            this.Visible = false;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            var sql = "Select * from StudentTable where Roll=" + this.txtSearchRoll.Text +
                                                  " and Class=" + this.cmbSearchClass.Text +
                                              " and Section='" + this.cmbSearchSection.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtStudentAutoName_TextChanged(object sender, EventArgs e)
        {
            var sql = "Select * from StudentTable where Names like '%" + this.txtStudentAutoName.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnStudentRefresh_Click(object sender, EventArgs e)
        {
            this.txtStudentName.Text = "";
            this.txtStudentAddress.Text = "";
            this.txtStudentPhone.Text = "";
            this.dtpStudentDOB.Text = "";
            this.txtStudentPassword.Text = "";
            this.cmbStudentClass.SelectedIndex = -1;
            this.cmbStudentSection.SelectedIndex = -1;
            this.txtStudentRoll.Text = "";
            this.txtBanglaTeacher.Text = "";
            this.txtEnglishTeacher.Text = "";
            this.txtScienceTeacher.Text = "";
            this.txtSearchRoll.Text="";
            this.cmbSearchClass.SelectedIndex=-1;
            this.cmbSearchSection.SelectedIndex = -1;
            this.txtStudentAutoName.Text = "";


            this.PopulateGridView();
            
        }

}

    }

