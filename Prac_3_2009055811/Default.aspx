<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Game Search</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div class="Page">
    <div class="Header">
        <div class="Title">
            <h1>
        Games Galore
            </h1>
        </div>
    </div>
        <div class="Main">
            <div class="Search">
                <h2>
            Search</h2>
                <p>
                    Specify the minimum and maximum price and select a category please.</p>
                <p>
                    <asp:Label ID="lblMin" runat="server" Text="Minimum price:" Width="100px"></asp:Label>
                    <asp:TextBox ID="txtMin" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="lblMax" runat="server" Text="Maximum price:" Width="100px"></asp:Label>
                    <asp:TextBox ID="txtMax" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="lblCat" runat="server" Text="Category:" Width="100px"></asp:Label>
                    <asp:DropDownList ID="ddlCategories" runat="server" 
                        DataSourceID="odsCategories" DataTextField="CategoryName" 
                        DataValueField="CategoryID" Width="150px">
                    </asp:DropDownList>
                </p>
                <p>
                    <asp:Label ID="lblSpaceAgent" runat="server" Width="100px"></asp:Label>
                    <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" 
                        Text="Search" />
                    <asp:ObjectDataSource ID="odsCategories" runat="server" 
                        SelectMethod="GetCategories" TypeName="CCategories"></asp:ObjectDataSource>
                </p>
&nbsp;</div>
            <div class="Results">
                <h2>
            Results
                </h2>
                <p>
                    <asp:GridView ID="dgvGames" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="GameID" DataSourceID="odsGames" Width="800px">
                        <Columns>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True" >
                            <HeaderStyle Width="50px" />
                            </asp:CommandField>
                            <asp:BoundField DataField="GameID" HeaderText="Game ID" 
                                SortExpression="GameID" Visible="False" />
                            <asp:BoundField DataField="GameTitle" HeaderText="Game Title" 
                                SortExpression="GameTitle" />
                            <asp:ImageField DataImageUrlField="GamePictureURL" HeaderText="Image">
                                <ControlStyle Width="100px" />
                                <HeaderStyle Width="100px" />
                            </asp:ImageField>
                            <asp:BoundField DataField="GamePrice" HeaderText="Price" 
                                SortExpression="GamePrice" DataFormatString="{0:c}" />
                            <asp:BoundField DataField="CategoryID" HeaderText="Category ID" 
                                SortExpression="CategoryID" Visible="False" />
                            <asp:BoundField DataField="GameReleaseDate" HeaderText="Release Date" 
                                SortExpression="GameReleaseDate" DataFormatString="{0:d}" />
                        </Columns>
                    </asp:GridView>
                    <asp:ObjectDataSource ID="odsGames" runat="server" 
                        SelectMethod="GetGamesInRange" TypeName="CGames">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="txtMin" Name="Min" PropertyName="Text" 
                                Type="Decimal" />
                            <asp:ControlParameter ControlID="txtMax" Name="Max" PropertyName="Text" 
                                Type="Decimal" />
                            <asp:ControlParameter ControlID="ddlCategories" Name="CategoryID" 
                                PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </p>
                <p>
                    <asp:DetailsView ID="dvGame" runat="server" AutoGenerateRows="False" 
                        DataKeyNames="GameID" DataSourceID="odsGame" Height="50px" Width="531px" 
                        onitemdeleted="dvGame_ItemDeleted" oniteminserted="dvGame_ItemInserted" 
                        oniteminserting="dvGame_ItemInserting" onitemupdated="dvGame_ItemUpdated" 
                        onitemupdating="dvGame_ItemUpdating">
                        <Fields>
                            <asp:BoundField DataField="GameID" HeaderText="Game ID" InsertVisible="False" 
                                SortExpression="GameID" />
                            <asp:BoundField DataField="GameTitle" HeaderText="Title" 
                                SortExpression="GameTitle" />
                            <asp:TemplateField HeaderText="Picture" SortExpression="GamePictureURL">
                                <EditItemTemplate>
                                    <asp:Image ID="imgGame" runat="server" ImageUrl='<%# Eval("GamePictureURL") %>' 
                                        Width="100px" />
                                    <br />
                                    <asp:FileUpload ID="fuGameImage" runat="server" />
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:Image ID="imgGame" runat="server" ImageUrl='<%# Eval("GamePictureURL") %>' 
                                        Width="100px" />
                                    <br />
                                    <asp:FileUpload ID="fuGameImage" runat="server" />
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Image ID="imgGame" runat="server" ImageUrl='<%# Eval("GamePictureURL") %>' 
                                        Width="100px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="GamePrice" HeaderText="Price" 
                                SortExpression="GamePrice" DataFormatString="{0:c}" />
                            <asp:TemplateField HeaderText="Category" SortExpression="CategoryID">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="odsCat" 
                                        DataTextField="CategoryName" DataValueField="CategoryID" Width="150px">
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="odsCat" runat="server" SelectMethod="GetCategories" 
                                        TypeName="CCategories"></asp:ObjectDataSource>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="odsCat" 
                                        DataTextField="CategoryName" DataValueField="CategoryID" Width="150px">
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="odsCat" runat="server" SelectMethod="GetCategories" 
                                        TypeName="CCategories"></asp:ObjectDataSource>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("CategoryID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="GameReleaseDate" HeaderText="Release Date" 
                                SortExpression="GameReleaseDate" DataFormatString="{0:d}" />
                            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                                ShowEditButton="True" ShowInsertButton="True" />
                        </Fields>
                    </asp:DetailsView>
                    <asp:ObjectDataSource ID="odsGame" runat="server" DeleteMethod="Delete" 
                        InsertMethod="Insert" SelectMethod="GetGame" TypeName="CGames" 
                        UpdateMethod="Update">
                        <DeleteParameters>
                            <asp:Parameter Name="GameID" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="GameTitle" Type="String" />
                            <asp:Parameter Name="GamePictureURL" Type="String" />
                            <asp:Parameter Name="GamePrice" Type="Decimal" />
                            <asp:Parameter Name="CategoryID" Type="Int32" />
                            <asp:Parameter Name="GameReleaseDate" Type="DateTime" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="dgvGames" Name="GameID" 
                                PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="GameID" Type="Int32" />
                            <asp:Parameter Name="GameTitle" Type="String" />
                            <asp:Parameter Name="GamePictureURL" Type="String" />
                            <asp:Parameter Name="GamePrice" Type="Decimal" />
                            <asp:Parameter Name="GameReleaseDate" Type="DateTime" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
                </p>
            </div>
        </div>
    </div>
    <div class="Footer">
    2012
    </div>
    </form>
</body>
</html>
