<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EscolaPage.aspx.cs" Inherits="DiretoriaEscolar.WebForms.EscolaPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="lista-escolas">
        <h1>Lista de escolas cadastradas</h1>
        <asp:Table ID="tbEscolas" runat="server">
            
        </asp:Table>
    </div>
</asp:Content>
