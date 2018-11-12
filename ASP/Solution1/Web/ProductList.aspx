<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h4>商品列表</h4>
    <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="SN" HeaderText="商品编号">
            <ItemStyle Width="130px" />
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="商品名称">
            <ItemStyle Width="130px" />
            </asp:BoundField>
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

    <script>
        var links = document.links;//获取所有链接
        for (var i in links) {
            //遍历所有连接
            var a = links[i];
            if (a.text == 'Delete' || a.text == '删除') {
                //如果是删除链接按钮
                //临时保存原来的链接
                var alink = a.href;
                //清除
                a.href = '#';
                a.addEventListener("click", function () {
                    var result = window.confirm("你是认真的吗？该记录会被删除！！！");
                    if (result == true)
                        eval(alink);
                    return false;
                });
            }
        }
    </script>
</asp:Content>

