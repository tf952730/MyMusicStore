<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        商品编号：<asp:Label ID="lblSN" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        商品名称：<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    </p>
        商品说明：<asp:Label ID="lblDSCN" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Image ID="Image1" runat="server" ImageUrl="https://www.lzzy.net/upload/main/image/2018/10/31/201810310931196260_650_400.jpg" Width="500px" />
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ProductList.aspx">返回</asp:HyperLink>
</asp:Content>

