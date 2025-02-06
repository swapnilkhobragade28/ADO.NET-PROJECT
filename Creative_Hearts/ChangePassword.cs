using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creative_Hearts
{
    public partial class ChangePassword : BaseForm
    {

        //----------------------------------DAL class object creation-----------------------------------------------------------------------------

        DAL d = new DAL();



        //--------------------------------------------------------------------------------------------------------------

        string emailid;
        bool ismember;


        //--------------------------------------------------constructor------------------------------------------------------------
        public ChangePassword(string emailid, bool ismember)
        {
            InitializeComponent();
            this.emailid = emailid;
            this.ismember = ismember;
        }




        //---------------------------------change password button click event------------------------------------------------------------------------------
        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (ismember == true && txt_newpassword.Text == txt_repassword.Text && txt_newpassword.Text != "" && txt_repassword.Text != "")
                {
                    string q = $"update ArtistDetails set password='{txt_repassword.Text}' where emailid='{emailid}' and password='{txt_oldpassword.Text}' ";
                    int result = d.GetExecuteNonQuery(q);
                    if (result > 0)
                    {
                        MessageBox.Show("Password updated successfully...");
                        ClearAllControls(txt_oldpassword, Controls);
                        SetVisibility(txt_newpassword, Controls, false, "warning");
                    }
                    else
                    {
                        MessageBox.Show("Sorry Password not updated....");
                        ClearAllControls(txt_oldpassword, Controls);
                        SetVisibility(txt_newpassword, Controls, false, "warning");
                    }
                }

                if (ismember == false && txt_newpassword.Text == txt_repassword.Text && txt_newpassword.Text != "" && txt_repassword.Text != "")
                {
                    string q = $"update CustomerDetails set password='{txt_repassword.Text}' where emailid='{emailid}' and password='{txt_oldpassword.Text}' ";
                    int result = d.GetExecuteNonQuery(q);
                    if (result > 0)
                    {
                        MessageBox.Show("Password updated successfully...");
                        ClearAllControls(txt_oldpassword, Controls);
                        SetVisibility(txt_newpassword, Controls, false, "warning");
                    }
                    else
                    {
                        MessageBox.Show("Sorry Password not updated....");
                        ClearAllControls(txt_oldpassword, Controls);
                        SetVisibility(txt_newpassword, Controls, false, "warning");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //-------------------------------------form load event------------------------------------------------------------------------
        private void txt_newpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txt_newpassword.Text.Length < 8 || txt_newpassword.Text.Length > 16)
            {
                lbl_warning.Text = "Password length must be 8 to 16";
                lbl_warning.Visible = true;
            }
        }

        private void txt_repassword_Validating(object sender, CancelEventArgs e)
        {
            if (txt_repassword.Text != txt_newpassword.Text)
            {
                lbl_warning.Text = "Not match to new password";
                lbl_warning.Visible = true;
            }
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c=new ContactUsForm();
            c.ShowDialog();
        }
    }
}
