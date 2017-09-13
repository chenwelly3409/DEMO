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
                file();
			}

		} // Pg_load

        protected void file(){
			try
			{   // Open the text file using a stream reader.
				using (StreamReader sr = new StreamReader("data.json"))
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
