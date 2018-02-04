using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Room_Detailsubject : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
        BindData(); 
    }
    void BindData()
    {
        con.Open();
        String strSQL;
        strSQL = "SELECT * FROM booking_labs";

        SqlDataReader dtReader;
        SqlCommand objCmd = new SqlCommand(strSQL, con);
        dtReader = objCmd.ExecuteReader();

        //*** BindData to Repeater ***//
        myRepeater.DataSource = dtReader;
        myRepeater.DataBind();

        dtReader.Close();
        dtReader = null;
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
        Label lblCustomerID = (Label)(e.Item.FindControl("lblroom"));
        if (lblCustomerID != null)
        {
            lblCustomerID.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_lab").ToString();
        }

        //*** Email ***//
        Label lblid = (Label)(e.Item.FindControl("lblid"));
        if (lblid != null)
        {
            lblid.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_user").ToString();
        }

        //*** Name ***//
        Label lblstart = (Label)(e.Item.FindControl("lblstart"));
        if (lblstart != null)
        {
            lblstart.Text = DataBinder.Eval(e.Item.DataItem, "start_time").ToString();
        }
        //*** CustomerID ***//
        Label lblend = (Label)(e.Item.FindControl("lblend"));
        if (lblend != null)
        {
            lblend.Text = (string)DataBinder.Eval(e.Item.DataItem, "end_time").ToString();
        }

        //*** Email ***//
        Label lbldateloan = (Label)(e.Item.FindControl("lbldateloan"));
        if (lbldateloan != null)
        {
            lbldateloan.Text = (string)DataBinder.Eval(e.Item.DataItem, "date_loan").ToString();
        }

        //*** Name ***//
        Label lbldate = (Label)(e.Item.FindControl("lbldate"));
        if (lbldate != null)
        {

            lbldate.Text = (string)DataBinder.Eval(e.Item.DataItem, "date").ToString();
        }
        Label lblreason = (Label)(e.Item.FindControl("lblreason"));
        if (lblreason != null)
        {

            lblreason.Text = (string)DataBinder.Eval(e.Item.DataItem, "reason").ToString();
        }


    }
}