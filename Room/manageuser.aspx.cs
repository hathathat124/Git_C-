using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

public partial class Room_manageuser : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());
    CheckBox chkCusID;

    Label lbliduser;
    Label lblpassword;
    Label lblname;
    Label lbllastname;
    Label lblstatus;
    Label lblemail;
    Label lbldate_register;
    protected void Page_Load(object sender, EventArgs e)
    {
        ////txtbox1.Text = DateTime.Today.ToLongDateString();
        //// labelshowdate.Text = datepickerr.Text;
        if (Session["session-id_admin"] == null & Session["session-id_user"] ==null)
        {
            Response.Redirect("/Home.aspx");
        }
        else if (Session["session-id_user"] != null)
        {
            Response.Redirect("editmanageuser.aspx");
        }
        else if(Session["session-id_admin"] !=null)
        {
            Label2.Text = "<b>" + Session["session-id_admin"].ToString() + " (admin)";
        }
        if (!Page.IsPostBack)
        {
            BindData();
        }
        if(Request.QueryString["id"]== "editdone")
        {
            Response.Write("<script>alert('แก้ไขเรียบร้อย')</script>");

        }
        //if (Page.IsPostBack)
        //{
        //    BindData();
        //}
        txt_search.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                            if (keyCode==13) { document.getElementById( '" + btn_search.ClientID + "' ).click(); }");

    }
    void BindData()
    {

        con.Open();
        String strSQL;
        if (!Page.IsPostBack)
        {
            if (txt_search.Text == "")
            {
                strSQL = "SELECT * FROM users where id_user !='admin'";
                SqlDataReader dtReader;
                SqlCommand objCmd = new SqlCommand(strSQL, con);
                dtReader = objCmd.ExecuteReader();

                //*** BindData to Repeater ***//
                myRepeater.DataSource = dtReader;
                myRepeater.DataBind();

                dtReader.Close();
                dtReader = null;
            }
            if (txt_search.Text != "")
            {
                string check = txt_search.Text + "%";
                strSQL = "SELECT * FROM users where id_user like '"+check+"'";
                SqlDataReader dtReader;
                SqlCommand objCmd = new SqlCommand(strSQL, con);
                dtReader = objCmd.ExecuteReader();

                //*** BindData to Repeater ***//
                myRepeater.DataSource = dtReader;
                myRepeater.DataBind();

                dtReader.Close();
                dtReader = null;
            }
        }
        con.Close();
    }

    void Page_UnLoad()
    {
        con.Close();
        con = null;
    }

    protected void myRepeater_ItemDataBound(Object sender, RepeaterItemEventArgs e)
    {

        //*** CustomerID ***//
        Label lbliduser = (Label)(e.Item.FindControl("lbliduser"));
        if (lbliduser != null)
        {
            lbliduser.Text = "<h5 style = 'color:#303030'>"+(string)DataBinder.Eval(e.Item.DataItem, "id_user").ToString();
        }

        //*** Email ***//
        Label lblpassword = (Label)(e.Item.FindControl("lblpassword"));
        if (lblpassword != null)
        {
            lblpassword.Text = "<h5 style = 'color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "password").ToString();
        }

        //*** Name ***//
        Label lblname = (Label)(e.Item.FindControl("lblname"));
        if (lblname != null)
        {
            lblname.Text = "<h5 style = 'color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "name").ToString();
        }
        //*** CustomerID ***//
        Label lbllastname = (Label)(e.Item.FindControl("lbllastname"));
        if (lbllastname != null)
        {
            lbllastname.Text = "<h5 style = 'color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "lastname").ToString();
        }

        //*** Email ***//
        Label lblstatus = (Label)(e.Item.FindControl("lblstatus"));
        if (lblstatus != null)
        {
            lblstatus.Text = "<h5 style = 'color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "status").ToString();
        }

        //*** Name ***//
        Label lblemail = (Label)(e.Item.FindControl("lblemail"));
        if (lblemail != null)
        {

            lblemail.Text = "<h5 style = 'color:#303030'> " + (string)DataBinder.Eval(e.Item.DataItem, "email").ToString();
        }
        Label lbldate_register = (Label)(e.Item.FindControl("lbldate_register"));
        if (lbldate_register != null)
        {

            lbldate_register.Text = "<h5 style = 'color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "date_register").ToString();
        }
        //Label lbledit = (Label)(e.Item.FindControl("lbledit"));
        //if (lbldate_register != null)
        //{

        //    lbledit.Text = (string)DataBinder.Eval(e.Item.DataItem, "date_register").ToString();
        //}
    }
   

    
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("room1.aspx");
    }
    //protected void edit_Click(object sender, EventArgs e)
    //{
    
    //    //ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2);var Mtop = (screen.height/2)-(700/2);window.open( 'edit.aspx', null, 'height=700,width=760,status=yes,toolbar=no,scrollbars=yes,menubar=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);

    //}
    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon(); //*** Delete All ***//
        Session.Clear(); //*** Delete All ***//
        Response.Redirect("../Home.aspx");
    }
  
    protected void Delete_Click(object sender, EventArgs e)
    {
        con.Open();
        

        int i;
        int ID_booking;
        lblText.Text = "";
        for (i = 0; i <= myRepeater.Items.Count - 1; i++)
        {
            chkCusID = (CheckBox)myRepeater.Items[i].FindControl("chkCustomerID");
            lbliduser = (Label)myRepeater.Items[i].FindControl("lbliduser");
            lblpassword = (Label)myRepeater.Items[i].FindControl("lblpassword");
            lblname = (Label)myRepeater.Items[i].FindControl("lblname");
            lbllastname = (Label)myRepeater.Items[i].FindControl("lbllastname");
            lblstatus = (Label)myRepeater.Items[i].FindControl("lblstatus");
            lblemail = (Label)myRepeater.Items[i].FindControl("lblemail");
            lbldate_register = (Label)myRepeater.Items[i].FindControl("lbldate_register");

            if (chkCusID.Checked)
            {
                //*** Have lblID.Text ***//
                this.lblText.Text = this.lblText.Text + "<br>" + lbliduser.Text;
                //if (int.TryParse(lblText.Text, out ID_booking)) ;
                string id_user = lbliduser.Text;
                string password = lblpassword.Text;
                string name = lblname.Text;
                string lastname = lbllastname.Text;
                string status = lblstatus.Text;
                string email = lblemail.Text;
                string dateregister = lbldate_register.Text;
                Response.Write("<script>alert('" + id_user + "')</script>");
                //int ID_booking = Convert.ToInt32(lblText);
                //string querytranferhistory = "insert into history_subjects select * from booking_subjects where id_lab = '" + id_string + "'and start_time = '" + startlbl + "'and end_time = '" + endlbl + "' and id_subject = '" + lblidsub.Text + "'";
                string querytranferhistoryuser = "insert into history_user select * from users where id_user = '" + id_user + "'";
                SqlCommand cmdtranferhistoryuser = new SqlCommand(querytranferhistoryuser, con);
                cmdtranferhistoryuser.ExecuteNonQuery();
                string querydelete = "delete from users where id_user = '" + id_user + "'";
                SqlCommand cmddelete = new SqlCommand(querydelete, con);
                cmddelete.ExecuteNonQuery();
                
               Response.Write("<script>alert('ลบรายการเรียบร้อย')</script>");
              
            }


        }
        if (this.lblText.Text != null)
        {
            //this.lblText.Text = this.lblText.Text + "<br>" + "ถูกลบเรียบร้อย";
        }
        con.Close();
        BindData();
    }

    protected void btnsendemail_Click(object sender, EventArgs e)
    {
        con.Open();


        int i;
        int ID_booking;
        lblText.Text = "";
        if (Session["session-id_admin"] != null)
        {
         
            for (i = 0; i <= myRepeater.Items.Count - 1; i++)
            {
                chkCusID = (CheckBox)myRepeater.Items[i].FindControl("chkCustomerID");
                lbliduser = (Label)myRepeater.Items[i].FindControl("lbliduser");
                lblpassword = (Label)myRepeater.Items[i].FindControl("lblpassword");
                lblname = (Label)myRepeater.Items[i].FindControl("lblname");
                lbllastname = (Label)myRepeater.Items[i].FindControl("lbllastname");
                lblstatus = (Label)myRepeater.Items[i].FindControl("lblstatus");
                lblemail = (Label)myRepeater.Items[i].FindControl("lblemail");
                lbldate_register = (Label)myRepeater.Items[i].FindControl("lbldate_register");



                if (chkCusID.Checked)
                {
                    //*** Have lblID.Text ***//
                    //this.lblText.Text = this.lblText.Text + "<br>" + lbliduser.Text;
                    //if (int.TryParse(lblText.Text, out ID_booking)) ;
                    string id_user = lbliduser.Text;
                    string password = lblpassword.Text;
                    string name = lblname.Text;
                    string lastname = lbllastname.Text;
                    string status = lblstatus.Text;
                    string email = lblemail.Text;
                    string dateregister = lbldate_register.Text;
                    Response.Write("<script>alert('" + id_user + "')</script>");

                    string querysendemailidandpassword = "select email from users where id_user = '" + Session["session-id_admin2"].ToString() + "'";
                    //SqlCommand cmdquerysendemailidandpassword = new SqlCommand(querysendemailidandpassword, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(querysendemailidandpassword, con);
                    DataSet dss = new DataSet();
                    adapter.Fill(dss, "Users");
                    string emailadmin = dss.Tables["Users"].Rows[0]["email"].ToString();
                    //Response.Write("emailadmin : " + emailadmin);

                    string subject = "KU Labs แจ้งข้อมูลไอดีรหัสผ่าน";
                    string body = ("<h3><a style=margin-left:55em; href=../home.apsx>เข้าสู่เว็บไซต์</a></h3>" +
                "<hr style=width:70%;border-color:#0efa45></hr>" +
                "<div style=text-align:center><h1><font color=green>แจ้งไอดีสมาชิก KU LAB </font color></h1></div>" +
                "<hr style=width:70%;border-color:#0efa45></hr>" +
                //"<div style=text-align:center;><h2>"+name+" "+lastname+"</h2></div>" +
                "<div style=text-align:center;><h2> ทำการแจ้งไอดีรหัสผ่านของคุณคือ </h2></div>" +
                "<div style=text-align:center;><h2>ไอดี "+id_user+"</h2></div>" +
                "<div style=text-align:center;><h2>รหัสผ่าน "+password+"</h2></div>" +
                "");


                    //Response.Redirect("testinsertdate.aspx");
                    con.Close();

                    try
                    {
                        MailMessage message = new MailMessage(emailadmin, email, subject, body);
                        message.IsBodyHtml = true;

                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.EnableSsl = true;
                        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        //client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential(emailadmin, "741341#S");
                        client.Send(message);

                    }
                    catch (Exception ex)
                    {
                        Response.Write(emailadmin + "''" + email + "''" + id_user);

                        Response.Write("<script>alert('ex.StackTrace')</script>");
                    }


                    Response.Write("<script>alert('ส่งอีเมลเรียบร้อย')</script>");

                }


            }
            if (this.lblText.Text != null)
            {
                //this.lblText.Text = this.lblText.Text + "<br>" + "ส่งอีเมลเรียบร้อย";
            }
           
            BindData();
        }
        else
        {
            Response.Redirect("../home.aspx");
        }
        con.Close();
    }

    protected void myRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "EditCommand")
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string queryuser = "select * from users where id_user = '" + e.CommandArgument + "'";
            //string queryname = "select name from users where id_user = '" + e.CommandArgument + "'";
            //string queryemail = "select email from users where id_user = '" + e.CommandArgument + "'";
            SqlCommand cmd = new SqlCommand(queryuser, con);

            SqlDataReader reader = cmd.ExecuteReader();

            //Session["edituser"] = reader["id_user"];
            while (reader.Read())
            {
                Session["editname"] = reader["name"];
                Session["editlastname"] = reader["lastname"];
                Session["editemail"] = reader["email"];
                //Response.Write("<script>alert('" + Session["editname"] + "')</script>");
            }
            Response.Redirect("editmanageuser.aspx?id=" + e.CommandArgument);

        }
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        BindData();
    }
}