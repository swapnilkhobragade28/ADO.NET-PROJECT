using System;
using System.Windows.Forms;

namespace Creative_Hearts
{
    public partial class BaseForm : Form
    {

        //----------------------------------------constuctor-----------------------------------------------------------------------//
        public BaseForm()
        {
            InitializeComponent();
        }


        //-----------------------------------------Enter and leave control color changing event----------------------------------------------------------------------//
        public void Enter_control(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            c.BackColor = Color.LightBlue;
        }

        public void Leave_control(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            c.BackColor = Color.White;
        }



        //---------------------------------Checking validations of text in textboxes---------------------------------------------
        public void Check_Validations(Object sender, KeyPressEventArgs e, string action)
        {
            Control c = (Control)sender;

            //----------------------------For full name text validations----------------------------------------

            string fullnamevalidstr = "abcdefghijklmnopqrstuvwxyz \b";
            if (action == "fullname")
            {
                if (c.Tag != null && c.Tag == "string")
                {
                    if (!(fullnamevalidstr.Contains(e.KeyChar.ToString().ToLower())))
                        e.KeyChar = (char)0;

                    if (c.Text.Split(' ').Length > 2 && e.KeyChar == ' ')
                        e.KeyChar = (char)0;

                    if (c.Text.Length > 0 && c.Text.Substring(c.Text.Length - 1) == " " && e.KeyChar == ' ')
                        e.KeyChar = (char)0;
                }
            }

            //-----------------------------for phone no textbox validations----------------------------------------
            if (action == "phoneno")
            {
                if (c.Tag != null && c.Tag == "int")
                {
                    if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b'))
                        e.KeyChar = (char)0;

                }
            }


            //----------------------------for email id textbox validations------------------------------------------

            string emailvalidstr = "1234567890abcdefghijklmnopqrstuvwxyz@.\b";

            if (action == "email")
            {
                if (c.Tag != null && c.Tag == "string")
                {
                    if (!(emailvalidstr.Contains(e.KeyChar.ToString().ToLower())))
                        e.KeyChar = (char)0;
                    if (c.Text.Contains("@") && e.KeyChar != '\b' && e.KeyChar == '@')
                        e.KeyChar = (char)0;
                }
            }


            //-----------------------------for password textbox validations--------------------------------------------
            //

            if (action == "password")
            {
                if (c.Tag != null && c.Tag == "string")
                {
                    if (e.KeyChar != '\b' && e.KeyChar == ' ')
                        e.KeyChar = (char)0;
                    if (c.Text.Length >= 16 && e.KeyChar != '\b')
                        e.KeyChar = (char)0;
                }
            }

        }



        //---------------------------------------------for clears all controls-----------------------------------------
        public void ClearAllControls(Control c, Control.ControlCollection ccn)
        {
            foreach (Control item in ccn)
            {
                if (item.Tag != null && item.Tag=="string" || item.Tag == "int" || item.Tag=="double" || item.Tag == "Textupdateartwork")
                    item.Text = "";

                if (item.GetType().Name == "ComboBox")
                {
                    ComboBox cb = (ComboBox)item;
                    cb.SelectedIndex = 0;
                }

                if (item.GetType().Name == "RadioButton")
                {
                    RadioButton rb = (RadioButton)item;
                    rb.Checked = false;
                }
            }
        }

        //----------------------------------------------to set warning label visibility false----------------------------------------------------------------------
        public void SetVisibility(Control c, Control.ControlCollection ccn,bool value,string tag)
        {
            foreach (Control item in ccn)
            {
                if (item.Tag == tag && value == true)
                    item.Visible = true;

                if (item.Tag == tag && value == false)
                    item.Visible = false;
            }
        }
    }
}