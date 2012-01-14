<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<script runat="server">

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" 
        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#7C6F57" onmenuitemclick="Menu1_MenuItemClick" 
        StaticSubMenuIndent="10px">
        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#F7F6F3" />
        <DynamicSelectedStyle BackColor="#5D7B9D" />
        <Items>
            <asp:MenuItem Text="Meu perfil" Value="Adicionar aluno" 
                NavigateUrl="/Perfil/Meu"></asp:MenuItem>
            <asp:MenuItem Text="Meus cursos" Value="Professor">
                <asp:MenuItem Text="Consultar presença" Value="Consultar presença">
                </asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Chat" Value="Gerenciar Turma">
                <asp:MenuItem Text="Criar nova turma" Value="Criar nova turma"></asp:MenuItem>
            </asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#5D7B9D" />
    </asp:Menu>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.</p>
</asp:Content>
