<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectGmud.Pages.Home.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 45px;
        }

        .auto-style2 {
            width: 100%;
            margin-right: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2 style=" text-align: center; font: Gill Sans; font-size: x-large">Relatório de Gmuds</h2>

    <asp:GridView ID="TABELACONSULTA"  runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" CaptionAlign="Top" Font-Bold="False" HorizontalAlign="Center"  >
        <Columns>
            <asp:BoundField DataField="CNPJ" HeaderText="CNPJ Cliente"/>
            <asp:BoundField DataField="RazaoSocial" HeaderText="Razao Social"/>
            <asp:BoundField DataField="nome" HeaderText="Prestador"/>
            <asp:BoundField DataField="status" HeaderText="Status Prestador"/>
            <asp:BoundField DataField="DESCRICAO" HeaderText="Descrição Demanda"/>
            <asp:BoundField DataField="STATUS" HeaderText="Status Demanda"/>

        </Columns>
        


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

    <asp:Button runat="server"  class="btn" style="align-content: center" Text="Exportar Relatório" OnClick="Unnamed1_Click" />

</asp:Content>
