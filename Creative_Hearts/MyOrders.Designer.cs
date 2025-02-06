namespace Creative_Hearts
{
    partial class MyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrders));
            grd_myorders = new DataGridView();
            lbl_myorders = new Label();
            pbx_logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grd_myorders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).BeginInit();
            SuspendLayout();
            // 
            // grd_myorders
            // 
            grd_myorders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_myorders.Location = new Point(255, 129);
            grd_myorders.Name = "grd_myorders";
            grd_myorders.Size = new Size(778, 150);
            grd_myorders.TabIndex = 0;
            grd_myorders.Visible = false;
            // 
            // lbl_myorders
            // 
            lbl_myorders.AutoSize = true;
            lbl_myorders.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_myorders.ForeColor = Color.Navy;
            lbl_myorders.Location = new Point(500, 45);
            lbl_myorders.Name = "lbl_myorders";
            lbl_myorders.Size = new Size(186, 32);
            lbl_myorders.TabIndex = 1;
            lbl_myorders.Text = "Your Order List";
            // 
            // pbx_logo
            // 
            pbx_logo.Image = (Image)resources.GetObject("pbx_logo.Image");
            pbx_logo.Location = new Point(12, 12);
            pbx_logo.Name = "pbx_logo";
            pbx_logo.Size = new Size(168, 53);
            pbx_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_logo.TabIndex = 14;
            pbx_logo.TabStop = false;
            pbx_logo.Click += pbx_logo_Click;
            // 
            // MyOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1224, 618);
            Controls.Add(pbx_logo);
            Controls.Add(lbl_myorders);
            Controls.Add(grd_myorders);
            Name = "MyOrders";
            Text = "MyOrders";
            WindowState = FormWindowState.Maximized;
            Load += MyOrders_Load;
            ((System.ComponentModel.ISupportInitialize)grd_myorders).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grd_myorders;
        private Label lbl_myorders;
        private PictureBox pbx_logo;
    }
}