<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectCommonCityAdd.aspx.cs" Inherits="GSSystem.Web.InputDate.ProjectCommonCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
    .auto-style5 {
        width: 30%;
        background-color: navajowhite;
        FONT-SIZE: 12pt;
    }
    .auto-style6 {
        width: 40%;
        background-color: navajowhite;
        FONT-SIZE: 12pt;
    }
    .auto-style8 {
        width:20%;
        background-color: navajowhite;
        FONT-SIZE: 12pt;
    }
    .auto-style10 {
        width: 20%;
        background-color: navajowhite;
        FONT-SIZE: 12pt;
    }
    .auto-style11 {
        width: 20%;
        background-color: navajowhite;
        FONT-SIZE: 12pt;
    }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
        <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/xmjbxxtj.gif"  width ="100%" style="height: 30px"/></div>
        <table width="100%" border="1" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
            <tr>
                <td class="auto-style10">项目名称：</td>
                <td class="auto-style8">
                    <input type="text" name="ProName" /></td>
                <td class="auto-style11">* 热量来源</td>
                <td class="auto-style6">
                    <input type="text" name="WType" />&nbsp; （地下水，土壤源，地表水，污水源，海水源）</td>
            </tr>
            <tr>
                <td class="auto-style10">* 项目地址：</td>
                <td class="auto-style8">
                    <input type="text" name="ProAdd" /></td>
                <td class="auto-style11">* 详细地址：</td>
                <td class="auto-style5">
                    <input type="text" name="DetailAdd" /></td>
            </tr>
            <tr>
                <td class="auto-style10">项目类型：</td>
                <td class="auto-style8">
                    <input type="text" name="ProType" /></td>

                <td class="auto-style11">施工单位：</td>
                <td class="auto-style5">
                    <input type="text" name="ConUnit" /></td>
            </tr>
            <tr>
                <td class="auto-style10">热泵设备厂家：</td>
                <td class="auto-style8">
                    <input type="text" name="HpManufacturer" /></td>

                <td class="auto-style11">* 竣工日期：</td>
                <td class="auto-style5">
                    <input type="text" name="FinTime" />格式：2016.01.01</td>
            </tr>
            <tr>
                <td class="auto-style10">* 建筑面积（万平方米）：</td>
                <td class="auto-style8">
                    <input type="text" name="CoveredArea" /></td>

                <td class="auto-style11">热泵类型：</td>
                <td class="auto-style5">
                    <input type="text" name="HpType" /></td>
            </tr>
            <tr>
                <td class="auto-style10">工程性质：</td>
                <td class="auto-style8">
                    <input type="text" name="EngCharacter" /></td>

                <td class="auto-style11">使用形式：</td>
                <td class="auto-style5">
                    <input type="text" name="UseFormat" /></td>
            </tr>
            <tr>
                <td class="auto-style10">末端形式：</td>
                <td class="auto-style8">
                    <input type="text" name="TerminalForm" /></td>

                <td class="auto-style11">* 热泵项目总热负荷：</td>
                <td class="auto-style5">
                    <input type="text" name="ProjectTHHp" /></td>
            </tr>
            <tr>
                <td class="auto-style10">* 热泵项目总冷负荷：</td>
                <td class="auto-style8">
                    <input type="text" name="ProjectTCHp" /></td>

                <td class="auto-style11">* 热泵设备型号：</td>
                <td class="auto-style5">
                    <input type="text" name="HpEquipmentType" /></td>
            </tr>
            <tr>
                <td class="auto-style10">&nbsp;* 热泵设备数量：</td>
                <td class="auto-style8">
                    <input type="text" name="HpEquipmentNum" /></td>

                <td class="auto-style11">* 名义制热量：</td>
                <td class="auto-style5">
                    <input type="text" name="NominalHeat" /></td>
            </tr>
            <tr>
                <td class="auto-style10">* 名义制冷量：</td>
                <td class="auto-style8">
                    <input type="text" name="NominalCool" /></td>

                <td class="auto-style11">* 制热输入功率：</td>
                <td class="auto-style5">
                    <input type="text" name="HeatInputPower" /></td>
            </tr>
            <tr>
                <td class="auto-style10">* 制冷输入功率：</td>
                <td class="auto-style8">
                    <input type="text" name="CoolInputPower" />
                </td>
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
