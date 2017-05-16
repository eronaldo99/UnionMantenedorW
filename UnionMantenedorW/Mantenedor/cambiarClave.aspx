<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenedor/MasterPrivate.Master" AutoEventWireup="true" CodeBehind="cambiarClave.aspx.cs" Inherits="UnionMantenedorW.Mantenedor.cambiarClave" enableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="perfil">
<h1>Cambiar Clave</h1>
      <form>
        <label for="clave_vieja" class="perfil_clave">Clave Antigua</label>
          <asp:TextBox ID="clave_vieja" runat="server" class="perfil_clave_input" type="password" required ></asp:TextBox>
        <hr noshade size="1">
        <label for="clave_nueva" class="perfil_clave">Clave Nueva</label>
          <asp:TextBox ID="clave_nueva" runat="server" class="perfil_clave_input" type="password" required ></asp:TextBox>
      <hr noshade size="1">
      <label for="clave_vieja2" class="perfil_clave">Repetir Clave Nueva</label>
          <asp:TextBox ID="clave_nueva2" runat="server" class="perfil_clave_input" type="password" required ></asp:TextBox>
        <hr>
        <asp:Button ID="btnEnviar" runat="server" Text="enviar" class="perfilBoton perfil_distancia2" OnClick="btnEnviar_Click" />
        <asp:Label ID="lblMsj" runat="server" />
      </form>
  </div>
</asp:Content>
