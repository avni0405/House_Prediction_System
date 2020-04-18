<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="test1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        LotArea:&nbsp;&nbsp;
        <asp:TextBox ID="t1" runat="server"></asp:TextBox>
        <br />
        <br />
        Street&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Pave</asp:ListItem>
            <asp:ListItem>Grvl</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Utilities&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>AllPub</asp:ListItem>
            <asp:ListItem>NoSeWa</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Neighborhood&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>CollgCr</asp:ListItem>
            <asp:ListItem>Veenker</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        HouseStyle&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>2Story</asp:ListItem>
            <asp:ListItem>1Story</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        OverallQual&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="t2" runat="server"></asp:TextBox>
        <br />
        <br />
        OverallCond&nbsp;&nbsp;
        <asp:TextBox ID="t3" runat="server"></asp:TextBox>
        <br />
        <br />
        YearBuilt&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="t4" runat="server"></asp:TextBox>
        <br />
        <br />
        TotalBsmtSF&nbsp;
        <asp:TextBox ID="t5" runat="server"></asp:TextBox>
        <br />
        <br />
        CentralAir&nbsp;&nbsp;
        <asp:TextBox ID="t6" runat="server"></asp:TextBox>
        <br />
        <br />
        1stFlrSF
        <asp:TextBox ID="t7" runat="server"></asp:TextBox>
        <br />
        <br />
        2ndFlrSF&nbsp;
        <asp:TextBox ID="t8" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        GrLivArea
        <asp:TextBox ID="t9" runat="server"></asp:TextBox>
        <br />
        <br />
        FullBath&nbsp;&nbsp;
        <asp:TextBox ID="t10" runat="server"></asp:TextBox>
        <br />
        <br />
        BedroomAbvGr&nbsp;&nbsp;
        <asp:TextBox ID="t11" runat="server"></asp:TextBox>
        <br />
        <br />
        KitchenAbvGr
        <asp:TextBox ID="t12" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        SalePrice
        <asp:TextBox ID="t13" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        TotRmsAbvGrd
        <asp:TextBox ID="t14" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="submit" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>

</body>
</html>
