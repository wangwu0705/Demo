<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UndergroundWaterEdit.aspx.cs" Inherits="GSSystem.Web.InputDate.UndergroundWaterEdit" %>

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
              width: 154px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
          .auto-style7 {
              width: 184px;
              background-color: navajowhite;
              FONT-SIZE: 12pt;
          }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
         <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/dxsxxtj.jpg"  width ="100%" style="height: 30px"/></div>
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
          
                <td class="auto-style7">打井数目：</td>
                <td>
                    <input type="text" name="WellNum" value="<%=BiModel.WellNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">提水井数量：</td>
                <td>
                    <input type="text" name="WEWNum" value="<%=BiModel.WEWNum %>"/></td>
          
                <td class="auto-style7">回灌井数量：</td>
                <td>
                    <input type="text" name="RWNum" value="<%=BiModel.RWNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">井深：</td>
                <td>
                    <input type="text" name="WellDepth" value="<%=BiModel.WellDepth%>"/></td>
            
                <td class="auto-style7">单井提水量：</td>
                <td>
                    <input type="text" name="SWWExtract" value="<%=BiModel.SWWExtract%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">供热时间：</td>
                <td>
                    <input type="text" name="HeatTime" value="<%=BiModel.HeatTime%>"/></td>
                <td class="auto-style7">制冷时间：</td>
                <td>
                    <input type="text" name="CoolTime" value="<%=BiModel.CoolTime%>"/></td>
            </tr>
            <tr>
                <td class="auto-style6">取水管径：</td>
                <td>
                    <input type="text" name="WPDiameter" value="<%=BiModel.WPDiameter%>"/></td>
                <td class="auto-style7">取水管材：</td>
                <td>
                    <input type="text" name="WPipe" value="<%=BiModel.WPipe%>"/></td>
            </tr>
            <tr>
               <td class="auto-style6">回水管径：</td>
                <td>
                    <input type="text" name="BWPDiameter" value="<%=BiModel.BWPDiameter%>"/></td>
               <td class="auto-style7">回水管材：</td>
                <td>
                    <input type="text" name="BWPipe" value="<%=BiModel.BWPipe%>"/></td>
            </tr>
            <tr>
               <td class="auto-style6">除砂器型号：</td>
                <td>
                    <input type="text" name="DModel" value="<%=BiModel.DModel%>"/></td>
                <td class="auto-style7">水处理仪型号：</td>
                <td>
                    <input type="text" name="WTIModel" value="<%=BiModel.WTIModel%>"/></td>
            </tr>
            <tr>
               <td class="auto-style6">定压膨胀罐型号：</td>
                <td>
                    <input type="text" name="CPETModel" value="<%=BiModel.CPETModel%>"/></td>
                <td class="auto-style7">定压膨胀罐数量：</td>
                <td>
                    <input type="text" name="CPETNum" value="<%=BiModel.CPETNum%>"/></td>
            </tr>
              <tr>
               <td class="auto-style6">补水箱大小：</td>
                <td>
                    <input type="text" name="FWTSize" value="<%=BiModel.FWTSize%>"/></td>
                <td class="auto-style7">补水泵数量：</td>
                <td>
                    <input type="text" name="WSPNum" value="<%=BiModel.WSPNum%>"/></td>
            </tr>
              <tr>
                  <td class="auto-style6">补水泵功率：</td>
                <td>
                    <input type="text" name="WPPower" value="<%=BiModel.WPPower%>"/></td>            
               <td class="auto-style7">水泵是否变频：</td>
                <td>
                    <input type="text" name="PVFreque" value="<%=BiModel.PVFreque%>"/></td>            
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
