﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manageuser.aspx.cs" Inherits="Room_manageuser" %>

 
<!DOCTYPE html>

<html>
<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <%--<meta name="viewport" content="width=device-width, initial-scale=1">--%>
    <meta name="description" content="">
    <meta name="author" content="">

    <title>KU</title>
     
    <!-- Bootstrap Core CSS -->
    <%--<link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">--%>
    <link href="../vendor/bootstrap2/css/bootstrap.css" rel="stylesheet">
    
    <!-- Custom Fonts -->
    <link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
    <%--<link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>--%>

    <!-- Plugin CSS -->
    <link href="../vendor/magnific-popup/magnific-popup.css" rel="stylesheet">

    <!-- Theme CSS -->
    <link href="../css/creative.css" rel="stylesheet">
     
    <link rel="stylesheet" media="all" type="text/css" href="../datepicker2/css/sunny/jquery-ui-1.9.2.custom.css" />
    <%--<script src="../vendor/jquery/jquery.min.js"></script>--%>

<%--<script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>--%>
    <%--<script type="text/javascript" src="../datepicker2/js/jquery-1.8.3.js"></script>--%>
    <%--<script type="text/javascript" src="../datepicker2/js/jquery-1.8.3.js"></script>--%>
      <%--<script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>--%>
        <%--<script src="../vendor/jquery/jquery.min.js"></script>--%>
  
    <script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>
    <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>--%>
    <script type="text/javascript" src="../datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>

       <%--<link rel="stylesheet" media="all" type="text/css" href="../datepicker2/css/sunny/jquery-ui-1.9.2.custom.css" />--%>
    <%--<script src="../vendor/jquery/jquery.min.js"></script>--%>

    <%--<script type="text/javascript" src="../datepicker3/js/jsanother/jquery-ui-1.8.16.offset.datepicker.min.js"></script>--%>


  

<%--    <script>
        function openNewWindow() {
            alert('HI');
            window.open(this.href http://www.stackoverflow.com, 'popupwindow', 'width=700,height=700,scrollbars,resizable');
            //window.open('http://www.stackoverflow.com');
        }
        </script>--%>
        <script type="text/javascript">

        //var datepicked = function () {

        //}

        //jQuery.noConflict();
        //jQuery(document).ready(function ()
        //$.noConflict();
        //jQuery(document).ready(function ()

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
                minDate: '0d',
                maxDate: '' + ''
            })
            function Navigate() {
                javascript: window.open("http://www.microsoft.com");
            }    
        });
    //var datepicked = function () {

    //}

    //$(function () {
    //    $("#datepickerr").datepicker({ dateFormat: 'dd/mm/yy', isBuddhist: true, defaultDate: toDay })


    //});

</script>



    </head>
<body id="page-top">

<%--    <nav id="mainNav" class="navbar navbar-default navbar-fixed-top">
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
    </nav>--%>
    <form id="form1" runat="server">
    <div class="container" style="margin-left:10px;">
      
     
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
                <div class="row">
                      <div class="span3" style="border-radius:70px 10px;border-top-left-radius:0px; margin-left:0px;margin-top:0px;padding-bottom:10px;background:#ffed80;border-color:black;border:5px medium black;position:absolute">
                         <br />
                            <img src="/images/Administrator.png">        
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                             <br />
                             <br />
                           
                              <asp:HyperLink ID="HyperLink1" class="btn btn-info" NavigateUrl="~/Room/room1.aspx"  style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                             <br />
                             <br />
                                    <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                  
                      <%--<asp:Button ID="Button3" class="btn btn-info" style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                             <br />
                             <br />

                     <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                  
                          --%>
                      </div>
                        <div class="span9"></div>

                 </div>
                <div class="row">
                    <br />
                    <div class="row">
                         <div class="offset3" style="width:890px;">
                            <table class="table"  style="margin-left:30px;">
                            <thead>
                                <tr class=""  style="solid 0px green;-webkit-border-radius:10px;
                                -moz-border-radius:100px;
                                border-radius:10px;
    
                                background: rgba(179,220,237,1);
                                background: -moz-linear-gradient(top, rgba(179,220,237,1) 0%, rgba(41,184,229,1) 60%, rgba(188,224,238,1) 100%);
                                background: -webkit-gradient(left top, left bottom, color-stop(0%, rgba(179,220,237,1)), color-stop(60%, rgba(41,184,229,1)), color-stop(100%, rgba(188,224,238,1)));
                                background: -webkit-linear-gradient(top, rgba(179,220,237,1) 0%, rgba(41,184,229,1) 60%, rgba(188,224,238,1) 100%);
                                background: -o-linear-gradient(top, rgba(179,220,237,1) 0%, rgba(41,184,229,1) 60%, rgba(188,224,238,1) 100%);
                                background: -ms-linear-gradient(top, rgba(179,220,237,1) 0%, rgba(41,184,229,1) 60%, rgba(188,224,238,1) 100%);
                                background: linear-gradient(to bottom, rgba(179,220,237,1) 0%, rgba(41,184,229,1) 60%, rgba(188,224,238,1) 100%);
                                filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#b3dced', endColorstr='#bce0ee', GradientType=0 );
                                ">
                                    <td><b>จัดการยูเซอร์</b></td>
                                </tr>
                            </thead>
                            </table>
                             </div>
                             </div>

                         <div class="span12 offset4" style="margin-left:;">
                             <div class=" offset0">
                        <asp:Label ID="Label1" style="margin-left:50px;" runat="server" Text="ค้นหาไอดี"></asp:Label>
                <%--<asp:DropDownList  ID="ddl_search" BorderWidth="2px" Width="130px" BorderColor="GrayText" runat="server"></asp:DropDownList>--%>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_search" BorderWidth="2px" Height="20px" BorderColor="GrayText" runat="server" Width="139px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;

                <asp:Button ID="btn_search"  class="btn btn-info" runat="server" Text="ตกลง" OnClick="btn_search_Click" style="height: 36px" />
                <br />
                    </div>


	            <table border="1" class="lab table-striped table-hover" width="80%"style="margin-top:18px;margin-left:0px;">
                    <asp:Repeater id="myRepeater" runat="server" onItemDataBound="myRepeater_ItemDataBound" OnItemCommand="myRepeater_ItemCommand">
	                    <HeaderTemplate>		
			            <tr  cellspacing="0" cellpadding="2"  style="background-color:aquamarine;">
                            <th style="text-align:center;width:26px;background-color:aquamarine;"><asp:CheckBox ID="chkHeader" runat="server" /></th>				

				            <th style="text-align:center;background-color:aquamarine;">ไอดีผู้ใช้</th>
				            <th style="text-align:center;background-color:aquamarine;">รหัสผ่าน</th>
				            <th style="text-align:center;background-color:aquamarine;">ชื่อ</th>
				            <th style="text-align:center;background-color:aquamarine;">นามสกุล</th>
				            <th style="text-align:center;background-color:aquamarine;">สถานะ</th>
				            <th style="text-align:center;background-color:aquamarine;">อีเมล</th>
				            <th style="text-align:center;background-color:aquamarine;">ณ เวลาที่เป็นสมาชิก</th>
				            <th style="text-align:center;background-color:aquamarine;">แก้ไข</th>
                  

                        </tr>
	                    </HeaderTemplate>
	                    <ItemTemplate>
		                <tr style="background:#cde0fe;">
			                <td style="width:26px;text-align:center;"><asp:CheckBox id="chkCustomerID" runat="server"></asp:CheckBox></td>			
			                <td style="text-align:center;"><asp:Label id="lbliduser" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblpassword" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblname" runat="server"></asp:Label></td>
                            <td style="text-align:center;"><asp:Label id="lbllastname" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblstatus" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblemail" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lbldate_register" runat="server"></asp:Label></td>
			                   <td style="text-align:center;">
       <asp:LinkButton ID="LinkButton1" class="btn btn-warning" runat="server" Text="แก้ไข" CommandName="EditCommand" CommandArgument='<%# Eval("id_user")%>'></asp:LinkButton>
        </td>  
                        </tr>		
	                    </ItemTemplate>	
	                </asp:Repeater>
	            </table>
                             <div class="offset3">
                                 <br /><br />
                    <asp:Button id="Button4" class="btn btn-danger"  runat="server" Text="ลบข้อมูล" OnClick="Delete_Click" />

                    <asp:Button ID="btninsert" class="btn btn-success " runat="server" Text="ส่งอีเมลล์" OnClick="btnsendemail_Click"  />
               &nbsp;<asp:Label  id="lblText"  runat="server"></asp:Label> 
         </div>
                             </div>
	     
                </div>                  
	            <br />

                <br />&nbsp&nbsp&nbsp&nbsp&nbsp
              
                         
          </div>
          <span></span>
        
    
    </form>
    
       <!-- jQuery -->
    <%--<script src="../vendor/jquery/jquery.min.js"></script>--%>

    <!-- Bootstrap Core JavaScript -->
    <script src="../vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <%--<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>--%>



    <script src="../vendor/jqueryeasing.js"></script>
    <script src="../vendor/scrollreveal/scrollreveal.min.js"></script>
    <script src="../vendor/magnific-popup/jquery.magnific-popup.min.js"></script>
    
    <!-- Theme JavaScript -->
    <script src="../js/creative.min.js"></script>
</body>

</html>
