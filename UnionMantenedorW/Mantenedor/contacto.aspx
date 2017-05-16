<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenedor/MasterPrivate.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="UnionMantenedorW.Mantenedor.contacto" enableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="perfil">
<h1>Contacto</h1>
      <form>
        <label for="asunto">Asunto</label>
          <asp:TextBox ID="txbAsunto" runat="server" required></asp:TextBox>
        <hr noshade size="1">
        <label for="mensaje">Mensaje</label>
          <asp:TextBox ID="txbMsj" runat="server" TextMode="MultiLine" required></asp:TextBox>
      <hr noshade size="1">
          <asp:Button ID="btnEnviar" runat="server" Text="enviar" class="perfilBoton perfil_distancia" OnClick="btnEnviar_Click" /><asp:Label ID="lblMsj" runat="server" ForeColor="Red" EnableViewState="false" />
      </form>
  </div>

</asp:Content>
