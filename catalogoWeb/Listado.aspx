<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="catalogoWeb.Listado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <div>
        <asp:GridView ID="dgvArticulos" runat="server" CssClass="table" AutoGenerateColumns="false" DataKeyNames="Id"
            OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged"
            OnPageIndexChanging="dgvArticulos_PageIndexChanging" AllowPaging="true" PageSize="5">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Precio en $" DataField="Precio" />
                <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="Gestionar"/>
            </Columns>
        </asp:GridView>
    </div>
    <div class="">
      <%--  <a href="GestionArticulos.aspx" class="btn btn-dark">Agregar</a> --%>
        <asp:Button type="button" ID="btnAgregar" OnClick="btnAgregar_Click" class="btn btn-dark">Agregar</asp:Button>
        <asp:Button type="button" ID="btnEditar" OnClick="btnEditar_Click" class="btn btn-dark">Editar</asp:Button>
        <asp:Button type="button" ID="btnEliminar" OnClick="btnEliminar_Click" class="btn btn-dark">Eliminar</asp:Button>
        


    </div>
</asp:Content>
