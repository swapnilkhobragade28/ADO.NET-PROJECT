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
    public partial class ArtistDetails : BaseForm
    {

        //----------------------------DAL CLASS OBJECT CREATION-----------------------------------------------------------------------------
        DAL d = new DAL();


        //-------------------------------------------------------------------------------------------------------------
        string emailid;
        string[] bio;


        //------------------------------------CONSTRUCTOR WITH PARAMETERS---------------------------------------------------------------------------
        public ArtistDetails(string emailid)
        {
            InitializeComponent();
            this.emailid = emailid;
        }


        //-----------------------------------------------FORM LOAD EVENT--------------------------------------------------------------
        private void ArtistDetails_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"Select * from ArtistDetails where emailid='{emailid}'";
                SqlDataReader rdr = d.GetSqlDataReader(query);

                if (rdr != null && rdr.HasRows)
                {
                    rdr.Read();

                    pbx_photo.Visible = true;
                    lbl_name.Visible = true;
                    lbl_bio.Visible = true;

                    pbx_photo.ImageLocation = rdr["profilephoto"].ToString();
                    lbl_name.Text = rdr["name"].ToString();
                    bio = (rdr["bio"].ToString()).Split('.');

                    rdr.Close();
                }

                if (bio[0] != null)
                {
                    lbl_bioline1.Text = bio[0];

                    if (bio[1] != null)
                    {
                        lbl_bioline2.Text = bio[1];

                        if (bio[2] != null)
                        {
                            lbl_bioline3.Text = bio[2];

                            if (bio[3] != null)
                            {
                                lbl_bioline4.Text = bio[3];

                                if (bio[4] != null)
                                {
                                    lbl_bioline5.Text = bio[4];

                                    if (bio[5] != null)
                                    {
                                        lbl_bioline6.Text = bio[5];
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    throw new Exception("Bio not found");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            try
            {

                string query = $"Select * from ArtworkDetails where artistemail='{emailid}'";
                SqlDataReader rdr2 = d.GetSqlDataReader(query);

                if (rdr2 != null && rdr2.HasRows)
                {
                    rdr2.Read();
                    pbx_artwork1.ImageLocation = rdr2["img"].ToString();
                    pbx_artwork1.Visible = true;
                    lbl_artworkid1.Text = rdr2["id"].ToString();

                    if (rdr2 != null && rdr2.HasRows)
                    {
                        rdr2.Read();
                        pbx_artwork2.ImageLocation = rdr2["img"].ToString();
                        pbx_artwork2.Visible = true;
                        lbl_artworkid2.Text = rdr2["id"].ToString();


                        if (rdr2 != null && rdr2.HasRows)
                        {
                            rdr2.Read();
                            pbx_artwork3.ImageLocation = rdr2["img"].ToString();
                            pbx_artwork3.Visible = true;
                            lbl_artworkid3.Text = rdr2["id"].ToString();


                            if (rdr2 != null && rdr2.HasRows)
                            {
                                rdr2.Read();
                                pbx_artwork4.ImageLocation = rdr2["img"].ToString();
                                pbx_artwork4.Visible = true;
                                lbl_artworkid4.Text = rdr2["id"].ToString();


                                if (rdr2 != null && rdr2.HasRows)
                                {
                                    rdr2.Read();
                                    pbx_artwork5.ImageLocation = rdr2["img"].ToString();
                                    pbx_artwork5.Visible = true;
                                    lbl_artworkid5.Text = rdr2["id"].ToString();


                                    if (rdr2 != null && rdr2.HasRows)
                                    {
                                        rdr2.Read();
                                        pbx_artwork6.ImageLocation = rdr2["img"].ToString();
                                        pbx_artwork6.Visible = true;
                                        lbl_artworkid6.Text = rdr2["id"].ToString();


                                        if (rdr2 != null && rdr2.HasRows)
                                        {
                                            rdr2.Read();
                                            pbx_artwork7.ImageLocation = rdr2["img"].ToString();
                                            pbx_artwork7.Visible = true;
                                            lbl_artworkid7.Text = rdr2["id"].ToString();

                                            if (rdr2 != null && rdr2.HasRows)
                                            {
                                                rdr2.Read();
                                                pbx_artwork8.ImageLocation = rdr2["img"].ToString();
                                                pbx_artwork8.Visible = true;
                                                lbl_artworkid8.Text = rdr2["id"].ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    rdr2.Close();
                }
            }
            catch (Exception ex) { }
        }


        //--------------------------------------artworks click event----------------------------------------------------------------------
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

        private void pbx_artwork7_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid7.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_artwork8_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder(Convert.ToInt32(lbl_artworkid8.Text), emailid);
            p.ShowDialog();
        }

        private void pbx_logo_Click(object sender, EventArgs e)
        {
            ContactUsForm c=new ContactUsForm();
            c.ShowDialog();
        }
    }
}
