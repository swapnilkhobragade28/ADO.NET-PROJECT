namespace Creative_Hearts
{
    partial class LogInsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInsForm));
            txt_password = new TextBox();
            txt_username = new TextBox();
            pbx_emailicon = new PictureBox();
            pbx_passwordicon = new PictureBox();
            v = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pbx_profileicon = new PictureBox();
            lbl_passwordwarning = new Label();
            lbl_emailwarning = new Label();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pbx_emailicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_passwordicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)v).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_profileicon).BeginInit();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(536, 348);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(273, 23);
            txt_password.TabIndex = 2;
            txt_password.Tag = "string";
            txt_password.Enter += Enter_control;
            txt_password.Leave += Leave_control;
            txt_password.Validating += txt_password_Validating;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(536, 276);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(273, 23);
            txt_username.TabIndex = 0;
            txt_username.Tag = "string";
            txt_username.Enter += Enter_control;
            txt_username.Leave += Leave_control;
            txt_username.Validating += txt_username_Validating;
            // 
            // pbx_emailicon
            // 
            pbx_emailicon.Image = (Image)resources.GetObject("pbx_emailicon.Image");
            pbx_emailicon.Location = new Point(476, 261);
            pbx_emailicon.Name = "pbx_emailicon";
            pbx_emailicon.Size = new Size(54, 50);
            pbx_emailicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_emailicon.TabIndex = 6;
            pbx_emailicon.TabStop = false;
            pbx_emailicon.Tag = "loginpbx";
            // 
            // pbx_passwordicon
            // 
            pbx_passwordicon.Image = (Image)resources.GetObject("pbx_passwordicon.Image");
            pbx_passwordicon.Location = new Point(487, 345);
            pbx_passwordicon.Name = "pbx_passwordicon";
            pbx_passwordicon.Size = new Size(34, 29);
            pbx_passwordicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_passwordicon.TabIndex = 7;
            pbx_passwordicon.TabStop = false;
            pbx_passwordicon.Tag = "loginpbx";
            // 
            // v
            // 
            v.Image = (Image)resources.GetObject("v.Image");
            v.Location = new Point(12, 12);
            v.Name = "v";
            v.Size = new Size(168, 53);
            v.SizeMode = PictureBoxSizeMode.StretchImage;
            v.TabIndex = 13;
            v.TabStop = false;
            v.Click += pbx_logo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(382, 117);
            label1.Name = "label1";
            label1.Size = new Size(557, 15);
            label1.TabIndex = 9;
            label1.Text = "--------------------------------------------------------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(382, 502);
            label2.Name = "label2";
            label2.Size = new Size(557, 15);
            label2.TabIndex = 17;
            label2.Text = "--------------------------------------------------------------------------------------------------------------";
            // 
            // pbx_profileicon
            // 
            pbx_profileicon.Image = (Image)resources.GetObject("pbx_profileicon.Image");
            pbx_profileicon.Location = new Point(588, 62);
            pbx_profileicon.Name = "pbx_profileicon";
            pbx_profileicon.Size = new Size(134, 126);
            pbx_profileicon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_profileicon.TabIndex = 22;
            pbx_profileicon.TabStop = false;
            // 
            // lbl_passwordwarning
            // 
            lbl_passwordwarning.AutoSize = true;
            lbl_passwordwarning.ForeColor = Color.Red;
            lbl_passwordwarning.Location = new Point(536, 387);
            lbl_passwordwarning.Name = "lbl_passwordwarning";
            lbl_passwordwarning.Size = new Size(60, 15);
            lbl_passwordwarning.TabIndex = 10;
            lbl_passwordwarning.Tag = "loginwarning";
            lbl_passwordwarning.Text = "-warning-";
            lbl_passwordwarning.Visible = false;
            // 
            // lbl_emailwarning
            // 
            lbl_emailwarning.AutoSize = true;
            lbl_emailwarning.ForeColor = Color.Red;
            lbl_emailwarning.Location = new Point(536, 314);
            lbl_emailwarning.Name = "lbl_emailwarning";
            lbl_emailwarning.Size = new Size(60, 15);
            lbl_emailwarning.TabIndex = 8;
            lbl_emailwarning.Tag = "loginwarning";
            lbl_emailwarning.Text = "-warning-";
            lbl_emailwarning.Visible = false;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(610, 421);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // LogInsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1264, 672);
            Controls.Add(pbx_profileicon);
            Controls.Add(label2);
            Controls.Add(v);
            Controls.Add(lbl_passwordwarning);
            Controls.Add(label1);
            Controls.Add(lbl_emailwarning);
            Controls.Add(pbx_passwordicon);
            Controls.Add(pbx_emailicon);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "LogInsForm";
            Text = "Log In";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbx_emailicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_passwordicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)v).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_profileicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_password;
        private TextBox txt_username;
        private PictureBox pbx_emailicon;
        private PictureBox pbx_passwordicon;
        private PictureBox v;
        private Label label1;
        private Label label2;
        private PictureBox pbx_profileicon;
        private Label lbl_passwordwarning;
        private Label lbl_emailwarning;
        private Button btn_login;
    }
}