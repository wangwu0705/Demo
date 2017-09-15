<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="GSSystem.Web.ProjectCommonCity.Modify" Title="修改页" %>
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
		ProAdd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProAdd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ConUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtConUnit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpManufacturer
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHpManufacturer" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FinTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtFinTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CoveredArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCoveredArea" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHpType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EngCharacter
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEngCharacter" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseFormat
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseFormat" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TerminalForm
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTerminalForm" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProjectTHHp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProjectTHHp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProjectTCHp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProjectTCHp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpEquipmentType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHpEquipmentType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpEquipmentNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHpEquipmentNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NominalHeat
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNominalHeat" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NominalCool
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNominalCool" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HeatInputPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHeatInputPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CoolInputPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCoolInputPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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

