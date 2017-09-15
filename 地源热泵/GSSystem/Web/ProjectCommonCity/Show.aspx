<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="GSSystem.Web.ProjectCommonCity.Show" Title="显示页" %>
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
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProAdd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProAdd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ConUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConUnit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpManufacturer
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHpManufacturer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FinTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFinTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CoveredArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCoveredArea" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHpType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EngCharacter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEngCharacter" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseFormat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseFormat" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TerminalForm
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTerminalForm" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProjectTHHp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProjectTHHp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProjectTCHp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProjectTCHp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpEquipmentType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHpEquipmentType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HpEquipmentNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHpEquipmentNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NominalHeat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNominalHeat" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NominalCool
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNominalCool" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HeatInputPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHeatInputPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CoolInputPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCoolInputPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWType" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




