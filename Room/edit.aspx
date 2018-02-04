<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="Room_edit" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>KU Register</title>
       <!-- Bootstrap Core CSS -->
    <link href="../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    
    <!-- Custom Fonts -->
    <link href="../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>

    <!-- Plugin CSS -->
    <link href="../vendor/magnific-popup/magnific-popup.css" rel="stylesheet">

    <!-- Theme CSS -->
    <link href="../css/creative.css" rel="stylesheet">

         


<style type="text/css">
    .top_header{
        margin-top:1.6em;
        position:center;
        text-align:center;
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
    .auto-style1 {
        width: 30%;
    }
    </style>
</head>

<body id="page-top">

 
     <form id="form1" runat="server">

    <header id="register">
      
     

        <div class="top_header">
        <img src="/images/register2.jpg " / style="width:30%">
                <hr>
            </div>
         
         
              <table style="width: 100%; height: auto;">
                  <tr  style="border-style: groove; border-width: thin;height:21px;background-color:black";>
                    <td colspan="2"></td>
                  </tr>
              </table>  
              
              <div class="content-right-login" style=";position:absolute;height:650px;width:100%;background: url(/images/latar.png)">
                  <div class="register2" style="margin-top:2em;background-color:;">
                      <img src="/images/Administrator.png">
                      <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                      <br /><br />
                       <table style="width: 100%;">
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
                               <td class="auto-style1">
                                   <asp:Label ID="Label3" runat="server" Text="รหัสประจำตัว" Font-Bold="True"></asp:Label>
                               </td>
                               <td style="text-align:left;">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtcollegeid" runat="server" ValidateRequestMode="Enabled" TextMode="Search" BackColor="#FFFF99" ReadOnly="True"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcollegeid" ErrorMessage='<img src="/images/cancel.png">'></asp:RequiredFieldValidator>
                               </td>
                         
                           </tr>
                             <tr>
                               <td class="auto-style1"><asp:Label ID="Label4" runat="server" Text="รหัสเข้าระบบ" Font-Bold="True"></asp:Label>
                                 </td>
                               <td style="text-align:left;">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="password" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
                                   <br />

           
                             </td>
     
                           </tr>
                         <%--  <tr>
                               <td class="auto-style1">
                                   <asp:Label ID="Label7" runat="server" Font-Bold="true" Text="ยินยันรหัสผ่าน"></asp:Label>
                                    
                               </td>
                               <td style="text-align:left">
                                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="password0" runat="server" ValidateRequestMode="Enabled" TextMode="Password"></asp:TextBox>
                                   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="password0" ErrorMessage="&lt;img src=&quot;/images/cancel.png&quot;&gt;รหัสผ่านไม่ตรงกัน"></asp:CompareValidator>
                                
                               </td>
                           </tr>--%>
                             <tr>
                               <td class="auto-style1"><asp:Label ID="Label5" runat="server" Text="อีเมล" Font-Bold="True"></asp:Label>
                                 </td>
                               <td style="text-align:left;">
                                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                   <asp:TextBox ID="email" runat="server" TextMode="Email" ValidateRequestMode="Enabled"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="email" ErrorMessage='<img src="/images/cancel.png">'></asp:RequiredFieldValidator>

                              </td>
                         
                           </tr>
                           </table>
                      <br />
                           <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="แก้ไข" OnClick="Submit_Click1" />
                </div>
                       
              </div>
        
             
  
    
    
            </header>
       </form>

</body>

</html>


