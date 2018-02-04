using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Room_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("Country"), new DataColumn("Salary") });
            dt.Rows.Add(1, "John Hammond", "United States", 70000);
            dt.Rows.Add(2, "Mudassar Khan", "India", 40000);
            dt.Rows.Add(3, "Suzanne Mathews", "France", 30000);
            dt.Rows.Add(4, "Robert Schidner", "Russia", 50000);
            rptCustomers.DataSource = dt;
            rptCustomers.DataBind();
        }
        if (datepickerr.Text == "")
        {
            datepickerr.Text = DateTime.Now.ToString("dd MMMM yyyy");
            string test = DateTime.Now.AddYears(0).ToString("dd MMMM yyyy");
            DateTime test2;
            if (DateTime.TryParse(test, out test2)) ;
            DateTime filld;
            filld = fillday(test2);
            sendmonday_sunday(Convert.ToDateTime(filld));
            for (int i = 0; i < 7; i++)
            {
                DateTime ss;
                //if (DateTime.TryParse(daym[i], out ss)) ;
            }
            for (int i = 0; i < 7; i++)
            {
                //if (DateTime.TryParse(daym[i], out ssdayofweek[i])) ;
            }

        }
        if (datepickerr.Text != "")
        {
            string test = datepickerr.Text;
            DateTime test2;
            if (DateTime.TryParse(test, out test2)) ;
            DateTime filld;
            filld = fillday(test2);
            sendmonday_sunday(Convert.ToDateTime(filld));

            for (int i = 0; i < 7; i++)
            {
                DateTime ss;
                //if (DateTime.TryParse(daym[i], out ss)) ;
            }
            for (int i = 0; i < 7; i++)
            {
                //if (DateTime.TryParse(daym[i], out ssdayofweek[i])) ;

            }


        }
        txtBox1.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                              Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show('สามารถกดได้แค่ตัวเลข')");

        Response.Write("<script>alert('"+daym[0]+"')</script>");
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
        daym[0] = dayforsend.ToString("dd MMMM yyyy");
        daym[1] = dayforsend.AddDays(1).ToString("dd MMMM yyyy");
        daym[2] = dayforsend.AddDays(2).ToString("dd MMMM yyyy");
        daym[3] = dayforsend.AddDays(3).ToString("dd MMMM yyyy");
        daym[4] = dayforsend.AddDays(4).ToString("dd MMMM yyyy");
        daym[5] = dayforsend.AddDays(5).ToString("dd MMMM yyyy");
        daym[6] = dayforsend.AddDays(6).ToString("dd MMMM yyyy");
    }

    
}