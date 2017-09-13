using System;
using System.Web;
using System.Web.UI;

namespace Demo
{

    public partial class login : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Convert.ToString(Session["login"]) == "")
			{
				//Response.Write("<script>alert('請先登入!'); location.href='Default.aspx'; </script>");

			}
			else
			{
				Response.Write("<script>location.href='profit.aspx'; </script>");
			}

		}


		protected void login_OnClick(object Source, EventArgs e)
		{
            if( account.Value.CompareTo("blockfuture123") == 0 && password.Value.CompareTo("WallStreet666") == 0 ) {
                Response.Write("<script>alert('登入成功!'); location.href='profit.aspx'; </script>");
                Session["login"] = "blockfuture123";
            }
			else if (account.Value.CompareTo("blockfuture456") == 0 && password.Value.CompareTo("WallStreet777") == 0)
			{
				Response.Write("<script>alert('登入成功!'); location.href='profit.aspx'; </script>");
				Session["login"] = "blockfuture456";
			}
			else if (account.Value.CompareTo("blockfuture789") == 0 && password.Value.CompareTo("WallStreet999") == 0)
			{
				Response.Write("<script>alert('登入成功!'); location.href='profit.aspx'; </script>");
				Session["login"] = "blockfuture789";
			}
            else{
                Response.Write("<script>alert('帳號或密碼有誤'); </script>");
            }
			//


		}



    }


	

}
