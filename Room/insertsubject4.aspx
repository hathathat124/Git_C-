<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertsubject4.aspx.cs" Inherits="Room_insertsubject4" %>



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
    <link href="../vendor/bootstrap2/css/bootstrap.min.css" rel="stylesheet">
    
    <!-- Custom Fonts -->
    <link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
<%--    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>--%>

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


  
    <%--<script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>--%>
    <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>--%>
    <%--<script type="text/javascript" src="../datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>--%>
        <%--<script type="text/javascript" src="    http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.1/jquery-ui.js"></script>--%>

        <%--<script type="text/javascript" src="    http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.1/jquery-ui.js"></script>--%>

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
                    minDate: '0d',
                    maxDate: '7d' + ''
                })
            });
    //var datepicked = function () {

    //}

    //$(function () {
    //    $("#datepickerr").datepicker({ dateFormat: 'dd/mm/yy', isBuddhist: true, defaultDate: toDay })


    //});

</script>

   


    </head>
<body id="page-top" style="background: url(/images/latar.png)">

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
    
        
     

      <div class="row" style="width:1375.5px; background:black">
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
             
               <%--   <asp:DropDownList ID="ddl_id_lab" runat="server"></asp:DropDownList>--%>

                       <div class="row">
                      <div class="span3" style="border-radius:70px 10px;border-top-left-radius:0px; margin-left:0px;margin-top:-40px;padding-bottom:10px;background:#ffed80;border-color:black;border:5px medium black;position:absolute">
                         <br />
                            <img src="/images/Administrator.png">        
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                <br />
                                <br />
                           
                                <asp:HyperLink ID="Button3" NavigateUrl="~/Room/room1.aspx" class="btn btn-info" style="margin-left:35px;"  runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                                <br />
                                <br />
                                <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                  
                              </div>  
           <div class="row">
               <div class="span12 offset7">
                   <asp:Label ID="lblnameterm" runat="server" Text="ภาคการเรียนที่"></asp:Label>
                    <asp:DropDownList ID="ddl_term" style="width:50px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove"  runat="server"></asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
                    <asp:Label ID="lblnameschoolyear"  runat="server" Text="ปีการศึกษา"></asp:Label><asp:DropDownList ID="ddl_schoolyear" style="width:75px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" runat="server"></asp:DropDownList>               
	                &nbsp&nbsp<asp:Button ID="Button5" class="btn btn-info" runat="server" Text="ตกลง" OnClick="Button5_Click" />               
                    
               </div>
               <div class="row">
               <div class="span12 offset4" style="margin-top:20px;">

                            <table class="table"  style="top:100px;width:1000px;">
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
                                    <td><b>เพิ่มเทอม-ปีการศึกษา</b></td>
                                </tr>
                            </thead>
                            </table>
                <br />
                </div>
                   </div>
               <div class="span12 offset4">
                    
                   <asp:Label ID="lblinsertidlab" runat="server"   Text="ห้อง"></asp:Label> <asp:DropDownList ID="ddlinsertidlab"  style="width:80px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" runat="server"></asp:DropDownList>
                   <asp:Label ID="lblinsertidsubject" runat="server" Text="รหัสวิชา"></asp:Label><asp:TextBox ID="txtinsertidsubject"  runat="server" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" BackColor="#E9FBB4"></asp:TextBox>
                   <asp:Label ID="lblinsertnamesubject" runat="server" Text="ชื่อวิชา"></asp:Label><asp:TextBox ID="txtinsertnamesubject" runat="server" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" BackColor="#E9FBB4"></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lblinsertday" runat="server" Text="วัน"></asp:Label>&nbsp;<asp:DropDownList ID="ddlinsertday" style="width:80px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove"  runat="server"></asp:DropDownList>           
                   <asp:Label ID="lblinsertstart" runat="server" Text="ตั้งแต่"></asp:Label><asp:DropDownList ID="ddlinsertstart" style="width:80px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" runat="server"></asp:DropDownList>
                   <asp:Label ID="lblinsertend" runat="server" Text="จนถึง"></asp:Label><asp:DropDownList ID="ddlinsertend" style="width:80px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" runat="server"></asp:DropDownList>
                   <asp:Label ID="lblinsertsec" runat="server" Text="หมู่เรียน"></asp:Label><asp:TextBox ID="txtinsertsec" Width="50px" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" runat="server" BackColor="#E9FBB4"></asp:TextBox>
                   <asp:Label ID="lblinsertteacher" runat="server" Text="ชื่ออาจารย์/รหัสที่ทำการจอง"></asp:Label> <asp:TextBox ID="txtinsertteacher" BorderWidth="2px" BorderColor="GrayText" BorderStyle="Groove" runat="server" BackColor="#E9FBB4"></asp:TextBox>

	               <br />
	               <br />
               <div class="offset3">
               <asp:Button ID="btninsert" class="btn btn-success" runat="server" Text="เพิ่มรายวิชา" OnClick="btninsert_Click"  />
                &nbsp;&nbsp;&nbsp;     <asp:Button id="Button4" class="btn btn-danger" runat="server" Text="ลบรายวิชา" OnClick="Button4_Click" />
             </div>
<br /><br />
           <%--       <table style="width: 100%; height: auto;margin-left:px;">
                  <tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                    <td colspan="2"></td>--%>
             <%--     </tr>
              </table>--%>	            	      
                      <%--<input type="text" id="datepickerr" name="date1" readonly="readonly" />--%>            
               &nbsp;
               &nbsp&nbsp&nbsp&nbsp&nbsp
            </div>

           </div>
              <div class="row">
             
                  <div class="span13 offset2">
              <table border="2" class="table-hover table-striped" style=";width:1140px">
                    <asp:Repeater id="myRepeater" runat="server" onItemDataBound="myRepeater_ItemDataBound" >

	                <HeaderTemplate>		
                        
			            <tr  cellspacing="0" cellpadding="2"  style="background-color:aquamarine;height:38px">
				            <th style="text-align:center;background-color:aquamarine;">เลือก</th>
				            <th style="text-align:center;background-color:aquamarine;">ห้อง</th>
				            <th style="text-align:center;background-color:aquamarine;">รหัสวิชา</th>
				            <th style="text-align:center;background-color:aquamarine;">รายชื่อวิชา</th>
				            <th style="text-align:center;background-color:aquamarine;">วัน</th>
				            <th style="text-align:center;background-color:aquamarine;">ตั้งแต่</th>
				            <th style="text-align:center;background-color:aquamarine;">จนถึง</th>
				            <th style="text-align:center;background-color:aquamarine;">หมู่เรียน</th>
				            <th style="text-align:center;width:29%;background-color:aquamarine;">อาจารย์ผู้สอน</th>
                            <%--<th style="text-align:center:">แก้ไข</th>--%>
                       </tr>
	                </HeaderTemplate>
	                <ItemTemplate>
		               <tr style="background:#cde0fe;">
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:CheckBox id="chkCustomerID" runat="server"></asp:CheckBox></td>	
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblroom" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblidsub" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblnamesub" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblday" runat="server"></asp:Label></td>
                            <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblstart" runat="server"></asp:Label></td>
                            <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblend" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblsec" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:2px;padding-bottom:2px;"><asp:Label id="lblteacher" runat="server"></asp:Label></td>
                      </tr>		

	                </ItemTemplate>	
                        
	                </asp:Repeater>

	                </table>
                      </div>
                </div>       
             </div>
         </div>
        
    </form>
    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
</script>
    
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

