using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Room_edit : System.Web.UI.Page
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
            Label6.Text = Session["session-id_admin"].ToString();
            txtcollegeid.Text = Session["session-id_userforedit"].ToString();
            password.Text = Session["session-passwordforedit"].ToString();
            txtname.Text = Session["session-nameforedit"].ToString();
            txtlastname.Text = Session["session-lastnameforedit"].ToString();
            email.Text = Session["session-emailforedit"].ToString();
        }
    }




    protected void Button4_Click(object sender, EventArgs e)
    {
        if (txtname.Text == "")
        {
            Response.Redirect("admin.aspx");
        }
    }










    protected void Submit_Click1(object sender, EventArgs e)
    {
        con.Open();
        //string checkrepeat = "select count(id_user) from users where id_user ='" + txtcollegeid.Text + "'";
        
        string queryinsertregister = "UPDATE users SET password = '"+password.Text+"',name ='"+txtname.Text+"',lastname='"+txtlastname.Text+"' WHERE id_user = '12345'";
        //SqlCommand cmdcheckrepeat = new SqlCommand(checkrepeat, con);
        SqlCommand cmdqueryinsertregister = new SqlCommand(queryinsertregister, con);
        //int outputcheckrepeat = (int)cmdcheckrepeat.ExecuteScalar();
        //if (outputcheckrepeat > 0)
        //{
        //    Response.Write("<script>alert('ไอดีนี้มีผู้ใช้แล้ว')</script>");
        //}
      
            cmdqueryinsertregister.ExecuteNonQuery();
            Response.Write("<script>alert('แก้ไขสมาชิกเรียบร้อย')</script>");



    }

}

