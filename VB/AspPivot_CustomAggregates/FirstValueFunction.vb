Imports DevExpress.Data.Filtering
Imports DevExpress.DataProcessing.Criteria
Imports System

Namespace Dashboard_FirstValueAggregate

    Friend Class FirstValueAggregateFunction
        Inherits ICustomAggregateFunction
        Implements ICustomFunctionOperatorBrowsable

        Public ReadOnly Property Name As String
            Get
                Return "FirstValue"
            End Get
        End Property

        Public ReadOnly Property MinOperandCount As Integer
            Get
                Return 1
            End Get
        End Property

        Public ReadOnly Property MaxOperandCount As Integer
            Get
                Return 1
            End Get
        End Property

        Public ReadOnly Property Description As String
            Get
                Return "Aggregates data by input value, and displays the first value of the field"
            End Get
        End Property

        Public ReadOnly Property Category As FunctionCategory
            Get
                Return DevExpress.Data.Filtering.FunctionCategory.Text
            End Get
        End Property

        Public Function Evaluate(ParamArray operands As Object()) As Object
            Throw New NotImplementedException()
        End Function

        'public string Format(Type providerType, params string[] operands) {
        '    return string.Format("FIRST_VALUE({0})", operands[0]);
        '}
        Public Function GetAggregationContextType(ByVal inputType As Type) As Type
            Return GetType(FirstValueAggregateState(Of )).MakeGenericType(inputType)
        End Function

        Public Function IsValidOperandCount(ByVal count As Integer) As Boolean
            Return count <= MaxOperandCount AndAlso count >= MinOperandCount
        End Function

        Public Function IsValidOperandType(ByVal operandIndex As Integer, ByVal operandCount As Integer, ByVal type As Type) As Boolean
            Return IsValidOperandCount(operandCount) AndAlso operandIndex = 0
        End Function

        Public Function ResultType(ParamArray operands As Type()) As Type
            Return operands(0)
        End Function
    End Class

    Friend Class FirstValueAggregateState(Of TInput)
        Inherits ICustomAggregateFunctionContext(Of TInput, TInput)

        Private isSet As Boolean = False

        Private firstValue As TInput

        Public Function GetResult() As TInput
            Return If(isSet, firstValue, Nothing)
        End Function

        Public Sub Process(ByVal value As TInput)
            If Not isSet Then
                firstValue = value
                isSet = True
            End If
        End Sub
    End Class
End Namespace
