<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="GSSystem.Web.UndergroundWater.Show" Title="显示页" %>
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
		WellNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WEWNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWEWNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RWNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRWNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellDepth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWellDepth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWWExtract
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWWExtract" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HeatTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHeatTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CoolTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCoolTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPDiameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPDiameter" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPipe
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPipe" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BWPDiameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBWPDiameter" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BWPipe
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBWPipe" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WTIModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWTIModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPETModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCPETModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPETNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCPETNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FWTSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFWTSize" runat="server"></asp:Label>
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
		WPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWPPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PVFreque
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPVFreque" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




