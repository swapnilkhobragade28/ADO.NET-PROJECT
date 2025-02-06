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
    public partial class PlaceOrder : Form
    {

        //--------------------------------DAL file object creation---------------------------------------------------------------------
        DAL d = new DAL();


        //--------------------------------------------------------------------------------------------------------------------
        int artworkid;

        string emailid;

        static int orderid;

        DateTime orderdate = DateTime.Now;


        //-----------------------------------------------------constructor--------------------------------------------------------------
        public PlaceOrder(int artworkid, string emailid)
        {
            InitializeComponent();
            this.artworkid = artworkid;
            this.emailid = emailid;
        }


        //-------------------------------------------form load event--------------------------------------------------------------------
        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            try
            {

                //-----------------------------------Finding latest order id--------------------------------------------

                string query1 = "select max(orderid) from CustomerOrders";

                Object ob = d.GetExecuteScaler(query1);

                if (ob != null)
                {
                    orderid = Convert.ToInt32(ob.ToString());
                }
                else
                {
                    orderid = 1;
                }



                //---------------------------------for displaying artwork details---------------------------------

                string query2 = $"Select * from ArtworkDetails where id={artworkid}";

                SqlDataReader dr = d.GetSqlDataReader(query2);

                if (dr != null && dr.HasRows)
                {
                    dr.Read();

                    lbl_displayname.Text = dr["title"].ToString();
                    lbl_displayartistname.Text= dr["artistname"].ToString();
                    lbl_displaysize.Text = dr["size"].ToString();
                    lbl_displaymedium.Text = dr["medium"].ToString();
                    lbl_displayyear.Text = dr["year"].ToString();
                    lbl_displayprice.Text = dr["price"].ToString();
                    pbx_productimg.ImageLocation = dr["img"].ToString();
                    lbl_artistemail.Text = dr["artistemail"].ToString();
                }

                dr.Close();



                //------------------------------For checking item is sold out or available--------------------------------

                string query3 = $"select status from ArtworkDetails where id={artworkid}";

                Object obj = d.GetExecuteScaler(query3);

                if (obj != null && obj.ToString() == "Sold Out")
                {
                    btn_placeorder.Text = obj.ToString();
                    btn_placeorder.BackColor = Color.Red;
                    btn_placeorder.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //--------------------------------------place order button click---------------------------------------------------------------------------
        private void btn_placeorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailid == "not login")
                {
                    MessageBox.Show("Please log in to place this order");

                    LogInsForm frm = new LogInsForm(false);
                    frm.ShowDialog();
                }
                else
                {
                    orderid++;

                    if (MessageBox.Show("Do u want to place this order ?", "Place Order", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                    string query = $"insert into CustomerOrders values({orderid},'{emailid}',{artworkid},'{lbl_displayname.Text}'," +
                        $"'{lbl_displayprice.Text}','{orderdate}','Order Placed')";

                    int result = d.GetExecuteNonQuery(query);

                    if (result > 0)
                    {
                        MessageBox.Show("Order Placed Successfully.....");
                        this.Close();

                        string query1 = $"update ArtworkDetails set status='Sold Out' where id={artworkid} ";

                        int result1 = d.GetExecuteNonQuery(query1);

                        if (result1 > 0)
                        {
                            MessageBox.Show("We appreciates your love for art.....");
                        }
                        else
                        {
                            MessageBox.Show("Sorry...Order not placed!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Order not Placed");
                    }
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

        private void pbx_seeprofile_Click(object sender, EventArgs e)
        {
            ArtistDetails p = new ArtistDetails(lbl_artistemail.Text);
                p.ShowDialog();
        }
    }
}
