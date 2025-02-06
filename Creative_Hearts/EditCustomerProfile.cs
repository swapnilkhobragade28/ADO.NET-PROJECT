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

    public partial class EditCustomerProfile : BaseForm
    {

        //--------------------------------DAL class object creation----------------------------------------------------------------------------

        DAL d = new DAL();



        //------------------------------------------------------------------------------------------------------------

        string email;


        //-----------------------------------------------constructor-------------------------------------------------------------
        public EditCustomerProfile(string email)
        {
            InitializeComponent();
            this.email = email;
        }


        //--------------------------------------form load event-----------------------------------------------------------------------
        private void EditProfile_Load(object sender, EventArgs e)
        {
            try
            {
                string q = $"select * from CustomerDetails where emailid='{email}'";

                SqlDataReader rdr = d.GetSqlDataReader(q);

                if (rdr != null && rdr.HasRows)
                {
                    rdr.Read();

                    txt_changename.Text = rdr["name"].ToString();
                    txt_changeaddress.Text = rdr["address"].ToString();
                    txt_changephone.Text = rdr["phone"].ToString();

                    rdr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //---------------------------------------save changes button click event---------------------------------------------------------------------
        private void btn_savechanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u want to make this changes?", "Edit Profile", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string query = $"update CustomerDetails set name='{txt_changename.Text}',phone='{txt_changephone.Text}',address='{txt_changeaddress.Text}' where emailid='{email}'";

            int result = d.GetExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Changes updated successfully....");
                ClearAllControls(txt_changename, Controls);
            }
            else
            {
                MessageBox.Show("Changes not updated");
                ClearAllControls(txt_changename, Controls);
            }
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c=new ContactUsForm();
            c.ShowDialog();
        }
    }
}
