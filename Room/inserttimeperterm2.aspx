<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inserttimeperterm2.aspx.cs" Inherits="Room_inserttimeperterm2" %>

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
    <%--<link href="../vendor/bootstrap2/css/bootstrap.min.css" rel="stylesheet"/>--%>
    <link href="../vendor/bootstrap2/css/bootstrap.css" rel="stylesheet">

    <%--<link href="../vendor/bootstrap2/css/bootstrap-responsive.min.css" rel="stylesheet"/>--%>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        $("#lab [id*=chkHeader]").click(function () {
            if ($(this).is(":checked")) {
                $("#lab [id*=chkCustomerID]").attr("checked", "checked");
            } else {
                $("#lab [id*=chkCustomerID]").removeAttr("checked");
            }
        });
        $("#lab [id*=chkRow]").click(function () {
            if ($("#lab [id*=chkCustomerID]").length == $("#lab [id*=chkCustomerID]:checked").length) {
                $("#lab [id*=chkHeader]").attr("checked", "checked");
            } else {
                $("#lab [id*=chkHeader]").removeAttr("checked");
            }
        });
    });
</script>
    <!-- Custom Fonts -->
    <link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
<%--    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>--%>

    <!-- Plugin CSS -->
    
    <!-- Theme CSS -->
    <link href="../css/creative.css" rel="stylesheet">
     
    <link rel="stylesheet" media="all" type="text/css" href="../datepicker2/css/sunny/jquery-ui-1.9.2.custom.css" />
  
    <script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>

    <style>        
 body {
            background-color: #fff; /*rgb(22, 160, 133);*/
            width: 100%;
            margin: 0;
            padding: 0;
        }</style>
 
        <script type="text/javascript">
            $(function () {

                $('#txtinsertdatestart').datepicker({


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
                $('#txtinsertdateend').datepicker({


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
        <div class="container-fluid">
            
        <%--<div class="row">
                <span id="mainNav" class="" style="">
                    <img style="height:80px;" src="/images/head_logo_sci.png" />
                </span>
            </div>--%>   
        <div class="row" style="width:1350.5px; background:black">
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
            <div class="span12 ">
                </div>
            </div>
                  <div class="row">
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
                      <%--<asp:Button ID="Button3" class="btn btn-info" style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                             <br />
                             <br />

                     <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                  
                          --%>
                      </div>
                        <div class="span9"></div>

                 </div>
                 <div class="row">
                      <%--<div class="span3"> 
                          <div class="row" style="background:">
                             <br />
                             <br />
                             
                              <asp:Button ID="Button3" class="btn btn-info" style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                             <br />
                             <br />
                                    <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                  
                            </div>
                         </div>--%>

                         <div class="span12 offset3" style="margin-top:35px;">
                             
                             <asp:Label ID="lblnameterm" runat="server" Text="ภาคการเรียนที่"></asp:Label>
                             <asp:DropDownList ID="ddl_term" BorderWidth="2px" BorderColor="GrayText" runat="server"></asp:DropDownList>&nbsp&nbsp&nbsp&nbsp
                             <asp:Label ID="lblnameschoolyear" runat="server" Text="ปีการศึกษา"></asp:Label><asp:DropDownList ID="ddl_schoolyear" BorderWidth="2px" BorderColor="GrayText" runat="server"></asp:DropDownList>              
	                         &nbsp&nbsp<asp:Button ID="Button5" class="btn btn-info" runat="server" Text="ตกลง" OnClick="Button5_Click" />
                             &nbsp&nbsp ต้องการข้อมูลทั้งหมด&nbsp&nbsp<asp:CheckBox ID="CheckBox1" runat="server" />
                            <br />
                            <br />
                            <table class="table"  style="">
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
         
                   <asp:Label ID="lblinsertterm" runat="server" Text="เทอม"></asp:Label>
                   &nbsp;&nbsp;<asp:DropDownList ID="ddlinsertterm" BorderWidth="2px" BorderColor="GrayText" runat="server"></asp:DropDownList>           
                   <asp:Label ID="lblinsertschoolyear" runat="server" Text="ปีการศึกษา"></asp:Label>
                   &nbsp;&nbsp;<asp:DropDownList ID="ddlinsertschoolyear" BorderWidth="2px" BorderColor="GrayText" runat="server"></asp:DropDownList>  
                   <br />
               <br />
                   <asp:Label ID="lblinsertdatestart" runat="server" Text="วันที่เปิดภาคเรียนการศึกษา"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="txtinsertdatestart"  runat="server" BorderWidth="2px" BorderColor="GrayText" BackColor="#FFFFCC"></asp:TextBox>
                   <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                   <asp:Label ID="lblinsertdateend" runat="server" Text="วันที่ปิดภาคเรียนการศึกษา"></asp:Label>&nbsp;&nbsp;<asp:TextBox ID="txtinsertdateend"  runat="server" BorderWidth="2px" BorderColor="GrayText" BackColor="#FFFFCC"></asp:TextBox>
	               <br />
                   <br />
               <div class="row">
                   <div class="span2 offset4">

               <asp:Button ID="btninsert" class="btn btn-success" runat="server" Text="เพิ่ม" OnClick="btninsert_Click"  />
                &nbsp;&nbsp;&nbsp;     <asp:Button id="Button4" class="btn btn-danger" runat="server" Text="ลบ" OnClick="Button4_Click" />             

                   </div>
                    </div>  
	               <asp:Label id="lblText" runat="server" Visible="False"></asp:Label> <br /><br />          
               &nbsp;
               &nbsp&nbsp&nbsp&nbsp&nbsp
                            </div>
                          <div class="span12 offset3">
                          <div class="row">
              <table border="2" class="lab table-hover table-striped"  style="width:1200px">
                    <asp:Repeater id="myRepeater" runat="server" onItemDataBound="myRepeater_ItemDataBound" >

	                <HeaderTemplate>		
			            <tr  cellspacing="0" cellpadding="2"  style="background-color:aquamarine;height:30px">                               <th style="text-align:center;width:26px;background-color:aquamarine;"><asp:CheckBox ID="chkHeader" runat="server" /></th>				
				            <th style="text-align:center;width:50px;background-color:aquamarine;">เทอม</th>
				            <th style="text-align:center;width:120px;background-color:aquamarine;">ปีการศึกษา</th>
				            <th style="text-align:center;width:220px;background-color:aquamarine;">วันที่เปิดภาคเรียนการศึกษา</th>
				            <th style="text-align:center;width:220px;background-color:aquamarine;">วันที่จบภาคเรียนการศึกษา</th>
			           </tr>
	                </HeaderTemplate>
	                <ItemTemplate>
		               <tr style="background:white;">
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:px;padding-bottom:px;"><asp:CheckBox id="chkCustomerID" runat="server"></asp:CheckBox></td>	
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:px;padding-bottom:px;"><asp:Label id="lblroom" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:px;padding-bottom:px;"><asp:Label id="lblidsub" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:px;padding-bottom:px;"><asp:Label id="lblnamesub" runat="server"></asp:Label></td>
			                <td style="text-align:center;padding-left:5px;padding-right:5px;padding-top:px;padding-bottom:px;"><asp:Label id="lblday" runat="server"></asp:Label></td>
                      </tr>		

	                </ItemTemplate>	
                        
	                </asp:Repeater>

	            </table>
         </div> 

                      </div>
                 </div>
                 <div class="row">
                    <div class="span14 offset1" style="padding-left:20px;">

                    </div>
                 </div>
                 

          </div>

    </form>
   
       <!-- jQuery -->
    <%--<script src="../vendor/jquery/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <%--<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>--%>



  
    <!-- Theme JavaScript -->
</body>

</html>

