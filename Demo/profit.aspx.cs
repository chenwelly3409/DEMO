using System;
using System.Web;
using System.Web.UI;

namespace Demo
{

    public partial class profit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
		{
		}


		protected void Start_OnClick(object Source, EventArgs e)
		{
            Session["start"] = "GOGO";
            Start.InnerText = "取消搬磚";



		}


	}
}
