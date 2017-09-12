using System;
using System.Web;
using System.Web.UI;

namespace Demo
{

    public partial class login : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
            //account.Value = "FFFF";
		}


		protected void login_OnClick(object Source, EventArgs e)
		{
            if( account.Value.CompareTo("blockfuture123") == 0 && password.Value.CompareTo("WallStreet666") == 0 ) {
                Response.Write("<script>alert('登入成功!'); location.href='profit.aspx'; </script>");
                Session["login"] = "YES";
            }
            else{
                Response.Write("<script>alert('帳號或密碼有誤'); </script>");
            }
			//

		}



    }


	

}
