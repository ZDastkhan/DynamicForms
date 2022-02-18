using DynamicForms.Factory;
using System.Collections.Generic;

namespace DynamicForms.Core
{
    public interface ICalculation
    {
        string Name { get; set; }
        CalculationType CalculationType { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }
        List<ControlGroup> Groups { get; set; }
        bool Calculate();
        NumericControl GetNumericControl(string fullName);
        OptionControl GetOptionControl(string fullName);
    }
}
