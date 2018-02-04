<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Detailsubject.aspx.cs" Inherits="Room_Detailsubject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
				            <th style="text-align:center;">เหตุผลที่จอง</th>

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
			                <td><asp:Label id="lblreason" runat="server"></asp:Label></td>


                        </tr>		
	                    </ItemTemplate>	
	                </asp:Repeater>
	            </table>
        </div>
    </form>
</body>
</html>
