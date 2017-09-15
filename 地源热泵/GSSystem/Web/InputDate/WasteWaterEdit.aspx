<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WasteWaterEdit.aspx.cs" Inherits="GSSystem.Web.InputDate.WasteWaterEdit" %>

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
              width: 186px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
          .auto-style7 {
              width: 187px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
         <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
         <div><img src="../Admin/left.files/wsyxxxg.gif"  width ="100%" style="height: 30px"/></div>
        <table border="1" width="100%">
             <tr>
                <td class="auto-style7">编号：</td>
                 <td>
                 <%=BiModel.id%>
                 <input type="hidden" name="id" value="<%=BiModel.id%>"/></td>
           
                <td class="auto-style6">项目名称：</td>
                <td>
                    <input type="text" name="ProName" value="<%=BiModel.ProName%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">水源类型</td>
                <td>
                    <input type="text" name="WType" value="<%=BiModel.WType%>"/></td>
          
                <td class="auto-style6">直/间接型：</td>
                <td>
                    <input type="text" name="Type" value="<%=BiModel.Type%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">换热介质：</td>
                <td>
                    <input type="text" name="Dowtherm" value="<%=BiModel.Dowtherm %>"/></td>
          
                <td class="auto-style6">污水泵数量：</td>
                <td>
                    <input type="text" name="SPNum" value="<%=BiModel.SPNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">污水泵扬程：</td>
                <td>
                    <input type="text" name="SPHead" value="<%=BiModel.SPHead%>"/></td>
            
                <td class="auto-style6">污水泵流量：</td>
                <td>
                    <input type="text" name="SPFlow" value="<%=BiModel.SPFlow%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">污水泵功率：</td>
                <td>
                    <input type="text" name="SPPower" value="<%=BiModel.SPPower%>"/></td>
                <td class="auto-style6">换热器类型：</td>
                <td>
                    <input type="text" name="HEType" value="<%=BiModel.HEType%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">换热器数量：</td>
                <td>
                    <input type="text" name="HENum" value="<%=BiModel.HENum%>"/></td>
                <td class="auto-style6">换热器换热面积：</td>
                <td>
                    <input type="text" name="HEHEArea" value="<%=BiModel.HEHEArea%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">污水进水温度：</td>
                <td>
                    <input type="text" name="SInTemp" value="<%=BiModel.SInTemp%>"/></td>
                <td class="auto-style6">污水出水温度：</td>
                <td>
                    <input type="text" name="SOutTemp" value="<%=BiModel.SOutTemp%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">污水流量：</td>
                <td>
                    <input type="text" name="SFlow" value="<%=BiModel.SFlow%>"/></td>
                <td class="auto-style6">水处理仪型号：</td>
                <td>
                    <input type="text" name="WTIModel" value="<%=BiModel.WTIModel%>"/></td>
            </tr>
            <tr>
               <td class="auto-style7">定压膨胀罐型号：</td>
                <td>
                    <input type="text" name="CPETMode" value="<%=BiModel.CPETMode%>"/></td>
                <td class="auto-style6">定压膨胀罐数量：</td>
                <td>
                    <input type="text" name="CPETNum" value="<%=BiModel.CPETNum%>"/></td>
            </tr>
              <tr>
                <td class="auto-style7">补水箱大小：</td>
                <td>
                    <input type="text" name="FWTSize" value="<%=BiModel.FWTSize%>"/></td>
                <td class="auto-style6">补水泵数量：</td>
                <td>
                    <input type="text" name="WSPNum" value="<%=BiModel.WSPNum%>"/></td>
            </tr>
              <tr>
                  <td class="auto-style7">补水泵功率：</td>
                <td>
                    <input type="text" name="WSPPower" value="<%=BiModel.WSPPower%>"/></td>            
                <td class="auto-style6">水泵是否变频：</td>
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
