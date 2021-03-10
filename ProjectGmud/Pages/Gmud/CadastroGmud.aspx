<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroGmud.aspx.cs" Inherits="ProjectGmud.Pages.Gmud.CadastroGmud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    



    <div class="cadastro">
        <div class="panel-heading">
            <h4>Preencha com as informações da GMUD</h4>
            <div class="control-group">
                Descrição
             <br />
                <asp:TextBox ID="txtDescricao" runat="server" class="input-xlarge"></asp:TextBox>
                <br />
                <br />
                Data Início
             <br />
                <asp:TextBox ID="txtInicio" runat="server" class="input-xlarge"></asp:TextBox>
                <br />
                <br />
                Data Fim
             <br />
                <asp:TextBox ID="txtFim" runat="server" class="input-xlarge"></asp:TextBox>
                <br />
                <br />
                CNPJ Cliente
                   <br />
                <asp:TextBox ID="txtcnpjclientebusca" runat="server" class="input-xlarge" ></asp:TextBox>
                <br />
                <br />
                CPF Prestador
                   <br />
                <asp:TextBox ID="txtCpfPrestador" runat="server" class="input-xlarge" ></asp:TextBox>
                <br />
                <br />
                Status
                <br />
                <select id="selectStatusGmud" runat="server" class="input-xlarge">
                    <option value="" selected disabled>-- Selecione o Status  --</option>
                </select>
                <br />
                <br />

                <asp:Button ID="btnSaveGmud" runat="server" Text="Salvar" class="btn" OnClick="btnSaveGmud_Click" />
                <asp:Button ID="btnCancelarGmud" runat="server" Text="Cancelar" class="btn" OnClick="btnCancelarGmud_Click"   />
            </div>


        </div>
    </div>
</asp:Content>
