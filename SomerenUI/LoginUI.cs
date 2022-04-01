using PasswordHasher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using ErrorHandlers;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            pnlRegister.Hide();
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            //image: Flaticon.com
            btnShowPassword.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            //image: Flaticon.com
            btnHidePassword.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    throw new SomerenException("Please fill all textboxes!");
                }
                if (!ValidateEmail(txtUsername.Text))
                {
                    throw new SomerenException("Please use a valid emailaddress!");
                }
                PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
                byte[] saltBytes = pwHasher.GetSaltBytes();
                HashWithSaltResult hashResult = pwHasher.HashWithSalt(txtPassword.Text, saltBytes, SHA512.Create());
                UserService userService = new UserService();

                User user = new User(txtUsername.Text, hashResult.Digest);
                user.Admin = userService.ValidateUser(user);
                user.Password = string.Empty;
                if (user.Admin != null)
                {
                    SomerenUI somerenUI = new SomerenUI(user);
                    this.Hide();
                    somerenUI.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new SomerenException("Username/password combination was incorrect!");
                }
                lblErrorMessage.Text = string.Empty;
            }
            catch (SomerenException sex)
            {
                lblErrorMessage.Text = sex.Message;
                MessageBox.Show(sex.Message);
            }
            catch (Exception ex)
            {
                ErrorLogger.WriteLogToFile(ex.Message);
                lblErrorMessage.Text = ex.Message;
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private bool ValidateEmail(string email)
        {
            Regex regularExpression = new Regex(@"^[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,3}");
            Match match = regularExpression.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Show();
            pnlRegister.BringToFront();
        }

        private void btnRegisterShowPsw_Click_1(object sender, EventArgs e)
        {
            btnRegisterHidePsw.BringToFront();
            btnRegisterHidePswConfirm.BringToFront();
            txtRegisterPassword.UseSystemPasswordChar = false;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = false;
        }

        private void btnRegisterHidePsw_Click(object sender, EventArgs e)
        {
            btnRegisterShowPsw.BringToFront();
            btnRegisterShowPswConfirm.BringToFront();
            txtRegisterPassword.UseSystemPasswordChar = true;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
        }

        private void btnRegisterShowPswConfirm_Click(object sender, EventArgs e)
        {
            btnRegisterHidePswConfirm.BringToFront();
            btnRegisterHidePsw.BringToFront();
            txtRegisterPassword.UseSystemPasswordChar = false;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = false;
        }

        private void btnRegisterHidePswConfirm_Click(object sender, EventArgs e)
        {
            btnRegisterShowPswConfirm.BringToFront();
            btnRegisterShowPsw.BringToFront();
            txtRegisterPassword.UseSystemPasswordChar = true;
            txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRegisterUsername.Text) || string.IsNullOrEmpty(txtRegisterPassword.Text) || string.IsNullOrEmpty(txtRegisterPasswordConfirm.Text) || string.IsNullOrEmpty(txtRegisterKey.Text) || cmdBoxRegisterRole.SelectedIndex == -1)
                {
                    throw new SomerenException("Please fill all textboxes!");
                }
                if (!ValidateEmail(txtRegisterUsername.Text))
                {
                    throw new SomerenException("Please use a valid emailaddress!");
                }
                if (txtRegisterPassword.Text != txtRegisterPasswordConfirm.Text)
                {
                    throw new SomerenException("Please make sure your passwords match!");
                }
                if (txtRegisterKey.Text != ConfigurationManager.AppSettings["LicenseKey"])
                {
                    throw new SomerenException("Please use a valid license key!");
                }
                PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
                byte[] saltBytes = pwHasher.GetSaltBytes();
                HashWithSaltResult hashResult = pwHasher.HashWithSalt(txtRegisterPassword.Text, saltBytes, SHA512.Create());
                UserService userService = new UserService();

                User user = new User(txtRegisterUsername.Text, hashResult.Digest)
                {
                    Admin = Convert.ToBoolean(int.Parse(cmdBoxRegisterRole.SelectedIndex.ToString()))
                };

                if (!userService.RegisterUser(user))
                {
                    throw new SomerenException("This username is already in use!");
                }
                MessageBox.Show($"{user.Username} has been registered");
                EmptyRegisterBoxes();
                lblErrorRegister.Text = string.Empty;
            }
            catch (SomerenException sex)
            {
                lblErrorRegister.Text = sex.Message;
                MessageBox.Show(sex.Message);
            }
            catch (Exception ex)
            {
                ErrorLogger.WriteLogToFile(ex.Message);
                lblErrorRegister.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void EmptyRegisterBoxes()
        {
            txtRegisterUsername.Text = string.Empty;
            txtRegisterPassword.Text = string.Empty;
            txtRegisterPasswordConfirm.Text = string.Empty;
            cmdBoxRegisterRole.SelectedIndex = -1;
            txtRegisterKey.Text = string.Empty;
        }

        private void btnRegisterReturn_Click(object sender, EventArgs e)
        {
            pnlRegister.Hide();
        }


        private void AddpasswordVield()
        {

            usernamelabel.Enabled = false;
            usernameField.Enabled = false;
            questionlabel.Enabled = false;
            antwoord.Enabled = false;


            
         

            TextBox textBox = new TextBox();
            textBox.Name = "Password";
            textBox.TabIndex = 7;
            textBox.Width = 145;
            textBox.Location = new Point(100, 120);

            forgotgroupbox.Controls.Add(textBox);


            Label label = new Label();
            label.Name = "passwordlabel";
            label.Text = "new password";
            label.TabIndex = 6;
            label.Location = new Point(10,122);

            forgotgroupbox.Controls.Add(label);

            check.Click -= check_Click;
            check.Click += submit_Click;
            check.Text = "submit";


        }

        private void reset()
        {
            usernamelabel.Enabled = true;
            usernameField.Enabled = true;
          
            usernameField.Text ="";
            questionlabel.Text = "question";
            antwoord.Text="";

            for (int i = forgotgroupbox.Controls.Count - 1; i >= 0; i--)
            {
                Control c = forgotgroupbox.Controls[i];
                if (c.Name == "passwordlabel" || c.Name == "Password")
                {
                    forgotgroupbox.Controls.RemoveAt(i);
                }
            }
        }


        private void AddQuestion()
        {
            questionlabel.Enabled = false;
            antwoord.Enabled = false;
            check.Enabled = false;
            check.Click-= check_Click;
            check.Click += GetQuestion;
        }
        
 

        //forgot password button
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {

            reset();

            usernameField.Text = null;

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = new User(username, password);

            UserService userservice = new UserService();

            UserQuestion question = userservice.Getquestion(user);

            if(question.question != null )
            {
                forgotpassword.Show();
                usernameField.Text = username;
                questionlabel.Text = question.question;
            }
            else
            {
                MessageBox.Show("please fill in your username");
                AddQuestion();
                forgotpassword.Show();
            }


        }


        //return buttons
        private void returnButon_Click(object sender, EventArgs e)
        {
            forgotpassword.Hide();
            

        }

        private void GetQuestion(object sender, EventArgs e)
        {
            string username = usernameField.Text;

            string password = null;

            User user = new User(username, password);

            UserService userservice = new UserService();

            UserQuestion question = userservice.Getquestion(user);
            if( question.question != null)
            {
                questionlabel.Text=question.question;
                questionlabel.Enabled = true;
                antwoord.Enabled = true;
                usernameField.Enabled = false;
                check.Click -= GetQuestion;
                check.Click += check_Click;
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result =  MessageBox.Show("you seem to not be registerd", "invalid password", buttons);

                if(result == DialogResult.Cancel)
                {
                    forgotpassword.Hide();
                }

            }

        }




        private void check_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string question = questionlabel.Text;
            string answer = antwoord.Text;


            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            byte[] saltBytes = pwHasher.GetSaltBytes();
            HashWithSaltResult hashResult = pwHasher.HashWithSalt(answer, saltBytes, SHA512.Create());

            User user = new User(username, null);
            user.question = new UserQuestion(question, hashResult.Digest);

            UserService userservice = new UserService();
             UserQuestion Questionanswer =   userservice.GetAnswer(user);

            if (Questionanswer.answer != null )
            {
                AddpasswordVield();

            }

        }
        private void submit_Click(object sender, EventArgs e)
        {

            //get data from form
            string question = questionlabel.Text;
            string answer = antwoord.Text;
            string password = forgotgroupbox.Controls[4].Text;


            //hash preparation
            PasswordWithSaltHasher passwordWithSalt = new PasswordWithSaltHasher();

            byte[] saltBytes = passwordWithSalt.GetSaltBytes();
            //hash password
            string paswordhashed =  passwordWithSalt.HashWithSalt(password,saltBytes,SHA512.Create()).Digest;
            //hashanswer
            string answerhashed = passwordWithSalt.HashWithSalt(answer, saltBytes, SHA512.Create()).Digest;

            //setup question
            UserQuestion userquestion = new UserQuestion(question, answerhashed);


            //setup user to be updated
            User user = new User(usernameField.Text, paswordhashed);
            user.question = userquestion;

            //update password
            UserService userservice = new UserService();
            if (userservice.UpdatePassword(user))
            {
                check.Click -= submit_Click;
                forgotpassword.Hide();
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("somethingwent wrong");
            }
         

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {
            if (!questionlabel.Enabled)
            {
                check.Enabled = true;
            }
        }
    }
}
