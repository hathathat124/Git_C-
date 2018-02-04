<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edituser.aspx.cs" Inherits="Room_edituser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background: url(/images/latar.png)">
    <form id="form1" runat="server">
        <div>
            
            <div class="top_header" style="padding-top:50px;text-align:center;background:white;">
                <img src="/images/head_logo_sci.png" />

            </div>
            <hr>
            <table style="width: 100%; height: auto;">
                  <tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                    <td colspan="2"></td>
                  </tr>
              </table>  
            <div>
              <div class="login"  style="text-align:center; width:20%;">
                  <div class="interface-login" style="padding-left:0px;"><br /><br>
            <img src="/images/Administrator.png">
                      <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                      &nbsp;<br /><br /><br />
                       <%--<button type="button">ออกจากระบบ</button>--%>
                                         
                      <%--<asp:Button ID="Button3" class="btn btn-info" runat="server" Text="ย้อนกลับ" OnClick="Button3_Click" />--%>
                                            <br /><br /><br />

                          
                  </div>
              </div>
              <div class="content-right-login" style="position:absolute;height:350px;width:100%;background: url(/images/latar.png)">
                  <div class="register2" style="top:-165px;margin-left:275px;position:absolute;;background-color:;">
                    
                      <br /><br />
                       <table style="width: 80%;margin-left:300px;">
                            <tr>
                               <td class="auto-style1">
                                   <asp:Label ID="Label3" runat="server" Text="รหัสประจำตัว" Font-Bold="True"></asp:Label>
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
    </form>
</body>
</html>
