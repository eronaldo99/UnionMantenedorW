<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenedor/MasterPrivate.Master" AutoEventWireup="true" CodeBehind="fotos.aspx.cs" Inherits="UnionMantenedorW.Mantenedor.fotos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="siniestro">
    <div class="modulo">
        <p class="sin_fotos">Fotos de Inmueble</p>
        <asp:Repeater ID="rptFotos" runat="server">
            <ItemTemplate>
                <a href='<%#DataBinder.Eval(Container.DataItem, "F_URL")%>' class="sin_modal"><img src='<%#DataBinder.Eval(Container.DataItem, "F_URL")%>' class="sin_thumb"/></a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>
</asp:Content>
