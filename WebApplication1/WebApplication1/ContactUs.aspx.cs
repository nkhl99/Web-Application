using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mail = Request.Form["mail"];
            string name = Request.Form["names"];
            string phone = Request.Form["phone"];
            string body = Request.Form["body"];
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("testmailtm03@gmail.com", "great1.2");
                MailMessage msgobj = new MailMessage();
                msgobj.To.Add("testmailtm03@gmail.com");
                msgobj.From = new MailAddress("testmailtm03@gmail.com");
                msgobj.Subject = "Complaint";
                //msgobj.Body = "Name = "+name+"\n"+"Email ="+mail+"\n"+"Mobile Number ="+phone+"\n"+"Issue ="+
                //    Textbody.Text;
                msgobj.Body = "Name = " + name + "\n" + "Email = " + mail + "\n" + "Mobile Number = " + phone + "\n" + "Issue = " +
                    body;
                client.Send(msgobj);
                ScriptManager.RegisterStartupScript(this,this.GetType(),"popup","alert('Message sent successfully');",true);
            }

            catch (Exception ex)
            {
                Response.Write("ERROR:not send");
            }
        }
    }
}