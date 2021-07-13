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
    public partial class FormStudent : Form
    {
        public DataAccess Da { get; set; }
        internal string id;
        
        public FormStudent()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormStudent(string holdId)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.id = holdId;
        }


        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void result()
        {
            try
            {
                string sql = "select * from StudentTable where StudentId ='"+id+"';";
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.lblStudentId.Text = ds.Tables[0].Rows[0]["StudentId"].ToString();
                this.lblName.Text = ds.Tables[0].Rows[0]["Names"].ToString();
                this.lblAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                this.lblPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                this.lblDob.Text = ds.Tables[0].Rows[0]["DateOfBirth"].ToString();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error" + exe.Message);
            }

        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            result();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            FormResult fr = new FormResult(this.id);
            fr.Visible = true;
            this.Visible = false;
            
        }
    }
}
