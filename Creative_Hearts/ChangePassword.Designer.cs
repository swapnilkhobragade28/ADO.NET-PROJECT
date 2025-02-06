namespace Creative_Hearts
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            pictureBox1 = new PictureBox();
            txt_oldpassword = new TextBox();
            txt_newpassword = new TextBox();
            txt_repassword = new TextBox();
            btn_changepassword = new Button();
            lbl_warning = new Label();
            pbx_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txt_oldpassword
            // 
            txt_oldpassword.Location = new Point(462, 314);
            txt_oldpassword.Name = "txt_oldpassword";
            txt_oldpassword.PasswordChar = '*';
            txt_oldpassword.Size = new Size(209, 23);
            txt_oldpassword.TabIndex = 21;
            txt_oldpassword.Tag = "string";
            // 
            // txt_newpassword
            // 
            txt_newpassword.Location = new Point(462, 382);
            txt_newpassword.Name = "txt_newpassword";
            txt_newpassword.Size = new Size(209, 23);
            txt_newpassword.TabIndex = 25;
            txt_newpassword.Tag = "string";
            txt_newpassword.Validating += txt_newpassword_Validating;
            // 
            // txt_repassword
            // 
            txt_repassword.Location = new Point(462, 443);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.PasswordChar = '*';
            txt_repassword.Size = new Size(209, 23);
            txt_repassword.TabIndex = 27;
            txt_repassword.Tag = "string";
            txt_repassword.Validating += txt_repassword_Validating;
            // 
            // btn_changepassword
            // 
            btn_changepassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_changepassword.Location = new Point(663, 500);
            btn_changepassword.Name = "btn_changepassword";
            btn_changepassword.Size = new Size(86, 29);
            btn_changepassword.TabIndex = 28;
            btn_changepassword.Text = "Reset";
            btn_changepassword.UseVisualStyleBackColor = true;
            btn_changepassword.Click += btn_changepassword_Click;
            // 
            // lbl_warning
            // 
            lbl_warning.AutoSize = true;
            lbl_warning.ForeColor = Color.Red;
            lbl_warning.Location = new Point(423, 527);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Size = new Size(60, 15);
            lbl_warning.TabIndex = 29;
            lbl_warning.Tag = "warning";
            lbl_warning.Text = "-warning-";
            lbl_warning.Visible = false;
            // 
            // pbx_logo
            // 
            pbx_logo.Image = (Image)resources.GetObject("pbx_logo.Image");
            pbx_logo.Location = new Point(12, 12);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new Size(169, 50);
            pbx_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_logo.TabIndex = 30;
            pbx_logo.TabStop = false;
            pbx_logo.Click += pbx_logo_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1262, 631);
            Controls.Add(pbx_logo);
            Controls.Add(lbl_warning);
            Controls.Add(btn_changepassword);
            Controls.Add(txt_repassword);
            Controls.Add(txt_newpassword);
            Controls.Add(txt_oldpassword);
            Controls.Add(pictureBox1);
            Name = "ChangePassword";
            Text = "ChangePassword";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txt_oldpassword;
        private TextBox txt_newpassword;
        private TextBox txt_repassword;
        private Button btn_changepassword;
        private Label lbl_warning;
        private PictureBox pbx_logo;
    }
}