﻿<%@ Page Title="UndergroundWater" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="GSSystem.Web.UndergroundWater.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="ProName" HeaderText="ProName" SortExpression="ProName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WType" HeaderText="WType" SortExpression="WType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellNum" HeaderText="WellNum" SortExpression="WellNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WEWNum" HeaderText="WEWNum" SortExpression="WEWNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RWNum" HeaderText="RWNum" SortExpression="RWNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WellDepth" HeaderText="WellDepth" SortExpression="WellDepth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SWWExtract" HeaderText="SWWExtract" SortExpression="SWWExtract" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HeatTime" HeaderText="HeatTime" SortExpression="HeatTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CoolTime" HeaderText="CoolTime" SortExpression="CoolTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WPDiameter" HeaderText="WPDiameter" SortExpression="WPDiameter" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WPipe" HeaderText="WPipe" SortExpression="WPipe" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BWPDiameter" HeaderText="BWPDiameter" SortExpression="BWPDiameter" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BWPipe" HeaderText="BWPipe" SortExpression="BWPipe" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DModel" HeaderText="DModel" SortExpression="DModel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WTIModel" HeaderText="WTIModel" SortExpression="WTIModel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CPETModel" HeaderText="CPETModel" SortExpression="CPETModel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CPETNum" HeaderText="CPETNum" SortExpression="CPETNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FWTSize" HeaderText="FWTSize" SortExpression="FWTSize" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WSPNum" HeaderText="WSPNum" SortExpression="WSPNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WPPower" HeaderText="WPPower" SortExpression="WPPower" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PVFreque" HeaderText="PVFreque" SortExpression="PVFreque" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
