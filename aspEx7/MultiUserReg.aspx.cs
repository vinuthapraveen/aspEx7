using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace aspEx7
{
    public partial class MultiUserReg : System.Web.UI.Page
    {
        Class1 conobj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(reg_id) from Loginn";
            string regid = conobj.Scalar_Fn(sel);
            int reggid = 0;
            if(regid=="")
            {
                reggid = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reggid = newregid + 1;
            }
            string ins = "insert into UserRegs values("+reggid+",'"+TextBox1.Text+ "','" + TextBox2.Text + "')";
            int i = conobj.NonQuery_Fn(ins);
            if(i==1)
            {
                string inslog = "insert into Loginn values(" + reggid + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
               int j = conobj.NonQuery_Fn(inslog);
            }
        }
    }
}