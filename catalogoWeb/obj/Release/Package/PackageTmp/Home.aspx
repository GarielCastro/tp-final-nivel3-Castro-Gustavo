<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="catalogoWeb.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.min.js" integrity="sha384-cuYeSxntonz0PPNlHhBs68uyIAVpIIOZZ5JqeqvYYIcEL727kskC66kF92t6Xl2V" crossorigin="anonymous"></script>

    <h1>Hola!</h1>
    <p>Llegaste al Catalogo Web...</p>

    <div class="row row-cols-1 row-cols-md-4 g-4">
        <asp:Repeater runat="server" ID="repRepetidor">
            <itemtemplate>
                <div class="col">
                    <div class="card-bg-secondary border-black" style="width: 200px" >
                       <img src="<%#Eval("UrlImagen") %>" class="card-img" max-height:50% style="background-color:darkgray">
                        <div class="card-body border-dark" style="background-color:darkgray">
                            <h5 class="card-title border-dark"><%#Eval("Nombre")%></h5>
                            <p class="card-text border-dark"><%#Eval("Descripcion")%></p>
                            <a href="Detalle.aspx?id=<%#Eval("Id")%>">Ver detalle</a>
                        </div>
                    </div>
                </div>
            </itemtemplate>
        </asp:Repeater>
    </div>
</asp:Content>
