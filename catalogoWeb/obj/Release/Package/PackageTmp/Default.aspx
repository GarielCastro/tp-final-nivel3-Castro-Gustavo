<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="catalogoWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido al Catalogo Web</h1>
    <h2>Para acceder, primero debes loguearte</h2>
    <hr />
    <div class="d-grid gap-2 col-5 mx-auto">
        <asp:Button Text="  Login  " CssClass="btn btn-success btn-lg" runat="server" ID="btnLogin" OnClick="btnLogin_Click" />
    </div>


</asp:Content>

