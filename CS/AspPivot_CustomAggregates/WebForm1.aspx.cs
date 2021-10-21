using Dashboard_FirstValueAggregate;
using DevExpress.Data.Filtering;
using System;

namespace AspPivot_CustomFunctions
{
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            CriteriaOperator.RegisterCustomFunction(new FirstValueAggregateFunction());
          
            
        }
    }
}