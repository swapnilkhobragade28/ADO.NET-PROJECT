namespace Creative_Hearts
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            lbl_entername = new Label();
            txt_entername = new TextBox();
            txt_enteremail = new TextBox();
            lbl_enteremail = new Label();
            txt_enterphone = new TextBox();
            lbl_enterphone = new Label();
            lbl_password = new Label();
            lbl_reenterpassword = new Label();
            txt_reenterpassword = new TextBox();
            txt_password = new TextBox();
            btn_signup = new Button();
            txt_address = new TextBox();
            lbl_address = new Label();
            label1 = new Label();
            label2 = new Label();
            lbl_login = new Label();
            lbl_namewarning = new Label();
            lbl_emailwarning = new Label();
            lbl_phonewarning = new Label();
            lbl_addresswarning = new Label();
            lbl_passwordwarning = new Label();
            lbl_repasswordwarning = new Label();
            pictureBox1 = new PictureBox();
            pbx_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).BeginInit();
            SuspendLayout();
            // 
            // lbl_entername
            // 
            lbl_entername.AutoSize = true;
            lbl_entername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_entername.ForeColor = SystemColors.ControlLight;
            lbl_entername.Location = new Point(748, 161);
            lbl_entername.Name = "lbl_entername";
            lbl_entername.Size = new Size(68, 15);
            lbl_entername.TabIndex = 0;
            lbl_entername.Text = "Full Name :";
            // 
            // txt_entername
            // 
            txt_entername.Location = new Point(896, 158);
            txt_entername.Name = "txt_entername";
            txt_entername.Size = new Size(255, 23);
            txt_entername.TabIndex = 1;
            txt_entername.Tag = "string";
            txt_entername.Enter += Enter_control;
            txt_entername.KeyPress += txt_entername_KeyPress;
            txt_entername.Leave += Leave_control;
            txt_entername.Validating += txt_entername_Validating;
            // 
            // txt_enteremail
            // 
            txt_enteremail.Location = new Point(896, 216);
            txt_enteremail.Name = "txt_enteremail";
            txt_enteremail.Size = new Size(255, 23);
            txt_enteremail.TabIndex = 2;
            txt_enteremail.Tag = "string";
            txt_enteremail.Enter += Enter_control;
            txt_enteremail.KeyPress += txt_enteremail_KeyPress;
            txt_enteremail.Leave += Leave_control;
            txt_enteremail.Validating += txt_enteremail_Validating;
            // 
            // lbl_enteremail
            // 
            lbl_enteremail.AutoSize = true;
            lbl_enteremail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_enteremail.ForeColor = SystemColors.ControlLight;
            lbl_enteremail.Location = new Point(748, 217);
            lbl_enteremail.Name = "lbl_enteremail";
            lbl_enteremail.Size = new Size(57, 15);
            lbl_enteremail.TabIndex = 2;
            lbl_enteremail.Text = "Email-id :";
            // 
            // txt_enterphone
            // 
            txt_enterphone.Location = new Point(896, 272);
            txt_enterphone.Name = "txt_enterphone";
            txt_enterphone.Size = new Size(255, 23);
            txt_enterphone.TabIndex = 3;
            txt_enterphone.Tag = "int";
            txt_enterphone.Enter += Enter_control;
            txt_enterphone.KeyPress += txt_enterphone_KeyPress;
            txt_enterphone.Leave += Leave_control;
            txt_enterphone.Validating += txt_enterphone_Validating;
            // 
            // lbl_enterphone
            // 
            lbl_enterphone.AutoSize = true;
            lbl_enterphone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_enterphone.ForeColor = SystemColors.ControlLight;
            lbl_enterphone.Location = new Point(748, 275);
            lbl_enterphone.Name = "lbl_enterphone";
            lbl_enterphone.Size = new Size(67, 15);
            lbl_enterphone.TabIndex = 4;
            lbl_enterphone.Tag = " ";
            lbl_enterphone.Text = "Phone No :";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = SystemColors.ControlLight;
            lbl_password.Location = new Point(748, 385);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(105, 15);
            lbl_password.TabIndex = 10;
            lbl_password.Text = "Create Password :";
            // 
            // lbl_reenterpassword
            // 
            lbl_reenterpassword.AutoSize = true;
            lbl_reenterpassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_reenterpassword.ForeColor = SystemColors.ControlLight;
            lbl_reenterpassword.Location = new Point(748, 436);
            lbl_reenterpassword.Name = "lbl_reenterpassword";
            lbl_reenterpassword.Size = new Size(107, 15);
            lbl_reenterpassword.TabIndex = 12;
            lbl_reenterpassword.Text = "Renter Password :";
            // 
            // txt_reenterpassword
            // 
            txt_reenterpassword.Location = new Point(896, 433);
            txt_reenterpassword.Name = "txt_reenterpassword";
            txt_reenterpassword.PasswordChar = '*';
            txt_reenterpassword.Size = new Size(255, 23);
            txt_reenterpassword.TabIndex = 6;
            txt_reenterpassword.Tag = "string";
            txt_reenterpassword.Enter += Enter_control;
            txt_reenterpassword.KeyPress += txt_reenterpassword_KeyPress;
            txt_reenterpassword.Leave += Leave_control;
            txt_reenterpassword.Validating += txt_reenterpassword_Validating;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(896, 382);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(255, 23);
            txt_password.TabIndex = 5;
            txt_password.Tag = "string";
            txt_password.Enter += Enter_control;
            txt_password.KeyPress += txt_password_KeyPress;
            txt_password.Leave += Leave_control;
            txt_password.Validating += txt_password_Validating;
            // 
            // btn_signup
            // 
            btn_signup.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_signup.Location = new Point(749, 504);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(187, 40);
            btn_signup.TabIndex = 14;
            btn_signup.Text = "Create account";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(896, 328);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(255, 23);
            txt_address.TabIndex = 4;
            txt_address.Tag = "string";
            txt_address.Validating += txt_address_Validating;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_address.ForeColor = SystemColors.ControlLight;
            lbl_address.Location = new Point(748, 331);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(57, 15);
            lbl_address.TabIndex = 15;
            lbl_address.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(748, 93);
            label1.Name = "label1";
            label1.Size = new Size(271, 27);
            label1.TabIndex = 17;
            label1.Text = "Create new Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(1015, 504);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 18;
            label2.Text = "Already have account ? ";
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.FromArgb(0, 192, 192);
            lbl_login.Location = new Point(1039, 529);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(40, 15);
            lbl_login.TabIndex = 19;
            lbl_login.Text = "Log in";
            lbl_login.Click += lbl_login_Click;
            // 
            // lbl_namewarning
            // 
            lbl_namewarning.AutoSize = true;
            lbl_namewarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_namewarning.ForeColor = Color.Red;
            lbl_namewarning.Location = new Point(896, 185);
            lbl_namewarning.Name = "lbl_namewarning";
            lbl_namewarning.Size = new Size(62, 15);
            lbl_namewarning.TabIndex = 20;
            lbl_namewarning.Tag = "signupwarning";
            lbl_namewarning.Text = "-warning-";
            lbl_namewarning.Visible = false;
            // 
            // lbl_emailwarning
            // 
            lbl_emailwarning.AutoSize = true;
            lbl_emailwarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_emailwarning.ForeColor = Color.Red;
            lbl_emailwarning.Location = new Point(896, 241);
            lbl_emailwarning.Name = "lbl_emailwarning";
            lbl_emailwarning.Size = new Size(62, 15);
            lbl_emailwarning.TabIndex = 21;
            lbl_emailwarning.Tag = "signupwarning";
            lbl_emailwarning.Text = "-warning-";
            lbl_emailwarning.Visible = false;
            // 
            // lbl_phonewarning
            // 
            lbl_phonewarning.AutoSize = true;
            lbl_phonewarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_phonewarning.ForeColor = Color.Red;
            lbl_phonewarning.Location = new Point(896, 299);
            lbl_phonewarning.Name = "lbl_phonewarning";
            lbl_phonewarning.Size = new Size(62, 15);
            lbl_phonewarning.TabIndex = 22;
            lbl_phonewarning.Tag = "signupwarning";
            lbl_phonewarning.Text = "-warning-";
            lbl_phonewarning.Visible = false;
            // 
            // lbl_addresswarning
            // 
            lbl_addresswarning.AutoSize = true;
            lbl_addresswarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_addresswarning.ForeColor = Color.Red;
            lbl_addresswarning.Location = new Point(896, 355);
            lbl_addresswarning.Name = "lbl_addresswarning";
            lbl_addresswarning.Size = new Size(62, 15);
            lbl_addresswarning.TabIndex = 23;
            lbl_addresswarning.Tag = "signupwarning";
            lbl_addresswarning.Text = "-warning-";
            lbl_addresswarning.Visible = false;
            // 
            // lbl_passwordwarning
            // 
            lbl_passwordwarning.AutoSize = true;
            lbl_passwordwarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_passwordwarning.ForeColor = Color.Red;
            lbl_passwordwarning.Location = new Point(896, 409);
            lbl_passwordwarning.Name = "lbl_passwordwarning";
            lbl_passwordwarning.Size = new Size(62, 15);
            lbl_passwordwarning.TabIndex = 24;
            lbl_passwordwarning.Tag = "signupwarning";
            lbl_passwordwarning.Text = "-warning-";
            lbl_passwordwarning.Visible = false;
            // 
            // lbl_repasswordwarning
            // 
            lbl_repasswordwarning.AutoSize = true;
            lbl_repasswordwarning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_repasswordwarning.ForeColor = Color.Red;
            lbl_repasswordwarning.Location = new Point(896, 460);
            lbl_repasswordwarning.Name = "lbl_repasswordwarning";
            lbl_repasswordwarning.Size = new Size(62, 15);
            lbl_repasswordwarning.TabIndex = 25;
            lbl_repasswordwarning.Tag = "signupwarning";
            lbl_repasswordwarning.Text = "-warning-";
            lbl_repasswordwarning.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pbx_logo
            // 
            pbx_logo.Image = (Image)resources.GetObject("pbx_logo.Image");
            pbx_logo.Location = new Point(12, 12);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new Size(189, 61);
            pbx_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_logo.TabIndex = 58;
            pbx_logo.TabStop = false;
            pbx_logo.Click += pbx_logo_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1241, 613);
            Controls.Add(pbx_logo);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_repasswordwarning);
            Controls.Add(lbl_passwordwarning);
            Controls.Add(lbl_addresswarning);
            Controls.Add(lbl_phonewarning);
            Controls.Add(lbl_emailwarning);
            Controls.Add(lbl_namewarning);
            Controls.Add(lbl_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_address);
            Controls.Add(lbl_address);
            Controls.Add(btn_signup);
            Controls.Add(txt_reenterpassword);
            Controls.Add(lbl_reenterpassword);
            Controls.Add(txt_password);
            Controls.Add(lbl_password);
            Controls.Add(txt_enterphone);
            Controls.Add(lbl_enterphone);
            Controls.Add(txt_enteremail);
            Controls.Add(lbl_enteremail);
            Controls.Add(txt_entername);
            Controls.Add(lbl_entername);
            Name = "SignUpForm";
            Text = "Sign Up";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_entername;
        private TextBox txt_entername;
        private TextBox txt_enteremail;
        private Label lbl_enteremail;
        private TextBox txt_enterphone;
        private Label lbl_enterphone;
        private Label lbl_password;
        private Label lbl_reenterpassword;
        private TextBox txt_reenterpassword;
        private TextBox txt_password;
        private Button btn_signup;
        private TextBox txt_address;
        private Label lbl_address;
        private Label label1;
        private Label label2;
        private Label lbl_login;
        private Label lbl_namewarning;
        private Label lbl_emailwarning;
        private Label lbl_phonewarning;
        private Label lbl_addresswarning;
        private Label lbl_passwordwarning;
        private Label lbl_repasswordwarning;
        private PictureBox pictureBox1;
        private PictureBox pbx_logo;
    }
}