using DynamicForms.Factory;
using System.Collections.Generic;

namespace DynamicForms.Core
{
    public abstract class CalculationBase : ICalculation
    {
        public string Name { get; set; }
        public CalculationType CalculationType { get; set; }
        public bool IsSuccessfull { get; set; }
        public string Message { get; set; }
        public List<ControlGroup> Groups { get; set; }

        public abstract bool Calculate();         
        
        public NumericControl GetNumericControl(string fullName)
        {
            foreach (var group in Groups)
            {
                foreach (var numCtrl in group.ValueControls)
                {
                    if (numCtrl.FullName == fullName)
                        return numCtrl;
                }
            }

            return null;
        }

        public OptionControl GetOptionControl(string fullName)
        {
            foreach (var group in Groups)
            {
                foreach (var optionCtrl in group.OptionControls)
                {
                    if (optionCtrl.FullName == fullName)
                        return optionCtrl;
                }
            }

            return null;
        }
    }
}
