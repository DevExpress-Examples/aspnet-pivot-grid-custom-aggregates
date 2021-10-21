Imports Dashboard_FirstValueAggregate
Imports DevExpress.Data.Filtering
Imports System

Namespace AspPivot_CustomFunctions

    Public Partial Class WebForm1
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            CriteriaOperator.RegisterCustomFunction(New FirstValueAggregateFunction())
        End Sub
    End Class
End Namespace
