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
    public partial class EditMemberProfile : BaseForm
    {

        //---------------------------------DAL class object creation----------------------------------------------------------------------------------------------------

        DAL D = new DAL();




        //-----------------------------------------------------------------------------------------------------------------------------------------

        string email, artistname;

        static int id;
        //----------------------------------------------constructor------------------------------------------------------------------------------------------
        public EditMemberProfile(string email)
        {
            InitializeComponent();
            this.email = email;
        }




        //---------------------------------------save or update button click event------------------------------------------------------------------------------------------------

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do u want to save this information ?", "Save Profile", MessageBoxButtons.YesNo)
                    == DialogResult.No)
                    return;

                string query = $"update ArtistDetails set name = '{txt_artist_name.Text}', style = '{txt_artist_style.Text}', " +
                        $"bio = '{rtxt_artist_bio.Text}', profilephoto = '{txt_artist_photo.Text}' where emailid = '{email}'";


                int result = D.GetExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Data saved successfully......");
                    ClearAllControls(txt_artist_name, Controls);
                }
                else
                {
                    MessageBox.Show("Can't saved Something wrong.......");
                }
            }

            catch (Exception ex) { }
        }

        //---------------------------------------form load event----------------------------------------------------------------------------------------------------
        private void MemberLoginForm_Load(object sender, EventArgs e)
        {
            SetVisibility(txt_artist_name, Controls, false, "editmemberprofile");
            SetVisibility(txt_artworkname, Controls, false, "updateartwork");
            SetVisibility(txt_artworkname, Controls, false, "Textupdateartwork");
            SetVisibility(txt_artworkname, Controls, false, "Buttonupdateartwork");
            SetVisibility(txt_artworkname, Controls, true, "displayartwork");
            LoadArtworks();
        }

        private void pbx_editprofile_Click(object sender, EventArgs e)
        {
            SetVisibility(txt_artworkname, Controls, false, "displayartwork");
            SetVisibility(txt_artworkname, Controls, false, "updateartwork");
            SetVisibility(txt_artworkname, Controls, false, "Textupdateartwork");
            SetVisibility(txt_artworkname, Controls, false, "Buttonupdateartwork");
            SetVisibility(txt_artist_name, Controls, true, "editmemberprofile");

            try
            {
                string query = $"select * from ArtistDetails where emailid = '{email}' ";

                SqlDataReader rdr = D.GetSqlDataReader(query);

                if (rdr != null && rdr.HasRows)
                {
                    rdr.Read();

                    txt_artist_name.Text = rdr["name"].ToString();
                    txt_artist_style.Text = rdr["style"].ToString();
                    rtxt_artist_bio.Text = rdr["bio"].ToString();
                    txt_artist_photo.Text = rdr["profilephoto"].ToString();
                    pbx_profileimg.ImageLocation = @txt_artist_photo.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_uploadartworkimg_Click(object sender, EventArgs e)
        {
            try
            {
                String query;

                query = "select max(id) from ArtworkDetails ";

                Object obj = D.GetExecuteScaler(query);

                if (obj == null)
                {
                    id = 0;
                }
                else
                {
                    id = Convert.ToInt32(obj.ToString());
                }

                id++;
                query = $"insert into ArtworkDetails values({id},'{txt_artworkname.Text}','{txt_artworksize.Text}','{txt_arworkmedium.Text}','{txt_artworkyear.Text}','{txt_artworkprice.Text}','{txt_artworkimglocation.Text}','{lbl_displayartistname.Text}','{email}','{txt_hashtags.Text}','available')";

                int result = D.GetExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Artwork Uploaded successfully....");
                    ClearAllControls(txt_artworkname, Controls);
                }
                else
                {
                    MessageBox.Show("Cant Upload!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbx_addartwork_Click(object sender, EventArgs e)
        {
            SetVisibility(txt_artworkname, Controls, false, "displayartwork");
            SetVisibility(txt_artist_name, Controls, false, "editmemberprofile");
            SetVisibility(txt_artworkname, Controls, true, "updateartwork");
            SetVisibility(txt_artworkname, Controls, true, "Textupdateartwork");
            SetVisibility(txt_artworkname, Controls, true, "Buttonupdateartwork");
        }

        private void pbx_changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(email, true);
            c.ShowDialog();
        }

        private void pbx_artworkgallery_Click(object sender, EventArgs e)
        {
            SetVisibility(txt_artist_name, Controls, false, "editmemberprofile");
            SetVisibility(txt_artworkname, Controls, false, "updateartwork");
            SetVisibility(txt_artworkname, Controls, false, "Textupdateartwork");
            SetVisibility(txt_artworkname, Controls, false, "Buttonupdateartwork");
            SetVisibility(txt_artworkname, Controls, true, "displayartwork");
            LoadArtworks();
        }

        private void LoadArtworks()
        {
            try
            {
                string query = $"select * from ArtworkDetails where artistemail= '{email}'";

                SqlDataReader r = D.GetSqlDataReader(query);

                if (r != null && r.HasRows)
                {
                    r.Read();

                    lbl_displayartistname.Text = r["artistname"].ToString();

                    pbx_artwork1.ImageLocation = r["img"].ToString();
                    pbx_artwork1.Visible = true;

                    r.Read();
                    pbx_artwork2.ImageLocation = r["img"].ToString();
                    pbx_artwork2.Visible = true;

                    r.Read();
                    pbx_artwork3.ImageLocation = r["img"].ToString();
                    pbx_artwork3.Visible = true;

                    r.Read();
                    pbx_artwork4.ImageLocation = r["img"].ToString();
                    pbx_artwork4.Visible = true;

                    r.Read();
                    pbx_artwork5.ImageLocation = r["img"].ToString();
                    pbx_artwork5.Visible = true;

                    r.Read();
                    pbx_artwork6.ImageLocation = r["img"].ToString();
                    pbx_artwork6.Visible = true;

                    r.Read();
                    pbx_artwork7.ImageLocation = r["img"].ToString();
                    pbx_artwork7.Visible = true;

                    r.Read();
                    pbx_artwork8.ImageLocation = r["img"].ToString();
                    pbx_artwork8.Visible = true;

                    r.Read();
                    pbx_artwork9.ImageLocation = r["img"].ToString();
                    pbx_artwork9.Visible = true;

                    r.Read();
                    pbx_artwork10.ImageLocation = r["img"].ToString();
                    pbx_artwork10.Visible = true;

                    r.Read();
                    pbx_artwork11.ImageLocation = r["img"].ToString();
                    pbx_artwork11.Visible = true;

                    r.Read();
                    pbx_artwork12.ImageLocation = r["img"].ToString();
                    pbx_artwork12.Visible = true;

                    r.Read();
                    pbx_artwork13.ImageLocation = r["img"].ToString();
                    pbx_artwork13.Visible = true;

                    r.Read();
                    pbx_artwork14.ImageLocation = r["img"].ToString();
                    pbx_artwork14.Visible = true;

                    r.Read();
                    pbx_artwork15.ImageLocation = r["img"].ToString();
                    pbx_artwork15.Visible = true;
                }
                r.Close();
            }
            catch (Exception ex) { }

        }

        private void pbx_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have logged out successfully.....");
            this.Close();
            HomePageForm h = new HomePageForm();
            h.ShowDialog();
        }
    }
}
