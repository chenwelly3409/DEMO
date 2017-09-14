using System;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{

    public partial class wallet : System.Web.UI.Page
    {

		

		protected void Page_Load(object sender, EventArgs e)
		{
            if (Convert.ToString(Session["login"]) == "")
			{
				Response.Write("<script>alert('請先登入!'); location.href='index.aspx'; </script>");

			}
			else
			{

                if (Convert.ToString(Session["login"]) == "blockfuture123") {
                    //file("blockfuture123");
                    BTC.Text = "0.00";
                    ETH.Text = "2.985800";
                    ZEC.Text = "0.00";
                    LTC.Text = "0.00";
                   // sum.Text = "0.00";
                    BTC_in.Text = "1PA58hjHVATxqLRM5yzXw8xdhiT7effiwu";
                    ETH_in.Text = "0x0b067b1bf04c8044fdcaaa4b90318cf96b4d6143";
                    ZEC_in.Text = "LPzjgZr5HGDNUKkyj61j5Md6xruGn5CiYT";
                    LTC_in.Text = "t1KADDMNSPpt8NMdbe1icqUZRmZMYqb1AAZ";
                }
				else if (Convert.ToString(Session["login"]) == "blockfuture456")
				{
                    //file("blockfuture456");
                    BTC.Text = "0.00";
                    ETH.Text = "0.00";
                    ZEC.Text = "0.00";
                    LTC.Text = "0.00";
                   // sum.Text = "0.00";
                    BTC_in.Text = "1Q3GUm3xEXp5PPzVf4EfApGuYEbmCgHcwv";
					ETH_in.Text = "0x7aeb6caa2783740e06077ed179a4b699613d001a";
					ZEC_in.Text = "t1PSQG6HAnUxTFbdsNJuGvMp2g6XuiS7jAZ";
					LTC_in.Text = "Las7242G75zB9pMepcuofwgRm3FAWvLeun";
				}
				else if (Convert.ToString(Session["login"]) == "blockfuture789")
				{
                    //file("blockfuture789");
                    BTC.Text = "0.999000";
                    ETH.Text = "0.00";
                    ZEC.Text = "0.00";
                    LTC.Text = "0.00";
                    //sum.Text = "0.999000 BTC";
                    BTC_in.Text = "1Ep1rfnDdXzDxTkSdYSrrbgHft34uJCMna";
					ETH_in.Text = "0x1a5cfb5408686c6559ee8c37a9a1ea35f712b366";
					ZEC_in.Text = "LiCJ2abZQjLgHjH5xBVYkCBeoKKLG9pjLm";
					LTC_in.Text = "t1Wxmob5YHv8YUN8sRCptQgFjsx3u6kwXzA";
				}


			}

		} // Pg_load

        protected void file(string name){
			try
			{   // Open the text file using a stream reader.
				using (StreamReader sr = new StreamReader(name+".json"))
				{
					// Read the stream to a string, and write the string to the console.
					String line = sr.ReadToEnd();
                    string[] DATA = line.Split(',');
                    BTC.Text = DATA[0];
                    ETH.Text = DATA[1];
                    ZEC.Text = DATA[2];
                    LTC.Text = DATA[3];
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}
        }

		




	}
}
