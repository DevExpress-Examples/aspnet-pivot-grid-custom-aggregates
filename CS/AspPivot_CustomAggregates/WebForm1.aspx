<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspPivot_CustomFunctions.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v21.2, Version=21.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientIDMode="AutoID" DataSourceID="SqlDataSource1" 
                OptionsView-ShowColumnGrandTotals ="False" OptionsView-ShowRowGrandTotals="False"
                OptionsView-ShowRowTotals="False" Theme="Metropolis">
                <Fields>
                    <dx:PivotGridField ID="fieldCountry" Area="RowArea" AreaIndex="0" FieldName="Country">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldProductName" Area="ColumnArea" AreaIndex="1" FieldName="ProductName" Visible="False">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldCategoryName" Area="ColumnArea" AreaIndex="0" FieldName="CategoryName">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldExtendedPrice" Area="DataArea" AreaIndex="0" FieldName="Extended_Price">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="fieldSalesPerson" Area="RowArea" AreaIndex="1" FieldName="Sales_Person">
                    </dx:PivotGridField>
                    <dx:PivotGridField ID="FirstSoldValue" Area="DataArea" AreaIndex="0" FieldName="FirstSoldProduct" 
                        Caption ="First Sold Product" Options-ShowGrandTotal ="false " Options-ShowTotals ="False">
                        <DataBindingSerializable>
                            <dx:ExpressionDataBinding Expression= "FirstValue([ProductName])" />
                        </DataBindingSerializable>
                    </dx:PivotGridField>
                </Fields>
                <OptionsData DataProcessingEngine="Optimized" />
            </dx:ASPxPivotGrid>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:nwind %>" 
                ProviderName="<%$ ConnectionStrings:nwind.ProviderName %>" 
                SelectCommand="SELECT [Country], [ProductName], [CategoryName], [ExtendedPrice] AS Extended_Price, [FullName] AS Sales_Person FROM [SalesPerson]">
            </asp:SqlDataSource>
        </div>
    </form>
    </body>
</html>
