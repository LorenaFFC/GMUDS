<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroPrestador.aspx.cs" Inherits="ProjectGmud.Pages.Prestador.CadastroPrestador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cadastro">
        <div class="panel-heading">
            <h4>Preencha com as informações do Prestador</h4>
            <div class="control-group">
                Nome Prestador
             <br />
                <asp:TextBox ID="txPNome" runat="server" class="input-xlarge"></asp:TextBox>
                <br />
                <br />
               CPF
             <br />
                <asp:TextBox ID="txPCPF" runat="server" class="input-xlarge"></asp:TextBox>
                <br />
                <br />
               CNPJ
             <br />
                <asp:TextBox ID="txPCNPJ" runat="server" class="input-xlarge"></asp:TextBox>
                <br />
                <br />
                Data Admissao
                   <br />
                <asp:TextBox ID="txPAdmissao" runat="server" class="input-xlarge" ></asp:TextBox>
                <br />
                <br />
                Valor Hora
                   <br />
                <asp:TextBox ID="txpVlrHra" runat="server" class="input-xlarge" ></asp:TextBox>
                <br />
                <br />
                Status
                <br />
                <select id="selectStatusPrestador" runat="server" class="input-xlarge">
                    <option value="" selected disabled>-- Selecione o Status  --</option>
                </select>
                <br />
                <br />

                <asp:Button ID="btnSavePrestador" runat="server" Text="Salvar" class="btn" OnClick="btnSavePrestador_Click" />
                <asp:Button ID="btnCancelPrestador" runat="server" Text="Cancelar" class="btn" OnClick="btnCancelPrestador_Click" />
            </div>


        </div>
    </div>
</asp:Content>
