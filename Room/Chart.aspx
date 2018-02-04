<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Chart.aspx.cs" Inherits="Room_Chart" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
      <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <%--<meta name="viewport" content="width=device-width, initial-scale=1">--%>
    <meta name="description" content="">
    <meta name="author" content="">

    <title>KU</title>
     
    <!-- Bootstrap Core CSS -->
    <link href="../vendor/bootstrap2/css/bootstrap.min.css" rel="stylesheet">
    
    <!-- Custom Fonts -->
    <%--<link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">--%>
<%--    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>--%>

    <!-- Plugin CSS -->
    <link href="../vendor/magnific-popup/magnific-popup.css" rel="stylesheet">

    <!-- Theme CSS -->
    <link href="../css/creative.css" rel="stylesheet">
    <link rel="stylesheet" media="all" type="text/css" href="../datepicker2/css/sunny/jquery-ui-1.9.2.custom.css" />
    <%--<script src="../vendor/jquery/jquery.min.js"></script>--%>
<%--<script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>--%>    <%--<script type="text/javascript" src="../datepicker2/js/jquery-1.8.3.js"></script>--%>    <%--<script type="text/javascript" src="../datepicker2/js/jquery-1.8.3.js"></script>--%>      <%--<script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>--%>        <%--<script src="../vendor/jquery/jquery.min.js"></script>--%>
   
    <script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>
    <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>--%>
    <script type="text/javascript" src="../datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>
       <script type="text/javascript">

    

        $(function () {
            $('#datepickerr').datepicker({
                monthNames: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน',
                    'กรกฏาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'],
                monthNamesShort: ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.',
                    'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.'],
                dayNames: ['อาทิตย์', 'จันทร์', 'อังคาร', 'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'],
                dayNamesShort: ['อา.', 'จ.', 'อ.', 'พ.', 'พฤ.', 'ศ.', 'ส.'],
                dayNamesMin: ['อา.', 'จ.', 'อ.', 'พ.', 'พฤ.', 'ศ.', 'ส.'],
                dateFormat: 'dd MM yy',
                firstDay: 0,
                isRTL: false,
                isBuddhist: true,
                minDate: '',
                maxDate: '' + ''
            })
            $('#datepickerr2').datepicker({
                monthNames: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน',
                    'กรกฏาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'],
                monthNamesShort: ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.',
                    'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.'],
                dayNames: ['อาทิตย์', 'จันทร์', 'อังคาร', 'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'],
                dayNamesShort: ['อา.', 'จ.', 'อ.', 'พ.', 'พฤ.', 'ศ.', 'ส.'],
                dayNamesMin: ['อา.', 'จ.', 'อ.', 'พ.', 'พฤ.', 'ศ.', 'ส.'],
                dateFormat: 'dd MM yy',
                firstDay: 0,
                isRTL: false,
                isBuddhist: true,
                minDate: '',
                maxDate: '' + ''
            })
        });
</script>
</head>
<body style="background: url(/images/latar.png)">

    <form id="form1" runat="server">
        <div id="container" >
      
     
            
      <div class="row" style="width:1369.5px; background:black">
            <div class="row">
                <div class="span6 offset5">
                    <img style="height:80px;" src="/images/head_logo_sci.png" />                
                </div>
                <div class="row">
                    <div class="span12 offset3">
                       
                        </div>
                    </div>
                </div>
            </div> 
         
        <br />
        <br />
         
          <div id="row" style="width:100%;" >

              <%--<table style="width: 100%; height: auto;">
                  <tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                    <td colspan="2"></td>
                  </tr>
              </table>
               --%>
             
               <%--   <asp:DropDownList ID="ddl_id_lab" runat="server"></asp:DropDownList>--%>

                            
              <div class="row" style="margin-left:0px;margin-top:-39px;">
                      <div class="span3" style="border-radius:70px 10px;border-top-left-radius:0px; margin-left:0px;margin-top:-1px;padding-bottom:10px;background:#ffed80;border-color:black;border:5px medium black;position:absolute">
                         <br />
                            <img src="/images/Administrator.png">        
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                             <br />
                             <br />
                            
                             <asp:HyperLink ID="Button3" class="btn btn-info" NavigateUrl="~/Room/room1.aspx"  style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                             <br />
                             <br />
                             <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                                        
                        </div>
                        <div class="span9"></div>
                 </div>              
    <div class="span12 offset4" style=";">
                  <br /><br />
         <div>
            <asp:Panel ID="Panel1" style="width:850px;" runat="server" BorderColor="Black" BorderWidth="1">
         <asp:Chart ID="Chart1" width="600px" runat="server" BorderlineColor="Black" BackColor="Gainsboro">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1" BackColor="#9999FF">
                        <AxisX Title ="ห้อง"></AxisX>
                        <AxisY Title ="ชั่วโมง"></AxisY>
                    </asp:ChartArea>
                </chartareas>
            <Legends>
                <asp:Legend Name="information"  BackColor="SkyBlue" TitleAlignment="Near"></asp:Legend>
            </Legends>
            </asp:Chart>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=NASENG-PC\SQLEXPRESSSTDARD;Initial Catalog=MyProject_DB;User ID=sa;Password=1234561" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [booking_labs]"></asp:SqlDataSource>
            <asp:TextBox ID="datepickerr" Width="100px" runat="server"></asp:TextBox>
            <asp:TextBox ID="datepickerr2" Width="100px" runat="server"></asp:TextBox>
            <asp:Button ID="Button1"  CssClass="btn btn-success" runat="server" OnClick="Button1_Click" Text="ตกลง" />   
                <b>จองรายวัน</b>&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" />
                <b>จองรายเทอม</b>&nbsp;<asp:CheckBox ID="CheckBox2" runat="server" />
   
        </asp:Panel>
        </div>
 
             
         
                </div> 
            </div>

        <span></span>
            </div>

    </form>
</body>
</html>
