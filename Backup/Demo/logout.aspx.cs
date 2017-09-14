using System;
using System.Web;
using System.Web.UI;

namespace Demo
{

    public partial class logout : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
		{
			Session.Abandon();
			Response.Redirect("index.aspx");
		}
    }
}
