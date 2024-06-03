using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginRegister
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //DataTable dt = new DataTable();
        //int x;
       


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {
           /* dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Date of birth", typeof(DateTime));
            dt.Columns.Add("E-mail", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dataGridViewUser.DataSource = dt;*/
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           /* DateTime d = dateTimePickerDOB.Value.Date;
            dt.Rows.Add(txtFirstname.Text, txtLast.Text, txtUsername.Text,cmbGender.Text,dateTimePickerDOB.MinDate.ToString(),txtEmail.Text, txtAddress.Text);
            dataGridViewUser.DataSource = dt;
            txtFirstname.Clear();
            txtLast.Clear();
            txtUsername.Clear();
            cmbGender.Items.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtFirstname.Focus();*/

            
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*x = e.RowIndex;
            DataGridViewRow R = dataGridViewUser.Rows[x];
            */
        }
    }
}
