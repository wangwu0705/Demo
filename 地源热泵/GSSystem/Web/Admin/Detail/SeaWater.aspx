<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeaWater.aspx.cs" Inherits="GSSystem.Web.Admin.Detail.shenyang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .style2 {
            width: 123px;
            color: Blue;
            FONT-SIZE: 11pt;
        }
    </style>
    <style>
        .datalist {
            border: 1px solid #0058a3; /* 表格边框 */
            font-family: Arial;
            border-collapse: collapse; /* 边框重叠 */
            background-color: #eaf5ff; /* 表格背景色 */
            font-size: 14px;
            text-align: center;
            width: 100%;
        }
            .datalist th {
                border: 1px solid #0058a3; /* 行名称边框 */
                background-color: #4bacff; /* 行名称背景色 */
                color: #FFFFFF; /* 行名称颜色 */
                font-weight: bold;
                padding-top: 4px;
                padding-bottom: 4px;
                padding-left: 12px;
                padding-right: 12px;
                text-align: center;
                vertical-align: middle;
            }
        .datalist td {
            border: 1px solid #0058a3; /* 单元格边框 */
            text-align: left;
            padding-top: 4px;
            padding-bottom: 4px;
            padding-left: 10px;
            padding-right: 10px;
        }

        .datalist tr.altrow {
            background-color: #c7e5ff; /* 隔行变色 */
        }
    </style>
</head>
<body style="background: Azure">
    <form id="form1" runat="server">
        <div>
            <img src="../left.files/hsyrb.jpg" width="100%" style="height: 146px" />            
                    <asp:Button ID="Button1" runat="server" Text="Excel输出" BorderStyle="None" Font-Size="Medium" ForeColor="Red" OnClick="Button1_Click" />  
        </div>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333"
            Width="100%">
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <ItemTemplate>
                <table cellspacing="0" cellpadding="0" width="100%" border="1" align="left" class="datalist">
                    <tr>
                        <th>属性</th>
                        <th>信息</th>
                        <th>属性</th>
                        <th>信息</th>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="编号" runat="server"></asp:Label></td>
                        <td height="20" width="30%" style="text-align: center"><%#Eval("id")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="项目名称" runat="server"></asp:Label></td>
                        <td height="20" width="30%" style="text-align: center"><%#Eval("ProName")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="水源类型" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WType")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="项目地址" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ProAdd")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="详细地址" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("DetailAdd")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="项目类型" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ProType")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="施工单位" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ConUnit")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热泵设备厂家" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HpManufacturer")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="竣工日期" runat="server"></asp:Label></td>
                        <td height="20" width="20%" style="text-align: center"><%#Eval("FinTime","{0:d}")%></td>

                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="建筑面积" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("CoveredArea")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热泵类型" runat="server"></asp:Label></td>
                        <td height="20" width="20%" style="text-align: center"><%#Eval("HpType")%></td>

                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="工程性质" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("EngCharacter")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="使用形式" runat="server"></asp:Label></td>
                        <td height="20" width="20%" style="text-align: center"><%#Eval("UseFormat")%></td>

                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="末端形式" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("TerminalForm")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热泵项目总热负荷" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ProjectTHHp")%></td>

                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热泵项目总冷负荷" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ProjectTCHp")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热泵设备型号" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HpEquipmentType")%></td>

                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热泵设备数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HpEquipmentNum")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="名义制热量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("NominalHeat")%></td>

                        <td height="25" style="text-align: left" class="style2">
                            <asp:Label Text="名义制冷量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("NominalCool")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="制热输入功率" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HeatInputPower")%></td>

                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="制冷输入功率" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("CoolInputPower")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="直/间接型" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("Type")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="换热介质" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("Dowtherm")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="海水井数量" runat="server"></asp:Label></td>
                        <td height="20" width="20%" style="text-align: center"><%#Eval("SWWellNum")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="海水井深度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SWWellDep")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="清水泵数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("CWPNum")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="清水泵扬程" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("CWPHead")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="清水泵流量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("CWPFlow")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="清水泵功率" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("CWPPower")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="换热器类型" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ExHeatType")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="换热器数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ExHeatNum")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="换热器换热面积" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ExHeatArea")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="海水进水温度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SWInTemp")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="海水出水温度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SWOutTemp")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="海水流量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SeaWaterFlow")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="除砂器数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("DesanderNum")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="除砂器型号" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("DesanderType")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="软化水箱大小" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SoftWTSize")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="软水装置型号" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SoftWType")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="补水泵数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WPNum")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="补水泵功率" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WPpower")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="水泵是否变频" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("PVariableFre")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热源端循环泵数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HSSCPNum")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热源端循环泵功率" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HSSCPPower")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热源端循环泵扬程" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HSSCPHead")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="热源端循环泵流量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("HSSCPFlow")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="用户端循环泵数量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("USCPNum")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="用户端循环泵功率" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("USCPPower")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="用户端循环泵扬程" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("USCPHead")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="用户端循环泵流量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("USCPFlow")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬抽水井水温" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WWPWTemp")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬季回灌井水温" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WWRWTemp")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬热源侧进水水温" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WHSSInWTemp")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬热源侧回水水温" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WHSSBackWTemp")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬热源侧循环水量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WHSSCWater")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬用户端供水温度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WUEWSTemp")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬用户端回水温度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WUEBWTemp")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬用户端循环水量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WUECircul")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="冬季房间温度范围" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("WRTempeRange")%></td>

                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏热源侧进水水温" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SHSSInWTemp")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏热源侧回水水温" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SHSSBackWTemp")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏热源侧循环水量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SHSSCWater")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏用户端供水温度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SUEWSTemp")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏用户端回水温度" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SUEBWTemp")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏用户端循环水量" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SUECircul")%></td>
                    </tr>
                    <tr class="altrow">
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="夏房间温度范围" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SRTempRange")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="系统总造价" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("ProTotalCost")%></td>
                    </tr>
                    <tr>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="机组造价" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("UnitCost")%></td>
                        <td height="20" style="text-align: left" class="style2">
                            <asp:Label Text="系统造价" runat="server"></asp:Label></td>
                        <td height="20" style="text-align: center"><%#Eval("SystemCost")%></td>
                    </tr>
                    <tr class="altrow" >
                        <td colspan="2" height="20" style="text-align: left" class="style2">
                            <asp:Label Text="项目联系电话" runat="server"></asp:Label></td>
                        <td colspan="2" height="20" style="text-align: center"><%#Eval("ProTel")%></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
