<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Huang.aspx.cs" Inherits="GSSystem.Web.SystemPG.Huang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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

        .auto-style2 {
            width: 843px;
            text-align: center;
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
                <th style="font-size: 30px;">环境效益</th>

            </tr>
            <tr>
                <th style="font-size: 30px;">考察指标</th>
                <th style="font-size: 30px;">二氧化碳/二氧化硫/粉尘</th>
            </tr>
        </table>
        <table class="datalist">
        <tr>
            <th colspan="3" ><p>环境效益</p></th>
        </tr>
             <tr>
            <th class="auto-style2">标煤二氧化碳排放因子</th>
            <th class="auto-style2">标煤二氧化硫排放因子</th>
            <th class="auto-style2">标煤粉尘排放因子</th>
        </tr>
        <tr>
            <td style="text-align: center;height:22px;">2.47
            </td>
            <td style="text-align: center;height:22px;">0.02
            </td>
            <td style="text-align: center;height:22px;">0.01
            </td>
        </tr>
        <tr>
            <th class="auto-style2">二氧化碳减排量</th>
            <th class="auto-style2">二氧化硫减排量</th>
            <th class="auto-style2">粉尘减排量</th>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<span><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span>(kg/年)
            </td>
            <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<span><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span>(kg/年)
            </td>
            <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<span><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span>(kg/年)
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
