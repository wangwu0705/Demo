<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="USCPEdit.aspx.cs" Inherits="GSSystem.Web.InputDate.USCPEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        .style2 {
            width: 123px;
            background-color: DeepSkyBlue;
            FONT-SIZE: 12pt;
        }

        .className {
            line-height: 30px;
            height: 30px;
            width: 70px;
            color: #ffffff;
            background-color: #4a8cf7;
            font-size: 16px;
            font-weight: normal;
            font-family: Arial;
            border: 0px solid #dcdcdc;
            -webkit-border-top-left-radius: 3px;
            -moz-border-radius-topleft: 3px;
            border-top-left-radius: 3px;
            -webkit-border-top-right-radius: 3px;
            -moz-border-radius-topright: 3px;
            border-top-right-radius: 3px;
            -webkit-border-bottom-left-radius: 3px;
            -moz-border-radius-bottomleft: 3px;
            border-bottom-left-radius: 3px;
            -webkit-border-bottom-right-radius: 3px;
            -moz-border-radius-bottomright: 3px;
            border-bottom-right-radius: 3px;
            -moz-box-shadow: inset 0px 0px 0px 0px #ffffff;
            -webkit-box-shadow: inset 0px 0px 0px 0px #ffffff;
            box-shadow: inset 0px 0px 0px 0px #ffffff;
            background: -webkit-gradient(linear, left top, left bottom, color-start(0.05, #477ed6), color-stop(1, #0e37d2));
            background: -moz-linear-gradient(top, #477ed6 5%, #0e37d2 100%);
            background: -o-linear-gradient(top, #477ed6 5%, #0e37d2 100%);
            background: -ms-linear-gradient(top, #477ed6 5%, #0e37d2 100%);
            background: linear-gradient(to bottom, #477ed6 5%, #0e37d2 100%);
            background: -webkit-linear-gradient(top, #477ed6 5%, #0e37d2 100%);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#477ed6', endColorstr='#0e37d2',GradientType=0);
            text-align: center;
            display: inline-block;
            text-decoration: none;
        }

            .className:hover {
                background-color: #4a8cf7;
                background: -webkit-gradient(linear, left top, left bottom, color-start(0.05, #0e37d2), color-stop(1, #477ed6));
                background: -moz-linear-gradient(top, #0e37d2 5%, #477ed6 100%);
                background: -o-linear-gradient(top, #0e37d2 5%, #477ed6 100%);
                background: -ms-linear-gradient(top, #0e37d2 5%, #477ed6 100%);
                background: linear-gradient(to bottom, #0e37d2 5%, #477ed6 100%);
                background: -webkit-linear-gradient(top, #0e37d2 5%, #477ed6 100%);
                filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#0e37d2', endColorstr='#477ed6',GradientType=0);
            }
         .auto-style6 {
             width: 196px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
         .auto-style7 {
             width: 189px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
         <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/yhdxxxg.gif"  width ="100%" style="height: 30px"/></div>
        <table border="1">
             <tr>
                <td class="auto-style6">编号：</td>
                 <td>
                 <%=BiModel.id%>
                 <input type="hidden" name="id" value="<%=BiModel.id%>"/></td>
           
                <td class="auto-style7">项目名称：</td>
                <td>
                    <input type="text" name="ProName" value="<%=BiModel.ProName%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">水源类型</td>
                <td >
                    <input type="text" name="WType" value="<%=BiModel.WType%>"/></td>
          
                <td class="auto-style7">用户端循环泵数量：</td>
                <td>
                    <input type="text" name="USCPNum" value="<%=BiModel.USCPNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">用户端循环泵功率：</td>
                <td>
                    <input type="text" name="USCPPower" value="<%=BiModel.USCPPower%>"/></td>
          
                <td class="auto-style7">用户端循环泵扬程：</td>
                <td>
                    <input type="text" name="USCPHead" value="<%=BiModel.USCPHead%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">用户端循环泵流量：</td>
                <td>
                    <input type="text" name="USCPFlow" value="<%=BiModel.USCPFlow%>"/></td>                       
            </tr>
            <tr>
                <td colspan="4" align="center">
                    <input type="submit" value="修改" class="className" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

