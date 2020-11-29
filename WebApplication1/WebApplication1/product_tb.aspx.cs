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
        string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    SqlConnection con = new SqlConnection(mainconn);
                    string query = "select product_id,product_name,product_price,manufacture,rating from product_tb inner join product_details_tb on product_tb.product_id=" + Request.QueryString["ID"].ToString() + " and product_details_tb.productD_id=" + Request.QueryString["ID"].ToString() + "";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //Label1.Text = "product Id :" + ds.Tables[0].Rows[0][0].ToString() + "<br/>" +
                        //    "product name :" + ds.Tables[0].Rows[0][1].ToString() + "<br/>" +
                        //    "product price :" + ds.Tables[0].Rows[0][2].ToString() + "<br/>" +
                        //    //"product date :" + ds.Tables[0].Rows[0][3].ToString() + "<br/>" +
                        //    "manufracture :" + ds.Tables[0].Rows[0][3].ToString() + "<br/>" +
                        //    "rating :" + ds.Tables[0].Rows[0][4].ToString() + "<br/>";

                        TextBox1.Text = ds.Tables[0].Rows[0]["product_id"].ToString();
                        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                        TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                        TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                        Button2.Enabled = false;
                        Button5.Enabled = false;
                    }

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

            Label1.Text = "New Blank Form Has Been Added.";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != "")
            {
                try
                {
                    String query = "insert into product_tb values('" + TextBox2.Text + "'," + TextBox3.Text + ")";

                    // String mycon = "Data Source=HP-PC\\SQLEXPRESS; Initial Catalog=CollegeData; Integrated Security=true";
                    SqlConnection con = new SqlConnection(mainconn);
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = query;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                    string querys = "select top 1 * from product_tb order by product_id desc";
                    SqlDataAdapter da = new SqlDataAdapter(querys, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    String query2 = "insert into product_details_tb values(" + ds.Tables[0].Rows[0]["product_id"].ToString() + ",'" + TextBox4.Text + "','" + TextBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query2;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    TextBox1.Text = ds.Tables[0].Rows[0]["product_id"].ToString();
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
            else { Label1.Text = "please enter name"; }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                String updatedata = "Update product_tb set product_name='" + TextBox2.Text + "', product_price='" + TextBox3.Text + "' where product_id=" + TextBox1.Text;
                String updatedata2 = "Update product_details_tb set manufacture='" + TextBox4.Text + "', rating='" + TextBox5.Text + "' where productD_id=" + TextBox1.Text;
                SqlConnection con = new SqlConnection(mainconn);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = updatedata2;
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
            if (TextBox1.Text != "")
            {
                String updatedata = "delete from product_tb where product_id=" + TextBox1.Text;
                String updatedata2 = "delete from product_details_tb where productD_id=" + TextBox1.Text;
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
            }
            else
            {
                Label1.Text = "no item to delete ";
            }

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
            Label1.Text = "Operation Has Been Cancelled Successfully";
        }


    }
}