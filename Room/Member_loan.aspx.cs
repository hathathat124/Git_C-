using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Room_Default6 : System.Web.UI.Page
{
    string txt_searchexchange;
    DateTime[] df = new DateTime[99];

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["session-id_admin"] == null && Session["session-id_user"] == null)
        {
            Response.Redirect("../Home");

        }
        else if (Session["session-id_user"] != null)
        {
            Label2.Text = "<b>" + Session["session-id_user"].ToString() + " (user)";
            if (!Page.IsPostBack)
            {
                ddl_search.Items.Add("ชื่อผู้จอง");
                ddl_search.Items.Add("ไอดีผู้จอง");

            }

        }
        else if (Session["session-id_admin"] != null)
        {
            Label2.Text = "<b>" + Session["session-id_admin"].ToString() + " (admin)";
            if (!Page.IsPostBack)
            {
                ddl_search.Items.Add("ชื่อผู้จอง");
                ddl_search.Items.Add("ไอดีผู้จอง");

            }

        }
        
        if (!Page.IsPostBack)
        {

            txt_search.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                            if (keyCode==13) { document.getElementById( '" + btn_search.ClientID + "' ).click(); }");
           
        }


    }
    public static DateTime fillday(DateTime day)
    {
        var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        var diff = day.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
        if (diff < 0)
            diff += 7;
        return day.AddDays(-diff).Date;
    }
    string[] daym = new string[7];
    public string htmldaymon { get { return daym[0]; } }
    public string htmldaytue { get { return daym[1]; } }
    public string htmldaywed { get { return daym[2]; } }
    public string htmldaythur { get { return daym[3]; } }
    public string htmldayfri { get { return daym[4]; } }
    public string htmldaysat { get { return daym[5]; } }
    public string htmldaysun { get { return daym[6]; } }

    void sendmonday_sunday(DateTime dayforsend)
    {
        daym[0] = dayforsend.ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[1] = dayforsend.AddDays(1).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[2] = dayforsend.AddDays(2).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[3] = dayforsend.AddDays(3).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[4] = dayforsend.AddDays(4).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[5] = dayforsend.AddDays(5).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[6] = dayforsend.AddDays(6).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));

    }

    string check2;
    string strSQL,strSQL2,strSQLcheckloan_by_admin;
    
    void BindData()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        //if (txt_search.Text != "")
        //{
           
            if(txt_search.Text == "")
            {
                strSQL = "select booking_labs.id_lab,booking_labs.id_user,users.name,cast(booking_labs.start_time as varchar) + '-' + "
            + "cast(booking_labs.end_time AS varchar) as Expr1,booking_labs.date_loan,booking_labs.date,booking_labs.loan_by_admin " 
            + " from booking_labs inner join users on users.id_user = booking_labs.id_user order by id_lab,date_loan,start_time";          
            }
            else if (ddl_search.Text == "ชื่อผู้จอง") { txt_searchexchange = "users.name";check2 = txt_search.Text+'%';
                //            strSQL = "select booking_labs.id_user,users.name,booking_labs.id_lab,cast(booking_labs.start_time as varchar) + '-' + cast(booking_labs.end_time AS varchar)  as Expr1,booking_labs.date_loan,booking_labs.date from booking_labs inner join users "
                //+ "on booking_labs.id_user = users.id_user where users.name like '"+check2+"' or booking_labs.id like'"+check2+"' order by id_lab,date_loan,start_time";
                strSQL = "select booking_labs.id_lab,booking_labs.id_user,users.name,cast(booking_labs.start_time as varchar) + '-' +"
            + "cast(booking_labs.end_time AS varchar) as Expr1,booking_labs.date_loan,booking_labs.date,booking_labs.loan_by_admin from(booking_labs inner join users on users.id_user= booking_labs.id_user)"
            +" where users.name like '"+check2+"'or booking_labs.loan_by_admin like'"+check2+"'order by id_lab,date_loan,start_time";
            }
            else if (ddl_search.Text == "ไอดีผู้จอง")
            {
                txt_searchexchange = "booking_labs.id_user"; check2 = txt_search.Text + '%';
                strSQL = "select booking_labs.id_lab,booking_labs.id_user,users.name,cast(booking_labs.start_time as varchar) + '-' + "
            + "cast(booking_labs.end_time AS varchar) as Expr1,booking_labs.date_loan,booking_labs.date,booking_labs.loan_by_admin from booking_labs inner join users "
            + "on booking_labs.id_user = users.id_user where booking_labs.id_user like '" + check2 + "' order by id_lab,date_loan,start_time";
            }
            SqlDataReader dtReader;
            SqlCommand objCmd = new SqlCommand(strSQL, con);
            

            dtReader = objCmd.ExecuteReader();
            //*** BindData to Repeater ***//
            myRepeater2.DataSource = dtReader;
            myRepeater2.DataBind();
            dtReader.Close();
            dtReader = null;        
        con.Close();
    }
    //protected void myRepeater_ItemDataBound(Object sender, RepeaterItemEventArgs e)
    //{

    //    //*** CustomerID ***//

    //    Label lblCustomerID = (Label)(e.Item.FindControl("lblroom"));
    //    if (lblCustomerID != null)
    //    {
    //        lblCustomerID.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_lab").ToString();
    //    }

    //    //*** Email ***//
    //    Label lblidsub = (Label)(e.Item.FindControl("lblidsub"));
    //    if (lblidsub != null)
    //    {
    //        lblidsub.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_subject").ToString();
    //    }
    //    //*** Email ***//
    //    Label lblnamesub = (Label)(e.Item.FindControl("lblnamesub"));
    //    if (lblnamesub != null)
    //    {
    //        lblnamesub.Text = (string)DataBinder.Eval(e.Item.DataItem, "name_subject").ToString();
    //    }
    //    //*** Email ***//
    //    Label lblday = (Label)(e.Item.FindControl("lblday"));
    //    if (lblday != null)
    //    {
    //        lblday.Text = (string)DataBinder.Eval(e.Item.DataItem, "day").ToString();
    //    }

    //    //*** Name ***//
    //    Label lblstart = (Label)(e.Item.FindControl("lblstart"));
    //    if (lblstart != null)
    //    {
    //        lblstart.Text = DataBinder.Eval(e.Item.DataItem, "start_time").ToString();
    //    }
    //    //*** CustomerID ***//
    //    Label lblend = (Label)(e.Item.FindControl("lblend"));
    //    if (lblend != null)
    //    {
    //        lblend.Text = (string)DataBinder.Eval(e.Item.DataItem, "end_time").ToString();
    //    }

    //    //*** Email ***//
    //    Label lblsec = (Label)(e.Item.FindControl("lblsec"));
    //    if (lblsec != null)
    //    {
    //        lblsec.Text = (string)DataBinder.Eval(e.Item.DataItem, "sec").ToString();
    //    }

    //    //*** Name ***//
    //    Label lblteacher = (Label)(e.Item.FindControl("lblteacher"));
    //    if (lblteacher != null)
    //    {

    //        lblteacher.Text = (string)DataBinder.Eval(e.Item.DataItem, "teacher").ToString();
    //    }




    //}
    protected void myRepeater2_ItemDataBound(Object sender, RepeaterItemEventArgs e)
    {

        //*** CustomerID ***//
        Label lblCustomerID_b = (Label)(e.Item.FindControl("lblroom_b"));
        if (lblCustomerID_b != null)
        {
            lblCustomerID_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "id_lab");
        }
        //*** Email ***//
        Label lblname_b = (Label)(e.Item.FindControl("lblname_b"));
        if (lblname_b != null)
        {
            lblname_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "name");
        }

        //*** Email ***//
        Label lblid_b = (Label)(e.Item.FindControl("lblid_b"));
        if (lblid_b != null)
        {
            lblid_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "id_user");
        }

        //*** Name ***//
        Label lblstart_b = (Label)(e.Item.FindControl("lblstart_b"));
        if (lblstart_b != null)
        {
            DateTime checkdayofweek = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "date_loan"));
            lblstart_b.Text = checkdayofweek.DayOfWeek.ToString();
            lblstart_b.Text = "<h5 style='color:#303030'>" + lblstart_b.Text +" "+DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //for (int i = 0; i < 7; i++)
            //{
            //Response.Write("<script>alert('alert there " + daym[i] + DataBinder.Eval(e.Item.DataItem, "date_loan")+ "')</script>");
            //DateTime df = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "date_loan"));
            //df[i] = Convert.ToDateTime(daym[i]);

            //Response.Write("<script>alert('alert there " + df[i].ToString("yyyy-M-dd", new System.Globalization.CultureInfo("en-US")) + DataBinder.Eval(e.Item.DataItem, "date_loan").ToString() + "')</script>");

            //if (DataBinder.Eval(e.Item.DataItem, "date_loan").ToString() == df[i].ToString("yyyy-M-dd", new System.Globalization.CultureInfo("en-US")))
            //{

            //if (i == 0)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "M " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //if (i == 1)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "Tu " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //if (i == 2)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "W " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //if (i == 3)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "Th " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //if (i == 4)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "F " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //if (i == 5)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "Sat " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //if (i == 6)
            //{
            //    lblstart_b.Text = "<h5 style='color:#303030'><b>" + "Sun " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
            //}
            //Response.Write("<script>alert('alert there "+lblstart_b.Text+"')</script>");
            //}


            //}
        }
        //*** CustomerID ***//
        //Label lblend_b = (Label)(e.Item.FindControl("lblend_b"));
        //if (lblend_b != null)
        //{
        //    lblend_b.Text = (string)DataBinder.Eval(e.Item.DataItem, "end_time").ToString();
        //}

        //*** Email ***//
        Label lbldateloan_b = (Label)(e.Item.FindControl("lbldateloan_b"));
        if (lbldateloan_b != null)
        {
            DateTime date_loan_turnto_bhuddist = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "date_loan"));
            lbldateloan_b.Text = "<h5 style='color:#303030'>" + date_loan_turnto_bhuddist.AddYears(543).ToString("dd/MM/yyyy");
        }
        //*** Name ***//
        Label lbldate_b = (Label)(e.Item.FindControl("lbldate_b"));
        if (lbldate_b != null)
        {
            lbldate_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "date").ToString();
        }
        Label lblloan_by_admin_b = (Label)(e.Item.FindControl("lblloan_by_admin_b"));
        if(lblloan_by_admin_b!=null)
        {
            lblloan_by_admin_b.Text =  "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "loan_by_admin").ToString();
        }
        //Label lblloan_by_admin_b2 = (Label)(e.Item.FindControl("lblloan_by_admin_b"));

        //if (lblloan_by_admin_b2 == null)
        //{
        //    lblloan_by_admin_b2.Text = "-";
        //}
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("room1.aspx");
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon(); //*** Delete All ***//
        Session.Clear(); //*** Delete All ***//
        Response.Redirect("../Home.aspx");
    }

    protected void btn_search_Click(object sender, EventArgs e)
    {
        BindData();
    }
}