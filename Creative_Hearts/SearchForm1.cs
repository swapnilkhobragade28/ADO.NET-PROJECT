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
    public partial class SearchForm1 : BaseForm
    {

        //----------------------------DAL class object creation------------------------------------------------------------------------------
        DAL d = new DAL();


        //--------------------------------------------------------------------------------------------------------------
        string searchstring, email, query;


        //----------------------------constructor with parameters-----------------------------------------------------------------------------------
        public SearchForm1(string searchstring, string email)
        {
            InitializeComponent();

            this.searchstring = searchstring;
            this.email = email;

            lbl_searchresult.Text = $"Search result for '{searchstring}'";
        }


        //--------------------------------------form load event------------------------------------------------------------------------
        private void SearchForm1_Load(object sender, EventArgs e)
        {
            try
            {
                query = $"select * from ArtworkDetails where title like'%{searchstring}%' " +
                        $"or  medium like'%{searchstring}%' " +
                        $"or artistname like'%{searchstring}%' or hashtags like'%{searchstring}%'";

                SqlDataReader r = d.GetSqlDataReader(query);

                if (r != null && r.HasRows)
                {
                    r.Read();

                    lbl_desc1.Text = r["title"].ToString();
                    lbl_price1.Text = r["price"].ToString();
                    pbx_img1.ImageLocation = r["img"].ToString();
                    lbl_artworkid1.Text = r["id"].ToString();

                    lbl_desc1.Visible = true;
                    lbl_price1.Visible = true;
                    pbx_img1.Visible = true;

                    if (r != null && r.HasRows)
                    {
                        r.Read();

                        lbl_desc2.Text = r["title"].ToString();
                        lbl_price2.Text = r["price"].ToString();
                        pbx_img2.ImageLocation = r["img"].ToString();
                        lbl_artworkid2.Text = r["id"].ToString();

                        lbl_desc2.Visible = true;
                        lbl_price2.Visible = true;
                        pbx_img2.Visible = true;

                        if (r != null && r.HasRows)
                        {
                            r.Read();

                            lbl_desc3.Text = r["title"].ToString();
                            lbl_price3.Text = r["price"].ToString();
                            lbl_artworkid3.Text = r["id"].ToString();
                            pbx_img3.ImageLocation = r["img"].ToString();

                            lbl_desc3.Visible = true;
                            lbl_price3.Visible = true;
                            pbx_img3.Visible = true;

                            if (r != null && r.HasRows)
                            {
                                r.Read();

                                lbl_desc4.Text = r["title"].ToString();
                                lbl_price4.Text = r["price"].ToString();
                                pbx_img4.ImageLocation = r["img"].ToString();
                                lbl_artworkid4.Text = r["id"].ToString();

                                lbl_desc4.Visible = true;
                                lbl_price4.Visible = true;
                                pbx_img4.Visible = true;

                                if (r != null && r.HasRows)
                                {
                                    r.Read();

                                    lbl_desc5.Text = r["title"].ToString();
                                    lbl_price5.Text = r["price"].ToString();
                                    pbx_img5.ImageLocation = r["img"].ToString();
                                    lbl_artworkid5.Text = r["id"].ToString();

                                    lbl_desc5.Visible = true;
                                    lbl_price5.Visible = true;
                                    pbx_img5.Visible = true;


                                    if (r != null && r.HasRows)
                                    {
                                        r.Read();

                                        lbl_desc6.Text = r["title"].ToString();
                                        lbl_price6.Text = r["price"].ToString();
                                        pbx_img6.ImageLocation = r["img"].ToString();
                                        lbl_artworkid6.Text = r["id"].ToString();

                                        lbl_desc6.Visible = true;
                                        lbl_price6.Visible = true;
                                        pbx_img6.Visible = true;

                                        if (r != null && r.HasRows)
                                        {
                                            r.Read();

                                            lbl_desc7.Text = r["title"].ToString();
                                            lbl_price7.Text = r["price"].ToString();
                                            pbx_img7.ImageLocation = r["img"].ToString();
                                            lbl_artworkid7.Text = r["id"].ToString();

                                            lbl_desc7.Visible = true;
                                            lbl_price7.Visible = true;
                                            pbx_img7.Visible = true;

                                            if (r != null && r.HasRows)
                                            {
                                                r.Read();

                                                lbl_desc8.Text = r["title"].ToString();
                                                lbl_price8.Text = r["price"].ToString();
                                                pbx_img8.ImageLocation = r["img"].ToString();
                                                lbl_artworkid8.Text = r["id"].ToString();

                                                lbl_desc8.Visible = true;
                                                lbl_price8.Visible = true;
                                                pbx_img8.Visible = true;

                                                if (r != null && r.HasRows)
                                                {
                                                    r.Read();

                                                    lbl_desc9.Text = r["title"].ToString();
                                                    lbl_price9.Text = r["price"].ToString();
                                                    pbx_img9.ImageLocation = r["img"].ToString();
                                                    lbl_artworkid9.Text = r["id"].ToString();

                                                    lbl_desc9.Visible = true;
                                                    lbl_price9.Visible = true;
                                                    pbx_img9.Visible = true;

                                                    if (r != null && r.HasRows)
                                                    {
                                                        r.Read();

                                                        lbl_desc10.Text = r["title"].ToString();
                                                        lbl_price10.Text = r["price"].ToString();
                                                        pbx_img10.ImageLocation = r["img"].ToString();
                                                        lbl_artworkid10.Text = r["id"].ToString();

                                                        lbl_desc10.Visible = true;
                                                        lbl_price10.Visible = true;
                                                        pbx_img10.Visible = true;

                                                        if (r != null && r.HasRows)
                                                        {
                                                            r.Read();

                                                            lbl_desc11.Text = r["title"].ToString();
                                                            lbl_price11.Text = r["price"].ToString();
                                                            pbx_img11.ImageLocation = r["img"].ToString();
                                                            lbl_artworkid11.Text = r["id"].ToString();

                                                            lbl_desc11.Visible = true;
                                                            lbl_price11.Visible = true;
                                                            pbx_img11.Visible = true;

                                                            if (r != null && r.HasRows)
                                                            {
                                                                r.Read();

                                                                lbl_desc12.Text = r["title"].ToString();
                                                                lbl_price12.Text = r["price"].ToString();
                                                                pbx_img12.ImageLocation = r["img"].ToString();
                                                                lbl_artworkid12.Text = r["id"].ToString();

                                                                lbl_desc12.Visible = true;
                                                                lbl_price12.Visible = true;
                                                                pbx_img12.Visible = true;

                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }

                                    }

                                }

                            }

                        }

                    }

                    r.Close();
                }
                else
                {
                    lbl_searchresult.Text = $"No result found for search '{searchstring}'";
                }
            }
            catch (Exception ex) { }

        }

        private void pbx_img1_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid1.Text), email);
            p.ShowDialog();
        }

        private void pbx_img2_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid2.Text), email);
            p.ShowDialog();
        }

        private void pbx_img3_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid3.Text), email);
            p.ShowDialog();
        }

        private void pbx_img4_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid4.Text), email);
            p.ShowDialog();
        }

        private void pbx_img5_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid5.Text), email);
            p.ShowDialog();
        }

        private void pbx_img6_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid6.Text), email);
            p.ShowDialog();
        }

        private void pbx_img7_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid7.Text), email);
            p.ShowDialog();
        }

        private void pbx_img8_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid8.Text), email);
            p.ShowDialog();
        }

        private void pbx_img9_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid9.Text), email);
            p.ShowDialog();
        }

        private void pbx_img10_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid10.Text), email);
            p.ShowDialog();
        }

        private void pbx_img11_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid11.Text), email);
            p.ShowDialog();
        }

        private void pbx_img12_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid12.Text), email);
            p.ShowDialog();
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c = new ContactUsForm();
            c.ShowDialog();
        }
    }
}
