namespace Creative_Hearts
{
    partial class EditCustomerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomerProfile));
            pbx_logo = new PictureBox();
            lbl_changename = new Label();
            txt_changename = new TextBox();
            txt_changephone = new TextBox();
            lbl_changephone = new Label();
            txt_changeaddress = new TextBox();
            lbl_changeaddress = new Label();
            label1 = new Label();
            btn_savechanges = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbx_logo
            // 
            pbx_logo.Image = (Image)resources.GetObject("pbx_logo.Image");
            pbx_logo.Location = new Point(12, 12);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new Size(186, 55);
            pbx_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_logo.TabIndex = 14;
            pbx_logo.TabStop = false;
            pbx_logo.Click += pbx_logo_Click;
            // 
            // lbl_changename
            // 
            lbl_changename.AutoSize = true;
            lbl_changename.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold);
            lbl_changename.Location = new Point(755, 166);
            lbl_changename.Name = "lbl_changename";
            lbl_changename.Size = new Size(129, 17);
            lbl_changename.TabIndex = 15;
            lbl_changename.Text = "Change Name :";
            // 
            // txt_changename
            // 
            txt_changename.Location = new Point(755, 197);
            txt_changename.Name = "txt_changename";
            txt_changename.Size = new Size(278, 23);
            txt_changename.TabIndex = 16;
            txt_changename.Tag = "string";
            // 
            // txt_changephone
            // 
            txt_changephone.Location = new Point(755, 290);
            txt_changephone.Name = "txt_changephone";
            txt_changephone.Size = new Size(278, 23);
            txt_changephone.TabIndex = 18;
            txt_changephone.Tag = "string";
            // 
            // lbl_changephone
            // 
            lbl_changephone.AutoSize = true;
            lbl_changephone.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold);
            lbl_changephone.Location = new Point(755, 262);
            lbl_changephone.Name = "lbl_changephone";
            lbl_changephone.Size = new Size(159, 17);
            lbl_changephone.TabIndex = 17;
            lbl_changephone.Text = "Change Phone no :";
            // 
            // txt_changeaddress
            // 
            txt_changeaddress.Location = new Point(755, 385);
            txt_changeaddress.Name = "txt_changeaddress";
            txt_changeaddress.Size = new Size(278, 23);
            txt_changeaddress.TabIndex = 20;
            txt_changeaddress.Tag = "string";
            // 
            // lbl_changeaddress
            // 
            lbl_changeaddress.AutoSize = true;
            lbl_changeaddress.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold);
            lbl_changeaddress.Location = new Point(755, 356);
            lbl_changeaddress.Name = "lbl_changeaddress";
            lbl_changeaddress.Size = new Size(152, 17);
            lbl_changeaddress.TabIndex = 19;
            lbl_changeaddress.Text = "Change Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 478);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 21;
            // 
            // btn_savechanges
            // 
            btn_savechanges.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_savechanges.Location = new Point(832, 466);
            btn_savechanges.Name = "btn_savechanges";
            btn_savechanges.Size = new Size(126, 36);
            btn_savechanges.TabIndex = 22;
            btn_savechanges.Text = "Save Changes";
            btn_savechanges.UseVisualStyleBackColor = true;
            btn_savechanges.Click += btn_savechanges_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(755, 84);
            label2.Name = "label2";
            label2.Size = new Size(270, 31);
            label2.TabIndex = 23;
            label2.Text = "Edit your Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(256, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // EditCustomerProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1224, 537);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btn_savechanges);
            Controls.Add(label1);
            Controls.Add(txt_changeaddress);
            Controls.Add(lbl_changeaddress);
            Controls.Add(txt_changephone);
            Controls.Add(lbl_changephone);
            Controls.Add(txt_changename);
            Controls.Add(lbl_changename);
            Controls.Add(pbx_logo);
            Name = "EditCustomerProfile";
            Text = "EditProfile";
            WindowState = FormWindowState.Maximized;
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx_logo;
        private Label lbl_changename;
        private TextBox txt_changename;
        private TextBox txt_changephone;
        private Label lbl_changephone;
        private TextBox txt_changeaddress;
        private Label lbl_changeaddress;
        private Label label1;
        private Button btn_savechanges;
        private Label label2;
        private PictureBox pictureBox1;
    }
}