using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

public partial class Room_Chart : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["session-id_admin"] == null)
        {
            Response.Redirect("../home.aspx");
        }
        
        Label2.Text = "<b>" + Session["session-id_admin"].ToString();
        if (!Page.IsPostBack)
        {
            GetChartData();
            GetChartType();
            string timezonevalue = "+08.00";
            string sign = timezonevalue.Substring(0, 1);
            string tTimeoffset = timezonevalue.Substring(1, 5);
            DateTime utc = DateTime.UtcNow;
            TimeSpan offset = new TimeSpan();
            if (TimeSpan.TryParse(tTimeoffset, out offset)) ;
            DateTime newdatetime = utc + offset; ;

            if (sign == "+")
            {
                string foo = newdatetime.AddSeconds(-5).AddHours(7).ToUniversalTime()
                                .ToString("dd'-'MM'-'yyyy'T'HH':'mm':'ss");
                datepickerr.Text = newdatetime.AddSeconds(-5).AddHours(7).ToUniversalTime()
                                .ToString("dd MMMM yyyy");
                datepickerr2.Text = newdatetime.AddDays(1).AddSeconds(-5).AddHours(7).ToUniversalTime()
                                .ToString("dd MMMM yyyy");
                //Response.Write("<script>alert('sss" + foo + "')</script>");
            }
            
        }
        if(datepickerr.Text == "" && datepickerr2.Text =="")
        {

            GetChartType();

        }
        if (Page.IsPostBack)
        {
            GetChartData();
        }

        if(!Page.IsPostBack)
        {
            CheckBox1.Checked = true;
        }
       
    }
    int stringtoint;

    double[,] a = new double[99, 99];
    int checkcountroom(int x)
    {
    
        string querycheckcountroom = "select count(distinct id_lab) from countlab";
        SqlCommand cmdquerycheckcountroom = new SqlCommand(querycheckcountroom, con);
        int outputquerycheckcountroom = (int)cmdquerycheckcountroom.ExecuteScalar();
        return outputquerycheckcountroom;
    }
    int countroom;

    string[] aa = new string[99];
    void GetChartData()
    { 
        if (datepickerr.Text != "" || datepickerr2.Text != "")
        {
            var s = datepickerr.Text;
            var s2 = datepickerr2.Text;
            DateTime q = Convert.ToDateTime(s);
            DateTime q2 = Convert.ToDateTime(s2);
            Series series = Chart1.Series["Series1"];
            con.Open();
            if (CheckBox1.Checked)
            {
                countroom = checkcountroom(0);
                int b = 0;
                //Response.Write("<script>alert('"+q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) +" " +q2.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"))+"')</script>");

                string querychart1 = "SELECT * FROM booking_labs where id_lab = '150411' and date_loan between'" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'and '" + q2.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";
                string querychart2 = "SELECT * FROM booking_labs where id_lab = '150413' and date_loan between'" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'and '" + q2.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";
                string querychart3 = "SELECT * FROM booking_labs where id_lab = '150414' and date_loan between'" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'and '" + q2.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";
                string querychart4 = "SELECT * FROM booking_labs where id_lab = '150415' and date_loan between'" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'and '" + q2.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";
                string querychart5 = "SELECT * FROM booking_labs where id_lab = '150416' and date_loan between'" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'and '" + q2.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";
                int countroom2 = 0;
                SqlCommand cmdquerychart1 = new SqlCommand(querychart1, con);
                SqlCommand cmdquerychart2 = new SqlCommand(querychart2, con);
                SqlCommand cmdquerychart3 = new SqlCommand(querychart3, con);
                SqlCommand cmdquerychart4 = new SqlCommand(querychart4, con);
                SqlCommand cmdquerychart5 = new SqlCommand(querychart5, con);

                SqlDataReader readerquerychart1 = cmdquerychart1.ExecuteReader();


                while (readerquerychart1.Read())
                {
                    if (readerquerychart1["start_time"] != DBNull.Value)
                    {
                        a[0, 0] = a[0, 0] + Convert.ToDouble(readerquerychart1["start_time"]);
                        a[0, 1] = a[0, 1] + Convert.ToDouble(readerquerychart1["end_time"]);
                        a[0, 2] = a[0, 1] - a[0, 0];

                        if (aa[0] == null)
                        {
                            aa[0] = "150411";
                        }
                        //Response.Write("<script>alert('1')</script>");

                        countroom2++;
                    }
                }
                readerquerychart1.Close();

                SqlDataReader readerquerychart2 = cmdquerychart2.ExecuteReader();
                while (readerquerychart2.Read())
                {
                    if (readerquerychart2["start_time"] != DBNull.Value)
                    {
                        a[1, 0] = a[1, 0] + Convert.ToDouble(readerquerychart2["start_time"]);
                        a[1, 1] = a[1, 1] + Convert.ToDouble(readerquerychart2["end_time"]);
                        a[1, 2] = a[1, 1] - a[1, 0];

                        if (aa[1] == null)
                        {
                            aa[1] = "150413";
                        }
                        //Response.Write("<script>alert('2')</script>");

                        countroom2++;
                    }
                }
                readerquerychart2.Close();
                SqlDataReader readerquerychart3 = cmdquerychart3.ExecuteReader();
                while (readerquerychart3.Read())
                {
                    if (readerquerychart3["start_time"] != DBNull.Value)
                    {
                        a[2, 0] = a[2, 0] + Convert.ToDouble(readerquerychart3["start_time"]);
                        a[2, 1] = a[2, 1] + Convert.ToDouble(readerquerychart3["end_time"]);
                        a[2, 2] = a[2, 1] - a[2, 0];

                        if (aa[2] == null)
                        {
                            aa[2] = "150414";
                        }
                        //Response.Write("<script>alert('3')</script>");

                        countroom2++;

                    }
                }
                readerquerychart3.Close();
                SqlDataReader readerquerychart4 = cmdquerychart4.ExecuteReader();
                while (readerquerychart4.Read())
                {
                    if (readerquerychart4["start_time"] != DBNull.Value)
                    {
                        a[3, 0] = a[3, 0] + Convert.ToDouble(readerquerychart4["start_time"]);
                        a[3, 1] = a[3, 1] + Convert.ToDouble(readerquerychart4["end_time"]);
                        a[3, 2] = a[3, 1] - a[3, 0];
                        if (aa[3] == null)
                        {
                            aa[3] = "150415";
                        }
                        countroom2++;
                        Response.Write("<script>alert('"+aa[3]+"')</script>");

                    }


                }
                readerquerychart4.Close();
                SqlDataReader readerquerychart5 = cmdquerychart5.ExecuteReader();
                while (readerquerychart5.Read())
                {
                    if (readerquerychart5["start_time"] != DBNull.Value)
                    {
                        a[4, 0] = a[4, 0] + Convert.ToDouble(readerquerychart5["start_time"]);
                        a[4, 1] = a[4, 1] + Convert.ToDouble(readerquerychart5["end_time"]);
                        a[4, 2] = a[4, 1] - a[4, 0];

                        if (aa[4] == null)
                        {
                            aa[4] = "150416";
                        }
                        countroom2++;
                    }

                }
                readerquerychart5.Close();
            }

            if (CheckBox2.Checked)
            {
                int b = 0;
                countroom = checkcountroom(0);

                DateTime date1 = Convert.ToDateTime(datepickerr.Text);
                DateTime date2 = Convert.ToDateTime(datepickerr2.Text);
                TimeSpan date3 = date2 - date1;
                string forsplit = date3.ToString();
                string[] sAry = forsplit.Split('.');

                int countroom2 = 0;
                Response.Write(sAry[0] + 1);
                if (int.TryParse(sAry[0], out stringtoint)) ;
                if(stringtoint == 0)
                { stringtoint = 1; }
                for (int ia = 0; ia < stringtoint + 1; ia++)
                {
                    DateTime dateadd = date1.AddDays(ia);
                    string dateweek = dateadd.DayOfWeek.ToString();
                    string querychart1 = "SELECT * FROM booking_subjects where id_lab = '150411' and day ='" + dateweek + "'";
                    string querychart2 = "SELECT * FROM booking_subjects where id_lab = '150413' and day ='" + dateweek + "'";
                    string querychart3 = "SELECT * FROM booking_subjects where id_lab = '150414' and day ='" + dateweek + "'";
                    string querychart4 = "SELECT * FROM booking_subjects where id_lab = '150415' and day ='" + dateweek + "'";
                    string querychart5 = "SELECT * FROM booking_subjects where id_lab = '150416' and day ='" + dateweek + "'";

                    SqlCommand cmdquerychart1 = new SqlCommand(querychart1, con);
                    SqlCommand cmdquerychart2 = new SqlCommand(querychart2, con);
                    SqlCommand cmdquerychart3 = new SqlCommand(querychart3, con);
                    SqlCommand cmdquerychart4 = new SqlCommand(querychart4, con);
                    SqlCommand cmdquerychart5 = new SqlCommand(querychart5, con);

                    SqlDataReader readerquerychart1 = cmdquerychart1.ExecuteReader();

                    while (readerquerychart1.Read())
                    {
                        if (readerquerychart1["start_time"] != DBNull.Value)
                        {
                            a[0, 0] = /*a[0, 0] +*/ Convert.ToDouble(readerquerychart1["start_time"]);
                            a[0, 1] = /*a[0, 1] +*/ Convert.ToDouble(readerquerychart1["end_time"]);
                            a[0, 2] = a[0, 2] + (a[0, 1] - a[0, 0]);

                            if (aa[0] == null)
                            {
                                aa[0] = "150411";
                            }
                            //Response.Write("<script>alert('start" + a[0, 0] + "end" + a[0, 1] + "=" + a[0, 2] + "')</script>");

                            countroom2++;
                        }
                    }
                    readerquerychart1.Close();



                    //Response.Write(dateweek);


                    string[] changedaytonameday = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                    //int countroom2 = 0;
                    //SqlCommand cmdquerychart1 = new SqlCommand(querychart1, con);
                    //SqlCommand cmdquerychart2 = new SqlCommand(querychart2, con);
                    //SqlCommand cmdquerychart3 = new SqlCommand(querychart3, con);
                    //SqlCommand cmdquerychart4 = new SqlCommand(querychart4, con);
                    //SqlCommand cmdquerychart5 = new SqlCommand(querychart5, con);


                    SqlDataReader readerquerychart2 = cmdquerychart2.ExecuteReader();
                    while (readerquerychart2.Read())
                    {
                        if (readerquerychart2["start_time"] != DBNull.Value)
                        {
                            a[1, 0] = a[1, 0] + Convert.ToDouble(readerquerychart2["start_time"]);
                            a[1, 1] = a[1, 1] + Convert.ToDouble(readerquerychart2["end_time"]);
                            a[1, 2] = a[1, 1] - a[1, 0];

                            if (aa[1] == null)
                            {
                                aa[1] = "150413";
                            }
                            //Response.Write("<script>alert('2')</script>");
                            //Response.Write("<script>alert('start" + a[0, 0] + "end" + a[0, 1] + "=" + a[0, 2] + "')</script>");

                            countroom2++;
                        }
                    }
                    readerquerychart2.Close();
                    SqlDataReader readerquerychart3 = cmdquerychart3.ExecuteReader();
                    while (readerquerychart3.Read())
                    {
                        if (readerquerychart3["start_time"] != DBNull.Value)
                        {
                            a[2, 0] = a[2, 0] + Convert.ToDouble(readerquerychart3["start_time"]);
                            a[2, 1] = a[2, 1] + Convert.ToDouble(readerquerychart3["end_time"]);
                            a[2, 2] = a[2, 1] - a[2, 0];

                            if (aa[2] == null)
                            {
                                aa[2] = "150414";
                            }
                            //Response.Write("<script>alert('3')</script>");

                            countroom2++;

                        }
                    }
                    readerquerychart3.Close();
                    SqlDataReader readerquerychart4 = cmdquerychart4.ExecuteReader();
                    while (readerquerychart4.Read())
                    {
                        if (readerquerychart4["start_time"] != DBNull.Value)
                        {
                            a[3, 0] = a[3, 0] + Convert.ToDouble(readerquerychart4["start_time"]);
                            a[3, 1] = a[3, 1] + Convert.ToDouble(readerquerychart4["end_time"]);
                            a[3, 2] = a[3, 1] - a[3, 0];

                            if (aa[3] == null)
                            {
                                aa[3] = "150415";
                            }
                            countroom2++;
                        }
                    }
                    readerquerychart4.Close();
                    SqlDataReader readerquerychart5 = cmdquerychart5.ExecuteReader();
                    while (readerquerychart5.Read())
                    {
                        if (readerquerychart5["start_time"] != DBNull.Value)
                        {
                            a[4, 0] = a[4, 0] + Convert.ToDouble(readerquerychart5["start_time"]);
                            a[4, 1] = a[4, 1] + Convert.ToDouble(readerquerychart5["end_time"]);
                            a[4, 2] = a[4, 1] - a[4, 0];

                            if (aa[4] == null)
                            {
                                aa[4] = "150416";
                            }
                            countroom2++;
                        }
                    }
                    readerquerychart5.Close();
                }
                con.Close();
            }
            int i, j;
            string[] stack1 = new string[99]; string[] stack2 = new string[99]; string[] stack3 = new string[99];
            string[] stack4 = new string[99]; int[] startminus8 = new int[99];
            int[] endminus8 = new int[99]; int[] resultstartendbyminus = new int[99]; int[] stackf4 = new int[99];
            int[] stackf5 = new int[99]; int[] resultpoint = new int[99];
            //Response.Write("<script>alert('"+countroom2+"')</script>");

            //Response.Write("<script>alert('checkroom1="+a[0,2]+"')</script>");
            //series.Points.AddXY(aa[0], a[0, 2]);
            //Response.Write("countroom=" + countroom);
            //Response.Write("check === " + (a[0, 2]).ToString().Length);

            for (i = 0; i < countroom; i++)
            {
                Response.Write("NUM == " + i);
                //Response.Write("Room1 = " + (a[0, 1])+a[0, 0]);

                //Response.Write("Why hereeee" + (a[1, 1] - a[1, 0]));
                //Response.Write("ค่าทศนิยม111 " + (a[i, 1] - a[i, 0]));
                //Response.Write("Total Hours = " + a[i,2].ToString().Length);
                //if (a[i, 2].ToString().Length == 1 && (a[i, 1] - a[i, 0]).ToString() != "0")// ex.5
                if (a[i, 2].ToString().Length == 3 && a[i,2].ToString().Substring(1,1)==".")// ex.5
                {
                    Response.Write("check =1= " + (a[i, 2] + 0.2));
                    //series.Points.AddXY(aa[i], a[i, 2]);
                }
                //Response.Write("check === " + (a[0, 2]).ToString().Length);

                if (a[i, 2].ToString().Length == 2)// ex 12
                {
                    Response.Write("check =2= " + (a[i, 2] + 0.2));
                    //Response.Write("check =2= " + (a[i, 2]));

                    series.Points.AddXY(aa[i], a[i, 2]);
                }
                if (a[i, 2].ToString().Length == 3)// ex.5.3
                {
                    stack1[i] = a[i, 2].ToString().Substring(0, 1);// string for num
                    stack3[i] = a[i, 2].ToString().Substring(2, 1);// string for point
                    //Response.Write("ค่าทศนิยม " + stack3[i]);
                    if (Convert.ToInt32(stack3[i]) == 3)//เช็ค เวลา //ex 5.3 = 5.5
                    {
                        Response.Write("check =3.1= " + (a[i, 2] + 0.2));
                        series.Points.AddXY(aa[i], (a[i, 2] + 0.2));
                    }
                    if (Convert.ToInt32(stack3[i]) == 7)//เช็ค เวลา //ex 5.7 =5.5
                    {
                        Response.Write("check =3.2= " + ((a[i, 2]) - 0.2));
                        series.Points.AddXY(aa[i], (a[i, 2]) - 0.2);
                    }
                   
                }

                if (a[i, 2].ToString().Length == 4) // ex 12.3
                {
                    stack1[i] = a[i, 2].ToString().Substring(0, 1);// string for num
                    stack3[i] = a[i, 2].ToString().Substring(3, 1);// string for point
                    //Response.Write("ค่าทศนิยม " + stack3[i]);
                    if (Convert.ToInt32(stack3[i]) == 3)//เช็ค เวลา //ex 12.3 = 12.5
                    {
                        Response.Write("check =4.1= " + ((a[i, 2]) + 0.2));


                        series.Points.AddXY(aa[i], (a[i, 2]) + 0.2);
                    }
                    if (Convert.ToInt32(stack3[i]) == 7)//เช็ค เวลา //ex 12.7 = 12.5
                    {
                        Response.Write("check =4.2= " + ((a[i, 2]) - 0.2));
                        series.Points.AddXY(aa[i], (a[i, 2]) - 0.2);
                    }
                }              
            }
        }
    }
    void GetChartType()
    {
        foreach(int chartType in Enum.GetValues(typeof(SeriesChartType)))
        {
            ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType), chartType), chartType.ToString());
            DropDownList1.Items.Add(li);
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //GetChartData();
        Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedValue);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //clickforrefresh postback work at onload page
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
}