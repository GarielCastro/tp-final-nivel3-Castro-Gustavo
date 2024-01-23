<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="catalogoWeb.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle del ariculo</h1>
    <div class="row">
 <form class="row g-2">
       
            <div class="col-auto">
                <div class="mb-3 row">
                </div>
                <div class="mb-3 row">
                <asp:Label Text="Nombre" CssClass="form-label" ID="lblNombre" Font-Size="XX-Large" runat="server" />
                </div>
                <div class="mb-3 row">
                <asp:Label Text="Descripción" CssClass="form-label" ID="lblDescripcion" Font-Size="XX-Large" runat="server" />
                </div>
                <div class="mb-3 row">
                <asp:Label Text="Código" CssClass="form-label" ID="lblCodigo" Font-Size="XX-Large" runat="server" />
                </div>
                <div class="mb-3 row">
                <asp:Label Text="Precio" CssClass="form-label" ID="lblPrecio" Font-Size="XX-Large" runat="server" />
                </div>
            </div>
            <div class="col-auto"
                <div>
                    <asp:Image ImageUrl="imageurl" ID="imgDetalle" runat="server" CssClass="rounded mx-auto d-block" />
                </div>
                <asp:Button Text="Favorito" ID="btnFavorito" OnClick="btnFavorito_Click" runat="server" />
            </div>
 </form>       
    </div>
</asp:Content>
