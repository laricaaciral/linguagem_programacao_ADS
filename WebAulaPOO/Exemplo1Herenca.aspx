<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.master" AutoEventWireup="true" CodeFile="Exemplo1Herenca.aspx.cs" Inherits="Exemplo1Herenca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="card efeito_Panel_2">
        <div class="card-header bg-dark text-white">
            Cadastro de Gerentes
        </div>
        <div class="card-body">
            <div class="form-goup">
                <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="Label2" runat="server" Text="CPF"></asp:Label>
                    <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="Label3" runat="server" Text="Salário"></asp:Label>
                    <asp:TextBox ID="txtSalario" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="Label4" runat="server" Text="Senha"></asp:Label>
                    <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-goup">
                <asp:Label ID="Label5" runat="server" Text="Dados Cadastrados"></asp:Label>
                <asp:TextBox ID="txtDadosCadastrados" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="card-footer">
            <div class="">
                <asp:Button ID="cmdCadastrar" CssClass="btn btn-dark form-control" runat="server" Text="Cadastrar" OnClick="cmdCadastrar_Click" />
            </div>
        </div>
    </div>
</asp:Content>

