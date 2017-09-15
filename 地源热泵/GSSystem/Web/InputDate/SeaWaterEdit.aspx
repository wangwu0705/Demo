<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeaWaterEdit.aspx.cs" Inherits="GSSystem.Web.InputDate.SeaWaterEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <style type="text/css">
        .style2 {
            width: 123px;
            background-color: navajowhite;
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
          .auto-style8 {
              width: 221px;
          }
          .auto-style9 {
              width: 157px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
         <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/hsyxxxg.gif"  width ="100%" style="height: 30px"/></div>
        <table border="1" width="100%">
             <tr>
                <td class="style2">编号：</td>
                 <td class="auto-style8" >
                 <%=BiModel.id%>
                 <input type="hidden" name="id" value="<%=BiModel.id%>"/></td>
           
                <td class="auto-style9">项目名称：</td>
                <td>
                    <input type="text" name="ProName" value="<%=BiModel.ProName%>"/></td>
            </tr>
            <tr>
                <td class="style2">水源类型</td>
                <td class="auto-style8" >
                    <input type="text" name="WType" value="<%=BiModel.WType%>"/></td>
          
                <td class="auto-style9">直/间接型：</td>
                <td>
                    <input type="text" name="Type" value="<%=BiModel.Type%>"/></td>
            </tr>
            <tr>
                <td class="style2">换热介质：</td>
                <td class="auto-style8" >
                    <input type="text" name="Dowtherm" value="<%=BiModel.Dowtherm %>"/></td>
          
                <td class="auto-style9">海水井数量：</td>
                <td>
                    <input type="text" name="SWWellNum" value="<%=BiModel.SWWellNum%>"/></td>
            </tr>
            <tr>
                <td class="style2">海水井深度：</td>
                <td class="auto-style8" >
                    <input type="text" name="SWWellDep" value="<%=BiModel.SWWellDep%>"/></td>
            
                <td class="auto-style9">清水泵数量：</td>
                <td>
                    <input type="text" name="FinTime" value="<%=BiModel.CWPNum%>"/></td>
            </tr>
            <tr>
               <td class="style2">清水泵扬程：</td>
                <td class="auto-style8" >
                    <input type="text" name="CWPHead" value="<%=BiModel.CWPHead%>"/></td>
                <td class="auto-style9">清水泵流量：</td>
                <td>
                    <input type="text" name="CWPFlow" value="<%=BiModel.CWPFlow%>"/></td>
            </tr>
            <tr>
                <td class="style2">清水泵功率：</td>
                <td class="auto-style8" >
                    <input type="text" name="CWPPower" value="<%=BiModel.CWPPower%>"/></td>
                <td class="auto-style9">换热器类型：</td>
                <td>
                    <input type="text" name="ExHeatType" value="<%=BiModel.ExHeatType%>"/></td>
            </tr>
            <tr>
                <td class="style2">换热器数量：</td>
                <td class="auto-style8" >
                    <input type="text" name="ExHeatNum" value="<%=BiModel.ExHeatNum%>"/></td>
                <td class="auto-style9">换热器换热面积：</td>
                <td>
                    <input type="text" name="ExHeatArea" value="<%=BiModel.ExHeatArea%>"/></td>
            </tr>
            <tr>
                <td class="style2">海水进水温度：</td>
                <td class="auto-style8" >
                    <input type="text" name="SWInTemp" value="<%=BiModel.SWInTemp%>"/></td>
                <td class="auto-style9">海水出水温度：</td>
                <td>
                    <input type="text" name="SWOutTemp" value="<%=BiModel.SWOutTemp%>"/></td>
            </tr>
            <tr>
                <td class="style2">海水流量：</td>
                <td class="auto-style8">
                    <input type="text" name="SeaWaterFlow" value="<%=BiModel.SeaWaterFlow%>"/></td>
               <td class="auto-style9">除砂器数量：</td>
                <td>
                    <input type="text" name="DesanderNum" value="<%=BiModel.DesanderNum%>"/></td>
            </tr>
              <tr>
               <td class="style2">除砂器型号：</td>
                <td class="auto-style8">
                    <input type="text" name="DesanderType" value="<%=BiModel.DesanderType%>"/></td>
                <td class="auto-style9">软化水箱大小：</td>
                <td>
                    <input type="text" name="SoftWTSize" value="<%=BiModel.SoftWTSize%>"/></td>
            </tr>
              <tr>
                <td class="style2">软水装置型号：</td>
                <td class="auto-style8">
                    <input type="text" name="SoftWType" value="<%=BiModel.SoftWType%>"/></td>
                  <td class="auto-style9">补水泵数量：</td>
                <td>
                    <input type="text" name="WPNum" value="<%=BiModel.WPNum%>"/></td>              
            </tr>
             <tr>
                <td class="style2">补水泵功率：</td>
                <td class="auto-style8">
                    <input type="text" name="WPpower" value="<%=BiModel.WPpower%>"/></td>
                  <td class="auto-style9">水泵是否变频：</td>
                <td>
                    <input type="text" name="PVariableFre" value="<%=BiModel.PVariableFre%>"/></td>              
            </tr>
            <tr>
                <td colspan="4" align="center">
                    <input type="submit" value="修改" class="className"/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
