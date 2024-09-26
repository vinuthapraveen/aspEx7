using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace aspEx7
{
    public partial class DocProf : System.Web.UI.Page
    {
        ConnectionClasss conobj = new ConnectionClasss();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select name,age,department,photo from DoctorRerg where doc_id=" + Session["uid"] + "";

                SqlDataReader dr = conobj.Reader_Fn(sel);
                while (dr.Read())
                {
                    TextBox3.Text = dr["name"].ToString();
                    TextBox4.Text = dr["age"].ToString();
                    
                    TextBox5.Text = dr["department"].ToString();
                    Image1.ImageUrl = dr["photo"].ToString();
                }
                
            }
    }
}