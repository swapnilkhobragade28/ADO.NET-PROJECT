namespace Creative_Hearts
{
    partial class ContactUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUsForm));
            pbx_whatsappno = new PictureBox();
            lbl_whatsappno = new Label();
            lbl_instagramid = new Label();
            pbx_instagramid = new PictureBox();
            lbl_officeaddrs = new Label();
            pbx_offficeaddrs = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbx_whatsappno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_instagramid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_offficeaddrs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbx_whatsappno
            // 
            pbx_whatsappno.Image = (Image)resources.GetObject("pbx_whatsappno.Image");
            pbx_whatsappno.Location = new Point(409, 124);
            pbx_whatsappno.Name = "pbx_whatsappno";
            pbx_whatsappno.Size = new Size(59, 53);
            pbx_whatsappno.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_whatsappno.TabIndex = 0;
            pbx_whatsappno.TabStop = false;
            // 
            // lbl_whatsappno
            // 
            lbl_whatsappno.AutoSize = true;
            lbl_whatsappno.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_whatsappno.Location = new Point(535, 134);
            lbl_whatsappno.Name = "lbl_whatsappno";
            lbl_whatsappno.Size = new Size(110, 23);
            lbl_whatsappno.TabIndex = 1;
            lbl_whatsappno.Text = "8378055572";
            // 
            // lbl_instagramid
            // 
            lbl_instagramid.AutoSize = true;
            lbl_instagramid.Font = new Font("Pristina", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_instagramid.Location = new Point(535, 225);
            lbl_instagramid.Name = "lbl_instagramid";
            lbl_instagramid.Size = new Size(125, 27);
            lbl_instagramid.TabIndex = 3;
            lbl_instagramid.Text = "Creative_Hearts";
            // 
            // pbx_instagramid
            // 
            pbx_instagramid.Image = (Image)resources.GetObject("pbx_instagramid.Image");
            pbx_instagramid.Location = new Point(409, 208);
            pbx_instagramid.Name = "pbx_instagramid";
            pbx_instagramid.Size = new Size(59, 55);
            pbx_instagramid.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_instagramid.TabIndex = 2;
            pbx_instagramid.TabStop = false;
            // 
            // lbl_officeaddrs
            // 
            lbl_officeaddrs.AutoSize = true;
            lbl_officeaddrs.Font = new Font("Rage Italic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_officeaddrs.Location = new Point(535, 310);
            lbl_officeaddrs.Name = "lbl_officeaddrs";
            lbl_officeaddrs.Size = new Size(381, 24);
            lbl_officeaddrs.TabIndex = 5;
            lbl_officeaddrs.Text = "Diamond Plaza, Floor no. 3, Goregaon West, Mumbai";
            // 
            // pbx_offficeaddrs
            // 
            pbx_offficeaddrs.Image = (Image)resources.GetObject("pbx_offficeaddrs.Image");
            pbx_offficeaddrs.Location = new Point(409, 297);
            pbx_offficeaddrs.Name = "pbx_offficeaddrs";
            pbx_offficeaddrs.Size = new Size(59, 56);
            pbx_offficeaddrs.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_offficeaddrs.TabIndex = 4;
            pbx_offficeaddrs.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ContactUsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 481);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_officeaddrs);
            Controls.Add(pbx_offficeaddrs);
            Controls.Add(lbl_instagramid);
            Controls.Add(pbx_instagramid);
            Controls.Add(lbl_whatsappno);
            Controls.Add(pbx_whatsappno);
            Name = "ContactUsForm";
            Text = "Contact Us";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pbx_whatsappno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_instagramid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_offficeaddrs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx_whatsappno;
        private Label lbl_whatsappno;
        private Label lbl_instagramid;
        private PictureBox pbx_instagramid;
        private Label lbl_officeaddrs;
        private PictureBox pbx_offficeaddrs;
        private PictureBox pictureBox1;
    }
}