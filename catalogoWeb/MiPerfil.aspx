<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="catalogoWeb.MiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validacion {
            color: red;
            font-size: 12px;
        }
    </style>
  
    <script>            <%--validacion de los textbox por js con tilde o error--%>
        function validar() {
            //capturar control
            const txtApellido = document.getElementById("txtApellido");
            if (txtApellido.value == "") {
                //alert("Denbes cargar el apellido");
                txtApellido.classList.add("is-invalid");
                txtApellido.classList.remove("is-valid");
                return false;
            }
            txtApellido.classList.remove("is-invalid");
            txtApellido.classList.add("is-valid");
            //return true;

            const txtNombre = document.getElementById("txtNombre");
            if (txtNombre.value == "") {
                //alert("Denbes cargar el apellido");
                txtNombre.classList.add("is-invalid");
                txtNombre.classList.remove("is-valid");
                return false;
            }
            txtNombre.classList.remove("is-invalid");
            txtNombre.classList.add("is-ivalid");

            return true;
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Mi Perfil</h2>
    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <label class="form-label">Id: </label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />

                <label class="form-label">Mail: </label>
                <asp:TextBox runat="server" ID="txtMail" ReadOnly="true" CssClass="form-control" />

                <label class="form-label">Nombre: </label>
                <asp:TextBox runat="server" ID="txtNombre" ClientIDMode="Static" CssClass="form-control" />
                <%--<asp:RequiredFieldValidator CssClass="validacion" ErrorMessage="Debes escribir un nombre" ControlToValidate="txtNombre" runat="server" />--%>
                <div>
                </div>
                <label class="form-label">Apellido: </label>
                <asp:TextBox runat="server" ClientIDMode="Static" ID="txtApellido" CssClass="form-control" />

                <%--<label class="form-label">Fecha de Nacimiento: </label>
                <asp:TextBox runat="server" ID="txtFechaNacimiento" TextMode="Date" CssClass="form-control" />--%>
            </div>
        </div>
        <div class="col-md-4">
            <div class="mb-3">
                <label class="form-label">Imagen Perfil</label>
                <input type="file" id="txtImagen" runat="server" class="form-control" />
            </div>
            <asp:Image ID="imgNuevoPerfil" ImageUrl="https://www.palomacornejo.com/wp-content/uploads/2021/08/no-image.jpg"
                runat="server" CssClass="img-fluid mb-3" Height="350px" />
        </div>
    </div>
    <div class="col-6">
        <div class="col mb-3">
            <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClientClick="return validar()" OnClick="btnAceptar_Click" runat="server" />
        </div>
    </div>
    <a href="Default.aspx">Cancelar</a>
    <div class="col-6">
    </div>


</asp:Content>
