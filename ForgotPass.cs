using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AOOP_EmpowerHER
{
    public partial class ForgotPass : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        Random rand = new Random();

        private string randomcode;
        public static string to;
        public ForgotPass()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());

        }

        public string getEmail
        {
            get { return to; }
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            if (Code.Text != randomcode)
            {
                MessageBox.Show("Code invalid. Try again.");
                Code.Text = string.Empty;
            }
            else
            {
                VerifiedEmail verified = new VerifiedEmail();
                verified.Show();
                this.Hide();
            }
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (Email.Text).ToString();
            from = "beargyu06@gmail.com";
            pass = "oted pfnd lraq lraf";
            messagebody = $"Your Reset Code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "EmpowerHER Reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show($"Code Successfully Sent {randomcode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT Count(*) From Student where Email = @email", cn);
            {
                cmd.Parameters.AddWithValue("@email", Email.Text);
                cn.Open();
                Int32 count = (Int32)cmd.ExecuteScalar();
                if (count == 0)
                {
                    Email.Text = string.Empty;
                    Email.PlaceholderText = "Email is not registerd yet.";
                    Email.PlaceholderForeColor = Color.Red;
                }

                cn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
