<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RelatorioGmud.aspx.cs" Inherits="ProjectGmud.Pages.Gmud.RelatorioGmud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2 style=" text-align: center; font: Gill Sans; font-size: x-large">Relatório de GMUDS</h2>
        <asp:GridView ID="RELATORIOGMUD" runat="server" 
            AllowPaging="TRUE"
            PageSize="10"
            AutoGenerateColumns="true"
            BackColor="White" 
            BorderColor="#999999"
            BorderStyle="None" 
            BorderWidth="1px" 
            CellPadding="3" 
            HorizontalAlign="Center"
            GridLines="Vertical"
            OnPageIndexChanging="RELATORIOGMUD_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#DCDCDC" />
               <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor=#294454 Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    <br />
 <asp:Button runat="server"  class="btn" style="align-content: center" Text="Exportar Relatório" OnClick="RELATORIOGMUDEXCEL" />
</asp:Content>
