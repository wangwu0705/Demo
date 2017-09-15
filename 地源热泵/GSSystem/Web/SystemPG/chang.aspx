<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chang.aspx.cs" Inherits="GSSystem.Web.SystemPG.chang" %>

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
            width: 59%;
        }
        .datalist2{
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
         .datalist2 th {
            border: 1px solid #0058a3; /* 行名称边框 */
            background-color: lavender; /* 行名称背景色 */
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
            text-align: center;
        }
          .datalist1 td {
            border: 1px solid #0058a3; /* 单元格边框 */
            text-align: left;
            padding-top: 4px;
            padding-bottom: 4px;
            padding-left: 10px;
            padding-right: 10px;
            text-align: center;
        }

        .datalist tr.altrow {
            background-color: #c7e5ff; /* 隔行变色 */
        }

        .auto-style2 {
            width: 310px;
        }

        .auto-style5 {
            width: 289px;
        }

        .auto-style6 {
            height: 24px;
        }

        .auto-style7 {
            width: 25%;
            height: 30px;
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
                <th style="font-size: 30px;">考察因素</th>
                <th style="font-size: 30px;">常规能源替代量</th>

            </tr>
            <tr>
                <th style="font-size: 30px;">系统类型</th>
                <th style="font-size: 30px;">采暖系统/空调系统</th>
            </tr>
        </table>
        <table class="datalist">
            <tr>
                <th style="font-size: 20px; text-align: left;">采暖系统</th>
            </tr>
            <tr>
                <th>η值选择表</th>
            </tr>
        </table>

        <table class="datalist" border="0">
            <tr>
                <th>常规能源类型</th>
                <th>热水系统</th>
                <th>采暖系统</th>
                <th>热力制冷空调系统</th>
            </tr>
            <tr>
                <td>电</td>
                <td>0.31</td>
                <td>-</td>
                <td>-</td>
            </tr>
            <tr class="altrow">
                <td>煤</td>
                <td>-</td>
                <td>0.70</td>
                <td>0.70</td>
            </tr>
            <tr>
                <td class="auto-style6">天然气</td>
                <td class="auto-style6">0.84</td>
                <td class="auto-style6">0.80</td>
                <td class="auto-style6">0.80</td>
            </tr>
        </table>
        <table>
            <tr>
                <td style="height: 5px"></td>
            </tr>
        </table>
        <table class="datalist1">
            <tr>
                <td style="text-align: center;" class="auto-style7">供暖季累计热负荷（MJ）</td>
                <td class="auto-style7">&nbsp;Qh<asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 26px" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 25%; height: 30px">加热效率</td>
                <td class="auto-style7">&nbsp;η
                    <asp:TextBox ID="TextBox2" runat="server" Style="margin-left: 26px" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center; width: 25%; height: 30px">每度电折合所耗标准煤量(kgce/kWh)</td>
                <td class="auto-style7">D <asp:TextBox ID="TextBox3" runat="server" Style="margin-left: 26px" Width="150px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="height: 52px; width: 380px" border="0">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" ForeColor="Black" Height="26px" OnClick="Button1_Click" Text="常规能源替代量Qs" Width="150px" BorderColor="Black" BorderWidth="1px" />
                    <asp:TextBox ID="TextBox8" runat="server" Style="Width:130px;Height:22px;" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <p>&nbsp;kgce</p>
                </td>
            </tr>
        </table>
        <table class="datalist">
            <tr>
                <th style="font-size: 20px; text-align: left;">空调系统</th>
            </tr>
            <tr>
                <th>EER值表</th>
            </tr>
        </table>
        <table class="datalist" border="0">
            <tr>
                <th>机组容量（kW）</th>
                <th>系统能效比EER</th>
            </tr>
            <tr>
                <td><528</td>
                <td>2.3</td>

            </tr>
            <tr class="altrow">
                <td>528~1163</td>
                <td>2.6</td>

            </tr>
            <tr>
                <td class="auto-style6">>1163</td>
                <td class="auto-style6">2.8</td>
            </tr>
        </table>
        <table>
            <tr>
                <td style="height: 5px"></td>
            </tr>
        </table>
        <table class="datalist1">
            <tr>
                <td style="text-align: center; width: 25%; height: 30px">每度电折合所耗标准煤量（kgce/kWh）</td>
                <td class="auto-style7">&nbsp; D &nbsp; <asp:TextBox ID="TextBox7" runat="server" Style="margin-left: 26px" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center; width: 25%; height: 30px">累计冷负荷（MJ）</td>
                <td class="auto-style7">&nbsp; Qc&nbsp;<asp:TextBox ID="TextBox4" runat="server" Style="margin-left: 25px" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: center; width: 25%; height: 30px">系统能效比</td>
                <td class="auto-style7">&nbsp; EER<asp:TextBox ID="TextBox5" runat="server" Style="margin-left: 25px" Width="150px"></asp:TextBox></td>
            </tr>
           

        </table>
        <table style="height: 47px; width: 362px">
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" ForeColor="Black" Height="25px" OnClick="Button2_Click" Text="常规能源替代量Qs" Width="150px" BorderColor="Black" BorderWidth="1px" />
                    <asp:TextBox ID="TextBox11" runat="server" Height="22px" Width="116px" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <p>&nbsp;kgce</p>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
