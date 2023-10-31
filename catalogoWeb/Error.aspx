<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="catalogoWeb.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lo siento, hubo un error!!!</h1>
    <asp:Label Text="text" ID="lblMensaje" runat="server" />
    <asp:Button Text="Volver" ID="btnVolver" OnClick="btnVolver_Click" runat="server" />
</asp:Content>
