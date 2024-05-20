using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOOP_EmpowerHER
{
    public partial class LoginForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnect dbcon = new DbConnect();

        public LoginForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            register login = new register();
            login.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = false;
        }

        private void guna2ImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void guna2TextBox2_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;

            try
            {
                string pass_decrypted = HashP.CalculateMD5Hash(Password.Text.Trim());

                cmd = new SqlCommand("SELECT Count(*) From Student where (Username = @useroremail OR Email = @useroremail) AND Password = @password", cn);
                cmd.Parameters.AddWithValue("@useroremail", username);
                cmd.Parameters.AddWithValue("@password", pass_decrypted);
                cn.Open();
                Int32 count = (Int32)cmd.ExecuteScalar();
                string countstring = count.ToString();

                if (count > 0)
                {
                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Password = pass_decrypted;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Account successfully logged in.", "Welcome! " + Properties.Settings.Default.Username, MessageBoxButtons.OK);

                    Dashboard dshbrd = new Dashboard();
                    dshbrd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email/Username and Password doesn't macth.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username.Clear();
                    Password.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForgotPass forpaass = new ForgotPass();
            this.Hide();
            forpaass.Show();
        }
    }
}
