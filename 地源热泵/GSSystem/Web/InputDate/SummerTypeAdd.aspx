﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummerTypeAdd.aspx.cs" Inherits="GSSystem.Web.InputDate.SummerType" %>

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
             width: 207px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
         .auto-style4 {
             width: 214px;
         }
         .auto-style5 {
             width: 184px;
             background-color: navajowhite;
             FONT-SIZE: 12pt;
         }
    </style>
</head>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
        <div><img src="../Admin/left.files/nbiaoti.gif"  width ="100%" style="height: 146px"/></div>
        <div><img src="../Admin/left.files/rbxjxxtj.gif"  width ="100%" style="height: 30px"/></div>
        <table width="100%" border="1" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
            <tr>
                <td class="auto-style3">项目名称：</td>
                <td class="auto-style4" >
                    <input type="text" name="ProName" /></td>       
                <td class="auto-style5">* 热量来源</td>
                <td >
                    <input type="text" name="WType" /></td>
            </tr>
            <tr>
                <td class="auto-style3">夏季热源侧进水水温：</td>
                <td class="auto-style4" >
                    <input type="text" name="SHSSInWTemp" /></td>
          
                <td class="auto-style5">夏季热源侧回水水温：</td>
                <td >
                    <input type="text" name="SHSSBackWTemp" /></td>
            </tr>
            <tr>
                <td class="auto-style3">夏季热源侧循环水量：</td>
                <td class="auto-style4" >
                    <input type="text" name="WHSSInWTemp" /></td>
      
                <td class="auto-style5">夏季用户端供水温度：</td>
                <td >
                    <input type="text" name="SUEWSTemp" /></td>
            </tr>
            <tr>
                <td class="auto-style3">夏季用户端回水温度：</td>
                <td class="auto-style4" >
                    <input type="text" name="SUEBWTemp" /></td>
         
                <td class="auto-style5">夏季用户端循环水量：</td>
                <td >
                    <input type="text" name="SUECircul" /></td>
            </tr>
             <tr>
                <td class="auto-style3">夏季房间温度范围：</td>
                <td class="auto-style4" >
                    <input type="text" name="SRTempRange" /></td>              
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
