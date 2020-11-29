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
    public partial class search : System.Web.UI.Page
    {
        string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Enabled = false;
                DropDownList2.Enabled = false;

            }
        }

        protected void TablesDropDown()
        {
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //sqlconn.Open();
            //// DropDownList1.Items.Add( new ListItem("---select value--"));
            //string query = "select name from sysobjects where xtype='U'";
            //SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            //sqlcomm.CommandType = CommandType.Text;
            //SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            //DataTable dt = new DataTable();
            //sdr.Fill(dt);
            ////DropDownList1.Items.Insert(0, new ListItem("---select value--", "0"));
            //// DropDownList1.DataSource = sqlcomm.ExecuteReader();
            //DropDownList1.DataSource = dt;
            //DropDownList1.DataTextField = "name";
            //DropDownList1.DataValueField = "name";
            //DropDownList1.Items.Insert(0, new ListItem("---Type---", "0"));
            //sqlconn.Close();

            //SqlConnection sqlconn = new SqlConnection(mainconn);
            //sqlconn.Open();
            //// DropDownList1.Items.Add( new ListItem("---select value--"));
            //string query = "select name from sysobjects where xtype='U'";
            //SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            //sqlcomm.CommandType = CommandType.Text;
            //SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            //DataTable dt = new DataTable();
            //sdr.Fill(dt);
            ////DropDownList1.Items.Insert(0, new ListItem("---select value--", "0"));
            //// DropDownList1.DataSource = sqlcomm.ExecuteReader();
            //DropDownList1.DataSource = dt;
            //DropDownList1.DataTextField = "name";
            //DropDownList1.DataValueField = "name";
            //DropDownList1.Items.Insert(0, new ListItem("---select value--", "0"));

            //DropDownList1.DataBind();
            //sqlconn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            try
            {

                if (TextBox1.Text == "")
                {
                    nosearchcontent();

                }
                else
                {
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand();
                    string query = "select * from " + DropDownList1.SelectedValue + " where " + DropDownList2.SelectedValue + "='" + TextBox1.Text + "'";
                    sqlcomm.CommandText = query;
                    sqlcomm.Connection = sqlconn;
                    sqlcomm.Parameters.AddWithValue("user_id", TextBox1.Text);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    sqlconn.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException wronginputtype)
            {
                Label1.Text = "enter correct input";

                //throw;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = DropDownList1.SelectedValue;
            if (table == "0")
            {
                DropDownList2.Enabled = false;
                TextBox1.Text = "";
                TextBox1.Enabled = false;

            }
            else
            {
                TextBox1.Text = "";
                DropDownList2.Enabled = true;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();
                string query = "select COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= N'" + table + "'";
                SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
                sqlcomm.CommandType = CommandType.Text;
                DropDownList2.DataSource = sqlcomm.ExecuteReader();
                DropDownList2.DataTextField = "COLUMN_NAME";
                DropDownList2.DataValueField = "COLUMN_NAME";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("Select", "0"));
                sqlconn.Close();
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columns = DropDownList2.SelectedValue;
            if (columns == "0")
            {
                TextBox1.Text = "";
                TextBox1.Enabled = false;
            }
            else
            {
                TextBox1.Text = "";
                TextBox1.Enabled = true;
            }
        }

        protected void nosearchcontent()
        {
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string query = "select * from " + DropDownList1.SelectedValue + "";
            sqlcomm.CommandText = query;
            sqlcomm.Connection = sqlconn;
            sqlcomm.Parameters.AddWithValue("user_id", TextBox1.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            sqlconn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedValue == "customer_tb")
            {
                
                GridViewRow row = GridView1.SelectedRow;
                string IDV = row.Cells[1].Text;
                HyperLink link = new HyperLink();
                link.Text = "view";
                link.NavigateUrl = "customer_tb.aspx?ID=" + IDV + "";
                row.Cells[0].Controls.Add(link);
            }

            else if (DropDownList1.SelectedValue == "product_tb")
            {

                GridViewRow row = GridView1.SelectedRow;
                string IDV = row.Cells[1].Text;
                HyperLink link = new HyperLink();
                link.Text = "view";
                link.NavigateUrl = "product_tb.aspx?ID=" + IDV + "";
                row.Cells[0].Controls.Add(link);
            }
            else
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
}