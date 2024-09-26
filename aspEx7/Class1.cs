using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace aspEx7
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;
        public Class1()
        {
            con = new SqlConnection(@"server=LAPTOP-3QUP4DAV\SQLEXPRESS;database=juneasp;Integrated security=true");
        }
    public int NonQuery_Fn(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Scalar_Fn(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}