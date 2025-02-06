using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Creative_Hearts
{
    public partial class LogInsForm : BaseForm
    {

        //--------------------------------------------DAL class object created-------------------------------------------------------------------//
        DAL d = new DAL();


        //---------------------------------------------------------------------------------------------------------------//
        string query;
        string emailid;
        bool ismember;


        //--------------------------------using get and set method accessing the emailid-------------------------------------------------------------------------------//
        public string getemail { set { emailid = value; } get { return emailid; } }



        //---------------------------------------constructor------------------------------------------------------------------------//
        public LogInsForm(bool ismember)
        {
            InitializeComponent();
            this.ismember = ismember;
        }


        //-----------------------------------------login button click event----------------------------------------------------------------------//
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text != "" || txt_password.Text != "")
                {
                    if (ismember == true)
                    {
                        query = $"select emailid from ArtistDetails where emailid='{txt_username.Text}' and password='{txt_password.Text}'";
                    }
                    else
                    {
                        query = $"select emailid from CustomerDetails where emailid='{txt_username.Text}' and password='{txt_password.Text}'";
                    }
                    Object obj = d.GetExecuteScaler(query);

                    if (obj == null)
                    {
                        throw new UsernameNotValidException("Username or Password is wrong........");
                    }

                    else
                    {
                        if (ismember == true)
                        {
                            getemail = txt_username.Text;
                            MessageBox.Show($"{getemail}  Login Success......");
                            ClearAllControls(txt_username, Controls);

                            EditMemberProfile emp = new EditMemberProfile(getemail);
                            emp.ShowDialog();
                        }
                        else
                        {
                            getemail = txt_username.Text;
                            MessageBox.Show($"{getemail}  Login Success......");
                            ClearAllControls(txt_username, Controls);

                            CustomerLoginForm c = new CustomerLoginForm(getemail);
                            c.ShowDialog();
                        }
                    }
                }
            }
            catch (UsernameNotValidException ex)
            {
                MessageBox.Show(ex.Message);
                ClearAllControls(txt_username, Controls);
                SetVisibility(txt_username, Controls, false, "warning");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (txt_username.Text == "")
            {
                lbl_emailwarning.Text = "Please Enter email id";
                lbl_emailwarning.Visible = true;
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (txt_password.Text == "")
            {
                lbl_passwordwarning.Text = "Please Enter password";
                lbl_passwordwarning.Visible = true;
            }
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c = new ContactUsForm();
            c.ShowDialog();
        }
    }
}
