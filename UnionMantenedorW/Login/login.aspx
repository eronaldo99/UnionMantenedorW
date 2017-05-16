<%@ Page Title="" Language="C#" MasterPageFile="~/Login/mpLogin.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UnionMantenedorW.Login.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <label>
            <asp:Label ID="lblNombreUsuario" runat="server" Text="Usuario"  /></label>
            <asp:TextBox ID="txbNombreUsuario" runat="server" MaxLength="30" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txbNombreUsuario" ErrorMessage="*" ForeColor="Red" ValidationGroup="vGuardar"></asp:RequiredFieldValidator>
        
        <br />
        <label>
            <asp:Label ID="lblPassword" runat="server" Text="Password"  /></label>
            <asp:TextBox ID="txbPassword" runat="server" MaxLength="15" TextMode="Password" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbPassword" ErrorMessage="*" ForeColor="Red" ValidationGroup="vGuardar"></asp:RequiredFieldValidator>
        
        <br />
        <asp:Button ID="btnEntrar" runat="server" Text="INGRESAR" ValidationGroup="vGuardar" OnClick="btnEntrar_Click" CssClass="botonLogin" /><br />
        <asp:Label ID="lblMsj" runat="server" ForeColor="Red" EnableViewState="false" CssClass="error" /><br />
</asp:Content>
