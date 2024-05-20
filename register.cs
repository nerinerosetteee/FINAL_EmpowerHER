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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;



namespace AOOP_EmpowerHER
{
    public partial class register : Form
    {
        private bool dateEntered = false;
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnect dbcon = new DbConnect();

        public register()
        {
            InitializeComponent();
            Birthday.Format = DateTimePickerFormat.Custom;
            Birthday.CustomFormat = " 'Birthday' ";
            cn = new SqlConnection(dbcon.connection());

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateEntered = Birthday.Value.Date != DateTime.Now.Date;

            Birthday.CustomFormat = dateEntered ? "MM/dd/yyyy" : " 'Birthday' ";
        }

        private void guna2DateTimePicker1_Enter(object sender, EventArgs e)
        {
            Birthday.Format = DateTimePickerFormat.Short;
        }

        private void guna2DateTimePicker1_Leave(object sender, EventArgs e)
        {
            Birthday.Format = DateTimePickerFormat.Custom;
            Birthday.CustomFormat = " 'Birthday' ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        public void Clear()
        {
            Lname.Clear();
            Fname.Clear();
            MI.Clear();
            Age.Clear();
            Birthday.Value = DateTime.Now;
            Address.Clear();
            Email.Clear();
            Username.Clear();
            Password.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Lname.Text) ||
                string.IsNullOrWhiteSpace(Fname.Text) ||
                string.IsNullOrWhiteSpace(MI.Text) ||
                string.IsNullOrWhiteSpace(Age.Text) ||
                string.IsNullOrWhiteSpace(Address.Text) ||
                string.IsNullOrWhiteSpace(Email.Text) ||
                string.IsNullOrWhiteSpace(Username.Text) ||
                string.IsNullOrWhiteSpace(Password.Text) ||
                string.IsNullOrWhiteSpace(Confirm_pass.Text) ||
                Birthday.Value == DateTime.Now)
            {
                MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any field is empty
            }



            try
            {
                string pass_encrypted = HashP.CalculateMD5Hash(Password.Text.Trim());

                cmd = new SqlCommand("INSERT INTO Student (LName, FName, MName, Age, Birthday, Address, Email, Username, Password) VALUES (@LName, @FName, @MName, @Age, @Birthday, @Address, @Email, @Username, @Password)", cn);
                {
                    cmd.Parameters.AddWithValue("@LName", Lname.Text);
                    cmd.Parameters.AddWithValue("@FName", Fname.Text);
                    cmd.Parameters.AddWithValue("@MName", MI.Text);
                    cmd.Parameters.AddWithValue("@Age", Age.Text);
                    cmd.Parameters.AddWithValue("@Birthday", Birthday.Value);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Password", pass_encrypted);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    Clear(); // Clear the fields only if the operation is successful
                }
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

        private void MI_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MI.Text, out int value)) MI.Text = string.Empty;
            if (MI.Text.Length > 1)
            {
                MI.Text = MI.Text.Substring(0, 1);
            }
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Age.Text, out int value))
            {
                Age.Text = string.Empty;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (!Email.Text.Contains("@gmail.com"))
            {
                Email.Clear();
                Email.PlaceholderText = "Enter a valid Gmail Address";
                Email.PlaceholderForeColor = Color.Red;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT Count(*) From Student where Username = @username", cn);
            {
                cmd.Parameters.AddWithValue("@username", Username.Text);
                cn.Open();
                Int32 count = (Int32)cmd.ExecuteScalar();
                if (count > 0)
                {
                    Username.Text = string.Empty;
                    Username.PlaceholderText = "Username is taken.";
                    Username.PlaceholderForeColor = Color.Red;
                }

                cn.Close();
            }
        }

        private void guna2ImageButton1_MouseUp(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void guna2ImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = false;
        }
        private void Password_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_pass_Leave(object sender, EventArgs e)
        {
            if (Confirm_pass.Text != Password.Text)
            {
                Confirm_pass.Text = string.Empty;
                Confirm_pass.PlaceholderText = "Password does not match.";
                Confirm_pass.PlaceholderForeColor = Color.Red;
            }
        }

        private void Birthday_Leave(object sender, EventArgs e)
        {
            if (Birthday.Value > DateTime.Now)
            {
                Birthday.Value = DateTime.Now;
                Birthday.CustomFormat = "'Enter a valid birthday.'";
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

