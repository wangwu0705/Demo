<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="RegisterLogin.aspx.cs" Inherits="GSSystem.Web.RegisterLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
    <style type="text/css">
        #imgLogin {
            height: 22px;
            width: 63px;
        }
        .auto-style1 {
            width: 200px;
        }
    .auto-style2 {
        width: 1613px;
    }
        .auto-style3 {
            width: 85px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            //完成异步登录
            $('#imgLogin').click(function () {
                $.post(
                    'RegisterLogin.ashx',
                    $('form').serialize(),
                    function (msg) {
                        if (msg =='1') {
                            location.href = 'Admin/Default.aspx';
                        } 
                    }
                );
            });
        });
    </script>
    <table border="0" align="center" cellpadding="0" cellspacing="0" runat="server" id="tblfirst">
        <tr>
            <td width="10">
                <img src="/content/images/az-tan-top-left-round-corner.gif" style="height: 58px; width: 11px" /></td>
            <td bgcolor="#DDDDCC" class="auto-style2"><span style="font-family: '黑体'; font-size: 16px; color: #660000;">地源热泵信息系统</span></td>
            <td width="10">
                <img src="/content/images/az-tan-top-right-round-corner.gif" style="height: 56px; width: 9px" /></td>
        </tr>
    </table>
    <table border="0" align="center" cellpadding="0" cellspacing="0" runat="server">
        <tr>
            <td bgcolor="#DDDDCC" style="width: 2px">&nbsp;</td>
            <td class="auto-style1">
                <div align="center">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="6">
                                <p style="font-size: 14px; font-weight: bold; color: #FF9900; text-align: center; width: 198px;">已注册用户请从这里登录</p>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" align="right" valign="top"><strong>用户名：</strong></td>
                            <td valign="top">
                                <input type="text" name="cname"/>
                            </td>
                        </tr>
                    </table>
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td rowspan="3" align="right" valign="top" class="auto-style3"><strong>密　码：</strong></td>
                            <td valign="top">
                                <input type="password" name="cpwd" />
                            </td>
                        </tr>

                    </table>
                    <div style="height: 37px; width:434px">
                        &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/content/Images/az-login-gold-3d.gif" OnClick="ImageButton1_Click" Width="90px" />
                        <a href="Register.aspx"><img src="/content/images/az-newuser-gold-3d.gif" border="0"/></a>
                    </div>
                    <div>
                        <div>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GroundSourceSystemConnectionString %>" SelectCommand="SELECT * FROM [User]"></asp:SqlDataSource>
                            &nbsp;
                        </div>
                    </div>
            </td>
        </tr>
    </table>
    <table width="60%" height="3" border="0" align="center" cellpadding="0" cellspacing="0" runat="server">
        <tr align="center">
            <td height="3" bgcolor="#DDDDCC">&nbsp;
            </td>
        </tr>
    </table>

</asp:Content>
