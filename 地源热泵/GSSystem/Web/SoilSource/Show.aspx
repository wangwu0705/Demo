<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="GSSystem.Web.SoilSource.Show" Title="显示页" %>
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
		PHoleNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPHoleNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HoleDepth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHoleDepth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HoleDistance
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHoleDistance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UHEMaterial
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUHEMaterial" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UHEDiameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUHEDiameter" runat="server"></asp:Label>
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
		BPFormat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBPFormat" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UHEUType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUHEUType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UHESparallel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUHESparallel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UHETotalLen
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUHETotalLen" runat="server"></asp:Label>
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
		WSPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWSPPower" runat="server"></asp:Label>
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




