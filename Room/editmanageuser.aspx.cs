using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Room_editmanageuser : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        if (Session["session-id_admin"] == null && Session["session-id_user"] == null)
        {

            //Response.Redirect("/Home.aspx");
        }
        if (Session["session-id_admin"] != null)
        {
            Label6.Text = "<b>"+Session["session-id_admin"].ToString() + " (admin)";

        }
        if (Session["session-id_user"] != null)
        {
            Label6.Text = "<b>"+Session["session-id_user"].ToString()+" (user)";
        }

        else
        {

        }
        if (!Page.IsPostBack)
        {
            aa();
        }
    }
    void aa()
    {
        if (Session["session-id_admin"] == null && Session["session-id_user"] == null)
        {
            Response.Redirect("../Home");

        }
        if (Session["session-id_admin"] != null)
        {
            if (Session["editname"].ToString() != null)
            {
                txtname.Text = Session["editname"].ToString();
                txtlastname.Text = Session["editlastname"].ToString();
                email.Text = Session["editemail"].ToString();
                if (Request.QueryString["id"] != null)
                {
                    txtcollegeid.Text = Request.QueryString["id"];
                }
                else
                {
                    txtcollegeid.Text = Session["session-id_user2"].ToString();
                }
            }
        }
        if(Session["session-id_user"]!=null)
        {
            string strSQL = "SELECT * FROM users where id_user ='"+Session["session-id_user2"]+"'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtname.Text = reader["name"].ToString();
                txtlastname.Text = reader["lastname"].ToString();
                email.Text = reader["email"].ToString();

            }
            reader.Close();
                txtcollegeid.Text = Session["session-id_user2"].ToString();
            
        }
        
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (txtname.Text == "")
        {
            Response.Redirect("manageuser.aspx");
        }
    }








    protected void Submit_Click1(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        string checkrepeat = "select count(id_user) from users where id_user ='" + txtcollegeid.Text + "'";
        string queryinsertregister = "update users set password='"+password.Text+"',name='"+ txtname.Text + "',lastname='" + txtlastname.Text + "',email='" + email.Text +"' where id_user='"+txtcollegeid.Text+"'";
        SqlCommand cmdqueryinsertregister = new SqlCommand(queryinsertregister, con);
        SqlCommand cmdcheckrepeat = new SqlCommand(checkrepeat, con);

        int outputcheckrepeat = (int)cmdcheckrepeat.ExecuteScalar();
        if (outputcheckrepeat == 1)
        {
            cmdqueryinsertregister.ExecuteNonQuery();
            Response.Write("<script>alert('แก้ไขเรียบร้อย')</script>");
            //Response.Redirect("manageuser.aspx?id=editdone");
        }
        else
        {
            Response.Write("<script>alert('ล้มเหลว')</script>");

        }


    }

    //protected void Button3_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("manageuser.aspx");
    //    password.Text = "SSS";
    //}
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon(); //*** Delete All ***//
        Session.Clear(); //*** Delete All ***//
        Response.Redirect("../Home.aspx");
    }
}