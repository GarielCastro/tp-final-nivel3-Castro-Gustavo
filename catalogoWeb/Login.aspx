<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="catalogoWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido, debes loguearte para acceder..</h1>
    <div class="col-md-6">
        <div class="mb-3">
            <label class="form-label">User</label>
            <asp:TextBox runat="server" ID="txtUser" Required placeHolder="Escribe aqui tu mail" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <label class="form-label">Password</label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="*****" CssClass="form-control" />
        </div>
        <asp:Button Text="Ingresar" runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" CssClass="btn btn-primary" />
        <label class="form-label">Si no estas registrado, puedes hacerlo desde el botón en la barra superior</label>
        <%--<asp:Button Text="Registrate" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" runat="server" />--%>
    </div>
</asp:Content>
