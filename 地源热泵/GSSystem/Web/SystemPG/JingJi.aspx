<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JingJi.aspx.cs" Inherits="GSSystem.Web.SystemPG.JingJi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .st {
            text-align: center;
            font-size: 14px;
        }

        .datalist {
            border: 1px solid #0058a3; /* 表格边框 */
            font-family: Arial;
            border-collapse: collapse; /* 边框重叠 */
            background-color: #eaf5ff; /* 表格背景色 */
            font-size: 14px;
            text-align: center;
            width: 530px;
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

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="datalist">
                <tr>
                    <th colspan="2">地源热泵系统年节约费用Cs（元/年）</th>
                </tr>         
                    <tr>
                        <td>请输入每年运行维护增加费用 M:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>请输入当地天然气或煤气价格（元/Nm3或元/kg）Pr:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>请输入天然气或煤的热值（天然气11kWh/Nm3,煤：8.14kWh/kg）R:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="计算Cs" ForeColor="Red" OnClick="Button1_Click" />
                        </td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="显示Cs"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        <div>
            <table class="datalist">
                <tr>
                    <th colspan="2">地源热泵系统增量成本静态投资回收年限N</th>
                </tr>         
                    <tr>
                        <td>请输入项目决策书数据计算出的C:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                    </tr>                 
                    <tr>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="计算回收年限N" ForeColor="Red" OnClick="Button2_Click" />
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="显示N"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
    </form>
</body>
</html>
