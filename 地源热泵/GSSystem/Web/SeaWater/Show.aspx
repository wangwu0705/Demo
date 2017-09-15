<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="GSSystem.Web.SeaWater.Show" Title="显示页" %>
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
		WType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Dowtherm
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDowtherm" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWWellNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWWellNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWWellDep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWWellDep" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCWPNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPHead
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCWPHead" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCWPFlow" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CWPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCWPPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExHeatType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExHeatType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExHeatNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExHeatNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExHeatArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExHeatArea" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWInTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWInTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWOutTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWOutTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SeaWaterFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSeaWaterFlow" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DesanderNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDesanderNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DesanderType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDesanderType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SoftWTSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSoftWTSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SoftWType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSoftWType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPpower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPpower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PVariableFre
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPVariableFre" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




