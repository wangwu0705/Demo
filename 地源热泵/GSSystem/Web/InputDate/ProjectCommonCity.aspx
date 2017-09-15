<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectCommonCity.aspx.cs" Inherits="GSSystem.Web.InputDate.ProjectCommonCity1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../js/jquery-1.7.1.min.js"></script>
     <script >
         function RemoveDelete(id) {
             if (confirm('确定要删除吗？')) {
                 $.post('ProjectCommonCity.ashx',
                     {
                         id: id
                     },
                     function (msg) {
                         if (msg == 1) {
                             location.href = location.href;
                         }
                         else {
                             alert('删除失败，请稍后再试！')
                         }
                     }
                 );

             }

         }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
                <img src="../Admin/left.files/nbiaoti.gif" width="100%" style="height: 146px; margin-bottom: 0px;" />
            <img src="../Admin/left.files/xmjbxxlb.gif" width="100%" style="height: 30px; margin-bottom: 0px;" />
            </div>
        <div>
            <a style="cursor:pointer; color:red" href="ProjectCommonCityAdd.aspx">添加信息</a>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
                        <tbody>
                            <tr>
                                <th align="center" colspan="16" style="height: 23px; border: 1px solid #0058a3;background-color: #4bacff;color: #FFFFFF;font-weight: bold;">地源热泵信息列表</th>
                            </tr>
                            <tr bgcolor="#DEE5FA">
                                <td colspan="16" align="center">&nbsp;</td>
                            </tr>
                            <tr align="center" bgcolor="#799AE1">
                                <td width="10%" align="center" class="txlHeaderBackgroundAlternate">编号</td>
                                <td width="15%" align="center" class="txlHeaderBackgroundAlternate">项目名称</td>
                                <td width="10%" align="center" class="txlHeaderBackgroundAlternate">水源类型</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">项目地址</td>
                                <td width="15%" align="center" class="txlHeaderBackgroundAlternate">竣工日期</td>
                                <td width="10%" align="center" class="txlHeaderBackgroundAlternate">热泵类型</td>
                                <td width="20%" align="center" class="txlHeaderBackgroundAlternate">操作</td>
                            </tr>
                </HeaderTemplate>
                <FooterTemplate>
                    <tr>
                        <td align="center" colspan ="7" class="page_nav">
                            <%=PageBar%>
                        </td>
                    </tr>
                    </tbody></table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr bgcolor="#DEE5FA">
                        <td align="center" ><%#Eval("id")%></td>
                        <td align="center" ><%#Eval("ProName")%></td>
                         <td align="center" ><%#Eval("WType")%></td>
                        <td align="center" ><%#Eval("DetailAdd")%></td>
                         <td align="center" ><%#Eval("FinTime","{0:d}")%></td>
                        <td align="center" ><%#Eval("HpType")%></td>
                        <td align="center" >
                            <a style="cursor:pointer" href='ProjectCommonCityEdit.aspx?id=<%#Eval("id") %>'>修改</a>
                            <a style="cursor:pointer" href ='javascript:RemoveDelete(<%#Eval("id") %>)'>删除</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
