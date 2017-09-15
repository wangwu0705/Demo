<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WasteWaterAdd.aspx.cs" Inherits="GSSystem.Web.InputDate.WasteWater" %>

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
         .auto-style3 {
             width: 187px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
         .auto-style4 {
             width: 168px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
        <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/wsyxxtj.gif"  width ="100%" style="height: 30px"/></div>
        <table width="100%" border="1" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
            <tr>
                <td class="auto-style3">项目名称：</td>
                <td>
                    <input type="text" name="ProName" /></td>       
                <td class="auto-style4">* 热量来源</td>
                <td>
                    <input type="text" name="WType" /></td>
            </tr>
            <tr>
                <td class="auto-style3">直/间接型：</td>
                <td>
                    <input type="text" name="Type" /></td>
          
                <td class="auto-style4">换热介质：</td>
                <td>
                    <input type="text" name="Dowtherm" /></td>
            </tr>
            <tr>
                <td class="auto-style3">污水泵数量：</td>
                <td>
                    <input type="text" name="SPNum" /></td>
      
                <td class="auto-style4">污水泵扬程：</td>
                <td>
                    <input type="text" name="SPHead" /></td>
            </tr>
            <tr>
                <td class="auto-style3">污水泵流量：</td>
                <td>
                    <input type="text" name="SPFlow" /></td>
         
                <td class="auto-style4">污水泵功率：</td>
                <td>
                    <input type="text" name="SPPower" /></td>
            </tr>
             <tr>
                <td class="auto-style3">换热器类型：</td>
                <td>
                    <input type="text" name="HEType" /></td>
         
                <td class="auto-style4">换热器数量：</td>
                <td>
                    <input type="text" name="HENum" /></td>
            </tr>        
             <tr>
                <td class="auto-style3">换热器换热面积：</td>
                <td>
                    <input type="text" name="HEHEArea" /></td>
         
                <td class="auto-style4">污水进水温度：</td>
                <td>
                    <input type="text" name="SInTemp" /></td>
            </tr>        
             <tr>
               <td class="auto-style3">污水出水温度：</td>
                <td class="auto-style5">
                    <input type="text" name="SOutTemp" /></td>
         
                <td class="auto-style4">污水流量：</td>
                <td>
                    <input type="text" name="SFlow" /></td>
            </tr>      
             <tr>
                <td class="auto-style3">水处理仪型号：</td>
                <td>
                    <input type="text" name="WTIModel" /></td>
         
                <td class="auto-style4">定压膨胀罐型号：</td>
                <td>
                    <input type="text" name="CPETMode" /></td>
            </tr>    <tr>
                <td class="auto-style3">定压膨胀罐数量：</td>
                <td>
                    <input type="text" name="CPETNum" /></td>
         
                <td class="auto-style4">补水箱大小：</td>
                <td>
                    <input type="text" name="FWTSize" /></td>
            </tr>   
             <tr>
                <td class="auto-style3">补水泵数量：</td>
                <td>
                    <input type="text" name="WSPNum" /></td>
         
                <td class="auto-style4">补水泵功率：</td>
                <td>
                    <input type="text" name="WSPPower" /></td>
            </tr>    
             <tr>
               <td class="auto-style3">水泵是否变频：</td>
                <td>
                    <input type="text" name="PVFrequ" /></td>                
            </tr>            
            <tr>
                <td colspan="4" align="center">
                    <input type="submit" value="添加" class="className"/>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
