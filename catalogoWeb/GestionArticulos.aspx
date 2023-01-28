<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="GestionArticulos.aspx.cs" Inherits="catalogoWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <%-- <asp:UpdatePanel runat="server">
        <ContentTemplate>--%>
            <div class="row">
                <div class="col-6">
                    <div class="col-3">
                        <label for="txtCodigo" class="form-label">Codigo</label>
                        <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control" />
                    </div>
                    <div class="col-3">
                        <label for="lblDescripcion" class="form-label">Descripcion</label>
                        <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" />
                    </div>
                    <div class="col-3">
                        <%--                <label for="lblCategoria" class="form-label">Categoria</label>
                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-select">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                </asp:DropDownList>--%>
                    </div>
                    <div class="col">
                        <asp:Label Text="Marca" runat="server" />
                        <asp:DropDownList runat="server" ID="ddlMarca" CssClass="btn btn-outline-dark dropdown-toggle" 
                            AutoPostBack="false" OnSelectedIndexChanged="ddlMarca_SelectedIndexChanged1">
                            <asp:ListItem Text="text1" />
                            <asp:ListItem Text="text2" />
                        </asp:DropDownList>
<%--                        <asp:DropDownList runat="server" ID="ddlMarca" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlMarca_SelectedIndexChanged">
                        </asp:DropDownList>--%>
                    </div>
                    <div class="col">
                        <asp:Label Text="Categoria" runat="server" />
                        <asp:DropDownList runat="server" ID="ddlCategoriaFiltrados" CssClass="btn btn-outline-dark dropdown-toggle">
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="col-3">
                    <label for="lblMarca" class="form-label">Marca</label>
                    <asp:TextBox runat="server" ID="lblMarca" CssClass="form-control" />
                </div>
                <div class="col-3">
                    <label for="lblUrlImagen" class="form-label">Url de la Imagen</label>
                    <asp:TextBox runat="server" ID="lblUrlImagen" CssClass="form-control" />
                </div>
                <div class="col-3">
                    <label for="lblPrecio" class="form-label">Precio</label>
                    <asp:TextBox runat="server" ID="lblPrecio" CssClass="form-control" />
                </div>
            </div>
            <%--</div>--%>
<%--        </ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>
