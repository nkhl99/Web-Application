using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class log1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            //SqlConnection con=new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\DELL\documents\visual studio 2010\Projects\WebApplication1\WebApplication1\App_Data\lohin_db1.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string checkuser = "select count(*) from log_tb where user_id='"+user.Text+"' and password='"+Password.Text+"'";
            SqlCommand cmd = new SqlCommand(checkuser,con);

             string output=cmd.ExecuteScalar().ToString();
            
             //Response.Write("-----" + output + "----");
            if (output == "1")
            {
                Response.Redirect("~/search.aspx");
            }
            else
            {
                Response.Write("wrong user_id or password");
            }
            con.Close();

        }

        protected void user_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}