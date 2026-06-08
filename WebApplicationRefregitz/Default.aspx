<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationRefregitzTow._Default"%>
<%@ Reference Control = "Controls_CBC.ascx"%>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    </asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Label ID="Label2" runat="server" OnLoad="Label2_Load" Text="Label"></asp:Label>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server" OnLoad="PlaceHolder1_Load" OnUnload="PlaceHolder1_UnLoad" OnDisposed="PlaceHolder1_Disposed" ValidateRequestMode="Enabled"></asp:PlaceHolder>
    <link rel="shortcut icon" type="image/x-icon" href="~/Images/clicknrun.ico" />
</asp:Content>
