﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="GSSystem.Web.SummerType.Show" Title="显示页" %>
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
		SHSSInWTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSHSSInWTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SHSSBackWTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSHSSBackWTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SHSSCWater
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSHSSCWater" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUEWSTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSUEWSTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUEBWTemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSUEBWTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUECircul
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSUECircul" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SRTempRange
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSRTempRange" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




