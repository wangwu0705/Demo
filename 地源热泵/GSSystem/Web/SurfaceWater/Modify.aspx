<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="GSSystem.Web.SurfaceWater.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Dowtherm
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDowtherm" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPHead
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPHead" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPFlow" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HEType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHEType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HENum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHENum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HEHeatArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHEHeatArea" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWITemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWITemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWOTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWOTemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWFlow" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWTSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWTSize" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWTType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWTType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WSPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWSPNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WSPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWSPPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PVFrequ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPVFrequ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

