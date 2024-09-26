using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspEx7
{
    public partial class PresLayer : System.Web.UI.Page
    {
        ConnectionClasss conobj = new ConnectionClasss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photoos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string strinsert = "insert into RegForm values('"+TextBox2.Text+ "','" + TextBox3.Text + "','" + p + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = conobj.NonQuery_Fn(strinsert);
            if(i==1)
            {
                Label1.Text = "inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

        }
    }
}