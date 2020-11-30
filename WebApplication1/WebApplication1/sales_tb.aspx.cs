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
    public partial class sales_tb : System.Web.UI.Page
    {
        string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        //DataTable bulkadd = new DataTable();
        DataSet bulkadd = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                

                if (Request.QueryString["ID"] != null)
                {
                    SqlConnection con = new SqlConnection(mainconn);
                    string query = "select * from sales_tb where receipt_no=" + Request.QueryString["ID"].ToString() + " ";
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

                        TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                        TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                        
                        Button2.Enabled = false;
                        Button5.Enabled = false;
                        DropDownList1.Enabled = false;
                        TextBox4.Enabled = false;
                        
                    }
                    string AllProducts = "select productS_name,productS_price from sales_product_tb where receiptP_no=" + Request.QueryString["ID"].ToString() + " ";
                    SqlDataAdapter productsDA = new SqlDataAdapter(AllProducts, con);
                    DataSet productsDS = new DataSet();
                    productsDA.Fill(productsDS);
                    GridView1.DataSource = productsDS;
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
            TextBox4.Enabled = true;
            DropDownList1.Enabled = true;
            
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label1.Text = "New Blank Form Has Been Added.";
            GridView1.DataSource = null;
            GridView1.DataBind();
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string query = "select product_name,product_price from product_tb";
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            sqlcomm.CommandType = CommandType.Text;
            DropDownList1.DataSource = sqlcomm.ExecuteReader();
            DropDownList1.DataTextField = "product_name";
            DropDownList1.DataValueField = "product_name";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Select", "0"));
            sqlconn.Close(); 
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string query = "select product_price from product_tb where product_name='" + DropDownList1.SelectedValue + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlconn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            TextBox5.Text = ds.Tables[0].Rows[0][0].ToString();
            sqlconn.Close(); 
        }

        protected void Button6_Click(object sender, EventArgs e)
        {   SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            string query = "select top 1 (receipt_no)+1 from sales_tb order by receipt_no desc ";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlconn);
            DataSet ds = new DataSet();
            da.Fill(ds);
           
            DataTable dt = new DataTable();
            dt.Columns.Add("receiptP_number");
            dt.Columns.Add("productS_name");
            dt.Columns.Add("productS_price");
            DataRow dr = null;
            if (ViewState["emp"] != null)
            {
                for (int i = 0; i < 1; i++)
                {
                    dt = (DataTable)ViewState["emp"];
                    
                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.NewRow();
                        
                        dr["receiptP_number"] = (ds.Tables[0].Rows[0][0]);
                        dr["productS_name"] = DropDownList1.SelectedValue.ToString();
                        dr["productS_price"] = TextBox5.Text;
                        dt.Rows.Add(dr);
                        
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        //Int32 t4 = Convert.ToInt32(TextBox4.Text);
                        //Int32 t5 = Convert.ToInt32(TextBox5.Text);
                        //TextBox4.Text = Convert.ToString(t4 + t5);

                    } 
                }
            }
            else
            {
                dr = dt.NewRow();
                dr["receiptP_number"] = ds.Tables[0].Rows[0][0];
                dr["productS_name"] = DropDownList1.SelectedValue.ToString();
                dr["productS_price"] = TextBox5.Text;
                dt.Rows.Add(dr);
                
                
                //TextBox4.Text = Convert.ToString((Convert.ToDecimal(TextBox4.Text) + Convert.ToDecimal(TextBox5.Text)));
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //Int32 t4 = Convert.ToInt32(TextBox4.Text);
                //Int32 t5 = Convert.ToInt32(TextBox5.Text);
                //TextBox4.Text = Convert.ToString(t4 + t5);
            }
            ViewState["emp"] = dt;

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Button1.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button2.Enabled = false;
            Button5.Enabled = false;
            DropDownList1.ClearSelection();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Label1.Text = "Operation Has Been Cancelled Successfully";
            GridView1.DataSource = null;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text != "")
            {
                try
                {
                    String query = "insert into sales_tb values(GETDATE(),'" + TextBox3.Text + "'," + TextBox4.Text + ")";

                    // String mycon = "Data Source=HP-PC\\SQLEXPRESS; Initial Catalog=CollegeData; Integrated Security=true";
                    SqlConnection con = new SqlConnection(mainconn);
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = query;
                    cmd2.Connection = con;
                    cmd2.ExecuteNonQuery();
                    string querys = "select top 1 * from sales_tb order by receipt_no  desc";
                    SqlDataAdapter da = new SqlDataAdapter(querys, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (GridViewRow gr in GridView1.Rows)
                    {
                         SqlConnection comm = new SqlConnection(mainconn);
                        string sqlquery = "insert into sales_product_tb values(@receiptP_no,@productS_name,@productS_price)";
                        SqlCommand sqlcomm = new SqlCommand(sqlquery, comm);
                        sqlcomm.Parameters.AddWithValue("@receiptP_no", gr.Cells[0].Text);
                        sqlcomm.Parameters.AddWithValue("@productS_name", gr.Cells[1].Text);
                        sqlcomm.Parameters.AddWithValue("@productS_price", gr.Cells[2].Text);
                        comm.Open();
                        sqlcomm.ExecuteNonQuery();
                        comm.Close();


                    }

                    TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                    TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
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
                    TextBox4.Enabled = false;

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
                String updatedata = "Update sales_tb set customerS_name='" + TextBox3.Text + "' where receipt_no=" + TextBox1.Text;
                //String updatedata2 = "Update product_details_tb set manufacture='" + TextBox4.Text + "', rating='" + TextBox5.Text + "' where productD_id=" + TextBox1.Text;
                SqlConnection con = new SqlConnection(mainconn);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                
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
                String updatedata = "delete from sales_tb where receipt_no=" + TextBox1.Text;
                String updatedata2 = "delete from sales_product_tb where receiptP_no=" + TextBox1.Text;
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

        //public void createnewrow()
        //{
        //    try
        //    {
        //        DataTable datatb1 = new DataTable();
        //        if (ViewState["Row"] != null)
        //        {
        //            datatb1 = (DataTable)ViewState["Row"];
        //            DataRow dr = null;
        //            if (datatb1.Rows.Count > 0)
        //            {
        //                dr["productS_name"] = DropDownList1.SelectedValue.ToString();
        //                dr["productS_price"] = TextBox5.Text;
        //                datatb1.Rows.Add(dr);
        //                ViewState["Row"] = datatb1;
        //                GridView1.DataSource = ViewState["Row"];
        //                GridView1.DataBind();
        //            }
        //        }
        //        else
        //        {
        //            datatb1.Columns.Add("productS_name", typeof(string));
        //            datatb1.Columns.Add("productS_price", typeof(decimal));

        //            DataRow dr1 = datatb1.NewRow();
        //            dr1 = datatb1.NewRow();
        //            dr1["productS_name"] = DropDownList1.SelectedValue.ToString();
        //            dr1["productS_price"] = TextBox5.Text;
        //            datatb1.Rows.Add(dr1);
        //            ViewState["Row"] = datatb1;
        //            GridView1.DataSource = ViewState["Row"];
        //            GridView1.DataBind();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
                
                
        //    }
        //}

        //protected void Gridview1_RowDeleting(object sender, GridViewDeletedEventArgs e )
        //{
        //    DataTable dt1 = (DataTable)ViewState["row"];
        //    if (dt1.Rows.Count > 0)
        //    {
        //        dt1.Rows[].Delete();
        //        GridView1.DataSource = dt1;
        //        GridView1.DataBind();
        //    }
        //}
    }
}