<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="GSSystem.Web.SystemPG.All" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .datalist {
            border: 1px solid #0058a3; /* 表格边框 */
            font-family: Arial;
            border-collapse: collapse; /* 边框重叠 */
            background-color: #eaf5ff; /* 表格背景色 */
            font-size: 14px;
            text-align: center;
            width: 100%;
        }

        .tt {
            background-color: #B0C4DE;
            color: white;
        }

        .datalist caption {
            padding-bottom: 5px;
            font: bold 1.4em;
            text-align: center;
            vertical-align: middle;
        }

        .datalist th {
            border: 1px solid #0058a3; /* 行名称边框 */
            background-color: #4bacff; /* 行名称背景色 */
            color: #FFFFFF; /* 行名称颜色 */
            font-weight: bold;
            padding-top: 4px;
            padding-bottom: 4px;
            padding-left: 12px;
            padding-right: 12px;
            text-align: center;
            vertical-align: middle;
        }

        .datalist td {
            border: 1px solid #0058a3; /* 单元格边框 */
            text-align: left;
            padding-top: 4px;
            padding-bottom: 4px;
            padding-left: 10px;
            padding-right: 10px;
        }

        .datalist tr.altrow {
            background-color: #c7e5ff; /* 隔行变色 */
        }

        .auto-style1 {
            width: 121px;
        }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
        <div>
            <img src="../Admin/left.files/xtpg.jpg" style="height: 150px; margin-bottom: 0px; width: 100%;" />
        </div>
        <table class="datalist">
            <tr>
                <th style="font-size: 30px;">地源热泵系统等级判定</th>
            </tr>
            <tr>
                <th style="font-size: 20px; text-align: left;">地源热泵系统的性能级别划分</th>
            </tr>
        </table>
        <table class="datalist" border="0">
            <tr>
                <th>工况</th>
                <th>1级</th>
                <th>2级</th>
                <th>3级</th>
            </tr>
            <tr>
                <td style="text-align: center;">制热性能系数</td>
                <td style="text-align: center;">COP≥3.5</td>
                <td style="text-align: center;">3.5≥COP≥3.0</td>
                <td style="text-align: center;">3.0≥COP≥2.6</td>
            </tr>
            <tr class="altrow">
                <td style="text-align: center;">制冷能效比</td>
                <td style="text-align: center;">EER≥3.9</td>
                <td style="text-align: center;">3.9≥EER≥3.4</td>
                <td style="text-align: center;">3.4≥EER≥3.0</td>
            </tr>
        </table>
        <table class="datalist">
            <tr>
                <th style="font-size: 30px;" width="30%">考察因素</th>
                <th style="font-size: 30px;" width="70%" colspan="5">总评</th>

            </tr>
            <tr>
                <td style="text-align: center">热泵系统功能</td>
                <td colspan="5" style="text-align: center">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width ="150px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>冬季使用</asp:ListItem>
                        <asp:ListItem>夏季使用</asp:ListItem>
                        <asp:ListItem>冬夏季使用</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="text-align: center">常规能源节省量</td>
                <td colspan="5">
                    <asp:Label ID="Label2" runat="server" Text=" "></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: center">CO2减排量</td>
                <td colspan="5" style="text-align: center">
                    <asp:Label ID="Label3" runat="server" Text=" "></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: center">SO2减排量</td>
                <td colspan="5" style="text-align: center">
                    <asp:Label ID="Label4" runat="server" Text=" "></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: center">粉尘减排量</td>
                <td colspan="5">
                    <asp:Label ID="Label5" runat="server" Text=" "></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: center" width="15%">机组</td>
                <td style="text-align: center">COP</td>
                <td width="20%">
                    <asp:Label ID="Label8" runat="server" Text=" "></asp:Label></td>
                <td style="text-align: center" width="15%">EER</td>
                <td colspan="2" width="20%" style="text-align: center">
                    <asp:Label ID="Label9" runat="server" Text=" "></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: center">系统</td>
                <td style="text-align: center">COP</td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text=" "></asp:Label></td>
                <td style="text-align: center">EER</td>
                <td colspan="2">
                    <asp:Label ID="Label7" runat="server" Text=" "></asp:Label></td>
            </tr>
        </table>
        <table class="datalist">
            <tr>
                <th style="font-size: 30px;" width="70%">地源热泵系统性能级别</th>
                <th style="font-size: 30px;" width="30%" colspan="5"><asp:Label ID="Label10" runat="server" Text=" "></asp:Label></th>

            </tr>
        </table>
    </form>
</body>
</html>
