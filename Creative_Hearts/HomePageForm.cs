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
    public partial class HomePageForm : BaseForm
    {
        //----------------------------------------DAL class------------------------------------------------------------//
        DAL d = new DAL();



        //---------------------------------------set emailid as not login for showing login page later-------------------------------------------------------------//
        string emailid = "not login";


        //----------------------------------------HomePageForm constructor------------------------------------------------------------//
        public HomePageForm()
        {
            InitializeComponent();
        }

        //------------------------------------------Logo click event--------------------------------------------------------
        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c = new ContactUsForm();
            c.ShowDialog();
        }

        //----------------------------Log in menu item------------------------------------------------------------//
        private void pbx_login_Click(object sender, EventArgs e)
        {
            LogInsForm l = new LogInsForm(false);
            l.ShowDialog();
        }

        //------------------------------------sign up menu item--------------------------------------------------------------------------------------------------------//
        private void pbx_signup_Click(object sender, EventArgs e)
        {
            SignUpForm s = new SignUpForm();
            s.ShowDialog();
        }

        //--------------------------------------member login menu item----------------------------------------------------------------------//
        private void pbx_memberlogin_Click(object sender, EventArgs e)
        {
            LogInsForm l = new LogInsForm(true);
            l.ShowDialog();
        }

        //----------------------------------------search icon click event-----------------------------------------------------------------------//
        private void pbx_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Write something for search results");
            }
            else
            {
                SearchForm1 sf = new SearchForm1(txt_search.Text,emailid);
                sf.ShowDialog();
            }
        }

        //-----------------------------------------Homepage load event----------------------------------------------------------------------//
        private void HomePageForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from ArtistDetails";// where name='Swapnil Khobragade'";

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
                string query = $"select * from ArtworkDetails where artistname= '{lbl_artistname.Text}'";//'Swapnil Khobragade'";

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


        //------------------------------------profile photo click event---------------------------------------------------------------------------//
        private void pbx_profilephoto_Click(object sender, EventArgs e)
        {
            ArtistDetails a = new ArtistDetails(lbl_artistid.Text);
            a.ShowDialog();
        }

        //------------------------------------artworks click event---------------------------------------------------------------------------//
        private void pbx_artwork1_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid1.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_artwork2_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid2.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_artwork3_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid3.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_artwork4_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid4.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_artwork5_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid5.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_artwork6_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid6.Text), emailid);
            p.ShowDialog();
        }
    }
}
