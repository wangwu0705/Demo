<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="GSSystem.Web.WasteWater.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
		SPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSPNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SPHead
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSPHead" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SPFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSPFlow" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSPPower" runat="server" Width="200px"></asp:TextBox>
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
		HEHEArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHEHEArea" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SInTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSInTemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SOutTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSOutTemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSFlow" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WTIModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWTIModel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPETMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCPETMode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPETNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCPETNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FWTSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFWTSize" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
