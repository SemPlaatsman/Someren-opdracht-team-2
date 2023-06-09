﻿
namespace SomerenUI
{
    partial class LoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.cmdBoxRegisterRole = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegisterReturn = new System.Windows.Forms.Button();
            this.btnRegisterShowPsw = new System.Windows.Forms.Button();
            this.btnRegisterShowPswConfirm = new System.Windows.Forms.Button();
            this.btnRegisterHidePswConfirm = new System.Windows.Forms.Button();
            this.btnRegisterHidePsw = new System.Windows.Forms.Button();
            this.lblErrorRegister = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegisterKey = new System.Windows.Forms.TextBox();
            this.txtRegisterPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forgotpassword = new System.Windows.Forms.Panel();
            this.forgotgroupbox = new System.Windows.Forms.GroupBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.antwoord = new System.Windows.Forms.TextBox();
            this.questionlabel = new System.Windows.Forms.Label();
            this.returnButon = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.forgotpassword.SuspendLayout();
            this.forgotgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Someren login";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(470, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 123);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 232);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(600, 19);
            this.lblErrorMessage.TabIndex = 7;
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(252, 188);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(252, 137);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 26);
            this.txtUsername.TabIndex = 8;
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePassword.Image")));
            this.btnHidePassword.Location = new System.Drawing.Point(398, 187);
            this.btnHidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(26, 28);
            this.btnHidePassword.TabIndex = 11;
            this.btnHidePassword.TabStop = false;
            this.btnHidePassword.UseVisualStyleBackColor = true;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(398, 187);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(26, 28);
            this.btnShowPassword.TabIndex = 12;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(166, 262);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 28);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.Location = new System.Drawing.Point(166, 295);
            this.btnForgotPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(126, 28);
            this.btnForgotPassword.TabIndex = 14;
            this.btnForgotPassword.Text = "Forgot password?";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(297, 295);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(126, 28);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.cmdBoxRegisterRole);
            this.pnlRegister.Controls.Add(this.label9);
            this.pnlRegister.Controls.Add(this.btnRegisterReturn);
            this.pnlRegister.Controls.Add(this.btnRegisterShowPsw);
            this.pnlRegister.Controls.Add(this.btnRegisterShowPswConfirm);
            this.pnlRegister.Controls.Add(this.btnRegisterHidePswConfirm);
            this.pnlRegister.Controls.Add(this.btnRegisterHidePsw);
            this.pnlRegister.Controls.Add(this.lblErrorRegister);
            this.pnlRegister.Controls.Add(this.btnRegisterUser);
            this.pnlRegister.Controls.Add(this.label8);
            this.pnlRegister.Controls.Add(this.label7);
            this.pnlRegister.Controls.Add(this.label6);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.txtRegisterKey);
            this.pnlRegister.Controls.Add(this.txtRegisterPasswordConfirm);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterUsername);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.pictureBox1);
            this.pnlRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(600, 366);
            this.pnlRegister.TabIndex = 16;
            this.pnlRegister.Visible = false;
            // 
            // cmdBoxRegisterRole
            // 
            this.cmdBoxRegisterRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBoxRegisterRole.FormattingEnabled = true;
            this.cmdBoxRegisterRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmdBoxRegisterRole.Location = new System.Drawing.Point(286, 194);
            this.cmdBoxRegisterRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmdBoxRegisterRole.Name = "cmdBoxRegisterRole";
            this.cmdBoxRegisterRole.Size = new System.Drawing.Size(160, 28);
            this.cmdBoxRegisterRole.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Role:";
            // 
            // btnRegisterReturn
            // 
            this.btnRegisterReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterReturn.Location = new System.Drawing.Point(9, 10);
            this.btnRegisterReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterReturn.Name = "btnRegisterReturn";
            this.btnRegisterReturn.Size = new System.Drawing.Size(90, 32);
            this.btnRegisterReturn.TabIndex = 22;
            this.btnRegisterReturn.Text = "Return";
            this.btnRegisterReturn.UseVisualStyleBackColor = true;
            this.btnRegisterReturn.Click += new System.EventHandler(this.btnRegisterReturn_Click);
            // 
            // btnRegisterShowPsw
            // 
            this.btnRegisterShowPsw.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterShowPsw.Image")));
            this.btnRegisterShowPsw.Location = new System.Drawing.Point(421, 112);
            this.btnRegisterShowPsw.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterShowPsw.Name = "btnRegisterShowPsw";
            this.btnRegisterShowPsw.Size = new System.Drawing.Size(26, 28);
            this.btnRegisterShowPsw.TabIndex = 21;
            this.btnRegisterShowPsw.TabStop = false;
            this.btnRegisterShowPsw.UseVisualStyleBackColor = true;
            this.btnRegisterShowPsw.Click += new System.EventHandler(this.btnRegisterShowPsw_Click_1);
            // 
            // btnRegisterShowPswConfirm
            // 
            this.btnRegisterShowPswConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterShowPswConfirm.Image")));
            this.btnRegisterShowPswConfirm.Location = new System.Drawing.Point(421, 153);
            this.btnRegisterShowPswConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterShowPswConfirm.Name = "btnRegisterShowPswConfirm";
            this.btnRegisterShowPswConfirm.Size = new System.Drawing.Size(26, 28);
            this.btnRegisterShowPswConfirm.TabIndex = 20;
            this.btnRegisterShowPswConfirm.TabStop = false;
            this.btnRegisterShowPswConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterShowPswConfirm.Click += new System.EventHandler(this.btnRegisterShowPswConfirm_Click);
            // 
            // btnRegisterHidePswConfirm
            // 
            this.btnRegisterHidePswConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterHidePswConfirm.Image")));
            this.btnRegisterHidePswConfirm.Location = new System.Drawing.Point(421, 153);
            this.btnRegisterHidePswConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterHidePswConfirm.Name = "btnRegisterHidePswConfirm";
            this.btnRegisterHidePswConfirm.Size = new System.Drawing.Size(26, 28);
            this.btnRegisterHidePswConfirm.TabIndex = 19;
            this.btnRegisterHidePswConfirm.TabStop = false;
            this.btnRegisterHidePswConfirm.UseVisualStyleBackColor = true;
            this.btnRegisterHidePswConfirm.Click += new System.EventHandler(this.btnRegisterHidePswConfirm_Click);
            // 
            // btnRegisterHidePsw
            // 
            this.btnRegisterHidePsw.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterHidePsw.Image")));
            this.btnRegisterHidePsw.Location = new System.Drawing.Point(421, 112);
            this.btnRegisterHidePsw.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterHidePsw.Name = "btnRegisterHidePsw";
            this.btnRegisterHidePsw.Size = new System.Drawing.Size(26, 28);
            this.btnRegisterHidePsw.TabIndex = 17;
            this.btnRegisterHidePsw.TabStop = false;
            this.btnRegisterHidePsw.UseVisualStyleBackColor = true;
            this.btnRegisterHidePsw.Click += new System.EventHandler(this.btnRegisterHidePsw_Click);
            // 
            // lblErrorRegister
            // 
            this.lblErrorRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRegister.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRegister.Location = new System.Drawing.Point(0, 280);
            this.lblErrorRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorRegister.Name = "lblErrorRegister";
            this.lblErrorRegister.Size = new System.Drawing.Size(600, 19);
            this.lblErrorRegister.TabIndex = 16;
            this.lblErrorRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(208, 309);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(190, 28);
            this.btnRegisterUser.TabIndex = 15;
            this.btnRegisterUser.Text = "Register user";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "License key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Confirm password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Username:";
            // 
            // txtRegisterKey
            // 
            this.txtRegisterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterKey.Location = new System.Drawing.Point(286, 235);
            this.txtRegisterKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterKey.Name = "txtRegisterKey";
            this.txtRegisterKey.Size = new System.Drawing.Size(160, 26);
            this.txtRegisterKey.TabIndex = 10;
            // 
            // txtRegisterPasswordConfirm
            // 
            this.txtRegisterPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPasswordConfirm.Location = new System.Drawing.Point(286, 154);
            this.txtRegisterPasswordConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterPasswordConfirm.Name = "txtRegisterPasswordConfirm";
            this.txtRegisterPasswordConfirm.Size = new System.Drawing.Size(160, 26);
            this.txtRegisterPasswordConfirm.TabIndex = 9;
            this.txtRegisterPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(286, 113);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(160, 26);
            this.txtRegisterPassword.TabIndex = 8;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(286, 72);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(160, 26);
            this.txtRegisterUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Register new user";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 123);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // forgotpassword
            // 
            this.forgotpassword.AutoSize = true;
            this.forgotpassword.Controls.Add(this.forgotgroupbox);
            this.forgotpassword.Controls.Add(this.returnButon);
            this.forgotpassword.Controls.Add(this.check);
            this.forgotpassword.Location = new System.Drawing.Point(0, 0);
            this.forgotpassword.Name = "forgotpassword";
            this.forgotpassword.Size = new System.Drawing.Size(600, 366);
            this.forgotpassword.TabIndex = 26;
            this.forgotpassword.Visible = false;
            // 
            // forgotgroupbox
            // 
            this.forgotgroupbox.AutoSize = true;
            this.forgotgroupbox.Controls.Add(this.usernamelabel);
            this.forgotgroupbox.Controls.Add(this.usernameField);
            this.forgotgroupbox.Controls.Add(this.antwoord);
            this.forgotgroupbox.Controls.Add(this.questionlabel);
            this.forgotgroupbox.Location = new System.Drawing.Point(173, 39);
            this.forgotgroupbox.Name = "forgotgroupbox";
            this.forgotgroupbox.Size = new System.Drawing.Size(273, 109);
            this.forgotgroupbox.TabIndex = 9;
            this.forgotgroupbox.TabStop = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(6, 23);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(53, 13);
            this.usernamelabel.TabIndex = 7;
            this.usernamelabel.Text = "username";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(65, 20);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(179, 20);
            this.usernameField.TabIndex = 1;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // antwoord
            // 
            this.antwoord.Location = new System.Drawing.Point(9, 69);
            this.antwoord.Name = "antwoord";
            this.antwoord.Size = new System.Drawing.Size(234, 20);
            this.antwoord.TabIndex = 4;
            // 
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.Location = new System.Drawing.Point(6, 53);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(47, 13);
            this.questionlabel.TabIndex = 5;
            this.questionlabel.Text = "question";
            // 
            // returnButon
            // 
            this.returnButon.Location = new System.Drawing.Point(24, 19);
            this.returnButon.Name = "returnButon";
            this.returnButon.Size = new System.Drawing.Size(75, 23);
            this.returnButon.TabIndex = 8;
            this.returnButon.Text = "return";
            this.returnButon.UseVisualStyleBackColor = true;
            this.returnButon.Click += new System.EventHandler(this.returnButon_Click);
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.check.Location = new System.Drawing.Point(252, 314);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 0;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.forgotpassword);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.forgotpassword.ResumeLayout(false);
            this.forgotpassword.PerformLayout();
            this.forgotgroupbox.ResumeLayout(false);
            this.forgotgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblErrorRegister;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegisterKey;
        private System.Windows.Forms.TextBox txtRegisterPasswordConfirm;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegisterShowPswConfirm;
        private System.Windows.Forms.Button btnRegisterHidePswConfirm;
        private System.Windows.Forms.Button btnRegisterHidePsw;
        private System.Windows.Forms.Button btnRegisterShowPsw;
        private System.Windows.Forms.Button btnRegisterReturn;
        private System.Windows.Forms.ComboBox cmdBoxRegisterRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel forgotpassword;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox antwoord;
        private System.Windows.Forms.Label questionlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button returnButon;
        private System.Windows.Forms.GroupBox forgotgroupbox;
    }
}