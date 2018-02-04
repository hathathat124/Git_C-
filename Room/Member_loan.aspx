<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Member_loan.aspx.cs" Inherits="Room_Default6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <%--<link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>--%>
    <link href="../vendor/bootstrap2/css/bootstrap.css" rel="stylesheet"/>
    <link href="../css/creative.css" rel="stylesheet"/>

</head>
<body style="background: url(/images/latar.png)">


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
                      <%--<asp:Button ID="Button3" class="btn btn-info" style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                             <br />
                             <br />

                     <b><a><asp:Button ID="Button6" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                  
                          --%>
                      </div>
                        <div class="span9"></div>

                 </div><div class="row">
           <div class="offset3" style="margin-top:50px;">

                            <table class="table"  style="top:100px;position:absolute;width:1000px;">
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
                                    <td><b>ประวัติการจองห้องออนไลน์</b></td>
                                </tr>
                            </thead>
                            </table>
                <br />
           </div>
                     <div class="row">
                         <div class="span10 offset4">
                             <asp:Label ID="Label1" style="margin-left:50px;" runat="server" Text="ค้นหา"></asp:Label>
                <asp:DropDownList  ID="ddl_search" BorderWidth="2px" BorderColor="GrayText" runat="server"></asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_search" BorderWidth="2px" BorderColor="GrayText" runat="server" Width="139px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;

                <asp:Button ID="btn_search"  class="btn btn-info" runat="server" Text="ตกลง" OnClick="btn_search_Click" style="height: 36px" />
                <br />
                             <table border="2" class="lab table-hover table-striped" width="1000px"style="background:white;margin-top:10px;margin-left:0px;">
                    <asp:Repeater id="myRepeater2" runat="server" onItemDataBound="myRepeater2_ItemDataBound">
	                <HeaderTemplate>		
			            <tr  cellspacing="0" cellpadding="2"  style="background-color:aquamarine;">
				            <th style="text-align:center;background-color:aquamarine;width:36px;">ห้อง</th>
                            <th style="text-align:center;background-color:aquamarine;">ไอดี</th>
                            <th style="text-align:center;background-color:aquamarine;">ชื่อ</th>
				            <th style="text-align:center;background-color:aquamarine;">เวลา</th>
				            <th style="text-align:center;background-color:aquamarine;">วันที่จอง</th>
				            <th style="text-align:center;background-color:aquamarine;">ณ เวลาที่ทำจอง</th>
				            <th style="text-align:center;background-color:aquamarine;">ชื่อคนที่จองผ่าน admin</th>
                       </tr>
	                </HeaderTemplate>
	                <ItemTemplate>
		               <tr>
                            <td style="text-align:center;"><asp:Label id="lblroom_b" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblid_b" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblname_b" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lblstart_b" runat="server"></asp:Label></td>
			                <td style="text-align:center;"><asp:Label id="lbldateloan_b" runat="server"></asp:Label></td>
                            <td style="text-align:center;"><asp:Label id="lbldate_b" runat="server"></asp:Label></td>
                            <td style="text-align:center;"><asp:Label id="lblloan_by_admin_b" runat="server"></asp:Label></td>
                      </tr>		
	                </ItemTemplate>	
	                </asp:Repeater>
	                </table>       
                         </div>
                     </div>
               
          </div>
        <span></span>
    </div>
         
    </form>

</body>
</html>
