<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="GSSystem.Web.UndergroundWater.Modify" Title="修改页" %>
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
		WellNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WEWNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWEWNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RWNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRWNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WellDepth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWellDepth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SWWExtract
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSWWExtract" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HeatTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHeatTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CoolTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCoolTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPDiameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPDiameter" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WPipe
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPipe" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BWPDiameter
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBWPDiameter" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BWPipe
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBWPipe" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDModel" runat="server" Width="200px"></asp:TextBox>
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
		CPETModel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCPETModel" runat="server" Width="200px"></asp:TextBox>
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
		WPPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWPPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PVFreque
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPVFreque" runat="server" Width="200px"></asp:TextBox>
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

