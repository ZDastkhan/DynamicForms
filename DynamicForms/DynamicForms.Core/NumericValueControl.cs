using System.Collections.Generic;

namespace DynamicForms.Core
{
    public class NumericValueControl
    {
        public string Id { get; set; }
        public int OrderIndex { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Tooltip { get; set; }
        public double Value { get; set; }
        public UnitDefinition InternalUnit { get; set; }
        public UnitDefinition UserUnit { get; set; }
        public double DefaultValue { get; set; }  
        public bool IsReadonly { get; set; }
        public virtual List<UnitDefinition> Units { get; set; }
        //public ValidationLimitModel MinLimit { get; set; }
        //public ValidationLimitModel MaxLimit { get; set; }

        public NumericValueControl()
        {
            Units = new List<UnitDefinition>();            
            //MinLimit = new ValidationLimitModel();
            //MaxLimit = new ValidationLimitModel();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
