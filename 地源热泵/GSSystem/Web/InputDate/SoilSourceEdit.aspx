<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SoilSourceEdit.aspx.cs" Inherits="GSSystem.Web.InputDate.SoilSourceEdit" %>

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
             width: 227px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
         .auto-style7 {
             width: 196px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
         <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/tryxxxg.gif"  width ="100%" style="height: 30px"/></div>
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
          
                <td class="auto-style6">打孔数目：</td>
                <td>
                    <input type="text" name="PHoleNum" value="<%=BiModel.PHoleNum%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">孔深：</td>
                <td>
                    <input type="text" name="HoleDepth" value="<%=BiModel.HoleDepth %>"/></td>
          
                <td class="auto-style6">孔间距：</td>
                <td>
                    <input type="text" name="HoleDistance" value="<%=BiModel.HoleDistance%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">地下换热器材质：</td>
                <td>
                    <input type="text" name="UHEMaterial" value="<%=BiModel.UHEMaterial%>"/></td>
            
                <td class="auto-style6">地下换热器管径：</td>
                <td>
                    <input type="text" name="UHEDiameter" value="<%=BiModel.UHEDiameter%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">供热时间：</td>
                <td>
                    <input type="text" name="HeatTime" value="<%=BiModel.HeatTime%>"/></td>
                <td class="auto-style6">制冷时间：</td>
                <td>
                    <input type="text" name="CoolTime" value="<%=BiModel.CoolTime%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">埋管形式：</td>
                <td>
                    <input type="text" name="BPFormat" value="<%=BiModel.BPFormat%>"/></td>
                <td class="auto-style6">地下换热器U型：</td>
                <td>
                    <input type="text" name="UHEUType" value="<%=BiModel.UHEUType%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">地下换热器串并联：</td>
                <td>
                    <input type="text" name="UHESparallel" value="<%=BiModel.UHESparallel%>"/></td>
                <td class="auto-style6">地下换热器总管长：</td>
                <td>
                    <input type="text" name="UHETotalLen" value="<%=BiModel.UHETotalLen%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">水处理仪型号：</td>
                <td>
                    <input type="text" name="WTIModel" value="<%=BiModel.WTIModel%>"/></td>
                <td class="auto-style6">定压膨胀罐型号：</td>
                <td>
                    <input type="text" name="CPETModel" value="<%=BiModel.CPETModel%>"/></td>
            </tr>
            <tr>
                <td class="auto-style7">定压膨胀罐数量：</td>
                <td>
                    <input type="text" name="CPETNum" value="<%=BiModel.CPETNum%>"/></td>
                <td class="auto-style6">补水箱大小：</td>
                <td>
                    <input type="text" name="FWTSize" value="<%=BiModel.FWTSize%>"/></td>
            </tr>
              <tr>
                <td class="auto-style7">补水泵数量：</td>
                <td>
                    <input type="text" name="WSPNum" value="<%=BiModel.WSPNum%>"/></td>
                <td class="auto-style6">补水泵功率：</td>
                <td>
                    <input type="text" name="WSPPower" value="<%=BiModel.WSPPower%>"/></td>
            </tr>
              <tr>
                <td class="auto-style7">水泵是否变频：</td>
                <td>
                    <input type="text" name="PVFreque" value="<%=BiModel.PVFreque%>"/></td>            
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
