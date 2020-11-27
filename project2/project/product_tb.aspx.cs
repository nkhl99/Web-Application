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
    public partial class product_tb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            if (Request.QueryString["ID"] != null)
            {
                SqlConnection con = new SqlConnection(mainconn);
                string query = "select product_id,product_name,product_price,date,manufacture,rating from product_tb inner join product_details_tb on product_tb.product_id=" + Request.QueryString["ID"].ToString() + " and product_details_tb.productD_id=" + Request.QueryString["ID"].ToString() + "";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Label1.Text = "product Id :" + ds.Tables[0].Rows[0][0].ToString() + "<br/>" +
                        "product name :" + ds.Tables[0].Rows[0][1].ToString() + "<br/>" +
                        "product price :" + ds.Tables[0].Rows[0][2].ToString() + "<br/>" +
                        "product date :" + ds.Tables[0].Rows[0][3].ToString() + "<br/>" +
                        "manufracture :" + ds.Tables[0].Rows[0][4].ToString() + "<br/>" +
                        "rating :" + ds.Tables[0].Rows[0][5].ToString() + "<br/>";

                }

            }
        }
    }
}