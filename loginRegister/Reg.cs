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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }
        //connecting to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private void btnReg_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                //txtBuser.PasswordChar = '\0';
                txtBpass.PasswordChar = '\0';
            }
            else
            {
                //txtBuser.PasswordChar = '*';
                txtBpass.PasswordChar = '*';
            }
        }

        private void txtBuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            String Login = "SELECT * FROM Table2 WHERE username = '" + txtBuser.Text + "'  and password = '" + txtBpass.Text + "'";
            string name = "SELECT username FROM Table2";
            string password = "SELECT password FROM Table2";
            command = new OleDbCommand(Login, con);
           // command = new OleDbCommand(name, con);
            //command = new OleDbCommand(password, con);
            OleDbDataReader reader = command.ExecuteReader();

            if (String.IsNullOrWhiteSpace(txtBuser.Text)||String.IsNullOrWhiteSpace(txtBpass.Text))
            {
                MessageBox.Show("This fields can not be empty", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (reader.Read() == true)
            {
                new Form1().ShowDialog();
                this.Hide();
            }
          
            else if(name == txtBuser.Text && password != txtBpass.Text)
            {
                MessageBox.Show("the password is incorrect", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your need to register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuser.Text = String.Empty;
                txtBpass.Text = String.Empty;

                login log = new login();
                log.Show();
                this.Hide();

            }
            con.Close();

        }
    }
}
