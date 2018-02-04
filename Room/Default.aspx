<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Room_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" media="all" type="text/css" href="../datepicker2/css/sunny/jquery-ui-1.9.2.custom.css" />
    <script type="text/javascript" src="../datepicker3/js/jquery-1.4.4.min.js"></script>
    <%--<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>--%>
    <script type="text/javascript" src="../datepicker3/js/jquery-ui-1.8.10.offset.datepicker.min.js"></script>
    
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
    $(function () {
        $("#lab [id*=chkHeaderr]").click(function () {
            if ($(this).is(":checked")) {
                $("#lab [id*=chkRow]").attr("checked", "checked");
            } else {
                $("#lab [id*=chkRow]").removeAttr("checked");
            }
        });
        $("#lab [id*=chkRow]").click(function () {
            if ($("#lab [id*=chkRow]").length == $("#lab [id*=chkRow]:checked").length) {
                $("#lab [id*=chkHeaderr]").attr("checked", "checked");
            } else {
                $("#lab [id*=chkHeaderr]").removeAttr("checked");
            }
        });
    });
</script>

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

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="datepickerr" runat="server" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            <asp:Button ID="Button1" runat="server"  Text="Button" />

            <img border="0" src="../images/javascript-tip162_formcal.gif" width="16"  height="16"/>
            <asp:TextBox ID="txtBox1" runat="server" onKeyPress=""  ></asp:TextBox>
        </div>
        
<asp:Repeater ID="rptCustomers" runat="server">
    <HeaderTemplate>
        <table id="lab" border="0" cellpadding="0" cellspacing="0">
            <thead>
                <tr>
                    <th><asp:CheckBox ID="chkHeaderr" runat="server" /></th>
                    <th>Customer Id</th>
                    <th>Customer Name</th>
                    <th>Country</th>
                    <th>Salary</th>
                </tr>
            </thead>
    </HeaderTemplate>
    <ItemTemplate>
        <tbody>
            <tr>
                <td><asp:CheckBox ID="chkRow" runat="server" /></td>
                <td><%#Eval("Id")%></td>
                <td><%#Eval("Name")%></td>
                <td><%#Eval("Country")%> </td>
                <td><%#Eval("Salary")%></td>
            </tr>
        </tbody>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>

    </form>
</body>
</html>
