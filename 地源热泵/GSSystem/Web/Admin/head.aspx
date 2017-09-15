<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="head.aspx.cs" Inherits="GSSystem.Web.Admin.head" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="inc/css.css" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 181px;
        }
    </style>
</head>
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0" rightmargin="0">
    <form id="form1" runat="server">
        <div> <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager></div> 
    <table cellspacing="0" cellpadding="0" width="100%" align="center" border="0" width="60px" style="height: 62px">
        <tbody>
            <tr>
                <td class="txlHeaderBackgroundAlternate" id="TableTitleLink" valign="center" height="40" style="font-size: 18px; width: 60%;">→ 欢迎你进入辽宁省地源热泵信息管理系统</td>
                <td class="txlHeaderBackgroundAlternate" id="TableTitleLink" valign="center" style="width:10% ;">&nbsp;</td>
                <td class="txlHeaderBackgroundAlternate" style="width:20% ;"><asp:UpdatePanel ID="UpdatePanel1" runat="server" bgcolor="#d6dff7">
                        <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="" Font-Size ="Medium" bgcolor="#d6dff7"></asp:Label> <asp:Timer ID="Timer1" runat="server" Interval="1000"/></ContentTemplate></asp:UpdatePanel></td>
                <td class="txlHeaderBackgroundAlternate" id="TableTitleLink" valign="center"
                    align="right" width="10%">                
                    <a href="main.aspx" target="mainFrame" style="font-size: 18px">返回主窗口</a></td>
            </tr>
             
        </tbody>
    </table>
    </form>
</body>
</html>
