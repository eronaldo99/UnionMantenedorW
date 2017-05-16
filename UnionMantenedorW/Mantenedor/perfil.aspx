<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenedor/MasterPrivate.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="UnionMantenedorW.Mantenedor.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="perfil">
<h1>Mis Datos</h1>
      <p><span class="perfil1">Nombre</span> <span class="perfil2"><asp:Label ID="lblNombre" runat="server" /></span></p>
      <hr noshade size="1">
      <p><span class="perfil1">RUT</span> <span class="perfil2"><asp:Label ID="lblRUT" runat="server" /></span></p>
      <hr noshade size="1">
      <p><span class="perfil1">Dirección</span> <span class="perfil2"><asp:Label ID="lblDireccion" runat="server" /></span></p>
      <hr noshade size="1">
      <p><span class="perfil1">Comuna</span> <span class="perfil2"><asp:Label ID="lblComuna" runat="server" /></span></p>
      <hr noshade size="1">
      <p><span class="perfil1">Región</span> <span class="perfil2"><asp:Label ID="lblRegion" runat="server" /></span></p>
      <hr noshade size="1">
      <p><span class="perfil1">Teléfono</span> <span class="perfil2"><asp:Label ID="lblFono" runat="server" /></span></p>
      <hr noshade size="1">
      <p><span class="perfil1">Email</span> <span class="perfil2"><asp:Label ID="lblEmail" runat="server" /></span></p>
      <hr noshade size="1">
      <a href="cambiarClave.aspx" class="perfilBoton perfil_distancia">cambiar clave</a>
  </div>

</asp:Content>
