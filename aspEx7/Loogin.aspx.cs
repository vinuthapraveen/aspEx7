﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace aspEx7
{
    public partial class Loogin : System.Web.UI.Page
    {
        ConnectionClasss conobj = new ConnectionClasss();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string selid = "select count(id) from Loogin where username='" + TextBox4.Text + "'and password='" + TextBox5.Text + "' ";
            string cid = conobj.Scalar_Fn(selid);
            if (cid == "1")
            {
                int id1 = 0;
                string s1 = "select id from RegForm" +
                    " where username='" + TextBox4.Text + "' and password='" + TextBox5.Text + "'";
                SqlDataReader dr = conobj.Reader_Fn(s1);
                while (dr.Read())
                {
                    id1 = Convert.ToInt32(dr["id"].ToString());
                }
                Session["uid"] = id1;
                Response.Redirect("DocProf.aspx");
            }
            else
            {
                Label1.Text = "invalid user";
            }
        }
    }
}