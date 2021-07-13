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
    public partial class FormTeacherRegistration : Form
    {
        private FormAdmin Fa = new FormAdmin();
        private DataAccess Da{ get; set; }
        public FormTeacherRegistration()
        {
            InitializeComponent();
            this.Da=new DataAccess();
            this.AutoId();
            this.PopulateGridView();
        }
        public FormTeacherRegistration(FormAdmin fa)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoId();
            this.PopulateGridView();
            this.Fa = fa;
        }

        private void FormTeacherRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTeacherSave_Click(object sender, EventArgs e)
        {
             try
            {
                if ( String.IsNullOrEmpty(this.txtTeacherId.Text) ||String.IsNullOrEmpty(this.txtTeacherName.Text) ||
                    String.IsNullOrEmpty(this.txtTeacherAddress.Text) || String.IsNullOrEmpty(this.txtTeacherPhone.Text) ||
                    String.IsNullOrEmpty(this.cmbTeacherSubject.Text) || String.IsNullOrEmpty(this.txtTeacherPassword.Text)
                     ||String.IsNullOrEmpty(this.dtpTeacherDOB.Text))
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                //var id = this.cmbStudentClass.Text+"-"+ this.cmbStudentSection.Text +"-"+ this.txtStudentRoll.Text;

                var qr = "select * from TeacherTable where TeacherId='"+this.txtTeacherId.Text+"';";
                DataSet ds = this.Da.ExecuteQuery(qr);
//update
            if (ds.Tables[0].Rows.Count == 1)
            {
                string sql = "update TeacherTable set TeacherId='"+this.txtTeacherId.Text+"', Names='"+this.txtTeacherName.Text+
                                                "',Address='"+this.txtTeacherAddress.Text+"',Phone='"+this.txtTeacherPhone.Text +
                                                 "',Subject='"+this.cmbTeacherSubject.Text+"',Password='"+this.txtTeacherPassword.Text+
                                                 "',Role='teacher',DateOfBirth='"+this.dtpTeacherDOB.Text+
                                                 "' where TeacherId = '"+this.txtTeacherId.Text+"';";

                int count = this.Da.ExecuteDML(sql);

                if (count == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                    MessageBox.Show("Data Update Failed");

                var sql1 = "update LoginTable set UserId='" + this.txtTeacherId.Text + "',Password='"+this.txtTeacherPassword.Text+
                    "',Role='teacher' where UserId = '" + this.txtTeacherId.Text + "';";
                int count1 = this.Da.ExecuteDML(sql1);
                if (count == 1)
                {
                    MessageBox.Show("LoginTable Updated");
                }
                else
                    MessageBox.Show("LoginTable Update Failed");
            
            }
//isertion
                else{
                
                var sql = @"insert into TeacherTable  values('"+this.txtTeacherId.Text+"','"+this.txtTeacherName.Text+
                                                             "','"+this.txtTeacherAddress.Text+"','"+this.txtTeacherPhone.Text+
                                                              "','"+this.cmbTeacherSubject.Text+"','"+this.txtTeacherPassword.Text+
                                                              "','teacher','" + this.dtpTeacherDOB.Text +"');";

                
                
                int count = this.Da.ExecuteDML(sql);
                if (count == 1)
                {
                    MessageBox.Show("Insertion Complete");
                }
                else
                {
                    MessageBox.Show("Insertion Incomplete");
                }
                var sql1 = "insert into LoginTable Values('" + this.txtTeacherId.Text + "','" + this.txtTeacherPassword.Text +
                                                             "','teacher');";
                int count1 = this.Da.ExecuteDML(sql1);
                if (count == 1)
                {
                    MessageBox.Show("LoginTable Data Inserted");
                }
                else
                    MessageBox.Show("LoginTable Data Insertion Failed");
                
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             this.Clear();
            this.PopulateGridView();
        }
         public void PopulateGridView(string sql = "select * from TeacherTable;")
        {
            try
            {
                DataSet ds = Da.ExecuteQuery(sql);

                this.dgvTeacherRegistration.AutoGenerateColumns = false;
                this.dgvTeacherRegistration.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error"+exc.Message);
            }

        }

         private void dgvTeacherRegistration_DoubleClick(object sender, EventArgs e)
         {
             this.txtTeacherId.Text = this.dgvTeacherRegistration.CurrentRow.Cells["TeacherId"].Value.ToString();
             this.txtTeacherName.Text = this.dgvTeacherRegistration.CurrentRow.Cells["Names"].Value.ToString();
             this.txtTeacherAddress.Text = this.dgvTeacherRegistration.CurrentRow.Cells["Address"].Value.ToString();
             this.txtTeacherPhone.Text = this.dgvTeacherRegistration.CurrentRow.Cells["Phone"].Value.ToString();
             this.cmbTeacherSubject.Text = this.dgvTeacherRegistration.CurrentRow.Cells["Subject"].Value.ToString();
             this.txtTeacherPassword.Text = this.dgvTeacherRegistration.CurrentRow.Cells["Password"].Value.ToString();
             this.dtpTeacherDOB.Text = this.dgvTeacherRegistration.CurrentRow.Cells["DateOfBirth"].Value.ToString();
         }

         private void btnTeacherDelete_Click(object sender, EventArgs e)
         {
             var id = this.dgvTeacherRegistration.CurrentRow.Cells["TeacherId"].Value.ToString();
             var sql = "delete from TeacherTable where TeacherId =  '" + id + "';";

             var count = this.Da.ExecuteDML(sql);
             if (count == 1)
             {
                 MessageBox.Show("Deletion Complete");
             }
             else
             {
                 MessageBox.Show("Deletion Incomplete");
             }

        //LoginTable 
             var sql1 = "delete from LoginTable where UserId =  '" + id + "';";

             var count1 = this.Da.ExecuteDML(sql1);
             if (count1 == 1)
             {
                 MessageBox.Show("Login Table Deletion Complete");
             }
             else
             {
                 MessageBox.Show("Login Table Deletion Incomplete");
             }
             this.Clear();
             this.PopulateGridView();
         }

         private void txtTeacherSearchId_TextChanged(object sender, EventArgs e)
         {
             var sql = "Select * from TeacherTable where TeacherId like '%" + this.txtTeacherSearchId.Text + "%';";
             this.PopulateGridView(sql);
         }

         private void txtTeacherSearchName_TextChanged(object sender, EventArgs e)
         {
             var sql = "Select * from TeacherTable where Names like '%" + this.txtTeacherSearchName.Text + "%';";
             this.PopulateGridView(sql);
         }

         private void btnTeacherRefresh_Click(object sender, EventArgs e)
         {
             this.Clear();
             this.PopulateGridView();
         }

         private void Clear() 
         {
             this.AutoId();//this.txtTeacherId.Text = "";
             this.txtTeacherName.Text = "";
             this.txtTeacherAddress.Text = "";
             this.txtTeacherPhone.Text = "";
             this.cmbTeacherSubject.SelectedIndex = -1;
             this.txtTeacherPassword.Text = "";
             this.dtpTeacherDOB.Text = "";
         }
         private void AutoId() 
         {
             var sql = "select TeacherId from TeacherTable order by TeacherId desc;";
             var ds = this.Da.ExecuteQuery(sql);
             string[] subString = (ds.Tables[0].Rows[0]["TeacherId"].ToString()).Split('-');
             int value = Convert.ToInt32(subString[1]);
             var newId = "t-" + (++value).ToString("d3");

             this.txtTeacherId.Text = newId;
         }

         private void btnBackToAdmin_Click(object sender, EventArgs e)
         {
             this.Fa.Visible = true;
             this.Visible = false;
         }

     
        }
    }

