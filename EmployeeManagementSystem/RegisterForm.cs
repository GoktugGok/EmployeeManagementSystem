using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace EmployeeManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gokgo\OneDrive\Belgeler\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_signInBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == ""| register_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Open) {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string insertData = "INSERT INTO users " + 
                            "(username, password,date_register)" + 
                            "VALUES(@username,@password, @date_Reg";

                        using (SqlCommand cmd = new SqlCommand(insertData))
                        {
                            cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_Reg", today);

                            MessageBox.Show("Registered successfully!","Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
        }
    }
}
