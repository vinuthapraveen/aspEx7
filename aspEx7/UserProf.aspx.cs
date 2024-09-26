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
    public partial class UserProf : System.Web.UI.Page
    {
        ConnectionClasss conobj = new ConnectionClasss();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select name,address,photo from RegForm where id=" + Session["uid"] + "";
            SqlDataReader dr = conobj.Reader_Fn(sel);

            while (dr.Read())
            {
                TextBox1.Text = dr["name"].ToString();
                TextBox2.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["photo"].ToString();
            }
            DataSet ds = conobj.Dataset_Fn(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataTable dt = conobj.Datatable_Fn(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();


        }

      
    }
}