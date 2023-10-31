<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="catalogoWeb.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle del ariculo</h1>
    <div class="card-body">
        <h5 class="card-title"><%#Eval("Nombre")%></h5>
        <p class="card-text"><%#Eval("Descripcion")%></p>
    </div>
</asp:Content>
