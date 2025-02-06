using System;
using System.Collections;
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
    public partial class MyOrders : Form
    {

        //-----------------------------------DAL class object creation----------------------------------------------------------------------

        DAL d = new DAL();


        //---------------------------------------------------------------------------------------------------------

        string customerEmailid;



        //----------------------------------------------constructor------------------------------------------------------------
        public MyOrders(string customerEmailid)
        {
            InitializeComponent();
            this.customerEmailid = customerEmailid;
        }


        //-----------------------------------------------form load event----------------------------------------------------------
        private void MyOrders_Load(object sender, EventArgs e)
        {
            try
            {
                string q = $"select * from CustomerOrders where emailid='{customerEmailid}'";
                Object val = d.GetExecuteScaler(q);
                if (val == null)
                {
                    lbl_myorders.Text = "No Orders Found";
                    lbl_myorders.ForeColor = Color.Red;
                }
                else
                {
                    grd_myorders.Visible = true;
                    grd_myorders.DataSource = d.GetDataTable(q);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c = new ContactUsForm();
            c.ShowDialog();
        }
    }
}
