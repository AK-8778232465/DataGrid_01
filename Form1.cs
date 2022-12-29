using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String randomCode;
        public static String to;

        // Twilio API  // SharpData Verification Code
        //SID
        //SKbf82e9ae15dc3494467067b5aec30289
        //Secret
        //qwyVAD7cDBChb2ioTsIIGYRgOFKSq0mz

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ServerConnectionString"].ToString());

        private void Form1_Load(object sender, EventArgs e)
        {
            btnResetPass.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                txtPassword.Text = "";
                txtUsername.Text = "";
                lblResult.Text = "Enter Credentials";
            }
            else
            {
                try
                {
                    con.Close();
                }
                catch
                {
                    //
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@userid", SqlDbType.NVarChar).Value = txtUsername.Text.ToString();
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text.ToString();

                try
                {
                    SqlDataReader loginTable = cmd.ExecuteReader();
                    if (loginTable.Read())
                    {
                        lblResult.Visible= true;
                        string uName = (string)loginTable["name"];
                        lblResult.Text = "Welcome "+ uName;
                        MessageBox.Show("Login success");
                    }
                    else
                    {
                        MessageBox.Show("Login Faild, Please check credentials");
                        lblResult.Visible = false;
                        lblResult.Text = "";
                        btnResetPass.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed");
                }

            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            GroupLogin.Visible = false;
            GroupReset.Visible = false;
            GroupVerify.Visible = true;
            txtVerifyCode.Enabled = false;
            btnVerifyCode.Enabled = false;
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {

            try
            {
                con.Close();
            }
            catch
            {
                //
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("VerifyMail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtForgotMail.Text.ToString();

            try
            {
                SqlDataReader loginTable = cmd.ExecuteReader();
                if (loginTable.Read())
                {
                    txtVerifyCode.Enabled = true;
                    btnVerifyCode.Enabled = true;
                    lblVerifyStatus.Visible = false;
                    lblVerifyStatus.Text = "";
                    String from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txtForgotMail.Text).ToString();
                    from = "theenderxxx@gmail.com";
                    pass = "fvdtbuurkpirxwsw";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Verification Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code Send Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } 
                else
                {
                    txtForgotMail.Text = "";
                    lblVerifyStatus.Visible = true;
                    lblVerifyStatus.Text = "*** Entered Email is not registered ***";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (randomCode == txtVerifyCode.Text)
            {
                GroupReset.Visible = true;
                GroupVerify.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void btnReseted_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text != "" && txtConfirm.Text != "" && txtNewPass.Text == txtConfirm.Text)
            {
                try
                {
                    con.Close();
                }
                catch
                {
                    //
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("ResetPass", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtForgotMail.Text.ToString();
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtNewPass.Text.ToString();
                SqlDataReader loginTable = cmd.ExecuteReader();
                GroupReset.Visible = false;
                GroupLogin.Visible = true;
            } 
            else
            {
                MessageBox.Show("*** Both Password fields should be same ***");
                txtNewPass.Text = "";
                txtConfirm.Text = "";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GroupRegister.Visible = true;
            GroupLogin.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GroupRegister.Visible = false;
            GroupLogin.Visible = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtEmailreg.Text != "" && txtEmpreg.Text != "" && txtFnamereg.Text != "" && txtPasswordreg.Text != "" && txtUnamereg.Text != "")
            {
                try
                {
                    con.Close();
                }
                catch
                {
                    //
                }
                con.Open();
                SqlCommand cmd = new SqlCommand("CreateAccount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@empId", SqlDbType.NVarChar).Value = txtEmpreg.Text.ToString();
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtFnamereg.Text.ToString();
                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUnamereg.Text.ToString();
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txtPasswordreg.Text.ToString();
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmailreg.Text.ToString();
                SqlDataReader loginTable = cmd.ExecuteReader();
                GroupRegister.Visible = false;
                GroupLogin.Visible = true;
                txtEmailreg.Text = txtEmpreg.Text = txtFnamereg.Text = txtPasswordreg.Text = txtUnamereg.Text = "";
                MessageBox.Show("*** Account registered Successfully ***");
            }
            else
            {
                if (txtEmailreg.Text == "")
                {
                    txtEmailreg.BackColor = Color.MistyRose;
                } else
                {
                    txtEmailreg.BackColor = SystemColors.Window;
                }
                if (txtEmpreg.Text == "")
                {
                    txtEmpreg.BackColor = Color.MistyRose;
                }
                else
                {
                    txtEmpreg.BackColor = SystemColors.Window;
                }
                if (txtFnamereg.Text == "")
                {
                    txtFnamereg.BackColor = Color.MistyRose;
                }
                else
                {
                    txtFnamereg.BackColor = SystemColors.Window;
                }
                if (txtPasswordreg.Text == "")
                {
                    txtPasswordreg.BackColor = Color.MistyRose;
                }
                else
                {
                    txtPasswordreg.BackColor = SystemColors.Window;
                }
                if (txtUnamereg.Text == "")
                {
                    txtUnamereg.BackColor = Color.MistyRose;
                }
                else
                {
                    txtUnamereg.BackColor = SystemColors.Window;
                }
            }
        }
    }
}
