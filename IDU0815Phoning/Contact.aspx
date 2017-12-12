<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
    <style type="text/css">  
        .style1  
        {  
            text-decoration: underline;  
            color: #0000FF;  
            font-size: large;  
        }  
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
      
        <span class="style1"><strong>Gridview Databind using MS Access Database</strong></span><br />  
        <br />  
      
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"   
            DataKeyNames="RECORD_ID" BackColor="White" BorderColor="White"   
            BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1"   
            GridLines="None">  
            <Columns>  
                <asp:TemplateField HeaderText="ID">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("RECORD_ID") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("RECORD_ID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="First Name">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("RECORD_EVENT_ID") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("RECORD_EVENT_ID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Last Name">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("RECORD_DATE") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("RECORD_DATE") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />  
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />  
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />  
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />  
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#F1F1F1" />  
            <SortedAscendingHeaderStyle BackColor="#594B9C" />  
            <SortedDescendingCellStyle BackColor="#CAC9C9" />  
            <SortedDescendingHeaderStyle BackColor="#33276A" />  
        </asp:GridView>  
      
    </div>  
    </form>  
</body>  
</html>  