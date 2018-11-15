<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h4>商品列表</h4>
    <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="productdetail.aspx?id={0}" HeaderText="商品编号" DataTextField="SN" DataTextFormatString="{0}">
            <ItemStyle Width="100px" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="Name" HeaderText="商品名称">
            <ItemStyle Width="130px" />
            </asp:BoundField>
            <asp:TemplateField FooterText="Categoty" HeaderText="分类">
                <EditItemTemplate>
                    <asp:DropDownList ID="DdlCategory" runat="server" Width="150px">
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LblCategory" runat="server" ForeColor="Red" Text='<%# GetName(Eval("Categoty")) %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle Width="10%" />
            </asp:TemplateField>
            <asp:BoundField DataField="DSCN" HeaderText="说明">
            <ItemStyle Width="200px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="维护操作" ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="删除" OnClientClick="return confirm('确定删除？');"></asp:LinkButton>
                </ItemTemplate>
                <ItemStyle Width="130px" />
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

