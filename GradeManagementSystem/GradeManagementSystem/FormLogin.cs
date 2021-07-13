using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagementSystem
{
    public partial class FormLogin : Form
    {
        public DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {  
              var sql = "select * from LoginTable where UserId='" + this.txtUserID.Text + "' and Password='" + this.txtPassword.Text + "';";



               // DataAccess da = new DataAccess();
                DataSet ds = Da.ExecuteQuery(sql);



                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (ds.Tables[0].Rows[0]["Role"].ToString() == "student")
                    {
                        FormStudent s1 = new FormStudent(this.txtUserID.Text);
                        s1.Visible = true;
                        this.Visible = false;



                    }
                    else if (ds.Tables[0].Rows[0]["Role"].ToString() == "admin")
                    {
                        FormAdmin a1 = new FormAdmin();
                        a1.Visible = true;
                        this.Visible = false;
                    }
                    else if (ds.Tables[0].Rows[0]["Role"].ToString() == "teacher")
                    {
                        FormTeacher a1 = new FormTeacher(this.txtUserID.Text);
                        a1.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
