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
    public partial class CustomerLoginForm : BaseForm
    {
        //--------------------------------------------------------------------------------------------------------------
        DAL d = new DAL();



        //--------------------------------------------------------------------------------------------------------------
        string email;


        //--------------------------------------------------constructor-----------------------------------------------------------
        public CustomerLoginForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }



        //-----------------------------------------------search button click event--------------------------------------------------------------
        private void pbx_search_Click(object sender, EventArgs e)
        {
            SearchForm1 sf = new SearchForm1(txt_search.Text, email);
            sf.ShowDialog();
        }

        //-------------------------------------------------form load event----------------------------------------------------------
        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {
            lbl_emailid.Text = email;

            try
            {
                string query = "select * from ArtistDetails";

                SqlDataReader r = d.GetSqlDataReader(query);

                if (r != null && r.HasRows)
                {
                    r.Read();
                    pbx_profilephoto.ImageLocation = r["profilephoto"].ToString();
                    lbl_artistname.Text = r["name"].ToString();
                    lbl_artistid.Text = r["emailid"].ToString();
                    pbx_profilephoto.Visible = true;
                    lbl_artistname.Visible = true;
                }
                r.Close();
            }
            catch (Exception ex) { }

            try
            {
                string query = $"select * from ArtworkDetails where artistname= '{lbl_artistname.Text}'";

                SqlDataReader r = d.GetSqlDataReader(query);

                if (r != null && r.HasRows)
                {
                    r.Read();
                    pbx_artwork1.ImageLocation = r["img"].ToString();
                    lbl_artworkid1.Text = r["id"].ToString();
                    pbx_artwork1.Visible = true;

                    r.Read();
                    pbx_artwork2.ImageLocation = r["img"].ToString();
                    lbl_artworkid2.Text = r["id"].ToString();
                    pbx_artwork2.Visible = true;

                    r.Read();
                    pbx_artwork3.ImageLocation = r["img"].ToString();
                    lbl_artworkid3.Text = r["id"].ToString();
                    pbx_artwork3.Visible = true;

                    r.Read();
                    pbx_artwork4.ImageLocation = r["img"].ToString();
                    lbl_artworkid4.Text = r["id"].ToString();
                    pbx_artwork4.Visible = true;

                    r.Read();
                    pbx_artwork5.ImageLocation = r["img"].ToString();
                    lbl_artworkid5.Text = r["id"].ToString();
                    pbx_artwork5.Visible = true;

                    r.Read();
                    pbx_artwork6.ImageLocation = r["img"].ToString();
                    lbl_artworkid6.Text = r["id"].ToString();
                    pbx_artwork6.Visible = true;
                }
                r.Close();
            }
            catch (Exception ex) { }
        }


        //-------------------------------------------------------------------------------------------------------
        private void pbx_myorders_Click(object sender, EventArgs e)
        {
            MyOrders m = new MyOrders(email);
            m.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------
        private void pbx_editprofile_Click_1(object sender, EventArgs e)
        {
            EditCustomerProfile ec = new EditCustomerProfile(email);
            ec.ShowDialog();
        }

        //-------------------------------------------------------------------------------------------------------

        //------------------------------------profile photo click event---------------------------------------------------------------------------//
        private void pbx_profilephoto_Click(object sender, EventArgs e)
        {
            ArtistDetails a = new ArtistDetails(lbl_artistid.Text);
            a.ShowDialog();
        }

        //------------------------------------artworks click event---------------------------------------------------------------------------//
        private void pbx_artwork1_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid1.Text), email);
            p.ShowDialog();
        }

        private void pbx_artwork2_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid2.Text), email);
            p.ShowDialog();
        }

        private void pbx_artwork3_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid3.Text), email);
            p.ShowDialog();
        }

        private void pbx_artwork4_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid4.Text), email);
            p.ShowDialog();
        }

        private void pbx_artwork5_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid5.Text), email);
            p.ShowDialog();
        }

        private void pbx_artwork6_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid6.Text), email);
            p.ShowDialog();
        }

        //--------------------------contact us click event--------------------------------------------------------------------------
        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c = new ContactUsForm();
            c.ShowDialog();
        }


        //-------------------------------change password click event----------------------------------------------------------------------------
        private void pbx_changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(email, false);
            cp.ShowDialog();
        }

        private void pbx_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have logged out successfully.....");
            this.Close();
            HomePageForm h=new HomePageForm();
            h.ShowDialog();
        }
    }
}
