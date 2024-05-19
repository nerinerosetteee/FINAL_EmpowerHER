using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace AOOP_EmpowerHER
{
    public partial class VerifiedEmail : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnect dbcon = new DbConnect();

        public VerifiedEmail()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Password.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPassText.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ForgotPass forgotPass = new ForgotPass();
                string email = forgotPass.getEmail;
                string pass_encrypted = HashP.CalculateMD5Hash(Password.Text.Trim());

                MessageBox.Show(email);

                cmd = new SqlCommand("UPDATE Student set Password = @Password where Email = @Email", cn);
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", pass_encrypted);

                    cn.Open();
                    cmd.ExecuteNonQuery();                }
            }
            catch (SqlException ex)
            {
                // Show a message box to the user with the error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                cn.Close();
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    LoginForm login = new LoginForm();
                    login.Show();
                    MessageBox.Show("Your account was successfully registered.");
                    this.Hide();
                }
            }
        }

        private void ConfirmPassText_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassText.Text != Password.Text)
            {
                ConfirmPassText.Text = string.Empty;
                ConfirmPassText.PlaceholderText = "Password does not match.";
                ConfirmPassText.PlaceholderForeColor = Color.Red;
            }
        }

        private void ConfirmPassText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
