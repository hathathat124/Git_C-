<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editmanageuser.aspx.cs" Inherits="Room_editmanageuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <%--<link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">--%>
    <link href="../vendor/bootstrap2/css/bootstrap.css" rel="stylesheet"/>
    <link href="../css/creative.css" rel="stylesheet">

    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body style="background: url(/images/latar.png)">
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
            
             
            <br /><br />
              <div class="row">
                      <div class="span3" style="border-radius:70px 10px;border-top-left-radius:0px; margin-left:0px;margin-top:-40px;padding-bottom:10px;background:#ffed80;border-color:black;border:5px medium black;position:absolute">
                         <br />
                            <img src="/images/Administrator.png"/>        
                                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                                <br />
                                <br />                           
                                <asp:HyperLink ID="Button3" NavigateUrl="~/Room/room1.aspx" class="btn btn-info" style="margin-left:35px;" runat="server" Text="เลือกห้องจอง" OnClick="Button3_Click" />
                                <br />
                                <br />
                                <b><a><asp:HyperLink ID="Button6" NavigateUrl="../Home.aspx" visible="true" style="margin-left:35px;" CssClass="lili btn-danger btn"  OnClick="logout_Click"  runat="server" Text="ออกจากระบบ" BackColor="#4F514E" BorderColor="#4F514E" BorderStyle="None" float="right" Font-Bold="True"  /></a></b>                                       
                      </div>
                      <div class="span9"></div>
                 </div>
            
             <div class="row">

           <div class="offset3" style="margin-top:;padding:10px;">                             
               <div class="row">
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
                                    <td><b>แก้ไขประวัติ</b></td>
                                </tr>
                            </thead>
                            </table>
               </div>
               <div class="row" style="background:white;width:1000px;margin-top:20px;">
                   <div class="offset2" style="padding-left:100px;padding-top:30px">
                   <table style="width:;">
                       <tr>
                           <td class="auto-style1">
                               <asp:Label ID="Label3" runat="server" Text="รหัสประจำตัว (IDuser)" Font-Bold="True"></asp:Label>
                           </td>
                               <td style="text-align:left;">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtcollegeid" runat="server" ValidateRequestMode="Enabled" TextMode="Search" BackColor="#FFFFCC" ReadOnly="True"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcollegeid" ErrorMessage='<img src="/images/cancel.png">'></asp:RequiredFieldValidator>
                               </td>
                         
                           </tr>
                           <tr style="margin-left:2em;padding-left:2em;">
                               <td class="auto-style1"> <asp:Label ID="Label1" runat="server" Text="ชื่อ" Font-Bold="True"></asp:Label></td>
                               <td style="text-align:left;">
             
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     
              <asp:TextBox ID="txtname" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage='<img src="/images/cancel.png">' Display="Dynamic"></asp:RequiredFieldValidator>
                               </td>
                           </tr>
                   
                           <tr>
                               <td class="auto-style1"><asp:Label ID="Label2" runat="server" Text="นามสกุล" Font-Bold="True"></asp:Label>
                               </td>
                               <td style="text-align:left;">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtlastname" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlastname" ErrorMessage='<img src="/images/cancel.png">'></asp:RequiredFieldValidator>
                               </td>
                        
                           </tr>
                          
                             <tr>
                               <td class="auto-style1"><asp:Label ID="Label4" runat="server" Text="รหัสเข้าระบบ" Font-Bold="True"></asp:Label>
                                 </td>
                               <td style="text-align:left;" class="auto-style1">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="password" runat="server" ValidateRequestMode="Enabled" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="password" ErrorMessage='<img src="/images/cancel.png">'></asp:RequiredFieldValidator><br />

           
                             </td>
     
                           </tr>
                          
                             <tr>
                               <td class="auto-style1"><asp:Label ID="Label5" runat="server" Text="อีเมล" Font-Bold="True"></asp:Label>
                                 </td>
                               <td style="text-align:left;" class="auto-style1">
                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                   <asp:TextBox ID="email" runat="server" TextMode="Email" ValidateRequestMode="Enabled"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="email" ErrorMessage='<img src="/images/cancel.png">'></asp:RequiredFieldValidator>
                               

                              </td>
                         
                           </tr>
                           <tr>
                               <td>

                               </td>
                               <td>
                           <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="ตกลง" OnClick="Submit_Click1" />

                               </td>
                           </tr>

                           </table>
                      <br />
               </div>
                   </div>
                  
                </div>
                       </div>
              
        </div>
    </form>
</body>
</html>
