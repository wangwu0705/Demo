<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeaWaterAdd.aspx.cs" Inherits="GSSystem.Web.InputDate.SeaWater" %>

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

        .auto-style1 {
            width: 184px;
            background-color: DeepSkyBlue;
            FONT-SIZE: 12pt;
        }

        .auto-style2 {
            width: 188px;
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
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
        <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/hsyxxtj.gif"  width ="100%" style="height: 30px"/></div>
        <table width="100%" border="1" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
            <tr>
                <td class="auto-style2">项目名称：</td>
                <td class="auto-style5">
                    <input type="text" name="ProName" /></td>       
                <td class="auto-style2">* 热量来源</td>
                <td class="auto-style6">
                    <input type="text" name="WType" /></td>
            </tr>
            <tr>
                <td class="auto-style2">直/间接型：</td>
                <td class="auto-style5">
                    <input type="text" name="Type" /></td>
          
                <td class="auto-style2">换热介质：</td>
                <td class="auto-style6">
                    <input type="text" name="ProType" /></td>
            </tr>
            <tr>
                <td class="auto-style2">施工单位：</td>
                <td class="auto-style5">
                    <input type="text" name="Dowtherm" /></td>
      
                <td class="auto-style2">海水井数量：</td>
                <td class="auto-style6">
                    <input type="text" name="SWWellNum" /></td>
            </tr>
            <tr>
                <td class="auto-style2">海水井深度：</td>
                <td class="auto-style5">
                    <input type="text" name="SWWellDep" /></td>
         
                <td class="auto-style2">清水泵数量：</td>
                <td class="auto-style6">
                    <input type="text" name="CWPNum" /></td>
            </tr>
             <tr>
                <td class="auto-style2">热泵类型：</td>
                <td class="auto-style5">
                    <input type="text" name="HpType" /></td>
         
                <td class="auto-style2">清水泵扬程：</td>
                <td class="auto-style6">
                    <input type="text" name="CWPHead" /></td>
            </tr>        
             <tr>
                <td class="auto-style2">清水泵流量：</td>
                <td class="auto-style5">
                    <input type="text" name="CWPFlow" /></td>
         
                <td class="auto-style2">末端形式：</td>
                <td class="auto-style6">
                    <input type="text" name="TerminalForm" /></td>
            </tr>        
             <tr>
                <td class="auto-style2">清水泵功率：</td>
                <td class="auto-style5">
                    <input type="text" name="CWPPower" /></td>
         
                <td class="auto-style2">换热器类型：</td>
                <td class="auto-style6">
                    <input type="text" name="ExHeatType" /></td>
            </tr>      
             <tr>
                <td class="auto-style2">换热器数量：</td>
                <td class="auto-style5">
                    <input type="text" name="ExHeatNum" /></td>
         
                <td class="auto-style2">热泵设备数量：</td>
                <td class="auto-style6">
                    <input type="text" name="HpEquipmentNum" /></td>
            </tr>    <tr>
                <td class="auto-style2">换热器换热面积：</td>
                <td class="auto-style5">
                    <input type="text" name="ExHeatArea" /></td>
         
                <td class="auto-style2">海水进水温度：</td>
                <td class="auto-style6">
                    <input type="text" name="SWInTemp" /></td>
            </tr>   
             <tr>
                <td class="auto-style2">海水出水温度：</td>
                <td class="auto-style5">
                    <input type="text" name="SWOutTemp" /></td>
         
                <td class="auto-style2">海水流量：</td>
                <td class="auto-style6">
                    <input type="text" name="SeaWaterFlow" /></td>
            </tr>     
             <tr>
                <td class="auto-style2">除砂器数量：</td>
                <td class="auto-style5">
                    <input type="text" name="DesanderNum" /></td>
         
                <td class="auto-style2">除砂器型号：</td>
                <td class="auto-style6">
                    <input type="text" name="DesanderType" /></td>
            </tr>    
            <tr>
                <td class="auto-style2">软化水箱大小：</td>
                <td class="auto-style5">
                    <input type="text" name="SoftWTSize" /></td>
         
                <td class="auto-style2">软水装置型号：</td>
                <td class="auto-style6">
                    <input type="text" name="SoftWType" /></td>
            </tr>     
            <tr>
                <td class="auto-style2">补水泵数量：</td>
                <td class="auto-style5">
                    <input type="text" name="WPNum" /></td>
         
                <td class="auto-style2">补水泵功率：</td>
                <td class="auto-style6">
                    <input type="text" name="WPpower" /></td>
            </tr>  
            <tr>
                <td class="auto-style2">水泵是否变频：</td>
                <td class="auto-style5">
                    <input type="text" name="PVariableFre" /></td>
                       
            </tr>      
            <tr>
                <td colspan="4" align="center">
                    <input type="submit" value="添加" class="className" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
