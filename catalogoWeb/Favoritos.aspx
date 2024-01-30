<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="catalogoWeb.Favoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Favoritos</h1>
    <h2>Estos son tus faboritos</h2>
    <div>
        <asp:GridView ID="dgvFavoritos" CssClass="table" runat="server" AutoGenerateColumns="false" DataKeyNames="Id">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Precio en $" DataField="Precio" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
