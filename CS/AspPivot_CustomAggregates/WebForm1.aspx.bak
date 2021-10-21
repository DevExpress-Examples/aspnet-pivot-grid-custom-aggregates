<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspPivot_GettingStarted.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.1, Version=17.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientIDMode="AutoID" DataSourceID="SqlDataSource1">
                <Fields>
                    <dx:PivotGridField ID="fieldCountry" Area="ColumnArea" AreaIndex="0" FieldName="Country">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldProductName" Area="RowArea" AreaIndex="1" FieldName="ProductName">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCategoryName" Area="RowArea" AreaIndex="0" FieldName="CategoryName">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldExtendedPrice" Area="DataArea" AreaIndex="0" FieldName="Extended_Price">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldSalesPerson" Area="ColumnArea" AreaIndex="1" FieldName="Sales_Person">
                    </dx:PivotGridField>
                </Fields>
                <OptionsData DataProcessingEngine="LegacyOptimized" />
            </dx:ASPxPivotGrid>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
                SelectCommand="SELECT [Country], [ProductName], [CategoryName], [Extended Price] AS Extended_Price, [Sales Person] AS Sales_Person FROM [SalesPerson]">
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
