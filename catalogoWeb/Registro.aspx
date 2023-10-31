<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="catalogoWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="col-md-6">
        <div class="mb-3">
            <label class="form-label">Ingrese un mail</label>
            <asp:TextBox runat="server" ID="txtUser" placeHolder="nombre@ejemplo" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <label class="form-label">Ingrese una contraseña</label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" placeholder="Escriba una contraseña" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <label class="form-label">Confirme la contraseña</label>
            <asp:TextBox runat="server" ID="txtConfirmaPassword" TextMode="Password" OnTextChanged="txtConfirmaPassword_TextChanged" placeholder="Repita la contraseña" CssClass="form-control" />
        </div>
        <asp:Button Text="Confirmar Registro" CssClass="btn btn-primary" ID="btnRegistro" OnClick="btnRegistro_Click" runat="server" />
        <a href="Default.aspx">Cancelar</a>
    </div>
</asp:Content>
