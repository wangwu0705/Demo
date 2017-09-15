<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anshan.aspx.cs" Inherits="GSSystem.Web.Admin.anshan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="inc/css.css" type="text/css" />
    <script src="../js/jquery-1.7.1.min.js"></script>
</head>
     <script>
         function PromptDo(WType, ProName) {
             var temp = WType;
             switch (temp) {
                 case '海水':
                     location.href = 'Detail/SeaWater.aspx?ProName=' + ProName;
                     break;
                 case '污水':
                     location.href = 'Detail/WasteWater.aspx?ProName=' + ProName;
                     break;
                 case '地下水':
                     location.href = 'Detail/UndergroundWater.aspx?ProName=' + ProName;
                     break;
                 case '地表水':
                     location.href = 'Detail/SurfaceWater.aspx?ProName=' + ProName;
                     break;
                 case '土壤源':
                     location.href = 'Detail/SoilSource.aspx?ProName=' + ProName;
                     break;
                 default:
                     alert('输入有误');
                     break;
             }
         }

     </script>
<body bgcolor="#DEE5FA">
    <form id="form1" runat="server">
        <div>
            <div><img src="left.files/anshana.jpg" width ="100%" height ="146px"/></div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
                        <tbody>
                            <tr>
                                <th align="center" colspan="16" style="height: 23px">地源信息列表</th>
                            </tr>
                            <tr align="center" bgcolor="#799AE1">
                                <td colspan="16" align="center" class="txlrow">&nbsp;</td>
                            </tr>
                            <tr align="center" bgcolor="#799AE1" >
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">编号</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">项目名称</td>
                                 <td width="20%" align="center" class="txlHeaderBackgroundAlternate">水源类型</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">项目地址</td>
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
                    <tr bgcolor="#DEE5FA" style="display:<%#Eval("ProAdd").ToString()!="鞍山"?"none":""%>">
                        <td align="center" class="txlrow"><%#Eval("id") %></td>
                        <td align="center" class="txlrow"><%#Eval("ProName")%></td>
                        <td align="center" class="txlrow"><%#Eval("WType") %></td>
                        <td align="center" class="txlrow"><asp:label runat="server" ID="ProAdd" Text='<%#Eval("ProAdd")%>'/></td>
                        <td align="center" class="txlrow">
                            <a style="cursor:pointer" onclick="PromptDo('<%#Eval("WType")%>','<%#Eval("ProName")%>')">详细信息</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
