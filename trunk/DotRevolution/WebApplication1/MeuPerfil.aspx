<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeuPerfil.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 938px;
            height: 141px;
        margin-left: 0px;
        margin-top: 0px;
    }
        #Enviar
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <img alt="" class="style1" 
        longdesc="http://localhost:4112/App_Themes/Dotrevolution/Dotrevol<a href="MeuPerfil.aspx"><br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Adicionar Conteúdo:"></asp:Label>
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <input id="Submit1" type="submit" value="Enviar" /><br />
    <br />
    </asp:Content>
