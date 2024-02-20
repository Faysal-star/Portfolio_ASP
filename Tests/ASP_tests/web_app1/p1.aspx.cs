using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_app1
{
    public partial class p1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void display_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(n1.Text) + Convert.ToDecimal(n2.Text);
            ans.Text = a.ToString("0.##");
        }

        protected void clr_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(n1.Text) - Convert.ToDecimal(n2.Text);
            ans.Text = a.ToString("0.##");
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(n1.Text) * Convert.ToDecimal(n2.Text);
            ans.Text = a.ToString("0.##");
        }

        protected void div_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(n2.Text) == 0)
            {
                ans.Text = "0 div error";
            }
            else
            {
                decimal a = Convert.ToDecimal(n1.Text) / Convert.ToDecimal(n2.Text);
                ans.Text = ans.Text = a.ToString("0.##");
            }
        }
    }
}