<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SystemCE.aspx.cs" Inherits="GSSystem.Web.SystemPG.SystemCE" %>

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
        .auto-style2 {
            width: 28%;
        }
        .auto-style3 {
            width: 22%;
        }
        .auto-style7 {
            width: 254px;
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
        <table border="1" class="datalist">
            <tr>
                <th>热泵系统制冷比COP、制热性能系数EER</th>
            </tr>
        </table>
        <table class="datalist">
           
            <tr>
                <td class="auto-style2">所有热泵机组累计消耗电量（kWh）</td>
                <td class="auto-style3">Ni&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Style="margin-left: 18px" Width="130px"></asp:TextBox>
                </td>
                <td class="auto-style2">所有水泵累计消耗电量（kWh）</td>
                <td class="auto-style3">N&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" Style="margin-left: 18px" Width="130px"></asp:TextBox>
                </td>
            </tr>          
            <tr>
                  <td class="auto-style7">冬季测试期间系统用户侧进出口介质温差（℃）</td>
                <td>t&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" Style="margin-left: 18px" Width="130px"></asp:TextBox>
                </td>
                <td class="auto-style7">夏季测试期间系统用户侧进出口介质温差（℃）</td>
                <td>&nbsp;t&nbsp;&nbsp; <asp:TextBox ID="TextBox8" runat="server" Style="margin-left: 18px" Width="130px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">冬季测试持续时间</td>
                <td class="auto-style3">T <asp:TextBox ID="TextBox9" runat="server" Style="margin-left: 26px" Width="130px"></asp:TextBox>
                </td>
                  <td class="auto-style2">冬季测试期间系统用户侧平均流量（m³/h）</td>
                <td class="auto-style3">V&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server" Style="margin-left: 18px" Width="130px"></asp:TextBox>
                </td>
            </tr>
             <tr>
                 <td class="auto-style2">夏季测试持续时间</td>
                <td class="auto-style3">T <asp:TextBox ID="TextBox5" runat="server" Style="margin-left: 26px" Width="130px"></asp:TextBox>
                </td>
                  <td class="auto-style2">夏季测试期间系统用户侧平均流量（m³/h）</td>
                <td class="auto-style3">V&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 18px" Width="130px"></asp:TextBox>
                </td>
              
            </tr>
        </table>
        <div>
            <table style="height: 52px; width: 675px" border="0">
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" ForeColor="Black" Height="22px" OnClick="Button1_Click" Text="计算COP、EER" Width="118px" BorderColor="Black" BorderWidth="1px" />
                    </td>              
                    <td>
                        <p>&nbsp;&nbsp;&nbsp;&nbsp; COP：<asp:TextBox ID="TextBox11" runat="server" Text="" Height="18px" Enabled="False"></asp:TextBox></p>
                    </td>
                    <td>
                        <p>&nbsp;&nbsp;&nbsp; EER：<asp:TextBox ID="TextBox12" runat="server" Text="" Height="18px" Enabled="False"></asp:TextBox></p>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
