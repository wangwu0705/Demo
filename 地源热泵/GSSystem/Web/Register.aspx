<%@ Page Title="" Language="C#" MasterPageFile="~/Pages.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GSSystem.Web.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            $('#cname').blur(function () {
                var cname = $('#cname').val();
                if (cname.length <= 0) {
                    $('#cname1').html('用户名不能为空');
                    return;
                }
                $.post(
                    'CNameExists.ashx',
                    {
                        cname: cname
                    },
                    function (msg) {
                        if (msg == 1) {
                            //表示存在
                            $('#cname1').html('X');
                        } else {
                            //不存在，用户名可用
                            $('#cname1').html('');
                        }
                    }
                );
            });

            $('#cpwd2').blur(function () {
                if ($('#cpwd1').val() != "") {
                    if ($('#cpwd2').val() != $('#cpwd1').val()) {
                        $('#cpwd22').html('X');
                    } else {
                        $('#cpwd22').html('');
                    }
                }
            });

            $('form').submit(function () {
                if ($('#cname').val() == '' || $('#cname1').html() != '') {
                    $('#cname').focus();
                    return false;
                }

                if ($('#cpwd22').html() == 'X') {
                    $('#cpwd2').focus();
                    return false;
                }
            });
        });
    </script>

    <div style="font-size: small">
        <table width="80%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td style="width: 10px">
                    <img src="content/images/az-tan-top-left-round-corner.gif" width="10" height="28" /></td>
                <td bgcolor="#DDDDCC"><span class="STYLE1">注册新用户</span></td>
                <td width="10">
                    <img src="content/images/az-tan-top-right-round-corner.gif" width="10" height="28" /></td>
            </tr>
        </table>


        <table width="80%" height="22" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
                <td>
                    <div align="center">
                        <table height="61" cellpadding="0" cellspacing="0" style="height: 332px">
                            <tr>
                                <td height="50" colspan="6">
                                    <p class="STYLE2" style="text-align: center">注册新帐户</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="24%" align="center" valign="top" style="height: 50">用户名</td>
                                <td valign="top" width="37%" align="left" style="height: 50">
                                    <input type="text" id="cname" name="cname" />
                                    <span id="cname1"></span>
                                </td>
                            </tr>
                            <tr>
                                <td width="24%" height="50" align="center" valign="top">密码：</td>
                                <td valign="top" width="37%" align="left">
                                    <input type="password" name="cpwd1" id="cpwd1" />
                                </td>
                            </tr>
                            <tr>
                                <td width="24%" height="50" align="center" valign="top">确认密码：</td>
                                <td height="50" valign="top" width="37%" align="left">
                                    <input type="password" name="cpwd2" id="cpwd2" /><span id="cpwd22"></span>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="left" height="50" ><%=Msg %>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" height="26" align="center">
                                    <input type="submit" value="注册"/>
                                </td>
                            </tr>
                        </table>
                        <div class="STYLE5">---------------------------------------------------------</div>
                    </div>
                </td>
                <td width="2" bgcolor="#DDDDCC">&nbsp;</td>
            </tr>
        </table>

        <table width="80%" height="3" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td height="3" bgcolor="#DDDDCC">
                    <img src="content/images/touming.gif" width="27" height="9" /></td>
            </tr>
        </table>
    </div>

</asp:Content>
