<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurfaceWaterEdit.aspx.cs" Inherits="GSSystem.Web.InputDate.SurfaceWaterEdit" %>

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
              width: 199px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
          .auto-style7 {
              width: 170px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
         <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/dbsyxxxg.gif"  width ="100%" style="height: 30px"/></div>
        <table border="1" width="100%">
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
                <td>
                    <input type="text" name="WType" value="<%=BiModel.WType%>"/></td>
          
                <td class="auto-style7">直/间接型：</td>
                <td>
                    <input type="text" name="Type" value="<%=BiModel.Type%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">换热介质：</td>
                <td>
                    <input type="text" name="Dowtherm" value="<%=BiModel.Dowtherm %>"/></td>
          
                <td class="auto-style7">水源取水泵数量：</td>
                <td>
                    <input type="text" name="WPNum" value="<%=BiModel.WPNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">水源取水泵扬程：</td>
                <td>
                    <input type="text" name="WPHead" value="<%=BiModel.WPHead%>"/></td>
            
                <td class="auto-style7">水源取水泵流量：</td>
                <td>
                    <input type="text" name="WPFlow" value="<%=BiModel.WPFlow%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">水源取水泵功率：</td>
                <td>
                    <input type="text" name="WPPower" value="<%=BiModel.WPPower%>"/></td>
                <td class="auto-style7">换热器类型：</td>
                <td>
                    <input type="text" name="HEType" value="<%=BiModel.HEType%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">换热器数量：</td>
                <td>
                    <input type="text" name="HENum" value="<%=BiModel.HENum%>"/></td>
                <td class="auto-style7">换热器换热面积：</td>
                <td>
                    <input type="text" name="HEHeatArea" value="<%=BiModel.HEHeatArea%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">地表水进水温度：</td>
                <td>
                    <input type="text" name="SWITemp" value="<%=BiModel.SWITemp%>"/></td>
                <td class="auto-style7">地表水出水温度：</td>
                <td>
                    <input type="text" name="SWOTemp" value="<%=BiModel.SWOTemp%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">地表水流量：</td>
                <td>
                    <input type="text" name="SWFlow" value="<%=BiModel.SWFlow%>"/></td>
                <td class="auto-style7">除砂器数量：</td>
                <td>
                    <input type="text" name="DNum" value="<%=BiModel.DNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">除砂器型号：</td>
                <td>
                    <input type="text" name="DType" value="<%=BiModel.DType%>"/></td>
                <td class="auto-style7">软化水箱大小：</td>
                <td>
                    <input type="text" name="SWTSize" value="<%=BiModel.SWTSize%>"/></td>
            </tr>
              <tr>
                <td class="auto-style6">软水装置型号：</td>
                <td>
                    <input type="text" name="SWTType" value="<%=BiModel.SWTType%>"/></td>
                <td class="auto-style7">补水泵数量：</td>
                <td>
                    <input type="text" name="WSPNum" value="<%=BiModel.WSPNum%>"/></td>
            </tr>
              <tr>
                 <td class="auto-style6">补水泵功率：</td>
                <td>
                    <input type="text" name="WSPPower" value="<%=BiModel.WSPPower%>"/></td>            
                <td class="auto-style7">水泵是否变频：</td>
                <td>
                    <input type="text" name="PVFrequ" value="<%=BiModel.PVFrequ%>"/></td>            
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
