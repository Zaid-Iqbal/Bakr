using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakr
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            #region Initialize Logos and Sign In Boxes
            FacebookLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Facebook Logo.png");
            FacebookLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            FacebookPasswordBox.PasswordChar = '\0';

            TwitterLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Twitter Logo.png");
            TwitterLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TwitterPasswordBox.PasswordChar = '\0';

            InstagramLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Instagram Logo.png");
            InstagramLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            InstagramPasswordBox.PasswordChar = '\0';

            RedditLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Reddit Logo.png");
            RedditLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            RedditPasswordBox.PasswordChar = '\0';

            YoutubeLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Youtube Logo.png");
            YoutubeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            YoutubePasswordBox.PasswordChar = '\0';

            TikTokLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Tik Tok Logo.png");
            TikTokLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TikTokPasswordBox.PasswordChar = '\0';

            LinkedInLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\LinkedIn Logo.png");
            LinkedInLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            LinkedInPasswordBox.PasswordChar = '\0';

            TumblrLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Tumblr Logo.png");
            TumblrLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TumblrPasswordBox.PasswordChar = '\0';

            GmailLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Gmail Logo.png");
            GmailLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            GmailPasswordBox.PasswordChar = '\0';

            YahooMailLogo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Yahoo Mail Logo.png");
            YahooMailLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            YahooMailPasswordBox.PasswordChar = '\0';

            #endregion


        }

        #region METHODS

        public static void WelcomePage()
        {

        }

        public static void StartFeed()
        {

        }

        #endregion

        #region EVENTS

        private void ShowPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HidePasswordBox.Checked == true)
            {
                FacebookPasswordBox.PasswordChar = '*';
            }
            else 
            {
                FacebookPasswordBox.PasswordChar = '\0';
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Accidents
        private void WelcomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}
