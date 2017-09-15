<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchName.aspx.cs" Inherits="GSSystem.Web.Search.SearchName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Admin/inc/css.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.1.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 268435392px;
        }
    </style>
</head>
<script>
    function PromptDo(WType, ProName) {
        var temp = WType;
        switch (temp) {
            case '海水':
                location.href = '../Admin/Detail/SeaWater.aspx?ProName=' + ProName;
                break;
            case '污水':
                location.href = '../Admin/Detail/WasteWater.aspx?ProName=' + ProName;
                break;
            case '地下水':
                location.href = '../Admin/Detail/UndergroundWater.aspx?ProName=' + ProName;
                break;
            case '地表水':
                location.href = '../Admin/Detail/SurfaceWater.aspx?ProName=' + ProName;
                break;
            case '土壤源':
                location.href = '../Admin/Detail/SoilSource.aspx?ProName=' + ProName;
                break;
            default:
                alert('输入有误');
                break;
        }
    }

</script>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <img src="../Admin/left.files/mccx.jpg" width="100%" style="height: 146px; margin-bottom: 0px;" />
            </div>
                      <table style="font-size: 9pt; " cellpadding="0" cellspacing="0" align="center" border="0" width="100%" bgcolor="lavender">
                <tr>
                    <td colspan="3" style="text-align: left"  Width="50%">
                        <asp:Label ID="Label2" runat="server" Text="根据项目名查询" Font-Size="Large"></asp:Label>
                        &nbsp;
                    <asp:TextBox ID="txtKey" runat="server" Width="210px"></asp:TextBox>
                    </td>
                    <td Width="30%" style="text-align: center">
                        <asp:Label ID="Label1" runat="server" Text="城市" Font-Size="Large"></asp:Label><asp:TextBox ID="txtKey1" runat="server" Height="16px" Width="104px"></asp:TextBox></td>
                    <td Width="20%" style="text-align: center">
                        <asp:Button ID="btnSel" runat="server" Text="查询" Height="29px" Width="59px" OnClick="btnSel_Click" Font-Size="Large" />
                        &nbsp;
                    </td>

                </tr>
            </table>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
                        <tbody>
                            <tr>
                                <th align="center" colspan="16" style="height: 23px">地源信息列表</th>
                            </tr>
                            <tr align="center" bgcolor="#799AE1">
                                <td width="10%" align="center" class="txlHeaderBackgroundAlternate">编号</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">项目名称</td>
                                <td width="10%" align="center" class="txlHeaderBackgroundAlternate">水源类型</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">项目地址</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">竣工时间</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">操作</td>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                    <tr>
                        <td align="center" class="txlrow" colspan="3">
                            <%=PagerBar %>
                        </td>
                    </tr>
                    </tbody></table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr bgcolor="#DEE5FA">
                        <td align="center" class="txlrow"><%#Eval("id") %></td>
                        <td align="center" class="txlrow"><%#Eval("ProName")%></td>
                        <td align="center" class="txlrow"><%#Eval("WType") %></td>
                        <td align="center" class="txlrow"><%#Eval("ProAdd")%></td>
                        <td align="center" class="txlrow"><%#Eval("FinTime","{0:d}")%></td>
                        <td align="center" class="txlrow">
                            <a style="cursor: pointer" onclick="PromptDo('<%#Eval("WType")%>','<%#Eval("ProName")%>')">详细信息</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </div>







    </form>
</body>
</html>
