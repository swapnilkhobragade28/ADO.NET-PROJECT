using System;
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
    public partial class SignUpForm : BaseForm
    {
        //------------------------------------DAL file object creation---------------------------------------------------------------------------//
        DAL D = new DAL();

        //-------------------------------------constructor--------------------------------------------------------------------------//
        public SignUpForm()
        {
            InitializeComponent();
        }


        //--------------------------------------sign up button click event-------------------------------------------------------------------------//
        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do u want to create this account ?", "Create new account", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                    return;

                string query = $"insert into CustomerDetails values('{txt_enteremail.Text}','{txt_password.Text}','{txt_entername.Text}'," +
                    $"{txt_enterphone.Text},'{txt_address.Text}')";

                int result = D.GetExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Your account created successfully......");
                    ClearAllControls(txt_entername, Controls);
                    SetVisibility(txt_entername, Controls, false, "warning");

                }
                else
                {
                    MessageBox.Show("Cant created account Something wrong.......");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        //---------------------------------------------------------------------------------------------------------------//
        private void txt_entername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Validations(sender, e, "fullname");
        }


        //---------------------------------------------------------------------------------------------------------------//
        private void txt_enterphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Validations(sender, e, "phoneno");
        }


        //---------------------------------------------------------------------------------------------------------------//
        private void txt_enteremail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Validations(sender, e, "email");
        }


        //---------------------------------------------------------------------------------------------------------------//
        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Validations(sender, e, "password");
        }


        //---------------------------------------------------------------------------------------------------------------//
        private void txt_reenterpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check_Validations(sender, e, "password");
        }


        //-----------------------------------------password text validating----------------------------------------------------------------------//
        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (txt_password.Text.Length < 8 || txt_password.Text.Length > 16)
            {
                lbl_passwordwarning.Text = "Password must be 8 to 16 character long";
                lbl_passwordwarning.Visible = true;
            }
        }
        private void lbl_login_Click(object sender, EventArgs e)
        {
            LogInsForm l = new LogInsForm(false);
            l.ShowDialog();
        }

        private void txt_entername_Validating(object sender, CancelEventArgs e)
        {
            if (txt_entername.Text == "")
            {
                lbl_namewarning.Text = "this field is mandatory";
                lbl_namewarning.Visible = true;
            }
        }

        private void txt_enteremail_Validating(object sender, CancelEventArgs e)
        {
            if (txt_enteremail.Text == "")
            {
                lbl_emailwarning.Text = "this field is mandatory";
                lbl_emailwarning.Visible = true;
            }
        }

        private void txt_enterphone_Validating(object sender, CancelEventArgs e)
        {
            if (txt_enterphone.Text.Length != 10)
            {
                lbl_phonewarning.Text = "Phone must be 10 digit long";
                lbl_phonewarning.Visible = true;
            }
        }
        private void txt_address_Validating(object sender, CancelEventArgs e)
        {
            if (txt_address.Text == "")
            {
                lbl_addresswarning.Text = "this field is mandatory";
                lbl_addresswarning.Visible = true;
            }
        }

        private void txt_reenterpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txt_reenterpassword.Text == "")
            {
                lbl_repasswordwarning.Text = "this field is mandatory";
                lbl_repasswordwarning.Visible = true;
                return;
            }
            else if (txt_reenterpassword.Text != txt_password.Text)
            {
                lbl_repasswordwarning.Text = "this password not match to above password";
                lbl_repasswordwarning.Visible = true;
                return;
            }
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c = new ContactUsForm();
            c.ShowDialog();
        }
    }
}
