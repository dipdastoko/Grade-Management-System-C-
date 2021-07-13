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
    public partial class FormResult : Form
    {
        private DataAccess Da { get; set; }
        private string idfr;
        public FormResult()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormResult(string holdId)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.idfr = holdId;
            
        }

        private void FormResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                string sql = "select * from ResultTable where StudentId='"+idfr+"';";
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.lblStudentIdFR.Text = ds.Tables[0].Rows[0]["StudentId"].ToString();
                this.lblScience.Text = ds.Tables[0].Rows[0]["Science"].ToString();
                this.lblMath.Text = ds.Tables[0].Rows[0]["Bangla"].ToString();
                this.lblEnglish.Text = ds.Tables[0].Rows[0]["English"].ToString();
                this.lblTotal.Text = ds.Tables[0].Rows[0]["Total"].ToString();
                this.lblPercentage.Text = ds.Tables[0].Rows[0]["Percentage"].ToString();
                this.lblGrade.Text = ds.Tables[0].Rows[0]["Grade"].ToString();
                

            }
            catch (Exception exe)
            {
                MessageBox.Show("Error" + exe.Message);
            }
        }
    }
}
