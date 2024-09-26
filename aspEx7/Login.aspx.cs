using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data;
//using System.Data.SqlClient;

namespace aspEx7
{
    public partial class Login : System.Web.UI.Page
    {
        Class1 conobj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(reg_id) from Loginn where username='"+TextBox1.Text+ "' and password='" + TextBox2.Text + "'  ";
            string cid = conobj.Scalar_Fn(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select reg_id from Loginn where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'  ";
                string regid = conobj.Scalar_Fn(str1);
                Session["userid"] = regid;
                string str2 = "select log_type from Loginn where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'  ";
                string logtype = conobj.Scalar_Fn(str2);
                if (logtype == "admin")
                {
                    Label1.Text = "Admin";
                }
                else if (logtype == "user")
                {
                    Label1.Text = "User";
                }
            }

            else
            {
                Label1.Text = "Invalid Username and Password";
            }
            
        }
    }
}