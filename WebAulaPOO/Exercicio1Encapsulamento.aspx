<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.master" AutoEventWireup="true" CodeFile="Exercicio1Encapsulamento.aspx.cs" Inherits="Exercicio1Encapsulamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="card efeito_Panel_2">
        <div class="card-header bg-dark text-white">
            Exemplo Funcionário
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-8">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                        <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Data Nascimento"></asp:Label>
                        <asp:TextBox ID="txtDataNascimento" CssClass="form-control" runat="server" type="date"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Salário"></asp:Label>
                        <asp:TextBox ID="txtSalario" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Nº de Filhos"></asp:Label>
                        <asp:TextBox ID="txtNFilhos" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-6">
                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Área de Atuação"></asp:Label>
                        <asp:TextBox ID="txtAreaAtuacao" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Dados Cadastrados"></asp:Label>
                <asp:TextBox ID="txtDadosCadastrados" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="card-footer">
            <div div="form-group">
                <asp:Button ID="cmdSalvar" CssClass="btn btn-dark form-control" runat="server" Text="Salvar" OnClick="cmdSalvar_Click" />
            </div>
        </div>

    </div>
</asp:Content>

