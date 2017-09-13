using System;
using System.Web;
using System.Web.UI;
using System.IO;


namespace Demo
{

    public partial class profit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
				if (Convert.ToString(Session["login"]) == "")
				{
					Response.Write("<script>alert('請先登入!'); location.href='index.aspx'; </script>");

				}
				else
				{
					if (Convert.ToString(Session["start"]) != "")
					{
						Start.InnerText = "取消搬磚";

					}


					random();
				}
            }

			

        }

        protected bool AAAA(string name)
		{
			try
			{   // Open the text file using a stream reader.
				using (StreamReader sr = new StreamReader(name + ".json"))
				{
					// Read the stream to a string, and write the string to the console.
					String line = sr.ReadToEnd();
					string[] DATA = line.Split(',');

                    if( Convert.ToDouble(DATA[0]) == 0.0 && Convert.ToDouble(DATA[1]) == 0.0 &&
                       Convert.ToDouble(DATA[2]) == 0.0 && Convert.ToDouble(DATA[3]) == 0.0 ) {
						Response.Write("<script>alert('錢包餘額為0!'); </script>");
                        return false;
					}
                    else{
                        return true;
                    }

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
                return false;
			}


		}

        protected void Start_OnClick(object Source, EventArgs e)
        {
			if (Convert.ToString(Session["start"]) == "" )
			{
                string temp = "";

				if (Convert.ToString(Session["login"]) == "blockfuture123")
				{
					temp = "blockfuture123";
				}
				else if (Convert.ToString(Session["login"]) == "blockfuture456")
				{
                    temp = "blockfuture456";
				}
				else if (Convert.ToString(Session["login"]) == "blockfuture789")
				{
                    temp = "blockfuture789";
				}

				if (AAAA(temp))
				{
					Session["start"] = "GOGO";
					Start.InnerText = "取消搬磚";
				}


				//Response.Write("<script>alert('請先登入!'); location.href='Default.aspx'; </script>");
				

			}
            else if (Convert.ToString(Session["start"]) != null)
			{
                //Response.Write("<script>alert('請先登入!'); location.href='Default.aspx'; </script>");
                Session["start"] = "";
				Start.InnerText = "開始搬磚";

			}


        }
        protected void random() {
            exchange1.Text = exchangeGen();
            exchange2.Text = exchangeGen();
            exchange3.Text = exchangeGen();
            exchange4.Text = exchangeGen();
            coin1.Text = "BTC-ETH";
            coin2.Text = "BTC-LTC";
            coin3.Text = "BTC-ZEC";
            coin4.Text = "ETH-LTC";
            profit1.Text = profitValue().ToString();
            profit2.Text = profitValue().ToString();
            profit3.Text = profitValue().ToString();
            profit4.Text = profitValue().ToString();
        }
        protected string exchangeGen() {
            Random rnd1 = new Random(Guid.NewGuid().GetHashCode());
            Random rnd2 = new Random(Guid.NewGuid().GetHashCode());
            int exchangeType1, exchangeType2;
            string exchangeCombine = "";
            exchangeType1 = rnd1.Next(0, 5);
            exchangeType2 = rnd2.Next(0, 5);
            while (exchangeType2 == exchangeType1)
            {
                exchangeType2 = rnd2.Next(0, 5);
            }
            switch (exchangeType1)
            {
                case 0:
                    exchangeCombine += "Poloniex to ";
                    break;
                case 1:
                    exchangeCombine += "Bittrex to ";
                    break;
                case 2:
                    exchangeCombine += "Bitfinex to ";
                    break;
                case 3:
                    exchangeCombine += "BitStamp to ";
                    break;
                case 4:
                    exchangeCombine += "Bitbase to ";
                    break;
            }
            switch (exchangeType2)
            {
                case 0:
                    exchangeCombine += "Poloniex";
                    break;
                case 1:
                    exchangeCombine += "Bittrex";
                    break;
                case 2:
                    exchangeCombine += "Bitfinex";
                    break;
                case 3:
                    exchangeCombine += "BitStamp";
                    break;
                case 4:
                    exchangeCombine += "Bitbase";
                    break;
            }
            return exchangeCombine;
        }


        protected string coinTypeGen()
        {
            string coinType = "";
            Random rnd1 = new Random(Guid.NewGuid().GetHashCode());
            int coinRandom = rnd1.Next(0, 4);
            switch (coinRandom)
            {
                case 0:
                    coinType = "BTC";
                    break;
                case 1:
                    coinType = "ETH";
                    break;
                case 2:
                    coinType = "LTC";
                    break;
                case 3:
                    coinType = "ZEC";
                    break;

            }
            return coinType;
        }

        protected double profitValue() {
            
            Random rnd4 = new Random(Guid.NewGuid().GetHashCode());
            double prfitV = rnd4.NextDouble();
            prfitV = (prfitV * -1) + 0.04; 
            System.Diagnostics.Debug.WriteLine(prfitV);
            return prfitV;

        }
    }


}


