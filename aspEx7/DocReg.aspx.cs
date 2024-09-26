using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace aspEx7
{
    public partial class DocReg : System.Web.UI.Page
    {
        Class1 conobj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(reg_id) from Loogin";
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
            string p = "~/Photoos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into DoctRerg values(" + reggid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + p + "','" + TextBox4.Text + "','" + TextBox2.Text + "')";
            int i = conobj.NonQuery_Fn(ins);
            if (i == 1)
            {
                string inslog = "insert into Loogin values(" + reggid + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','user','active')";
                int j = conobj.NonQuery_Fn(inslog);
            }
        }
    }
}