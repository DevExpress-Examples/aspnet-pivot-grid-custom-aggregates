using DevExpress.Data.Filtering;
using DevExpress.DataProcessing.Criteria;
using System;

namespace Dashboard_FirstValueAggregate {
    class FirstValueAggregateFunction : ICustomAggregateFunction, ICustomFunctionOperatorBrowsable {
        public string Name => "FirstValue";

        public int MinOperandCount => 1;

        public int MaxOperandCount => 1;

        public string Description => @"Aggregates data by an input value, 
            and displays the first value of the field";

        public FunctionCategory Category => DevExpress.Data.Filtering.FunctionCategory.Text;

        public object Evaluate(params object[] operands) {
            throw new NotImplementedException();
        }
        public Type GetAggregationContextType(Type inputType) {
            return typeof(FirstValueAggregateState<>).MakeGenericType(inputType);
        }
        public bool IsValidOperandCount(int count) {
            return count <= MaxOperandCount && count >= MinOperandCount;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return IsValidOperandCount(operandCount) && operandIndex == 0;
        }
        public Type ResultType(params Type[] operands) {
            return operands[0];
        }
    }

    class FirstValueAggregateState<TInput> : ICustomAggregateFunctionContext<TInput, TInput> {
        bool isSet = false;
        TInput firstValue;
        public TInput GetResult() {
            return isSet ? firstValue : default(TInput);
        }
        public void Process(TInput value) {
            if(!isSet) {
                firstValue = value;
                isSet = true;
            }
        }
    }
}
