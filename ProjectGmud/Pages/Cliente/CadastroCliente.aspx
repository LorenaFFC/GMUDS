<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="ProjectGmud.Pages.Cliente.CadastroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cadastro">
        <div class="panel-heading">
            <h4>Preencha com as informações do Cliente</h4>
            <div class="control-group">
                CNPJ
             <br />
                <asp:TextBox ID="txtCNPJ" runat="server" class="input-xlarge"></asp:TextBox>
                <br /><br />
                Razão Social
            <br />
                <asp:TextBox ID="txtRS" runat="server" class="input-xlarge"></asp:TextBox>
                <br /><br />
                Endereço:<br />
                <asp:TextBox ID="txtEndereco" runat="server"  class="input-xlarge"></asp:TextBox>
                <br /><br />
                Cidade:<br />
                <asp:TextBox ID="txtCidade" runat="server"  class="input-xlarge"></asp:TextBox>
                <br /><br />
                UF:<br />
                <select id="selectUF" runat="server" class="input-xlarge">
                    <option value="" selected disabled>-- Selecione um Estado --</option>
                </select>
                <br /><br />
                Data
            <asp:Calendar ID="date" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                <DayStyle Width="14%" />
                <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                <TodayDayStyle BackColor="#CCCC99" />
            </asp:Calendar>
                <br />
                <asp:Button ID="btnSave" runat="server" Text="Salvar" class="btn" OnClick="btnSave_Click" />
                &nbsp;&nbsp;
            <asp:Button ID="btnCancelar" runat="server"  class="btn" Text="Cancelar" />
                <br />

            </div>


        </div>
    </div>
</asp:Content>
