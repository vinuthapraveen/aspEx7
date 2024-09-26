using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspEx7
{
    public partial class adminn : System.Web.UI.Page
    {
        ConnectionClasss conobj = new ConnectionClasss();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select max(regid) from Loogin";
            string regid = conobj.Scalar_Fn(sel);
            int reggid = 0;
            if (regid == "")
            {
                reggid = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reggid = newregid + 1;
            }
            string ins = "insert into AdminReg values(" + reggid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = conobj.NonQuery_Fn(ins);
            if (i == 1)
            {
                string inslog = "insert into Loogin values(" + reggid + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
                int j = conobj.NonQuery_Fn(inslog);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}