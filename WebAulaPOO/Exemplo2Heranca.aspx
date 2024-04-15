<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.master" AutoEventWireup="true" CodeFile="Exemplo2Heranca.aspx.cs" Inherits="Exemplo2Heranca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="card efeito_Panel_2">
        <div class="card-header bg_dark text-white">
            Cadastro de Pessoa Física
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-md-3">
                    <asp:Label ID="Label1" runat="server" Text="CPF"></asp:Label>
                    <asp:TextBox ID="txtCPF" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="Label2" runat="server" Text="RG"></asp:Label>
                    <asp:TextBox ID="txtRG" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3">
                    <asp:Label ID="Label4" runat="server" Text="Data de Nascimento"></asp:Label>
                    <asp:TextBox ID="txtDataNascimento" CssClass="form-control" type="date" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label>
                    <asp:TextBox ID="txtTelefone" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <asp:Label ID="Label6" runat="server" Text="Endereço"></asp:Label>
                    <asp:TextBox ID="txtEndereco" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-goup">
                <asp:Label ID="Label7" runat="server" Text="Dados Cadastrados"></asp:Label>
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

