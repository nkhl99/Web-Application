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
        string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    SqlConnection con = new SqlConnection(mainconn);
                    string query = "select customer_id,first_name,last_name,phone_number,email_id,state,country,pincode from customer_tb inner join customer_details_tb on customer_tb.customer_id=" + Request.QueryString["ID"].ToString() + " and customer_details_tb.customerD_id=" + Request.QueryString["ID"].ToString() + "";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
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
                        Button2.Enabled = false;
                        Button5.Enabled = false;
                    }
                    string forgrid = "select * from sales_tb where customerS_name='" + ds.Tables[0].Rows[0][1].ToString() + "'";
                    SqlDataAdapter da2 = new SqlDataAdapter(forgrid, con);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    GridView1.DataSource = ds2;
                    GridView1.DataBind();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button2.Enabled = true;
            Button5.Enabled = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Label1.Text = "New Blank Form Has Been Added.";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (TextBox2.Text != "" && TextBox4.Text != "" && TextBox8.Text != "")
            {
                try
                {
                    String query = "insert into customer_tb values('" + TextBox2.Text + "','" + TextBox3.Text + "')";

                    // String mycon = "Data Source=HP-PC\\SQLEXPRESS; Initial Catalog=CollegeData; Integrated Security=true";
                    SqlConnection con = new SqlConnection(mainconn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    string querys = "select top 1 * from customer_tb order by customer_id desc";
                    SqlDataAdapter da = new SqlDataAdapter(querys, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    String query2 = "insert into customer_details_tb(customerD_id,phone_number,email_id,state,country,pincode) values('" + ds.Tables[0].Rows[0]["customer_ID"].ToString() + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')";
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = query2;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                    TextBox1.Text = ds.Tables[0].Rows[0]["customer_id"].ToString();
                    con.Close();
                    Button1.Enabled = true;
                    Button3.Enabled = true;
                    Button4.Enabled = true;
                    Button2.Enabled = false;

                    //TextBox1.Text = "";
                    //TextBox2.Text = "";
                    //TextBox3.Text = "";
                    //TextBox4.Text = "";
                    //TextBox5.Text = "";
                    //TextBox6.Text = "";
                    //TextBox7.Text = "";
                    //TextBox8.Text = "";
                    //TextBox2.Enabled = false;
                    //TextBox3.Enabled = false;
                    //TextBox4.Enabled = false;
                    Label1.Text = "Data Has Been Saved Successfully";
                }
                catch (Exception)
                {

                    Label1.Text = "unable to add please check the value";
                }
            }
            else
            {
                Label1.Text = "please add name,phone number and pincode";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                String updatedata = "Update customer_tb set first_name='" + TextBox2.Text + "', last_name='" + TextBox3.Text + "' where customer_id=" + TextBox1.Text;
                String updatedata2 = "Update customer_details_tb set phone_number='" + TextBox4.Text + "', email_id='" + TextBox5.Text + "', state='" + TextBox6.Text + "', country='" + TextBox7.Text + "', pincode='" + TextBox8.Text + "' where customerD_id=" + TextBox1.Text;
                SqlConnection con = new SqlConnection(mainconn);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata2;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = updatedata;
                cmd2.Connection = con;
                cmd2.ExecuteNonQuery();
                con.Close();

                Label1.Text = "Particular Record Has Been Updated Successfully : customer ID " + TextBox1.Text;
                Button1.Enabled = true;
                Button2.Enabled = false;
                Button4.Enabled = true;
                Button5.Enabled = true;
            }
            catch (Exception)
            {

                Label1.Text = "unable to update please check the values";
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
            String updatedata = "delete from customer_tb where customer_id=" + TextBox1.Text;
            String updatedata2 = "delete from customer_details_tb where customerD_id=" + TextBox1.Text;
            SqlConnection con = new SqlConnection(mainconn);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata2;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = updatedata;
            cmd2.Connection = con;
            cmd2.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Particular Record Has Been Deleted Successfully : customer ID " + TextBox1.Text;
            Button1.Enabled = true;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button2.Enabled = false;
            Button5.Enabled = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Label1.Text = "Operation Has Been Cancelled Successfully";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string IDV = row.Cells[1].Text;
            HyperLink link = new HyperLink();
            link.Text = "view";
            link.NavigateUrl = "sales_tb.aspx?ID=" + IDV + "";
            row.Cells[0].Controls.Add(link);
        }

    }
}