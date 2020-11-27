using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace project
{
    public partial class customer_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            if (Request.QueryString["ID"] != null)
            {
                SqlConnection con = new SqlConnection(mainconn);
                string query = "select customer_id,first_name,last_name,phone_number,email_id,state,country,pincode from customer_tb inner join customer_details_tb on customer_tb.customer_id="+Request.QueryString["ID"].ToString()+" and customer_details_tb.customerD_id="+Request.QueryString["ID"].ToString()+"";
                SqlDataAdapter da = new SqlDataAdapter(query,con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Label1.Text = "customer Id :" + ds.Tables[0].Rows[0]["customer_ID"].ToString() + "<br/>" +
                    //    "First name :" + ds.Tables[0].Rows[0][1].ToString() + "<br/>" +
                    //    "Last name :" + ds.Tables[0].Rows[0][2].ToString() + "<br/>" +
                    //    "phone no :" + ds.Tables[0].Rows[0][3].ToString() + "<br/>" +
                    //    "email :" + ds.Tables[0].Rows[0][4].ToString() + "<br/>" +
                    //    "state :" + ds.Tables[0].Rows[0][5].ToString() + "<br/>" +
                    //    "country :" + ds.Tables[0].Rows[0][6].ToString() + "<br/>" +
                    //    "pincode :" + ds.Tables[0].Rows[0][7].ToString() + "<br/>";
                    TextBox1.Text = ds.Tables[0].Rows[0]["customer_ID"].ToString();
                    TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                    TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                    TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                    TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                    TextBox6.Text = ds.Tables[0].Rows[0][5].ToString();
                    TextBox7.Text = ds.Tables[0].Rows[0][6].ToString();
                    TextBox8.Text = ds.Tables[0].Rows[0][7].ToString();
                }

            }
        }

    }
}