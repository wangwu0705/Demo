<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="GSSystem.Web.SurfaceWater.Show" Title="显示页" %>
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
		WPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPHead
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPHead" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPFlow" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HEType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHEType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HENum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHENum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HEHeatArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHEHeatArea" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWITemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWITemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWOTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWOTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWFlow" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWTSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWTSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWTType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWTType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WSPNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWSPNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WSPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWSPPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PVFrequ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPVFrequ" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




