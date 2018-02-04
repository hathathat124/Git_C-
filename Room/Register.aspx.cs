using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Room_Registry : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["session-id_admin"] == null)
        {

            Response.Redirect("../Home.aspx");
        }
        else
        {
            Label6.Text = "<b>"+Session["session-id_admin"].ToString()+" (admin)";

        }
    }




    protected void Button4_Click(object sender, EventArgs e)
    {
        if (txtname.Text == "")
        {
            Response.Redirect("admin.aspx");
        }
    }

    //protected void addsubject_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("adminaddsubject.aspx");
    //}

    //protected void logout_Click(object sender, EventArgs e)
    //{
    //    Session.Abandon(); //*** Delete All ***//
    //    Session.Clear(); //*** Delete All ***//
    //    Response.Redirect("../Home.aspx");
    //}



    




    protected void Submit_Click1(object sender, EventArgs e)
    {
        con.Open();
        string checkrepeat = "select count(id_user) from users where id_user ='" + txtcollegeid.Text + "'";
        string queryinsertregister = "insert into users values('" + txtcollegeid.Text + "','" +password.Text + "','" + txtname.Text + "','" +txtlastname.Text + "','user','"+email.Text+"','"+DateTime.Now.ToString(/*"yyyy-MM-dd HH:mm:ss",*/ new System.Globalization.CultureInfo("en-US")) +"')";
        string queryinsertregister2 = "insert into users values('" + txtcollegeid.Text + "','" + password.Text + "','" + txtname.Text + "','" + txtlastname.Text + "','admin','" + email.Text + "','" + DateTime.Now.ToString(/*"yyyy-MM-dd HH:mm:ss",*/ new System.Globalization.CultureInfo("en-US")) + "')";

        SqlCommand cmdcheckrepeat = new SqlCommand(checkrepeat, con);
        SqlCommand cmdqueryinsertregister = new SqlCommand(queryinsertregister, con);
        SqlCommand cmdqueryinsertregister2 = new SqlCommand(queryinsertregister2, con);


        int outputcheckrepeat = (int)cmdcheckrepeat.ExecuteScalar();
        if(outputcheckrepeat>0)
        {
            Response.Write("<script>alert('ไอดีนี้มีผู้ใช้แล้ว')</script>");
        }
        else if(Checkadmin.Checked)
        {
            Response.Write("<script>alert('สมัครสมาชิกเรียบร้อย')</script>");
            cmdqueryinsertregister2.ExecuteNonQuery();
        }
        else
        {
            cmdqueryinsertregister.ExecuteNonQuery();
            Response.Write("<script>alert('สมัครสมาชิกเรียบร้อย')</script>");

        }

       
    }



}