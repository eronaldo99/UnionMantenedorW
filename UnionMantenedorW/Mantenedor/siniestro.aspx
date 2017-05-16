<%@ Page Title="" Language="C#" MasterPageFile="~/Mantenedor/MasterPrivate.Master" AutoEventWireup="true" CodeBehind="siniestro.aspx.cs" Inherits="UnionMantenedorW.Mantenedor.siniestro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="siniestro">
    <div class="moduloInfo">
	<h1>Siniestro <asp:Label ID="lblSiniestroId" runat="server" /></h1>
        <p class="sin_fecha"><asp:Label ID="lblFechaSistema" runat="server" /></p>
        <p class="sin_dato"><span>Compañía:</span> <strong><asp:Label ID="lblCia" runat="server" /></strong></p>
        <p class="sin_dato"><span>Tipo Siniestro:</span> <strong><asp:Label ID="lblTipo" runat="server" /></strong></p>
        <p class="sin_dato"><span>Etapa:</span> <strong><asp:Label ID="lblEtapa" runat="server" /></strong></p>
        <p class="sin_dato"><span>Estado:</span> <strong><asp:Label ID="lblEstado" runat="server" /></strong></p>
        <p class="sin_dato"><span>Estado Fecha:</span> <strong><asp:Label ID="lblEstadoFecha" runat="server" /></strong></p>
     </div>
      <br />
    <asp:Repeater ID="rptLineaTiempo" runat="server" OnItemDataBound="rptLineaTiempo_ItemDataBound">
        <ItemTemplate>
                    <div class="modulo"><span class="numero"><asp:Label ID="lblNum" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Numero_etapa")%>' /></span>
       	                <h2>Etapa:  <asp:Label ID="lblEtapa" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "CTD_DESCRIPCION")%>' /></h2>
                        <p class="status">Estado: <span><asp:Label ID="lblEstado" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "CTDE_NOMBRE")%>' /></span></p>
                        <asp:Literal ID="liDocs" runat="server"></asp:Literal>
                    </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
