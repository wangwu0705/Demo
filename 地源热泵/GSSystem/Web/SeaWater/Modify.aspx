<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="GSSystem.Web.SeaWater.Modify" Title="修改页" %>
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
		SWWellNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWWellNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWWellDep
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWWellDep" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCWPNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPHead
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCWPHead" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCWPFlow" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCWPPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExHeatType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExHeatType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExHeatNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExHeatNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExHeatArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExHeatArea" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWInTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWInTemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWOutTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWOutTemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SeaWaterFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSeaWaterFlow" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DesanderNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDesanderNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DesanderType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDesanderType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SoftWTSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSoftWTSize" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SoftWType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSoftWType" runat="server" Width="200px"></asp:TextBox>
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
		WPpower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPpower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PVariableFre
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPVariableFre" runat="server" Width="200px"></asp:TextBox>
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

