<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>
<!DOCTYPE html>

<html>
<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>KU</title>

    <!-- Bootstrap Core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.css" rel="stylesheet">
    <link href="vendor/bootstrap/css/cssbutton.css" rel="stylesheet">
    <!-- Custom Fonts -->
    <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>

    <!-- Plugin CSS -->
    <link href="vendor/magnific-popup/magnific-popup.css" rel="stylesheet">

    <!-- Theme CSS -->
    <link href="css/creative.css" rel="stylesheet">

    <link rel="stylesheet" media="all" type="text/css" href="/datepicker2/css/sunny/jquery-ui-1.9.2.custom.css" />
       <script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>
    <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>--%>
    <script type="text/javascript" src="../datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>
<%--<script type="text/javascript" src="/datepicker3/js/jquery-1.4.4.min.js"></script>
<script type="text/javascript" src="/datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>--%>
<script>

    var datepicked = function () {
       
    }
 
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
    });   
    //var datepicked = function () {

    //}

    //$(function () {
    //    $("#datepickerr").datepicker({ dateFormat: 'dd/mm/yy', isBuddhist: true, defaultDate: toDay })
        

    //});

</script>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

<style type="text/css">
    .top_header{
        margin-top:7em;
    }
    html {
    background: url(polished-stucco-texture_23-2147506837.gif) no-repeat center center fixed;
    -webkit-background-size: cover;
    -moz-background-size: cover;
    -o-background-size: cover;
    background-size: cover;
}
 .black-ribbon {
  position: fixed;
  z-index: 9999;
  width: 70px;
}
@media only all and (min-width: 768px) {
  .black-ribbon {
    width: auto;
  }
}

.stick-left { left: 0; }
.stick-right { right: 0; }
.stick-top { top: 0; }
.stick-bottom { bottom: 0; }
    </style>
</head>
<body id="page-top">

    <nav id="mainNav" class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" style="background-color:white;color:blue" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span> Menu <i class="fa fa-bars"></i>
                </button>
                  
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1" style="background-color: rgb(150,150,150, 0);">
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a class="page-scroll" href="#promotion">เข้าสู่ระบบ</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#showdate">ดูตารางเวลาห้อง</a>
                    </li>
                 
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container-fluid -->
    </nav>
    <form id="form1" runat="server">
    <div>
        <header id="promotion">
            <div class="top_header">
                <img src="/images/head_logo_sci.png" />
            </div>
                <hr>
             <div id="page-one" style="height:1760px;" width="100%">
             <table style="width: 100%; height: auto;">
                <tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                    <td colspan="2"></td>
                </tr>
              </table>


             <div class="content-right-login" style=";position:absolute;margin-left:364.5px;width:73%;background: url(images/latar.png)">
            
               

                <div class="quoteOfDay" style="width:75%;margin-left:50px;background:#fcfef0;border:solid 1px #d8e9c4;margin-top:25px;text-align:;">
	                <h4><b>ยินดีต้อนรับเข้าสู่</b></h4>
	                <marquee style="padding-left: 30px;padding-right:30px;"><i style="color: #5b5b5b;"><h4><b>" ระบบจองห้องเรียนออนไลน์ "<b /></h4></i></marquee>
	            </div>  <%--<asp:DropDownList ID="ddl_id_lab" runat="server"></asp:DropDownList>--%>
                <div class="shownumroom" style="border-left:2px solid #808080  ;margin-left:50px;margin-right:25px;margin-top:25px;background:#fcfef0;padding-top:25px">


                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>





                  <%--  <table style="border-style: ; border-width: thin;width:100%;margin-bottom:50px;">
                          <tr>
                                <div class="alert alert-info" style="width: 75%; margin-left:50px; margin-top:25px;margin-right:50px;text-align:left;padding-left:25px;">
				<b> ห้องปฏิบัติการ ตึก15</b>
			</div>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><font size="4"><b>15101</b></font><br /><asp:Button ID="btn_room1" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room1_Click" /></td>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><font size="4"><b>15102</b></font><br /><asp:Button ID="btn_room2" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room2_Click" /></td>
                              
                          </tr>
                          <tr>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><br /><font size="4"><b>15103</b></font><br /><asp:Button ID="btn_room3" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room3_Click" /></td>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><br /><font size="4"><b>15104</b></font><br /><asp:Button ID="btn_room4" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room4_Click" /></td>
                              
                          </tr>
                          <tr>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><br /><font size="4"><b>15105</b></font><br /><asp:Button ID="btn_room5" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room5_Click" /></td>
                              
                              
                          </tr>
                       
                      </table>
                      <table style="border-style: ; border-width: thin;width:100%;margin-bottom:75px;">
                          <tr>
                                <div class="alert alert-info" style="width: 75%; margin-left:50px; margin-top:25px;margin-right:50px;text-align:left;padding-left:25px;">
				<b> ห้องปฏิบัติการ ตึก2</b>
			</div>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><font size="4"><b>15101</b></font><br /><asp:Button ID="Button2" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room1_Click" /></td>
                              <td style ="padding-bottom:15px;text-align:center;"><img src="/images/logo kasetsart.jpg" style="width: 205px; height: 220px" /><br /><font size="4"><b>15102</b></font><br /><asp:Button ID="Button3" class="btn btn-primary btn-md"  runat="server" Text="จองห้อง" OnClick="btn_room2_Click" /></td>
                              
                          </tr>
                          </table>--%>
                  </div>
           
              </div>

           
                  <%--<asp:DropDownList ID="ddl_id_lab" runat="server"></asp:DropDownList>--%>

                            
              <div class="login"  style="height:255px; width:27%;background:#fcfef0">
                  <img src="/images/logo science login.jpg" style=""/> <br /><br />

                  <div class="interface-login" style="padding-left:px;">
                       <%--<asp:TextBox ID="txtid2" Width="156px" placeholder="User Name" runat="server"></asp:TextBox> <br />
                       <asp:TextBox ID="Txtpass2" Width="156px"  placeholder="Password" TextMode="Password" runat="server"></asp:TextBox> <br /><br />--%>
                    
                      <img src="images/Administrator.png">
                      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

                      <br /><br />
                       <%--<button type="button">ออกจากระบบ</button>--%>
                      
                      <asp:Button ID="btnedit" class="btn btn-info" runat="server" Text="แก้ไขการจอง" OnClick="edit_booking_Click" />
   <br /><br />
                      <asp:Button ID="btnaddsubject" class="btn btn-info" runat="server" Width="110px" Text="เพิ่มรายวิชา" OnClick="addsubject_Click" />
   <br /><br />
                      <asp:Button ID="btnmanageuser" class="btn btn-info" runat="server"  Text="จัดการยูเซอร์" OnClick="manage_user_Click" />
                         <br /><br />
                       <asp:HyperLink class="btn btn-info" Runat="server" NavigateUrl="~/Room/register.aspx" Text="สมัครยูเซอร์" onclick="window.open (this.href, 'popupwindow',  'width=700,height=700,scrollbars,resizable'); return false;"></asp:HyperLink>           

   <br /><br />
                      <asp:Button ID="btnchart" class="btn btn-info" runat="server" Width="110px" Text="ดูรายงาน" OnClick="Chart_Click" />
                      <br /><br />
                      <asp:Button ID="logout" class="btn btn-info"  runat="server"  Text="ออกจากระบบ" OnClick="logout_Click"   />
              
                  </div>
  
    
              </div>

              
          </div>
        <span></span>
            </header>
     <main id="showdate">
          
             <table style="width: 100%; height: auto;"><tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                 <td></td></tr></table>
                <div class="top_page2" style="text-align:center;padding-top:50px;padding-bottom:25px;">
             <asp:Label ID="Label3" runat="server" Text="วันที่"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:TextBox ID="datepickerr" runat="server"  Visible="true" AutoCompleteType="Disabled" OnTextChanged="Page_Load" ></asp:TextBox>
 &nbsp;&nbsp;&nbsp;&nbsp;

     <asp:Button ID="Button1" class="btn btn-info" runat="server" Text="ดูตารางเวลา"  PostBackUrl="admin#showdate" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Label"  Font-Bold="True"  Font-Size="X-Large"></asp:Label>

                    <%--<asp:Button ID="Button1" class="btn btn-info" runat="server" Text="ดูตารางเวลา" OnClick="Button1_Click" PostBackUrl="user#showdate" />--%>
             </div>
           <table class="lab" border="3px solid black" cellspacing="0" cellpadding="0" align="center" width="80%"style="margin-top:50px;"  >
                      <tr bgcolor="#2966B8">

                            <th width="14%">
                                <font color="#FFFFFF"> เวลา / ห้อง </font>
                            </th>

                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF"> <h5><b>08.00-09.00</b></h5> </font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>09.00-10.00</b></h5> </font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>10.00-11.00</b></h5> </font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>11.00-12.00</b></h5> </font>                                           
                            </th>

                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>12.00-13.00</b></h5></font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>13.00-14.00</b></h5></font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>14.00-15.00</b></h5></font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>15.00-16.00</b></h5></font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>16.00-17.00</b></h5></font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>17.00-18.00</b></h5></font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>18.00-19.00</b></h5> </font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>19.00-20.00</b></h5> </font>                                           
                            </th>
                            <th width="6.5384615384615384615384615384615%" colspan=2>                
                                <font color="#FFFFFF" > <h5><b>20.00-21.00</b></h5> </font>                                           
                            </th>
                            <%--  <th width="8.3333313970937043168462528922579%" colspan=2>                
                                <font color="#FFFFFF">  <h5><b>19.30-20.30</b></h5></font>                                           
                            </th>--%>

                        </tr>
               
                    <tr>
                       <th bgcolor="#2966B8" height="34px">                
                           <h5> <font  color="#FFFFFF"> <b>15101</b></font> </h5>                                          
                        </th>
                        <td bgcolor ="<%=ba0%>" align="center">   <%// 8.00 %>
                            
                            </td>
                        <td bgcolor ="<%=ba1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=ba2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=ba3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=ba4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=ba5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=ba6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=ba7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=ba8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=ba9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=ba10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=ba11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=ba12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=ba13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=ba14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=ba15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=ba16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=ba17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=ba18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=ba19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=ba20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=ba21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=ba22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=ba23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=ba24%>" align="center">   <%// 20.00 %>
                            
                        </td>

                          <td bgcolor ="<%=ba25%>" align="center">   <%// 20.30 %>
                            
                        </td>

                             <td  >                           
                        </td>



                        
                    </tr>

                     <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> <h5><b>15102</b></h5></font>                                           
                        </th>
                         <td bgcolor ="<%=bb0%>" align="center">   <%// 8.30 %>
                            
                            </td>
                         <td bgcolor ="<%=bb1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=bb2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=bb3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=bb4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=bb5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bb6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bb7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=bb8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bb9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bb10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bb11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bb12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bb13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bb14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=bb15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bb16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bb17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bb18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bb19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=bb20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=bb21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bb22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bb23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bb24%>" align="center">   <%// 20.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bb25%>" align="center">   <%// 20.00 %>
                            
                        </td>
                     </tr>
                    
                     <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> <h5><b>15103</b></h5></font></th>
                         <td bgcolor ="<%=bc0%>" align="center">   <%// 8.30 %>
                            
                            </td> 
                         <td bgcolor ="<%=bc1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=bc2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=bc3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=bc4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=bc5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bc6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bc7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=bc8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bc9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bc10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bc11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bc12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bc13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bc14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=bc15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bc16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bc17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bc18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bc19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=bc20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=bc21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bc22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bc23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bc24%>" align="center">   <%// 20.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bc25%>" align="center">   <%// 20.00 %>
                            
                        </td>
                     </tr>
                     <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> <h5><b>15104</h5></b></font>                                           
                        </th>
                         <td bgcolor ="<%=bd0%>" align="center">   <%// 8.30 %>
                            
                            </td> 
                         <td bgcolor ="<%=bd1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=bd2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=bd3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=bd4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=bd5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bd6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bd7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=bd8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bd9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bd10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bd11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bd12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bd13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bd14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=bd15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bd16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bd17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bd18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bd19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=bd20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=bd21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bd22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bd23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bd24%>" align="center">   <%// 20.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bd25%>" align="center">   <%// 20.00 %>
                            
                        </td>
                     </tr>
                     <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> <h5><b>15201</h5></b></font>                                           
                        </th>
                         <td bgcolor ="<%=be0%>" align="center">   <%// 8.30 %>
                            
                            </td>
                          <td bgcolor ="<%=be1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=be2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=be3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=be4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=be5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=be6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=be7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=be8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=be9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=be10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=be11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=be12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=be13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=be14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=be15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=be16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=be17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=be18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=be19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=be20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=be21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=be22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=be23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=be24%>" align="center">   <%// 20.00 %>
                            
                        </td>

                         <td bgcolor ="<%=be25%>" align="center">   <%// 20.00 %>
                            
                        </td>
                     </tr>
                     <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> <h5><b>15202</h5></b></font>                                           
                        </th>
                         <td bgcolor ="<%=bf0%>" align="center">   <%// 8.30 %>
                            
                            </td>
                         <td bgcolor ="<%=bf1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=bf2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=bf3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=bf4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=bf5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bf6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bf7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=bf8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bf9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bf10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bf11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bf12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bf13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bf14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=bf15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bf16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bf17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bf18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bf19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=bf20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=bf21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bf22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bf23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bf24%>" align="center">   <%// 20.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bf25%>" align="center">   <%// 20.00 %>
                            
                        </td>
                     </tr>
                         <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> <h5><b>15203</h5></b></font>                                           
                        </th>
                             <td bgcolor ="<%=bg0%>" align="center">   <%// 8.30 %>
                            
                            </td>
                            <td bgcolor ="<%=bg1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=bg2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=bg3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=bg4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=bg5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bg6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bg7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=bg8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bg9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bg10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bg11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bg12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bg13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bg14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=bg15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bg16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bg17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bg18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bg19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=bg20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=bg21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bg22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bg23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bg24%>" align="center">   <%// 20.00 %>
                            
                        </td>
                             <td bgcolor ="<%=bg25%>" align="center">   <%// 20.00 %>
                            
                        </td>
                     </tr>

<%--                      <tr>
                        <th bgcolor="#2966B8" height="34px">                
                            <font  color="#FFFFFF"> 15204</font>                                           
                        </th>
                          <td bgcolor ="<%=bh1%>" align="center">   <%// 8.30 %>
                            
                            </td>
                        <td bgcolor ="<%=bh2%>" align="center">   <%// 9.00 %>
                            
                            </td>
                        <td bgcolor ="<%=bh3%>" align="center">   <%// 9.30 %>

                           
                        </td>
                        <td bgcolor ="<%=bh4%>" align="center">   <%// 10.00 %>
                            
                        </td>
                        <td bgcolor ="<%=bh5%>" align="center">   <%// 10.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bh6%>" align="center">   <%// 11.00 %>
                            
                        </td>

                         <td bgcolor ="<%=bh7%>" align="center">   <%// 11.30 %>

                            
                        </td>
                        <td bgcolor ="<%=bh8%>" align="center">   <%// 12.00 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bh9%>" align="center">   <%// 12.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bh10%>" align="center">   <%// 13.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bh11%>" align="center">   <%// 13.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bh12%>" align="center">   <%// 14.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bh13%>" align="center">   <%// 14.30 %>
                            
                        </td>
                        
                         <td bgcolor ="<%=bh14%>" align="center">   <%// 15.00 %>

                            
                        </td>
                        <td bgcolor ="<%=bh15%>" align="center">   <%// 15.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bh16%>" align="center">   <%// 16.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bh17%>" align="center">   <%// 16.30 %>

                            
                        </td>
                         <td bgcolor ="<%=bh18%>" align="center">   <%// 17.00 %>
                            
                        </td>
                         <td bgcolor ="<%=bh19%>" align="center">   <%// 17.30 %>
                            
                        </td>
                         <td bgcolor ="<%=bh20%>" align="center">   <%// 18.00 %>

                            
                        </td>
                         <td bgcolor ="<%=bh21%>" align="center">   <%// 18.30 %>
                            
                        </td>
                          <td bgcolor ="<%=bh22%>" align="center">   <%// 19.00 %>
                            
                        </td>
                        
                        <td bgcolor ="<%=bh23%>" align="center">   <%// 19.30 %>

                            
                        </td>
                         <%--<td bgcolor ="<%=bh24%>" align="center">   <%// 20.00 %>
                            
                        </td>

                     </tr>			--%>
					 </table>           
         <div class="top_page2" style="text-align:center;padding-top:50px;padding-bottom:25px;">
             <asp:Label ID="Label1" runat="server" Text="ตารางเวลา" style="position:center;font-size:x-large;" Font-Bold="true" ></asp:Label>
             </div>
 	<table border="1" class="lab" width="80%"style="margin-top:50px;margin-left:170px;">
    <asp:Repeater id="myRepeater" runat="server" onItemDataBound="myRepeater_ItemDataBound">
	<HeaderTemplate>		
			<tr  cellspacing="0" cellpadding="2"  style="background-color:aquamarine;">
				<%--<th style="text-align:center;">เลือก</th>--%>
				<th style="text-align:center;">ห้อง</th>
				<th style="text-align:center;">ไอดี</th>
				<th style="text-align:center;">ตั้งแต่</th>
				<th style="text-align:center;">จนถึง</th>
				<th style="text-align:center;">วันที่จองห้อง</th>
				<th style="text-align:center;">ณ เวลาที่ทำจอง</th>

            </tr>
	</HeaderTemplate>
	<ItemTemplate>
		<tr>
			<%--<td><asp:CheckBox id="chkCustomerID" runat="server"></asp:CheckBox></td>--%>			
			<td><asp:Label id="lblroom" runat="server"></asp:Label></td>
			<td><asp:Label id="lblid" runat="server"></asp:Label></td>
			<td><asp:Label id="lblstart" runat="server"></asp:Label></td>
            <td><asp:Label id="lblend" runat="server"></asp:Label></td>
			<td><asp:Label id="lbldateloan" runat="server"></asp:Label></td>
			<td><asp:Label id="lbldate" runat="server"></asp:Label></td>

        </tr>		
	</ItemTemplate>	
	</asp:Repeater>
	</table>
     </main>
        <%-- <section id="informations-ec">
                   <table style="width: 100%; height: auto;"><tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                 <td></td></tr></table>
         <table class="lab"  cellspacing="0" cellpadding="0"  width="73%" align="center"  >
             <tr align="center" style="">
                 <td> <div class="information" style="width:100%;text-align:center; ">
                  <a><h2>ข่าวสาร</h2></a>
                  <div class="msg" style="background:#eeeeee;padding:0em; border:medium ridge #808080">
                       asdfasdfasdfasdf
                       <br /><br /><br /><br /><br /><br /><br /><br /><br />
                  </div>
                          
                  <br /><br /><br />
          <br />
          <br /> 
              </div></td> 
             </tr>
         </table>
</section>--%>
        
     
                          
    </div>
         
    </form>

    
       <!-- jQuery -->
    <%--<script src="vendor/jquery/jquery.min.js"></script>--%>

    <!-- Bootstrap Core JavaScript -->
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <%--<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>--%>
    <script src="vendor/jqueryeasing.js"></script>
    <script src="vendor/scrollreveal/scrollreveal.min.js"></script>
    <script src="vendor/magnific-popup/jquery.magnific-popup.min.js"></script>
    
    <!-- Theme JavaScript -->
    <script src="js/creative.min.js"></script>
</body>
</html>
