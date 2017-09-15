<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JiZu.aspx.cs" Inherits="GSSystem.Web.SystemPG.JiZu" %>

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

        .datalist1 {
            border: 1px solid #0058a3; /* 表格边框 */
            font-family: Times New Roman;
            border-collapse: collapse; /* 边框重叠 */
            background-color: #eaf5ff; /* 表格背景色 */
            font-size: 14px;
            text-align: center;
            width: 65%;
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
         .datalist1 th {
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

        .datalist1 td {
            border: 1px solid #0058a3; /* 单元格边框 */
            text-align: center;
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
            height: 36px;
        }

        .auto-style2 {
            width: 58%;
        }

        .auto-style3 {
            width: 234px;
            height: 36px;
        }
        .auto-style4 {
            height: 36px;
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
        <table>
            <tr>
                <td style="width:10px"></td>
            </tr>
        </table>
        <table class="datalist1">
            <tr>
                <th class="datelist1" colspan="2">热泵机组制冷比COP、制热性能系数EER</th>
            </tr>
            <tr>
                <td class="auto-style2">制冷时热泵机组用户侧平均流量（m³/h）</td>
                <td style="text-align: left">&nbsp;V&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 22px" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">制热时热泵机组用户侧平均流量（m³/h）</td>
                <td style="text-align: left">&nbsp;V&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Style="margin-left: 22px" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">热泵机组用户侧进出口介质平均温差（℃）</td>
                <td style="text-align: left">&nbsp;Δt&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Style="margin-left: 22px" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">测试期间机组平均输入功率（kW）</td>
                <td style="text-align: left">&nbsp;N&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Style="margin-left: 22px" Width="150px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div>
            <table style="height: 28px; width: 639px" border="0">
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" ForeColor="Black" Height="22px" OnClick="Button1_Click" Text="计算COP、EER" Width="118px" BorderColor="Black" BorderWidth="1px" />
                    </td>
                    <td class="auto-style3">
                        <p>&nbsp;&nbsp;&nbsp; COP：<asp:TextBox ID="TextBox5" runat="server" Height="18px" style="margin-top: 0px" Width="138px" Enabled="False"></asp:TextBox></p>
                    </td>
                    <td class="auto-style4">
                        <p>&nbsp;&nbsp;&nbsp; EER：<asp:TextBox ID="TextBox6" runat="server" Height="18px" Enabled="False"></asp:TextBox></p>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
