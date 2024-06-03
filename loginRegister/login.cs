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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //connecting to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if(txtUser.Text == "" || txtPass.Text == "")
            {
                lblMessage.Text = "This field can not be empty!";
                
            }*/
            // validate to deny empty fields
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(textConfirm.Text))
            {
                MessageBox.Show("This fields can not be empty", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            //check if the password match
            else if(txtPass.Text == textConfirm.Text)
            {
                con.Open();
                String register = "INSERT INTO Table2 VALUES('"+ txtUser.Text + "','" + txtPass.Text + "')";

                command = new OleDbCommand(register, con);
                command.ExecuteNonQuery();
                con.Close();

                //Clear
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                textConfirm.Text = string.Empty;


                MessageBox.Show("Registered", "Good", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Password and Cornfirm Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPassword.Checked)
            {
                txtPass.PasswordChar = '\0';
                textConfirm.PasswordChar= '\0';
            }else
            {
                txtPass.PasswordChar = '*';
                textConfirm.PasswordChar ='*';
            }
        }

        private void textConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            textConfirm.Text = string.Empty;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
