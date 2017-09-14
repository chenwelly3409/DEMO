using System;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

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
                    ETH.Text = "2.9917716";
                    ZEC.Text = "0.00";
                    LTC.Text = "0.00";
                    BTC_in.Text = "1PA58hjHVATxqLRM5yzXw8xdhiT7effiwu";
                    ETH_in.Text = "0x0b067b1bf04c8044fdcaaa4b90318cf96b4d6143";
                    ZEC_in.Text = "LPzjgZr5HGDNUKkyj61j5Md6xruGn5CiYT";
                    LTC_in.Text = "t1KADDMNSPpt8NMdbe1icqUZRmZMYqb1AAZ";


                    addHistory("2017/9/14 15:30","匯入","成功","2.985800 ETH");
                    addHistory("2017/9/14 16:44","0.011645", "成功" ,"+0.0021293 ETH");
                    addHistory("2017/9/14 17:03","0.008421", "成功", "+0.0017520 ETH");
                    addHistory("2017/9/14 19:27","0.007932", "失敗", "+0" );
                    addHistory("2017/9/14 21:46","0.006521","失敗","+0");
                    addHistory("2017/9/14 23:18","0.009130","成功","+0.0020903 ETH");
                    addHistory("2017/9/14 23:22","0.008212","失敗","+0");


                }
				else if (Convert.ToString(Session["login"]) == "blockfuture456")
				{
                    //file("blockfuture456");
                    BTC.Text = "0.00";
                    ETH.Text = "0.00";
                    ZEC.Text = "0.00";
                    LTC.Text = "0.00";
                    BTC_in.Text = "1Q3GUm3xEXp5PPzVf4EfApGuYEbmCgHcwv";
					ETH_in.Text = "0x7aeb6caa2783740e06077ed179a4b699613d001a";
					ZEC_in.Text = "t1PSQG6HAnUxTFbdsNJuGvMp2g6XuiS7jAZ";
					LTC_in.Text = "Las7242G75zB9pMepcuofwgRm3FAWvLeun";
				}
				else if (Convert.ToString(Session["login"]) == "blockfuture789")
				{
                    //file("blockfuture789");
                    BTC.Text = "1.000980";
                    ETH.Text = "0.00";
                    ZEC.Text = "0.00";
                    LTC.Text = "0.00";
                    BTC_in.Text = "1Ep1rfnDdXzDxTkSdYSrrbgHft34uJCMna";
					ETH_in.Text = "0x1a5cfb5408686c6559ee8c37a9a1ea35f712b366";
					ZEC_in.Text = "LiCJ2abZQjLgHjH5xBVYkCBeoKKLG9pjLm";
					LTC_in.Text = "t1Wxmob5YHv8YUN8sRCptQgFjsx3u6kwXzA";

                    addHistory("2017/9/14 12:01", "匯入", "成功", "0.999000 BTC");
                    addHistory("2017/9/14 14:30", "0.0021427", "成功", "+0.000772 BTC");
                    addHistory("2017/9/14 14:53", "0.00143112","失敗", "+0");
                    addHistory("2017/9/14 17:22", "0.00178002","失敗", "+0");
                    addHistory("2017/9/14 20:16","0.00501266","成功", "+0.001208 BTC");
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

		
        protected void addHistory(string stime, string sprofit, string sstate, string smount) {
			HtmlTableRow row = new HtmlTableRow();
			HtmlTableCell item_cell = new HtmlTableCell();
            item_cell.InnerHtml = stime;
			row.Cells.Add(item_cell);
			item_cell = new HtmlTableCell();
            item_cell.InnerHtml = sprofit;
			row.Cells.Add(item_cell);
			item_cell = new HtmlTableCell();
            item_cell.InnerHtml = sstate;
			row.Cells.Add(item_cell);
			item_cell = new HtmlTableCell();
            item_cell.InnerHtml = smount;
			row.Cells.Add(item_cell);

            history.Rows.Add(row);
        }



	}
}
